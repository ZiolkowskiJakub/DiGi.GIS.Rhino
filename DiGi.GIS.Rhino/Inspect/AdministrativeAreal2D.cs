using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Name", "Name", "AdministrativeAreal2D Name")]
        public static GH_String Name(this AdministrativeAreal2D administrativeAreal2D)
        {
            if (administrativeAreal2D == null)
            {
                return null;
            }

            return new GH_String(administrativeAreal2D.Name);
        }

        [Inspect("Occupancy", "Occupancy", "AdministrativeAreal2D Occupancy")]
        public static GH_Integer Occupancy(this AdministrativeAreal2D administrativeAreal2D)
        {
            if (administrativeAreal2D == null || administrativeAreal2D.Occupancy == null)
            {
                return null;
            }

            return new GH_Integer(System.Convert.ToInt32(administrativeAreal2D.Occupancy.Value));
        }

        [Inspect("AdministrativeArealType", "AdministrativeArealType", "AdministrativeAreal2D AdministrativeArealType")]
        public static GooEnum<AdministrativeArealType> AdministrativeArealType(this AdministrativeAreal2D administrativeAreal2D)
        {
            if (administrativeAreal2D == null)
            {
                return null;
            }

            return new GooEnum<AdministrativeArealType>(administrativeAreal2D.AdministrativeArealType);
        }
    }
}
