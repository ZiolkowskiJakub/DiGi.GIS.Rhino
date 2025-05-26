using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        [Inspect("GISModel", "GISModel", "GISModel")]
        public static GooGISModel GISModel(this GIS.Classes.GISModelFile gISModelFile)
        {
            if (gISModelFile == null)
            {
                return null;
            }

            gISModelFile.Open();

            return new GooGISModel(gISModelFile.Value);
        }

        [Inspect("Path", "Path", "Path")]
        public static GH_String Path(this GIS.Classes.GISModelFile gISModelFile)
        {
            if (gISModelFile == null)
            {
                return null;
            }

            return new GH_String(gISModelFile.Path);
        }
    }
}
