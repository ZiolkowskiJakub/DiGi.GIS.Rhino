using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.GIS.Rhino.Classes
{
    public class Areal2DsByPoint2D : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("1d64346f-8b7e-45f6-8e8f-ee3bcd765eaa");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Areal2DsByPoint2D()
          : base("GIS.Areal2DsByPoint2D", "GIS.Areal2DsByPoint2D",
              "Gets Areal2Ds By Point2D",
              "DiGi", "DiGi.GIS")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooGISModelParam() { Name = "GISModel", NickName = "GISModel", Description = "DiGi GIS GISModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPoint2DParam() { Name = "Point2D", NickName = "Point2D", Description = "DiGi Geometry Point2D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

                Param_Number param_Number = new Param_Number() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(Core.Constans.Tolerance.Distance);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));
                
                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooBuilding2DParam() { Name = "Building2Ds", NickName = "Building2Ds", Description = "DiGi GIS Building2Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                result.Add(new Param(new GooAdministrativeAreal2DParam() { Name = "AdministrativeAreal2Ds", NickName = "AdministrativeAreal2Ds", Description = "DiGi GIS AdministrativeAreal2Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("GISModel");
            GIS.Classes.GISModel gISModel = null;
            if (index == -1 || !dataAccess.GetData(index, ref gISModel) || gISModel == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Point2D");
            Point2D point2D = null;
            if (index == -1 || !dataAccess.GetData(index, ref point2D) || point2D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Tolerance");
            double tolerance = Core.Constans.Tolerance.Distance;
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            List<Building2D> building2Ds = Query.Building2Ds(gISModel, point2D, out List<AdministrativeAreal2D> administrativeAreal2Ds, tolerance);

            index = Params.IndexOfOutputParam("Building2Ds");
            if (index != -1)
            {
                dataAccess.SetDataList(index, building2Ds?.ConvertAll(x => new GooBuilding2D(x)));
            }

            index = Params.IndexOfOutputParam("AdministrativeAreal2Ds");
            if (index != -1)
            {
                dataAccess.SetDataList(index, administrativeAreal2Ds?.ConvertAll(x => new GooAdministrativeAreal2D(x)));
            }
        }
    }
}