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
    /// <summary>
    /// A Grasshopper component that converts coordinates from the EPSG:4326 (WGS 84) coordinate system to the EPSG:2180 (Korea Central Belt) coordinate system.
    /// </summary>
    public class ToEPSG2180 : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("a880614a-8dc9-4b46-a8d0-547eb36228b2");

        /// <summary>
        /// Gets the exposure level of the component, which determines how it is highlighted in the Grasshopper canvas.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToEPSG2180"/> class.
        /// </summary>
        public ToEPSG2180()
          : base("GIS.ToEPSG2180", "GIS.ToEPSG2180",
              "Converts From EPSG4326 to EPSG2180 coordinete system",
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
                List<Param> result =
                [
                    new Param(new GooPoint3DParam() { Name = "Point3D", NickName = "Point3D", Description = "EPSG4326 Point3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooPoint2DParam() { Name = "Point2D", NickName = "Point2D", Description = "EPSG2180 Point2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work of converting a point from EPSG:4326 to EPSG:2180.
        /// </summary>
        /// <param name="DA">The DA object used to retrieve input data and store output results.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int index;

            index = Params.IndexOfInputParam("Point3D");
            Geometry.Spatial.Classes.Point3D? point3D = null;
            if (index == -1 || !DA.GetData(index, ref point3D) || point3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Point2D? point2D = Convert.ToEPSG2180(point3D);

            index = Params.IndexOfOutputParam("Point2D");
            if (index != -1)
            {
                DA.SetData(index, point2D);
            }
        }
    }
}