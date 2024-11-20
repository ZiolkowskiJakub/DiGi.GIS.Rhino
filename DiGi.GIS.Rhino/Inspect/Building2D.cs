using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid Guid(this Building2D building2D)
        {
            if (building2D == null)
            {
                return null;
            }

            return new GH_Guid(building2D.Guid);
        }

        [Inspect("Reference", "Reference", "Building2D Reference")]
        public static GH_String Reference(this Building2D building2D)
        {
            if (building2D == null)
            {
                return null;
            }

            return new GH_String(building2D.Reference);
        }
    }
}
