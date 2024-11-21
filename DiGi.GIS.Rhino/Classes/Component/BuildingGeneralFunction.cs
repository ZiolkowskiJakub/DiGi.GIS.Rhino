using DiGi.Rhino.Core.Classes;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class BuildingGeneralFunction : EnumComponent<Enums.BuildingGeneralFunction>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f8f964b9-91b4-43d8-9630-186439d229bf");

        /// <summary>
        /// Panel Type
        /// </summary>
        public BuildingGeneralFunction()
          : base("GIS")
        {
        }
    }
}