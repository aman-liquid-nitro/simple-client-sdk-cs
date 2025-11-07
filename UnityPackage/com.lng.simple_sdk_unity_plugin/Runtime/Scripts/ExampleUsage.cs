using UnityEngine;

namespace LNG.SimpleSDKUnityPlugin.Examples
{
    /// <summary>
    /// Example script demonstrating how to use the plugin system
    /// </summary>
    public class ExampleUsage : MonoBehaviour
    {
        [Header("Math Examples")]
        public int mathValueA = 10;
        public int mathValueB = 5;
        
        [Header("String Examples")]
        public string testString = "Hello Unity!";
        
        [Header("Random Examples")]
        public bool generateOnStart = true;
        public float minRandomRange = 0f;
        public float maxRandomRange = 10f;

        private void Start()
        {
            if (!PluginManager.IsReady())
            {
                Debug.LogError("Plugin system not ready!");
                return;
            }

            Debug.Log("=== Unity Plugin System Examples ===");
            
            DemonstrateMathOperations();
            DemonstrateStringOperations();
            
            if (generateOnStart)
            {
                DemonstrateRandomGeneration();
            }
        }

        private void DemonstrateMathOperations()
        {
            Debug.Log("--- Math Operations ---");
            
            int sum = Unity.BridgePlugin.PluginBridge.Add(mathValueA, mathValueB);
            int difference = Unity.BridgePlugin.PluginBridge.Subtract(mathValueA, mathValueB);
            float product = Unity.BridgePlugin.PluginBridge.Multiply(mathValueA, mathValueB);
            float quotient = Unity.BridgePlugin.PluginBridge.Divide(mathValueA, mathValueB);

            Debug.Log($"{mathValueA} + {mathValueB} = {sum}");
            Debug.Log($"{mathValueA} - {mathValueB} = {difference}");
            Debug.Log($"{mathValueA} * {mathValueB} = {product}");
            Debug.Log($"{mathValueA} / {mathValueB} = {quotient}");
        }

        private void DemonstrateStringOperations()
        {
            Debug.Log("--- String Operations ---");
            
            string reversed = Unity.BridgePlugin.PluginBridge.ReverseString(testString);
            string upperCase = Unity.BridgePlugin.PluginBridge.ToUpper(testString);
            string lowerCase = Unity.BridgePlugin.PluginBridge.ToLower(testString);

            Debug.Log($"Original: {testString}");
            Debug.Log($"Reversed: {reversed}");
            Debug.Log($"Uppercase: {upperCase}");
            Debug.Log($"Lowercase: {lowerCase}");
        }

        private void DemonstrateRandomGeneration()
        {
            Debug.Log("--- Random Generation ---");
            
            // Set seed for reproducible results
            Unity.BridgePlugin.PluginBridge.SetRandomSeed(12345);
            
            int randomInt = Unity.BridgePlugin.PluginBridge.GetRandomInt((int)minRandomRange, (int)maxRandomRange);
            float randomFloat = Unity.BridgePlugin.PluginBridge.GetRandomFloat(minRandomRange, maxRandomRange);
            bool randomBool = Unity.BridgePlugin.PluginBridge.GetRandomBool();
            Color randomColor = Unity.BridgePlugin.UnityExtensions.RandomColor();
            Vector3 randomVector = Unity.BridgePlugin.UnityExtensions.RandomVector3(minRandomRange, maxRandomRange);

            Debug.Log($"Random Int: {randomInt}");
            Debug.Log($"Random Float: {randomFloat}");
            Debug.Log($"Random Bool: {randomBool}");
            Debug.Log($"Random Color: {randomColor}");
            Debug.Log($"Random Vector3: {randomVector}");
        }

        private void Update()
        {
            // Example: Generate random values on space press
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GenerateRandomValue();
            }
        }

        private void GenerateRandomValue()
        {
            float randomValue = Unity.BridgePlugin.PluginBridge.GetRandomFloat(minRandomRange, maxRandomRange);
            Debug.Log($"Generated Random Value: {randomValue}");
        }
    }
}