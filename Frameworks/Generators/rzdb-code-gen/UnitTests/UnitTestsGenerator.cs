using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using RzDb.CodeGen;

public class UnitTestsGenerator : EdmxCodeGenBase
{
    public UnitTestsGenerator(string edmxPath, string outputPath) : base(edmxPath, @"UnitTests\UnitTestsTemplate.cshtml", outputPath)
    {
            
    }
}