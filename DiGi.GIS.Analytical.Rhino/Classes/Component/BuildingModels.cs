using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using DiGi.Analytical.Building.Rhino.Classes;
using DiGi.GIS.Classes;
using DiGi.Analytical.Building.Classes;

namespace DiGi.GIS.Rhino.Classes
{
    public class BuildingModels : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f9120fc5-0589-4101-933d-3752b7bacde4");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public BuildingModels()
          : base("GIS.BuildingModels", "GIS.BuildingModels",
              "Loads BuildingModels from GISModelFile",
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
                result.Add(new Param(new GooGISModelFileParam() { Name = "GISModelFile", NickName = "GISModelFile", Description = "DiGi GIS GISModelFile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooBuilding2DParam() { Name = "Building2Ds", NickName = "Building2Ds", Description = "DiGi GIS Building2Ds", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Voluntary));
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
                result.Add(new Param(new GooBuildingModelParam() { Name = "BuildingModels", NickName = "BuildingModels", Description = "DiGi Analytical BuildingModels", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("GISModelFile");
            GIS.Classes.GISModelFile gISModelFile = null;
            if (index == -1 || !dataAccess.GetData(index, ref gISModelFile) || gISModelFile == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            List<Building2D> building2Ds = null;
            index = Params.IndexOfInputParam("Building2Ds");
            if(index != -1)
            {
                building2Ds = new List<Building2D>();
                if(!dataAccess.GetDataList(index, building2Ds))
                {
                    building2Ds = null;
                }
            }

            if(building2Ds == null)
            {
                gISModelFile.Open();
                building2Ds = gISModelFile.Value?.GetObjects<Building2D>();
            }

            Dictionary<string, BuildingModel> dictionary = Analytical.Query.BuildingModelDictionary(gISModelFile, building2Ds?.ConvertAll(x => x?.Reference));

            List<BuildingModel> buildingModels = new List<BuildingModel>();
            if(dictionary != null)
            {
                foreach (BuildingModel buildingModel in dictionary.Values)
                {
                    buildingModels.Add(buildingModel);
                }
            }

            index = Params.IndexOfOutputParam("BuildingModels");
            if (index != -1)
            {
                dataAccess.SetDataList(index, buildingModels?.ConvertAll(x => new GooBuildingModel(x)));
            }
        }
    }
}