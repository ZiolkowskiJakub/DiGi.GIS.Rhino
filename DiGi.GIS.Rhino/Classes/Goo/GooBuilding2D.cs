using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for a 2D building object, enabling serialization and bake-aware functionality within the Rhino environment.
    /// </summary>
    public class GooBuilding2D : GooBakeAwareSerializableObject<GIS.Classes.Building2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBuilding2D"/> class.
        /// </summary>
        public GooBuilding2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBuilding2D"/> class with the specified 2D building object.
        /// </summary>
        /// <param name="building2D">The 2D building object to be wrapped.</param>
        public GooBuilding2D(GIS.Classes.Building2D? building2D)
            : base(building2D)
        {
        }

        /// <summary>
        /// Gets the geometric representations associated with the 2D building, used for baking into the Rhino document.
        /// </summary>
        /// <returns>An array of <see cref="IGeometry"/> objects if a valid polygonal face exists; otherwise, null.</returns>
        public override IGeometry[]? Geometries
        {
            get
            {
                PolygonalFace2D? polygonalFace2D = Value?.PolygonalFace2D;
                if (polygonalFace2D == null)
                {
                    return null;
                }

                return [polygonalFace2D];
            }
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing a copy of the building data.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooBuilding2D(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type used to handle and transport <see cref="GooBuilding2D"/> objects.
    /// </summary>
    public class GooBuilding2DParam : GooBakeAwareSerializableParam<GooBuilding2D, GIS.Classes.Building2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBuilding2DParam"/> class.
        /// </summary>
        public GooBuilding2DParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique global identifier for the building 2D parameter component.
        /// </summary>
        public override Guid ComponentGuid => new("0f93b620-2aaa-43a2-a923-481bb6ad7adf");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}