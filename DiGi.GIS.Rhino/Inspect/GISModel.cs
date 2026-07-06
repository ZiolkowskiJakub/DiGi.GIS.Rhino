using DiGi.GIS.Classes;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.GIS.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Gets the unique identifier of the specified GIS model as a Grasshopper GUID.
        /// </summary>
        /// <param name="gISModel">The GIS model to inspect.</param>
        /// <returns>The GH_Guid representing the model's identity, or null if the model is null.</returns>
        [Inspect("Guid", "Guid", "Guid")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Name matches the property being inspected.")]
        public static GH_Guid? Guid(this GIS.Classes.GISModel? gISModel)
        {
            if (gISModel == null)
            {
                return null;
            }

            return new GH_Guid(gISModel.Guid);
        }

        /// <summary>
        /// Gets a collection of 2D buildings associated with the specified GIS model, converted to Goo wrappers.
        /// </summary>
        /// <param name="gISModel">The GIS model to inspect.</param>
        /// <returns>An enumerable collection of GooBuilding2D objects, or null if the model is null.</returns>
        [Inspect("Building2Ds", "Building2Ds", "GISModel Building2Ds")]
        public static IEnumerable? Building2Ds(this GIS.Classes.GISModel? gISModel)
        {
            if (gISModel == null)
            {
                return null;
            }

            return gISModel.GetObjects<Building2D>()?.ConvertAll(x => new GooBuilding2D(x));
        }

        /// <summary>
        /// Gets a collection of administrative areas associated with the specified GIS model, converted to Goo wrappers.
        /// </summary>
        /// <param name="gISModel">The GIS model to inspect.</param>
        /// <returns>An enumerable collection of GooAdministrativeAreal2D objects, or null if the model is null.</returns>
        [Inspect("AdministrativeAreal2Ds", "AdministrativeAreal2Ds", "GISModel AdministrativeAreal2Ds")]
        public static IEnumerable? AdministrativeAreal2Ds(this GIS.Classes.GISModel? gISModel)
        {
            if (gISModel == null)
            {
                return null;
            }

            return gISModel.GetObjects<AdministrativeAreal2D>()?.ConvertAll(x => new GooAdministrativeAreal2D(x));
        }
    }
}