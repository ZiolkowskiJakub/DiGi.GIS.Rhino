using DiGi.GIS.Classes;
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
    }
}
