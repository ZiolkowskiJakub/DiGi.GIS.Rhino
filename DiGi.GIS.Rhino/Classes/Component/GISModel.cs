using DiGi.Core.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino.Classes
{
    public class GISModel : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("e315f51e-f6f8-4cfa-a7f6-ede4088f5480");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public GISModel()
          : base("GIS.GISModel", "GIS.GISModel",
              "Loads GISModel from file",
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_FilePath() { Name = "Path", NickName = "Path", Description = "File Path", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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
                result.Add(new Param(new GooGISModelParam() { Name = "GISModel", NickName = "GISModel", Description = "DiGi GIS GISModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Path");
            string path = null;
            if (index == -1 || !dataAccess.GetData(index, ref path) || path == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Path? path_Temp = path;

            if (!path_Temp.Value.FileExists)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "File does not exist or is invalid.");
                return;
            }

            GIS.Classes.GISModel gISModel = null;
            using (GIS.Classes.GISModelFile gISModelFile = new GIS.Classes.GISModelFile(path_Temp.Value))
            {
                gISModelFile.Open();
                gISModel = gISModelFile.Value;
            }

            index = Params.IndexOfOutputParam("GISModel");
            if (index != -1)
            {
                dataAccess.SetData(index, gISModel);
            }
        }
    }
}