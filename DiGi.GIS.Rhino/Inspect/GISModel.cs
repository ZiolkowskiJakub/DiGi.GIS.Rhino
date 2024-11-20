using DiGi.GIS.Classes;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid Guid(this GIS.Classes.GISModel gISModel)
        {
            if (gISModel == null)
            {
                return null;
            }

            return new GH_Guid(gISModel.Guid);
        }

        [Inspect("Building2Ds", "Building2Ds", "GISModel Building2Ds")]
        public static List<GooBuilding2D> Building2Ds(this GIS.Classes.GISModel gISModel)
        {
            if (gISModel == null)
            {
                return null;
            }

            return gISModel.GetObjects<Building2D>()?.ConvertAll(x => new GooBuilding2D(x));
        }

        //[Inspect("Test", "Test", "GISModel Test")]
        //public static List<GH_String> Test(this GIS.Classes.GISModel gISModel)
        //{
        //    if (gISModel == null)
        //    {
        //        return null;
        //    }

        //    return new List<GH_String> { new GH_String("AAA"), new GH_String("BBBS") };
        //}
    }
}
