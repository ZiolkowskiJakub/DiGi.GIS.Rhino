using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        [Inspect("LOD", "LOD", "Level of Detail")]
        public static GooEnum LOD(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            if(!buildingModel.TryGetValue(Analytical.Enums.BuildingModelParameter.LOD, out Analytical.Enums.LOD lOD, new Core.Parameter.Classes.GetValueSettings(true, false)))
            {
                return null;
            }

            return new GooEnum(lOD);
        }

        [Inspect("Reference", "Reference", "Reference")]
        public static GH_String Guid(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            if (!buildingModel.TryGetValue(Analytical.Enums.BuildingModelParameter.Reference, out string result))
            {
                return null;
            }

            return new GH_String(result);
        }
    }
}


