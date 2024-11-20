using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooGISModel : GooSerializableObject<GIS.Classes.GISModel>
    {
        public GooGISModel()
            : base()
        {
        }

        public GooGISModel(GIS.Classes.GISModel gISModel)
        {
            Value = gISModel;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooGISModel(Value);
        }

    }

    public class GooGISModelParam : GooPresistentParam<GooGISModel, GIS.Classes.GISModel>
    {
        public override Guid ComponentGuid => new Guid("c8240b7b-0393-49a8-9eae-35a8b5d9a23c");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGISModelParam()
            : base()
        {
        }
    }
}
