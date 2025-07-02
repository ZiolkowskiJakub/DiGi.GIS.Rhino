using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooAreal2D : GooBakeAwareSerializableObject<GIS.Classes.Areal2D>
    {
        public GooAreal2D()
            : base()
        {
        }

        public GooAreal2D(GIS.Classes.Areal2D areal2D)
            : base(areal2D)
        {

        }

        public override IGeometry[] Geometries
        {
            get
            {
                PolygonalFace2D polygonalFace2D = Value?.PolygonalFace2D;
                if(polygonalFace2D == null)
                {
                    return null;
                }

                return [polygonalFace2D];
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooAreal2D(Value);
        }

    }

    public class GooAreal2DParam : GooBakeAwareSerializableParam<GooAreal2D, GIS.Classes.Areal2D>
    {
        public override Guid ComponentGuid => new Guid("a7c4576b-f722-40cb-b159-c5806ff5258f");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooAreal2DParam()
            : base()
        {
        }
    }
}
