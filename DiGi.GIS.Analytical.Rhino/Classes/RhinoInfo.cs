using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.GIS.Analytical.Rhino.Classes
{
    /// <summary>
    /// Provides assembly information for the DiGi.GIS.Analytical.Rhino Grasshopper plugin.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the GHA library.
        /// </summary>
        public override string Name => "DiGi.GIS.Analytical.Rhino";

        /// <summary>
        /// Gets the icon representing this GHA library.
        /// </summary>
        public override Bitmap? Icon => null;

        /// <summary>
        /// Gets a short description of the purpose of this GHA library.
        /// </summary>
        public override string Description => "";

        /// <summary>
        /// Gets the unique identifier for this GHA library.
        /// </summary>
        public override Guid Id => new("c89f4c64-b274-4395-9feb-532701db5f22");

        /// <summary>
        /// Gets the name of the author or company that created this GHA library.
        /// </summary>
        public override string AuthorName => "Jakub Ziolkowski";

        /// <summary>
        /// Gets the contact details for the author of this GHA library.
        /// </summary>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}