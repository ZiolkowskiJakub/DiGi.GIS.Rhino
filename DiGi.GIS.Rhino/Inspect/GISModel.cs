using DiGi.GIS.Classes;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

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
        public static IEnumerable Building2Ds(this GIS.Classes.GISModel gISModel)
        {
            if (gISModel == null)
            {
                return null;
            }

            return gISModel.GetObjects<Building2D>()?.ConvertAll(x => new GooBuilding2D(x));
        }

        [Inspect("AdministrativeAreal2Ds", "AdministrativeAreal2Ds", "GISModel AdministrativeAreal2Ds")]
        public static IEnumerable AdministrativeAreal2Ds(this GIS.Classes.GISModel gISModel)
        {
            if (gISModel == null)
            {
                return null;
            }

            return gISModel.GetObjects<AdministrativeAreal2D>()?.ConvertAll(x => new GooAdministrativeAreal2D(x));
        }
    }
}
