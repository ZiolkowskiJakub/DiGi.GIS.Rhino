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
        [Inspect("Storeys", "Storeys", "Building2D Storeys")]
        public static GH_Integer Storeys(this Building2D building2D)
        {
            if (building2D == null)
            {
                return null;
            }

            return new GH_Integer(building2D.Storeys);
        }

        [Inspect("BuildingGeneralFunction", "BuildingGeneralFunction", "BuildingGeneralFunction")]
        public static GooEnum<BuildingGeneralFunction> BuildingGeneralFunction(this Building2D building2D)
        {
            if (building2D?.BuildingGeneralFunction == null)
            {
                return null;
            }

            return new GooEnum<BuildingGeneralFunction>(building2D.BuildingGeneralFunction.Value);
        }

        [Inspect("BuildingSpecificFunctions", "BuildingSpecificFunctions", "BuildingSpecificFunctions")]
        public static IEnumerable BuildingSpecificFunctions(this Building2D building2D)
        {
            if (building2D?.BuildingSpecificFunctions == null)
            {
                return null;
            }

            return building2D?.BuildingSpecificFunctions.ToList().ConvertAll(x => new GooEnum<BuildingSpecificFunction>(x));
        }

        [Inspect("BuildingPhase", "BuildingPhase", "BuildingPhase")]
        public static GooEnum<BuildingPhase> BuildingPhase(this Building2D building2D)
        {
            if (building2D?.BuildingPhase == null)
            {
                return null;
            }

            return new GooEnum<BuildingPhase>(building2D.BuildingPhase.Value);
        }

        [Inspect("IsOccupied", "IsOccupied", "Building2D Is Occupied")]
        public static GH_Boolean IsOccupied(this Building2D building2D)
        {
            if (building2D == null)
            {
                return null;
            }

            return new GH_Boolean(Query.IsOccupied(building2D));
        }
    }
}
