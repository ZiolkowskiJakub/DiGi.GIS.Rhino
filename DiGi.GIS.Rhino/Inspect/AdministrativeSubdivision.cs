using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Name", "Name", "AdministrativeSubdivision Name")]
        public static GH_String Name(this AdministrativeSubdivision administrativeSubdivision)
        {
            if (administrativeSubdivision == null)
            {
                return null;
            }

            return new GH_String(administrativeSubdivision.Name);
        }

        [Inspect("Occupancy", "Occupancy", "AdministrativeSubdivision Occupancy")]
        public static GH_Integer Occupancy(this AdministrativeSubdivision administrativeSubdivision)
        {
            if (administrativeSubdivision == null || administrativeSubdivision.Occupancy == null)
            {
                return null;
            }

            return new GH_Integer(System.Convert.ToInt32(administrativeSubdivision.Occupancy.Value));
        }

        [Inspect("AdministrativeSubdivisionType", "AdministrativeSubdivisionType", "AdministrativeSubdivision AdministrativeSubdivisionType")]
        public static GooEnum<AdministrativeSubdivisionType> AdministrativeSubdivisionType(this AdministrativeSubdivision administrativeSubdivision)
        {
            if (administrativeSubdivision == null)
            {
                return null;
            }

            return new GooEnum<AdministrativeSubdivisionType>(administrativeSubdivision.AdministrativeSubdivisionType);
        }
    }
}
