using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooBuilding2D : GooBakeAwareSerializableObject<GIS.Classes.Building2D>
    {
        public GooBuilding2D()
            : base()
        {
        }

        public GooBuilding2D(GIS.Classes.Building2D building2D)
            : base(building2D)
        {

        }

        public override IGeometry[] Geometries
        {
            get
            {
                PolygonalFace2D polygonalFace2D = Value?.PolygonalFace2D;
                if (polygonalFace2D == null)
                {
                    return null;
                }

                return [polygonalFace2D];
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooBuilding2D(Value);
        }

    }

    public class GooBuilding2DParam : GooBakeAwareSerializableParam<GooBuilding2D, GIS.Classes.Building2D>
    {
        public GooBuilding2DParam()
            : base()
        {
        }

        public override Guid ComponentGuid => new Guid("0f93b620-2aaa-43a2-a923-481bb6ad7adf");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
