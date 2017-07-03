using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace RzDb.CodeGen
{
    class ConsoleHarness
    {
        static void Main(string[] args)
        {
            var edmxFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase) + @"\..\..\..\..\DataAccess\Models\WideWorldImporters.edmx";
            if (edmxFile.StartsWith("file:\\")) edmxFile = edmxFile.Substring(6);
            string exactPath = Path.GetFullPath(edmxFile);
            if (!File.Exists(edmxFile))
            {
                System.Console.WriteLine(@"Input File '" + edmxFile + "' does not exist");
            } else
            {
                var outputPath = Path.GetTempPath() + "RzDbCodeGen\\";
                if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
                // Code that goes into CodeGenerations.tt file starts here --- 

                //new WebApiControllerGenerator(edmxFile, outputPath).ProcessTemplate();
                //new EdmxGenDemoGenerator(edmxFile, outputPath).ProcessTemplate();
                new Ef6ModelsGenerator(edmxFile, outputPath).ProcessTemplate();


                // End of the Code that goes into RzDb.CodeGenerations.tt 
                Process.Start(outputPath);
            }
        }
    }
}
