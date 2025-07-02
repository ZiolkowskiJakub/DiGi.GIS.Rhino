using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino.Classes
{
    public class ToEPSG4326 : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("d5d5f31f-2760-4fe9-96d0-65a80d98c9f0");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ToEPSG4326()
          : base("GIS.ToEPSG4326", "GIS.ToEPSG4326",
              "Converts From EPSG2180 to EPSG4326 coordinete system",
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
                result.Add(new Param(new GooPoint2DParam() { Name = "Point2D", NickName = "Point2D", Description = "EPSG2180 Point2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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
                result.Add(new Param(new GooPoint3DParam() { Name = "Point3D", NickName = "Point3D", Description = "EPSG2180 Point3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Point2D");
            Point2D point2D = null;
            if (index == -1 || !dataAccess.GetData(index, ref point2D) || point2D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Geometry.Spatial.Classes.Point3D point3D = Convert.ToEPSG4326(point2D);

            index = Params.IndexOfOutputParam("Point3D");
            if (index != -1)
            {
                dataAccess.SetData(index, point3D);
            }
        }
    }
}