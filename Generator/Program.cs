using HexaGen;

CsCodeGeneratorSettings settings = CsCodeGeneratorSettings.Load("generator.json");
CsCodeGenerator generator = new CsCodeGenerator(settings);
generator.PatchEngine.RegisterPrePatch(new NamingPatch());
generator.Generate([.. Directory.GetFiles("include")], "../../../../Hexa.NET.LibSSH2/Generated");