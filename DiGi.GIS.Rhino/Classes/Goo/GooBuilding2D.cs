using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooBuilding2D : GooSerializableObject<GIS.Classes.Building2D>
    {
        public GooBuilding2D()
            : base()
        {
        }

        public GooBuilding2D(GIS.Classes.Building2D building2D)
            : base(building2D)
        {

        }

        public GooBuilding2D(GooBuilding2D gooBuilding2D)
            : base(gooBuilding2D)
        {

        }

        public override IGH_Goo Duplicate()
        {
            return new GooBuilding2D(Value);
        }

    }

    public class GooBuilding2DParam : GooPresistentParam<GooBuilding2D, GIS.Classes.Building2D>
    {
        public override Guid ComponentGuid => new Guid("ea3e3743-a880-4e8b-af02-4c0b054d0ef2");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooBuilding2DParam()
            : base()
        {
        }
    }
}
