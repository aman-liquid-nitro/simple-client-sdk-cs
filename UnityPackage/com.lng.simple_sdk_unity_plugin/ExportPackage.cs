using UnityEditor;
using UnityEngine;
using System.IO;

public static class PackageExporter
{
    private const string PackageName = "com.lng.simple_sdk_unity_plugin";
    private const string OutputDirectory = "../Export";
    
    [MenuItem("Tools/LNG/Simple SDK/Export Package")]
    public static void Export()
    {
        // Ensure output directory exists
        if (!Directory.Exists(OutputDirectory))
            Directory.CreateDirectory(OutputDirectory);

        // Define assets to include in package
        string[] assetsToExport = new string[]
        {
            $"Assets/{PackageName}",
            $"Assets/{PackageName}/package.json",
            $"Assets/{PackageName}/Runtime",
            $"Assets/{PackageName}/Runtime/SimpleSdk.Core.dll",
            $"Assets/{PackageName}/Runtime/SimpleSdk.Unity.BridgePlugin.dll",
            $"Assets/{PackageName}/Runtime/Scripts",
            $"Assets/{PackageName}/Editor",
            $"Assets/{PackageName}/Samples",
            $"Assets/{PackageName}/Documentation"
        };

        string outputPath = $"{OutputDirectory}/{PackageName}.unitypackage";
        
        // Export the package
        AssetDatabase.ExportPackage(assetsToExport, outputPath, ExportPackageOptions.Recurse);
        
        Debug.Log($"Package exported to: {outputPath}");
    }
}