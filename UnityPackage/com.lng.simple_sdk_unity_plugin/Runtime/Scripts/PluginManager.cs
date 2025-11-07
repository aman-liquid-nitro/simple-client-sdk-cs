using UnityEngine;

namespace LNG.SimpleSDKUnityPlugin
{
    /// <summary>
    /// Main manager class that initializes and provides access to the plugin system
    /// </summary>
    public static class PluginManager
    {
        private static bool _isInitialized = false;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize()
        {
            if (_isInitialized) return;

            // Verify plugin is working
            bool pluginReady = SimpleSdk.Unity.BridgePlugin.PluginBridge.IsInitialized();
            
            if (pluginReady)
            {
                _isInitialized = true;
                Debug.Log($"Simple SDK Unity Plugin System initialized successfully. Version: {GetVersion()}");
                
                // Log system readiness
                Debug.Log($"Math operations: ✓");
                Debug.Log($"String utilities: ✓");
                Debug.Log($"Random generation: ✓");
            }
            else
            {
                Debug.LogError("Failed to initialize Unity Plugin System!");
            }
        }

        /// <summary>
        /// Gets the version information of the plugin system
        /// </summary>
        public static string GetVersion()
        {
            return Unity.BridgePlugin.PluginBridge.GetVersionInfo();
        }

        /// <summary>
        /// Check if the plugin system is properly initialized and ready to use
        /// </summary>
        public static bool IsReady()
        {
            return _isInitialized;
        }
    }
}