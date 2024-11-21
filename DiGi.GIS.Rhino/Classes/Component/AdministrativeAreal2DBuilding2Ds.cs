using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino.Classes
{
    public class AdministrativeAreal2DBuilding2Ds : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("a2421efa-aec7-428b-80a5-8c4d428cd0d3");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
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
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooGISModelParam() { Name = "GISModel", NickName = "GISModel", Description = "DiGi GIS GISModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooAdministrativeAreal2DParam() { Name = "AdministrativeAreal2D", NickName = "AdministrativeAreal2D", Description = "DiGi GIS AdministrativeAreal2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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
                result.Add(new Param(new GooBuilding2DParam() { Name = "Building2Ds", NickName = "Building2Ds", Description = "DiGi GIS Building2Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("GISModel");
            GIS.Classes.GISModel gISModel = null;
            if (index == -1 || !dataAccess.GetData(index, ref gISModel) || gISModel == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("AdministrativeAreal2D");
            AdministrativeAreal2D administrativeAreal2D = null;
            if (index == -1 || !dataAccess.GetData(index, ref administrativeAreal2D) || administrativeAreal2D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            if(!gISModel.TryGetRelatedObjects<Building2D, AdministrativeAreal2DBuilding2DsRelation>(administrativeAreal2D, out List<Building2D> building2Ds))
            {
                building2Ds = null;
            }

            index = Params.IndexOfOutputParam("Building2Ds");
            if (index != -1)
            {
                dataAccess.SetDataList(index, building2Ds?.ConvertAll(x => new GooBuilding2D(x)));
            }
        }
    }
}