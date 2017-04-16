using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace RzDb.CodeGen
{

    public class WebApiControllerGenerator : EdmxCodeGenBase
    {
        public WebApiControllerGenerator(string edmxPath, string outputPath) : base(edmxPath, @"WebApiControllers\WebApiControllersTemplate.cshtml", outputPath)
        {
            
        }
    }
}