using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;
using System.Linq;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the number of storeys for a given Building2D object as a Grasshopper integer.
        /// </summary>
        /// <param name="building2D">The Building2D instance to inspect.</param>
        /// <returns>A <see cref="GH_Integer"/> representing the number of storeys, or null if the building is null.</returns>
        [Inspect("Storeys", "Storeys", "Building2D Storeys")]
        public static GH_Integer? Storeys(this Building2D? building2D)
        {
            if (building2D == null)
            {
                return null;
            }

            return new GH_Integer(building2D.Storeys);
        }

        /// <summary>
        /// Retrieves the general function of a given Building2D object as a GooEnum.
        /// </summary>
        /// <param name="building2D">The Building2D instance to inspect.</param>
        /// <returns>A <see cref="GooEnum{T}"/> of <see cref="BuildingGeneralFunction"/> representing the building's general function, or null if the building or its function is null.</returns>
        [Inspect("BuildingGeneralFunction", "BuildingGeneralFunction", "BuildingGeneralFunction")]
        public static GooEnum<BuildingGeneralFunction>? BuildingGeneralFunction(this Building2D? building2D)
        {
            if (building2D?.BuildingGeneralFunction == null)
            {
                return null;
            }

            return new GooEnum<BuildingGeneralFunction>(building2D.BuildingGeneralFunction.Value);
        }

        /// <summary>
        /// Retrieves the specific functions of a given Building2D object as a collection of GooEnums.
        /// </summary>
        /// <param name="building2D">The Building2D instance to inspect.</param>
        /// <returns>An enumerable collection of <see cref="GooEnum{T}"/> of <see cref="BuildingSpecificFunction"/>, or null if the building or its functions are null.</returns>
        [Inspect("BuildingSpecificFunctions", "BuildingSpecificFunctions", "BuildingSpecificFunctions")]
        public static IEnumerable? BuildingSpecificFunctions(this Building2D? building2D)
        {
            if (building2D?.BuildingSpecificFunctions == null)
            {
                return null;
            }

            return building2D?.BuildingSpecificFunctions.ToList().ConvertAll(x => new GooEnum<BuildingSpecificFunction>(x));
        }

        /// <summary>
        /// Retrieves the construction phase of a given Building2D object as a GooEnum.
        /// </summary>
        /// <param name="building2D">The Building2D instance to inspect.</param>
        /// <returns>A <see cref="GooEnum{T}"/> of <see cref="BuildingPhase"/> representing the building's phase, or null if the building or its phase is null.</returns>
        [Inspect("BuildingPhase", "BuildingPhase", "BuildingPhase")]
        public static GooEnum<BuildingPhase>? BuildingPhase(this Building2D? building2D)
        {
            if (building2D?.BuildingPhase == null)
            {
                return null;
            }

            return new GooEnum<BuildingPhase>(building2D.BuildingPhase.Value);
        }

        /// <summary>
        /// Checks whether a given Building2D object is occupied and returns the result as a Grasshopper boolean.
        /// </summary>
        /// <param name="building2D">The Building2D instance to inspect.</param>
        /// <returns>A <see cref="GH_Boolean"/> indicating if the building is occupied, or null if the building is null.</returns>
        [Inspect("IsOccupied", "IsOccupied", "Building2D Is Occupied")]
        public static GH_Boolean? IsOccupied(this Building2D? building2D)
        {
            if (building2D == null)
            {
                return null;
            }

            return new GH_Boolean(Query.IsOccupied(building2D));
        }
    }
}