using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooAreal2D : GooSerializableObject<GIS.Classes.Areal2D>
    {
        public GooAreal2D()
            : base()
        {
        }

        public GooAreal2D(GIS.Classes.Areal2D areal2D)
            : base(areal2D)
        {

        }

        public GooAreal2D(GooAreal2D gooAreal2D)
            : base(gooAreal2D)
        {

        }

        public override IGH_Goo Duplicate()
        {
            return new GooAreal2D(Value);
        }

    }

    public class GooAreal2DParam : GooPresistentParam<GooAreal2D, GIS.Classes.Areal2D>
    {
        public override Guid ComponentGuid => new Guid("deb28870-f3d8-403c-81e2-539d5ecf0e9b");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooAreal2DParam()
            : base()
        {
        }
    }
}
