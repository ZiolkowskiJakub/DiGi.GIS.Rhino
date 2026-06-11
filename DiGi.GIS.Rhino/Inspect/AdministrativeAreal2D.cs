using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the name of the administrative areal 2D object as a Grasshopper string.
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative areal 2D object to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the name, or <c>null</c> if the input object is null.</returns>
        [Inspect("Name", "Name", "AdministrativeAreal2D Name")]
        public static GH_String? Name(this AdministrativeAreal2D? administrativeAreal2D)
        {
            if (administrativeAreal2D == null)
            {
                return null;
            }

            return new GH_String(administrativeAreal2D.Name);
        }
    }
}