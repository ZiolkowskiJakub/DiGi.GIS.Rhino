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
    /// A Grasshopper component that converts coordinates from the EPSG 2180 coordinate system to the EPSG 4326 coordinate system.
    /// </summary>
    public class ToEPSG4326 : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("d5d5f31f-2760-4fe9-96d0-65a80d98c9f0");

        /// <summary>
        /// Gets the exposure of the component, determining how it is executed in the Grasshopper canvas.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToEPSG4326"/> class.
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
                List<Param> result =
                [
                    new Param(new GooPoint2DParam() { Name = "Point2D", NickName = "Point2D", Description = "EPSG2180 Point2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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
                    new Param(new GooPoint3DParam() { Name = "Point3D", NickName = "Point3D", Description = "EPSG2180 Point3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work of converting a point from EPSG 2180 to EPSG 4326.
        /// </summary>
        /// <param name="DA">The DA object used to retrieve input data and store output results.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int index;

            index = Params.IndexOfInputParam("Point2D");
            Point2D? point2D = null;
            if (index == -1 || !DA.GetData(index, ref point2D) || point2D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Geometry.Spatial.Classes.Point3D? point3D = Convert.ToEPSG4326(point2D);

            index = Params.IndexOfOutputParam("Point3D");
            if (index != -1)
            {
                DA.SetData(index, point3D);
            }
        }
    }
}