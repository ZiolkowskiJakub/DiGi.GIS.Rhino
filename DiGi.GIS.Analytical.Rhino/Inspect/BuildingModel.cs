using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the reference GUID for the specified building model.
        /// </summary>
        /// <param name="buildingModel">The building model to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the reference GUID, or <c>null</c> if the value is not found or the building model is null.</returns>
        [Inspect("Reference", "Reference", "Reference")]
        public static GH_String? Reference(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            if (!buildingModel.TryGetValue(Analytical.Enums.BuildingModelParameter.Reference, out string? result))
            {
                return null;
            }

            return new GH_String(result);
        }

        /// <summary>
        /// Retrieves the administrative area code for the specified building model.
        /// </summary>
        /// <param name="buildingModel">The building model to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the administrative area code, or <c>null</c> if the value is not found or the building model is null.</returns>
        [Inspect("Code", "Code", "Code")]
        public static GH_String? Code(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            if (!buildingModel.TryGetValue(Analytical.Enums.BuildingModelParameter.Code, out string? result))
            {
                return null;
            }

            return new GH_String(result);
        }

        /// <summary>
        /// Retrieves the data source information for the specified building model.
        /// </summary>
        /// <param name="buildingModel">The building model to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the source information, or <c>null</c> if the value is not found or the building model is null.</returns>
        [Inspect("Source", "Source", "Source")]
        public static GH_String? Source(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            if (!buildingModel.TryGetValue(Analytical.Enums.BuildingModelParameter.Source, out string? result))
            {
                return null;
            }

            return new GH_String(result);
        }
    }
}
