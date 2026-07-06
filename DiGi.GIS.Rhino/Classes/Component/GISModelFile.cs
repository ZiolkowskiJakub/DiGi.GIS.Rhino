using DiGi.Core.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// A Grasshopper component that loads a GIS model file from a specified file path.
    /// </summary>
    public class GISModelFile : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("652f95e1-7e8b-4b02-996b-6993089630bb");

        /// <summary>
        /// Gets the exposure of the component, determining how it behaves in the Grasshopper canvas.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="GISModelFile"/> class.
        /// </summary>
        public GISModelFile()
          : base("GIS.GISModelFile", "GIS.GISModelFile",
              "Loads GISModelFile from file",
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
                    new Param(new Grasshopper.Kernel.Parameters.Param_FilePath() { Name = "Path", NickName = "Path", Description = "File Path", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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
                    new Param(new GooGISModelFileParam() { Name = "GISModelFile", NickName = "GISModelFile", Description = "DiGi GIS GISModelFile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work, loading the GIS model file from the provided path and outputting it.
        /// </summary>
        /// <param name="DA">The DA object used to retrieve input data and store output data.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            int index;

            index = Params.IndexOfInputParam("Path");
            string? path = null;
            if (index == -1 || !DA.GetData(index, ref path) || path == null)
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

            GIS.Classes.GISModelFile gISModelFile = new(path_Temp.Value);

            index = Params.IndexOfOutputParam("GISModelFile");
            if (index != -1)
            {
                DA.SetData(index, gISModelFile);
            }
        }
    }
}