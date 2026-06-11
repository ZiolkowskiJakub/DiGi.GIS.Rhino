using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// A Grasshopper component that retrieves the 2D geometry calculation result for a specific building within a GIS model.
    /// </summary>
    public class Building2DGeometryCalculationResult : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("b8fdeab6-2bdb-4df1-9eb4-c6608774805e");

        /// <summary>
        /// Gets the exposure level of the component, determining how it is displayed on the Grasshopper canvas.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DGeometryCalculationResult"/> class.
        /// </summary>
        public Building2DGeometryCalculationResult()
          : base("GIS.Building2DGeometryCalculationResult", "GIS.Building2DGeometryCalculationResult",
              "Gets Building2DGeometryCalculationResult",
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
                    new Param(new GooGISModelParam() { Name = "GISModel", NickName = "GISModel", Description = "DiGi GIS GISModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooBuilding2DParam() { Name = "Building2D", NickName = "Building2D", Description = "DiGi GIS Building2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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
                    new Param(new GooBuilding2DGeometryCalculationResultParam() { Name = "Building2DGeometryCalculationResult", NickName = "Building2DGeometryCalculationResult", Description = "DiGi GIS Building2DGeometryCalculationResult", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work. It retrieves the GIS model and building, 
        /// calculates the related geometry result, and sets it as output.
        /// </summary>
        /// <param name="dataAccess">The DA object used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("GISModel");
            GIS.Classes.GISModel? gISModel = null;
            if (index == -1 || !dataAccess.GetData(index, ref gISModel) || gISModel == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Building2D");
            Building2D? building2D = null;
            if (index == -1 || !dataAccess.GetData(index, ref building2D) || building2D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult = gISModel.GetRelatedObject<GIS.Classes.Building2DGeometryCalculationResult>(building2D);

            index = Params.IndexOfOutputParam("Building2DGeometryCalculationResult");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooBuilding2DGeometryCalculationResult(building2DGeometryCalculationResult));
            }
        }
    }
}