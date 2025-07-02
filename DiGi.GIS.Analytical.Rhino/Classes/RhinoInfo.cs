using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.GIS.Analytical.Rhino.Classes
{
    public class RhinoInfo : GH_AssemblyInfo
    {
        public override string Name => "DiGi.GIS.Analytical.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("c89f4c64-b274-4395-9feb-532701db5f22");

        //Return a string identifying you or your company.
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}
