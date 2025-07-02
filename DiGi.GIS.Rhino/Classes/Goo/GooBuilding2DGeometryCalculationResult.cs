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

        public override IGH_Goo Duplicate()
        {
            return new GooBuilding2DGeometryCalculationResult(Value);
        }

    }

    public class GooBuilding2DGeometryCalculationResultParam : GooPresistentParam<GooBuilding2DGeometryCalculationResult, GIS.Classes.Building2DGeometryCalculationResult>
    {
        public override Guid ComponentGuid => new Guid("cdd5d5f9-dfb6-46ad-9a6d-6a7248303f02");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooBuilding2DGeometryCalculationResultParam()
            : base()
        {
        }
    }
}
