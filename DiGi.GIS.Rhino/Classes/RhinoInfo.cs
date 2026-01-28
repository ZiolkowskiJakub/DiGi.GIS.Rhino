using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.GIS.Rhino.Classes
{
    public class RhinoInfo : GH_AssemblyInfo
    {
        public override string Name => "DiGi.GIS.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap? Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new("5f962e9f-3dde-4ee9-94fb-2d9339ece48c");

        //Return a string identifying you or your company.
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}