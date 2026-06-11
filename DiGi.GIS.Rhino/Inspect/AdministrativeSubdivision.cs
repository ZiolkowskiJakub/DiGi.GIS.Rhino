using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the name of the specified administrative subdivision.
        /// </summary>
        /// <param name="administrativeSubdivision">The administrative subdivision to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the name, or <c>null</c> if the input is null.</returns>
        [Inspect("Name", "Name", "AdministrativeSubdivision Name")]
        public static GH_String? Name(this AdministrativeSubdivision? administrativeSubdivision)
        {
            if (administrativeSubdivision == null)
            {
                return null;
            }

            return new GH_String(administrativeSubdivision.Name);
        }

        /// <summary>
        /// Gets the occupancy of the specified administrative subdivision.
        /// </summary>
        /// <param name="administrativeSubdivision">The administrative subdivision to inspect.</param>
        /// <returns>A <see cref="GH_Integer"/> containing the occupancy value, or <c>null</c> if the input or its occupancy is null.</returns>
        [Inspect("Occupancy", "Occupancy", "AdministrativeSubdivision Occupancy")]
        public static GH_Integer? Occupancy(this AdministrativeSubdivision? administrativeSubdivision)
        {
            if (administrativeSubdivision == null || administrativeSubdivision.Occupancy == null)
            {
                return null;
            }

            return new GH_Integer(System.Convert.ToInt32(administrativeSubdivision.Occupancy.Value));
        }

        /// <summary>
        /// Gets the administrative subdivision type of the specified administrative subdivision.
        /// </summary>
        /// <param name="administrativeSubdivision">The administrative subdivision to inspect.</param>
        /// <returns>A <see cref="GooEnum{T}"/> containing the administrative subdivision type, or <c>null</c> if the input is null.</returns>
        [Inspect("AdministrativeSubdivisionType", "AdministrativeSubdivisionType", "AdministrativeSubdivision AdministrativeSubdivisionType")]
        public static GooEnum<AdministrativeSubdivisionType>? AdministrativeSubdivisionType(this AdministrativeSubdivision? administrativeSubdivision)
        {
            if (administrativeSubdivision == null)
            {
                return null;
            }

            return new GooEnum<AdministrativeSubdivisionType>(administrativeSubdivision.AdministrativeSubdivisionType);
        }
    }
}