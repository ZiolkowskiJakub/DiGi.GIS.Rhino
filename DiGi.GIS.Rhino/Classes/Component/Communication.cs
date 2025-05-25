using DiGi.Core.Classes;
using DiGi.Geometry.Planar;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino.Classes
{
    public class Communication : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("4174f080-dc83-4202-b4e7-5161f1858780");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Communication()
          : base("GIS.Communication", "GIS.Communication",
              "Communication",
              "DiGi", "DiGi.GIS")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooEllipse2DParam() { Name = "Ellipse2D", NickName = "Ellipse2D", Description = "Ellipse2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPolygonalFace2DParam() { Name = "PolygonalFace2Ds", NickName = "PolygonalFace2Ds", Description = "PolygonalFace2Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooSegment2DParam() { Name = "Segment2Ds In", NickName = "Segment2Ds In", Description = "Segment2Ds In", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                result.Add(new Param(new GooSegment2DParam() { Name = "Segment2Ds Out", NickName = "Segment2Ds Out", Description = "Segment2Ds Out", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("Ellipse2D");
            Ellipse2D ellipse2D = null;
            if (index == -1 || !dataAccess.GetData(index, ref ellipse2D) || ellipse2D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("PolygonalFace2Ds");
            List<PolygonalFace2D> polygonalFace2Ds = new List<PolygonalFace2D>();
            if (index == -1 || !dataAccess.GetDataList(index, polygonalFace2Ds) || polygonalFace2Ds == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            BoundingBox2D boundingBox2D_Ellipse2D = ellipse2D.GetBoundingBox();

            List<Point2D> point2Ds = new List<Point2D>();
            List<Tuple<BoundingBox2D, IPolygonal2D>> tuples = new List<Tuple<BoundingBox2D, IPolygonal2D>>();

            foreach (PolygonalFace2D polygonalFace2D in polygonalFace2Ds)
            {
                BoundingBox2D boundingBox2D_PolygonalFace2D = polygonalFace2D?.GetBoundingBox();
                if(boundingBox2D_PolygonalFace2D == null)
                {
                    continue;
                }

                if(!boundingBox2D_PolygonalFace2D.InRange(boundingBox2D_Ellipse2D))
                {
                    continue;
                }

                IPolygonal2D externalEdge= polygonalFace2D.ExternalEdge;
                if (externalEdge == null)
                {
                    continue;
                }

                tuples.Add(new Tuple<BoundingBox2D, IPolygonal2D>(boundingBox2D_PolygonalFace2D, externalEdge));

                List<Point2D> point2Ds_Intersection = ellipse2D.IntersectionPoints(externalEdge);
                if(point2Ds_Intersection == null || point2Ds_Intersection.Count == 0)
                {
                    continue;
                }

                point2Ds.AddRange(point2Ds_Intersection);
            }

            List<Segment2D> segment2Ds_In = new List<Segment2D>();
            List<Segment2D> segment2Ds_Out = new List<Segment2D>();

            if (point2Ds != null && point2Ds.Count != 0)
            {
                Point2D[] focalPoints = ellipse2D.GetFocalPoints();

                foreach(Point2D focalPoint in focalPoints)
                {
                    foreach(Point2D point2D in point2Ds)
                    {
                        Segment2D segment2D = new Segment2D(point2D, focalPoint);
                        BoundingBox2D boundingBox2D = new BoundingBox2D(segment2D.GetPoints());

                        bool @in = true;
                        foreach (Tuple<BoundingBox2D, IPolygonal2D> tuple in tuples)
                        {
                            if(tuple.Item2.On(point2D))
                            {
                                continue;
                            }

                            if(!boundingBox2D.InRange(tuple.Item1))
                            {
                                continue;
                            }

                            if(!tuple.Item2.Intersect(segment2D))
                            {
                                continue;
                            }

                            @in = false;
                            break;
                        }

                        List<Segment2D> segment2Ds = @in ? segment2Ds_In : segment2Ds_Out;
                        segment2Ds.Add(segment2D);
                    }
                }
            }

            index = Params.IndexOfOutputParam("Segment2Ds In");
            if (index != -1)
            {
                dataAccess.SetDataList(index, segment2Ds_In);
            }

            index = Params.IndexOfOutputParam("Segment2Ds Out");
            if (index != -1)
            {
                dataAccess.SetDataList(index, segment2Ds_Out);
            }
        }
    }
}