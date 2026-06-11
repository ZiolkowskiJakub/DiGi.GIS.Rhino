using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper-compatible wrapper for a GIS model file, enabling its use and serialization within the Grasshopper environment.
    /// </summary>
    public class GooGISModelFile : GooSerializableObject<GIS.Classes.GISModelFile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooGISModelFile"/> class.
        /// </summary>
        public GooGISModelFile()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGISModelFile"/> class with the specified GIS model file.
        /// </summary>
        /// <param name="gISModelFile">The GIS model file to be wrapped in this Goo object.</param>
        public GooGISModelFile(GIS.Classes.GISModelFile? gISModelFile)
        {
            Value = gISModelFile;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo wrapper.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the duplicated value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooGISModelFile(Value);
        }
    }

    /// <summary>
    /// Represents a persistent Grasshopper parameter used to handle and store <see cref="GooGISModelFile"/> objects.
    /// </summary>
    public class GooGISModelFileParam : GooPresistentParam<GooGISModelFile, GIS.Classes.GISModelFile>
    {
        /// <summary>
        /// Gets the unique global identifier for the GIS model file component.
        /// </summary>
        public override Guid ComponentGuid => new("f63fcf46-21bc-44a2-84f6-b24e63d9aeef");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGISModelFileParam"/> class.
        /// </summary>
        public GooGISModelFileParam()
            : base()
        {
        }
    }
}