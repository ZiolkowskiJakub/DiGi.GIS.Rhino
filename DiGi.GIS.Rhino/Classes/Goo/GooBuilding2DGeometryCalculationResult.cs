using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    public class GooBuilding2DGeometryCalculationResult : GooSerializableObject<GIS.Classes.Building2DGeometryCalculationResult>
    {
        public GooBuilding2DGeometryCalculationResult()
            : base()
        {
        }

        public GooBuilding2DGeometryCalculationResult(GIS.Classes.Building2DGeometryCalculationResult building2DGeometryCalculationResult)
            : base(building2DGeometryCalculationResult)
        {

        }

        public GooBuilding2DGeometryCalculationResult(GooBuilding2DGeometryCalculationResult gooBuilding2DGeometryCalculationResult)
            : base(gooBuilding2DGeometryCalculationResult)
        {

        }

        public override IGH_Goo Duplicate()
        {
            return new GooBuilding2DGeometryCalculationResult(Value);
        }

    }

    public class GooBuilding2DGeometryCalculationResultParam : GooPresistentParam<GooBuilding2DGeometryCalculationResult, GIS.Classes.Building2DGeometryCalculationResult>
    {
        public override Guid ComponentGuid => new Guid("fdf2900e-a374-4c69-b3ec-9601ae63e829");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooBuilding2DGeometryCalculationResultParam()
            : base()
        {
        }
    }
}
