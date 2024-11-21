using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid Guid(this Areal2D areal2D)
        {
            if (areal2D == null)
            {
                return null;
            }

            return new GH_Guid(areal2D.Guid);
        }

        [Inspect("Reference", "Reference", "Areal2D Reference")]
        public static GH_String Reference(this Areal2D areal2D)
        {
            if (areal2D == null)
            {
                return null;
            }

            return new GH_String(areal2D.Reference);
        }

        [Inspect("PolygonalFace2D", "PolygonalFace2D", "Areal2D PolygonalFace2D")]
        public static GooPolygonalFace2D PolygonalFace2D(this Areal2D areal2D)
        {
            if (areal2D == null)
            {
                return null;
            }

            return new GooPolygonalFace2D(areal2D.PolygonalFace2D);
        }

    }
}
