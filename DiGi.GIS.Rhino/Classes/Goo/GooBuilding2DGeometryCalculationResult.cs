using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for the building 2D geometry calculation result, enabling its use within the Grasshopper environment.
    /// </summary>
    public class GooBuilding2DGeometryCalculationResult : GooSerializableObject<GIS.Classes.Building2DGeometryCalculationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBuilding2DGeometryCalculationResult"/> class.
        /// </summary>
        public GooBuilding2DGeometryCalculationResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBuilding2DGeometryCalculationResult"/> class with the specified building 2D geometry calculation result.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The building 2D geometry calculation result to wrap.</param>
        public GooBuilding2DGeometryCalculationResult(GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
            : base(building2DGeometryCalculationResult)
        {
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A duplicated <see cref="IGH_Goo"/> instance.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooBuilding2DGeometryCalculationResult(Value);
        }
    }

    /// <summary>
    /// Represents a persistent Grasshopper parameter for handling building 2D geometry calculation results.
    /// </summary>
    public class GooBuilding2DGeometryCalculationResultParam : GooPresistentParam<GooBuilding2DGeometryCalculationResult, GIS.Classes.Building2DGeometryCalculationResult>
    {
        /// <summary>
        /// Gets the unique global identifier of the component parameter.
        /// </summary>
        public override Guid ComponentGuid => new("cdd5d5f9-dfb6-46ad-9a6d-6a7248303f02");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBuilding2DGeometryCalculationResultParam"/> class.
        /// </summary>
        public GooBuilding2DGeometryCalculationResultParam()
            : base()
        {
        }
    }
}