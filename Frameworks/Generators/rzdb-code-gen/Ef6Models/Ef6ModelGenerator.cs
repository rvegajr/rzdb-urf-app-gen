using RzDb.CodeGen;

public class Ef6ModelsGenerator : EdmxCodeGenBase
{
    public Ef6ModelsGenerator(string edmxPath, string outputPath) : base(edmxPath, @"Ef6Models\Ef6ModelsTemplate.cshtml", outputPath)
    {
            
    }
}