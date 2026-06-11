using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for an Areal2D GIS object, enabling its use within the Grasshopper environment.
    /// </summary>
    public class GooAreal2D : GooBakeAwareSerializableObject<GIS.Classes.Areal2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooAreal2D"/> class.
        /// </summary>
        public GooAreal2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAreal2D"/> class with the specified Areal2D value.
        /// </summary>
        /// <param name="areal2D">The <see cref="GIS.Classes.Areal2D"/> object to be wrapped.</param>
        public GooAreal2D(GIS.Classes.Areal2D? areal2D)
            : base(areal2D)
        {
        }

        /// <summary>
        /// Gets the geometry associated with the wrapped Areal2D object.
        /// </summary>
        /// <returns>An array of <see cref="IGeometry"/> containing the polygonal face if available; otherwise, null.</returns>
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
        /// Creates a duplicate of the current GooAreal2D instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance that is a copy of this object.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooAreal2D(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type for Areal2D objects.
    /// </summary>
    public class GooAreal2DParam : GooBakeAwareSerializableParam<GooAreal2D, GIS.Classes.Areal2D>
    {
        /// <summary>
        /// Gets the unique global identifier for the Areal2D component.
        /// </summary>
        public override Guid ComponentGuid => new("a7c4576b-f722-40cb-b159-c5806ff5258f");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAreal2DParam"/> class.
        /// </summary>
        public GooAreal2DParam()
            : base()
        {
        }
    }
}