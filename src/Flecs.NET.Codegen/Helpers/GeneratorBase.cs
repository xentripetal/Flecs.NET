using System.IO;
using System.Runtime.CompilerServices;

namespace Flecs.NET.Codegen.Helpers;

public abstract class GeneratorBase
{
    public abstract void Generate();

    public void AddSource(string file, string source, [CallerFilePath] string callerPath = "")
    {
        string typeName = GetType().Name;
        string filePath = Path.GetFullPath(Path.Combine(callerPath, "..", "..", "..", "Flecs.NET", "Generated", typeName, file));
        string directoryPath = Path.GetDirectoryName(filePath);

        if (!Directory.Exists(directoryPath))
            Directory.CreateDirectory(directoryPath!);

        File.WriteAllText(filePath,  $$"""
            // /_/src/Flecs.NET/Generated/{{typeName}}/{{file}}
            // File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/{{typeName}}.cs
            {{source}}
            """);
    }
}
