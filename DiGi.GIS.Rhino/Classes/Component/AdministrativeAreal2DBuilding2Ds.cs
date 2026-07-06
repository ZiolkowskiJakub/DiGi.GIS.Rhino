using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// A Grasshopper component that retrieves a list of 2D buildings associated with a specific administrative area within a GIS model.
    /// </summary>
    public class AdministrativeAreal2DBuilding2Ds : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("a2421efa-aec7-428b-80a5-8c4d428cd0d3");

        /// <summary>
        /// Gets the exposure level of the component, determining how it is displayed in the Grasshopper canvas.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DBuilding2Ds"/> class.
        /// </summary>
        public AdministrativeAreal2DBuilding2Ds()
          : base("GIS.AdministrativeAreal2DBuilding2Ds", "GIS.AdministrativeAreal2DBuilding2Ds",
              "Gets AdministrativeAreal2D Building2Ds",
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
                    new Param(new GooAdministrativeAreal2DParam() { Name = "AdministrativeAreal2D", NickName = "AdministrativeAreal2D", Description = "DiGi GIS AdministrativeAreal2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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
                    new Param(new GooBuilding2DParam() { Name = "Building2Ds", NickName = "Building2Ds", Description = "DiGi GIS Building2Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work of retrieving buildings related to the provided administrative area.
        /// </summary>
        /// <param name="DA">The DA object used to retrieve data from inputs and store results in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int index;

            index = Params.IndexOfInputParam("GISModel");
            GIS.Classes.GISModel? gISModel = null;
            if (index == -1 || !DA.GetData(index, ref gISModel) || gISModel == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("AdministrativeAreal2D");
            AdministrativeAreal2D? administrativeAreal2D = null;
            if (index == -1 || !DA.GetData(index, ref administrativeAreal2D) || administrativeAreal2D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            if (!gISModel.TryGetRelatedObjects<Building2D, AdministrativeAreal2DBuilding2DsRelation>(administrativeAreal2D, out List<Building2D>? building2Ds))
            {
                building2Ds = null;
            }

            index = Params.IndexOfOutputParam("Building2Ds");
            if (index != -1)
            {
                DA.SetDataList(index, building2Ds?.ConvertAll(x => new GooBuilding2D(x)));
            }
        }
    }
}