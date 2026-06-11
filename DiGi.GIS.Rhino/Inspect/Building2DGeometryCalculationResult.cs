using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Planar.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the area of the building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result.</param>
        /// <returns>A <see cref="GH_Number"/> representing the area, or null if the input is null.</returns>
        [Inspect("Area", "Area", "Building2D Area")]
        public static GH_Number? Area(this Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.Area);
        }

        /// <summary>
        /// Gets the rectangularity of the building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result.</param>
        /// <returns>A <see cref="GH_Number"/> representing the rectangularity, or null if the input is null.</returns>
        [Inspect("Rectangularity", "Rectangularity", "Building2D Rectangularity")]
        public static GH_Number? Rectangularity(this Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.Rectangularity);
        }

        /// <summary>
        /// Gets the rectangular thinness ratio of the building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result.</param>
        /// <returns>A <see cref="GH_Number"/> representing the rectangular thinness ratio, or null if the input is null.</returns>
        [Inspect("RectangularThinnessRatio", "RectangularThinnessRatio", "Building2D Rectangular Thinness Ratio")]
        public static GH_Number? RectangularThinnessRatio(this Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.RectangularThinnessRatio);
        }

        /// <summary>
        /// Gets the internal point of the building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the internal point, or null if the input is null.</returns>
        [Inspect("InternalPoint", "InternalPoint", "Building2D Rectangular Internal Point")]
        public static GooPoint2D? InternalPoint(this Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GooPoint2D(building2DGeometryCalculationResult.InternalPoint);
        }

        /// <summary>
        /// Gets the centroid of the building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result.</param>
        /// <returns>A <see cref="GooPoint2D"/> representing the centroid, or null if the input is null.</returns>
        [Inspect("Centroid", "Centroid", "Building2D Centroid")]
        public static GooPoint2D? Centroid(this Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GooPoint2D(building2DGeometryCalculationResult.Centroid);
        }

        /// <summary>
        /// Gets the thinness ratio of the building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result.</param>
        /// <returns>A <see cref="GH_Number"/> representing the thinness ratio, or null if the input is null.</returns>
        [Inspect("ThinnessRatio", "ThinnessRatio", "Building2D ThinnessRatio")]
        public static GH_Number? ThinnessRatio(this Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.ThinnessRatio);
        }

        /// <summary>
        /// Gets the perimeter of the building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result.</param>
        /// <returns>A <see cref="GH_Number"/> representing the perimeter, or null if the input is null.</returns>
        [Inspect("Perimeter", "Perimeter", "Building2D Perimeter")]
        public static GH_Number? Perimeter(this Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.Perimeter);
        }

        /// <summary>
        /// Gets the isoperimetric ratio of the building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result.</param>
        /// <returns>A <see cref="GH_Number"/> representing the isoperimetric ratio, or null if the input is null.</returns>
        [Inspect("IsoperimetricRatio", "IsoperimetricRatio", "Building2D IsoperimetricRatio")]
        public static GH_Number? IsoperimetricRatio(this Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult == null)
            {
                return null;
            }

            return new GH_Number(building2DGeometryCalculationResult.IsoperimetricRatio);
        }
    }
}