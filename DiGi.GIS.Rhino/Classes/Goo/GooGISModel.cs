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

        public override bool CastFrom(object source)
        {
            if (source == null)
            {
                return false;
            }

            if (source is GIS.Classes.GISModel)
            {
                Value = (GIS.Classes.GISModel)source;
                return true;
            }

            Type type_Source = source?.GetType();
            if (typeof(IGH_Goo).IsAssignableFrom(type_Source))
            {
                object @object = (source as dynamic).Value;
                if(@object is GIS.Classes.GISModel)
                {
                    Value = (GIS.Classes.GISModel)@object;
                }
                else if (@object is GIS.Classes.GISModelFile)
                {
                    Value = ((GIS.Classes.GISModelFile)@object).Value;
                }
            }

            return base.CastFrom(source);
        }

        public override bool CastTo<Y>(ref Y target)
        {
            if (typeof(Y) == typeof(GIS.Classes.GISModel))
            {
                target = (Y)(object)Value;
                return true;
            }

            if (typeof(Y) == typeof(object))
            {
                target = (Y)(object)Value;
                return true;
            }

            return base.CastTo(ref target);
        }

    }

    public class GooGISModelParam : GooPresistentParam<GooGISModel, GIS.Classes.GISModel>
    {
        public override Guid ComponentGuid => new Guid("de24fde4-53dc-42df-8c0a-27cde1a3d1ed");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooGISModelParam()
            : base()
        {
        }
    }
}
