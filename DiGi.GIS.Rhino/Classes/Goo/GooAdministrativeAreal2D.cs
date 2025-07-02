using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooAdministrativeAreal2D : GooSerializableObject<GIS.Classes.AdministrativeAreal2D>
    {
        public GooAdministrativeAreal2D()
            : base()
        {
        }

        public GooAdministrativeAreal2D(GIS.Classes.AdministrativeAreal2D administrativeAreal2D)
            : base(administrativeAreal2D)
        {

        }

        public override IGH_Goo Duplicate()
        {
            return new GooAdministrativeAreal2D(Value);
        }

    }

    public class GooAdministrativeAreal2DParam : GooPresistentParam<GooAdministrativeAreal2D, GIS.Classes.AdministrativeAreal2D>
    {
        public override Guid ComponentGuid => new Guid("23c47f22-426a-4407-8d11-306ceedc0bea");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooAdministrativeAreal2DParam()
            : base()
        {
        }
    }
}
