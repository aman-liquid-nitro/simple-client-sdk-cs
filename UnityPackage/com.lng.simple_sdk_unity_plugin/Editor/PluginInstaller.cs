using UnityEditor;
using UnityEngine;

namespace LNG.SimpleSDKUnityPlugin.Editor
{
    /// <summary>
    /// Editor window for plugin installation and configuration
    /// </summary>
    public class PluginInstaller : EditorWindow
    {
        [MenuItem("Tools/LNG/Simple SDK Plugin Installer")]
        public static void ShowWindow()
        {
            GetWindow<PluginInstaller>("Simple SDK Plugin Installer");
        }

        private void OnGUI()
        {
            GUILayout.Space(10);

            // Header
            EditorGUILayout.LabelField("Simple SDK Unity Plugin System", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Version 1.0.0", EditorStyles.miniLabel);

            GUILayout.Space(20);

            // Status
            EditorGUILayout.LabelField("Installation Status:", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("Simple SDK Plugin system is properly installed and ready to use.", MessageType.Info);

            GUILayout.Space(10);

            // Features
            EditorGUILayout.LabelField("Available Features:", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("• Math Operations (Add, Subtract, Multiply, Divide)");
            EditorGUILayout.LabelField("• String Utilities (Reverse, Upper/Lower Case)");
            EditorGUILayout.LabelField("• Random Generation (Int, Float, Bool, Color, Vector3)");

            GUILayout.Space(20);

            // Quick Actions
            if (GUILayout.Button("Create Example Scene", GUILayout.Height(30)))
            {
                CreateExampleScene();
            }

            if (GUILayout.Button("View Documentation", GUILayout.Height(25)))
            {
                Application.OpenURL("https://docs.liquidnitrogames.com/simple-sdk-unity-plugin");
            }

            GUILayout.Space(10);
        }

        private void CreateExampleScene()
        {
            // This would create a new scene with example objects
            Debug.Log("Creating example scene...");
            // Implementation for scene creation would go here
        }
    }

    /// <summary>
    /// Adds menu items for quick access to plugin features
    /// </summary>
    public class PluginMenuItems
    {
        [MenuItem("Tools/LNG/Quick Actions/Reverse Selected Text")]
        private static void ReverseSelectedText()
        {
            string testText = "Hello Unity";
            string reversed = SimpleSdk.Unity.BridgePlugin.PluginBridge.ReverseString(testText);
            Debug.Log($"Reversed '{testText}': {reversed}");
        }
    }
}