using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper-compatible wrapper for an administrative areal 2D object, enabling serialization and data transfer within the Rhino/Grasshopper environment.
    /// </summary>
    public class GooAdministrativeAreal2D : GooSerializableObject<GIS.Classes.AdministrativeAreal2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooAdministrativeAreal2D"/> class.
        /// </summary>
        public GooAdministrativeAreal2D()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAdministrativeAreal2D"/> class with the specified administrative areal 2D object.
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative areal 2D object to wrap.</param>
        public GooAdministrativeAreal2D(GIS.Classes.AdministrativeAreal2D? administrativeAreal2D)
            : base(administrativeAreal2D)
        {
        }

        /// <summary>
        /// Creates a duplicate of the current goo object.
        /// </summary>
        /// <returns>A duplicate of the current instance as an <see cref="IGH_Goo"/>.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooAdministrativeAreal2D(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter used to handle and persist <see cref="GooAdministrativeAreal2D"/> objects.
    /// </summary>
    public class GooAdministrativeAreal2DParam : GooPresistentParam<GooAdministrativeAreal2D, GIS.Classes.AdministrativeAreal2D>
    {
        /// <summary>
        /// Gets the unique global identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("23c47f22-426a-4407-8d11-306ceedc0bea");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooAdministrativeAreal2DParam"/> class.
        /// </summary>
        public GooAdministrativeAreal2DParam()
            : base()
        {
        }
    }
}