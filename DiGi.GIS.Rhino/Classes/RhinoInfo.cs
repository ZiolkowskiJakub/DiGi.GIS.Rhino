using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Provides assembly information for the DiGi.GIS.Rhino Grasshopper plugin.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the GHA library.
        /// </summary>
        public override string Name => "DiGi.GIS.Rhino";

        /// <summary>
        /// Gets a 24x24 pixel bitmap to represent this GHA library.
        /// </summary>
        public override Bitmap? Icon => null;

        /// <summary>
        /// Gets a short string describing the purpose of this GHA library.
        /// </summary>
        public override string Description => "";

        /// <summary>
        /// Gets the unique identifier for the GHA library.
        /// </summary>
        public override Guid Id => new("5f962e9f-3dde-4ee9-94fb-2d9339ece48c");

        /// <summary>
        /// Gets a string identifying the author or company that created this GHA library.
        /// </summary>
        public override string AuthorName => "Jakub Ziolkowski";

        /// <summary>
        /// Gets a string representing the preferred contact details of the author or company.
        /// </summary>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}