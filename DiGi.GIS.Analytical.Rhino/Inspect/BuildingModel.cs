using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the Level of Detail (LOD) for the specified building model.
        /// </summary>
        /// <param name="buildingModel">The building model to inspect.</param>
        /// <returns>A <see cref="GooEnum"/> representing the LOD, or <c>null</c> if the value is not found or the building model is null.</returns>
        [Inspect("LOD", "LOD", "Level of Detail")]
        public static GooEnum? LOD(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            if (!buildingModel.TryGetValue(Analytical.Enums.BuildingModelParameter.LOD, out Analytical.Enums.LOD lOD, new Core.Parameter.Classes.GetValueSettings(true, false)))
            {
                return null;
            }

            return new GooEnum(lOD);
        }

        /// <summary>
        /// Retrieves the reference GUID for the specified building model.
        /// </summary>
        /// <param name="buildingModel">The building model to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the reference GUID, or <c>null</c> if the value is not found or the building model is null.</returns>
        [Inspect("Reference", "Reference", "Reference")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Name matches the property being inspected.")]
        public static GH_String? Guid(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel)
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
    }
}