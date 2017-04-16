using RzDb.CodeGen;

public class Ef6ContextGenerator : EdmxCodeGenBase
{
    public Ef6ContextGenerator(string edmxPath, string outputPath) : base(edmxPath, @"Ef6Context\Ef6ContextTemplate.cshtml", outputPath)
    {
            
    }
}