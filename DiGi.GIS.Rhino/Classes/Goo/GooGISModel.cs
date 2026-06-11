using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.GIS.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for the <see cref="GIS.Classes.GISModel"/> class, 
    /// enabling its use within the Grasshopper environment.
    /// </summary>
    public class GooGISModel : GooSerializableObject<GIS.Classes.GISModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooGISModel"/> class.
        /// </summary>
        public GooGISModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGISModel"/> class with a specified GIS model.
        /// </summary>
        /// <param name="gISModel">The GIS model to wrap.</param>
        public GooGISModel(GIS.Classes.GISModel? gISModel)
        {
            Value = gISModel;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A duplicate of the current <see cref="GooGISModel"/> as an <see cref="IGH_Goo"/>.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooGISModel(Value);
        }

        /// <summary>
        /// Attempts to cast a source object into the <see cref="GooGISModel"/> type.
        /// </summary>
        /// <param name="source">The object to cast from.</param>
        /// <returns><c>true</c> if the casting was successful; otherwise, <c>false</c>.</returns>
        public override bool CastFrom(object? source)
        {
            if (source == null)
            {
                return false;
            }

            if (source is GIS.Classes.GISModel gISModel)
            {
                Value = gISModel;
                return true;
            }

            Type? type_Source = source?.GetType();
            if (typeof(IGH_Goo).IsAssignableFrom(type_Source))
            {
                object @object = (source as dynamic)!.Value;
                if (@object is GIS.Classes.GISModel gISModel_Temp)
                {
                    Value = gISModel_Temp;
                }
                else if (@object is GIS.Classes.GISModelFile gISModelFile)
                {
                    Value = gISModelFile.Value;
                }
            }

            return base.CastFrom(source);
        }

        /// <summary>
        /// Attempts to cast the wrapped value into a specified type.
        /// </summary>
        /// <typeparam name="Y">The target type for casting.</typeparam>
        /// <param name="target">A reference to the target variable where the result will be stored.</param>
        /// <returns><c>true</c> if the casting was successful; otherwise, <c>false</c>.</returns>
        public override bool CastTo<Y>(ref Y target)
        {
            if (typeof(Y) == typeof(GIS.Classes.GISModel))
            {
                target = (Y)(object)Value!;
                return true;
            }

            if (typeof(Y) == typeof(object))
            {
                target = (Y)(object)Value!;
                return true;
            }

            return base.CastTo(ref target);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter that handles <see cref="GooGISModel"/> objects and persists <see cref="GIS.Classes.GISModel"/> data.
    /// </summary>
    public class GooGISModelParam : GooPresistentParam<GooGISModel, GIS.Classes.GISModel>
    {
        /// <summary>
        /// Gets the unique global identifier for the <see cref="GooGISModelParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("de24fde4-53dc-42df-8c0a-27cde1a3d1ed");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooGISModelParam"/> class.
        /// </summary>
        public GooGISModelParam()
            : base()
        {
        }
    }
}