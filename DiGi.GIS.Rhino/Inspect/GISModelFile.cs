using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the GIS model from the specified GIS model file.
        /// </summary>
        /// <param name="gISModelFile">The GIS model file to inspect.</param>
        /// <returns>A <see cref="GooGISModel"/> representing the GIS model, or <c>null</c> if the input file is null.</returns>
        [Inspect("GISModel", "GISModel", "GISModel")]
        public static GooGISModel? GISModel(this GIS.Classes.GISModelFile? gISModelFile)
        {
            if (gISModelFile == null)
            {
                return null;
            }

            gISModelFile.Open();

            return new GooGISModel(gISModelFile.Value);
        }

        /// <summary>
        /// Extracts the file path from the specified GIS model file.
        /// </summary>
        /// <param name="gISModelFile">The GIS model file to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the path, or <c>null</c> if the input file is null.</returns>
        [Inspect("Path", "Path", "Path")]
        public static GH_String? Path(this GIS.Classes.GISModelFile? gISModelFile)
        {
            if (gISModelFile == null)
            {
                return null;
            }

            return new GH_String(gISModelFile.Path);
        }
    }
}