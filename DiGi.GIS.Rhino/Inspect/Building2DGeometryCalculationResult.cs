using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Area", "Area", "Building2D Area")]
        public static GH_Number Area(this Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.Area);
        }

        [Inspect("Rectangularity", "Rectangularity", "Building2D Rectangularity")]
        public static GH_Number Rectangularity(this Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.Rectangularity);
        }

        [Inspect("RectangularThinnessRatio", "RectangularThinnessRatio", "Building2D Rectangular Thinness Ratio")]
        public static GH_Number RectangularThinnessRatio(this Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.RectangularThinnessRatio);
        }

        [Inspect("InternalPoint", "InternalPoint", "Building2D Rectangular Internal Point")]
        public static GooPoint2D InternalPoint(this Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GooPoint2D(building2DGeometryCalculationResult.InternalPoint);
        }

        [Inspect("Centroid", "Centroid", "Building2D Centroid")]
        public static GooPoint2D Centroid(this Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GooPoint2D(building2DGeometryCalculationResult.Centroid);
        }

        [Inspect("ThinnessRatio", "ThinnessRatio", "Building2D ThinnessRatio")]
        public static GH_Number ThinnessRatio(this Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.ThinnessRatio);
        }

        [Inspect("Perimeter", "Perimeter", "Building2D Perimeter")]
        public static GH_Number Perimeter(this Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.Perimeter);
        }

        [Inspect("IsoperimetricRatio", "IsoperimetricRatio", "Building2D IsoperimetricRatio")]
        public static GH_Number IsoperimetricRatio(this Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.IsoperimetricRatio);
        }

    }
}
