using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the unique global identifier (GUID) from an <see cref="Areal2D"/> object and wraps it in a Grasshopper GUID type.
        /// </summary>
        /// <param name="areal2D">The areal 2D object to inspect.</param>
        /// <returns>A <see cref="GH_Guid"/> containing the GUID of the object, or <c>null</c> if the input is null.</returns>
        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid? Guid(this Areal2D? areal2D)
        {
            if (areal2D == null)
            {
                return null;
            }

            return new GH_Guid(areal2D.Guid);
        }

        /// <summary>
        /// Extracts the reference string from an <see cref="Areal2D"/> object and wraps it in a Grasshopper string type.
        /// </summary>
        /// <param name="areal2D">The areal 2D object to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the reference of the object, or <c>null</c> if the input is null.</returns>
        [Inspect("Reference", "Reference", "Areal2D Reference")]
        public static GH_String? Reference(this Areal2D? areal2D)
        {
            if (areal2D == null)
            {
                return null;
            }

            return new GH_String(areal2D.Reference);
        }

        /// <summary>
        /// Extracts the polygonal face representation from an <see cref="Areal2D"/> object and wraps it in a Goo wrapper.
        /// </summary>
        /// <param name="areal2D">The areal 2D object to inspect.</param>
        /// <returns>A <see cref="GooPolygonalFace2D"/> containing the polygonal face of the object, or <c>null</c> if the input is null.</returns>
        [Inspect("PolygonalFace2D", "PolygonalFace2D", "Areal2D PolygonalFace2D")]
        public static GooPolygonalFace2D? PolygonalFace2D(this Areal2D? areal2D)
        {
            if (areal2D == null)
            {
                return null;
            }

            return new GooPolygonalFace2D(areal2D.PolygonalFace2D);
        }
    }
}