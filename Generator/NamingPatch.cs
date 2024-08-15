using CppAst;
using HexaGen;
using HexaGen.Patching;

public class NamingPatch : PrePatch
{
    protected override void PatchFunction(CsCodeGeneratorSettings settings, CppFunction cppFunction)
    {
        var name = settings.GetPrettyFunctionName(cppFunction.Name);

        if (name.StartsWith("Libssh2"))
            name = name["Libssh2".Length..];

        settings.FunctionMappings.Add(new(cppFunction.Name, name, null, [], []));
    }
}