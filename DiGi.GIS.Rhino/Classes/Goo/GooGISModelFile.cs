using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooGISModelFile : GooSerializableObject<GIS.Classes.GISModelFile>
    {
        public GooGISModelFile()
            : base()
        {
        }

        public GooGISModelFile(GIS.Classes.GISModelFile gISModelFile)
        {
            Value = gISModelFile;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGISModelFile(Value);
        }

    }

    public class GooGISModelFileParam : GooPresistentParam<GooGISModelFile, GIS.Classes.GISModelFile>
    {
        public override Guid ComponentGuid => new Guid("f63fcf46-21bc-44a2-84f6-b24e63d9aeef");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGISModelFileParam()
            : base()
        {
        }
    }
}
