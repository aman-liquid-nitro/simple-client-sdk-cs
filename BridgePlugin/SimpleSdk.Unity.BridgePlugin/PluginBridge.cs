using System;
using SimpleSdk.Core;

namespace SimpleSdk.Unity.BridgePlugin
{
    /// <summary>
    /// Main bridge class that provides Unity-friendly access to core plugin functionality
    /// </summary>
    public static class PluginBridge
    {
        private static Calculator _calculator;
        private static StringUtilities _stringUtilities;
        private static RandomGenerator _randomGenerator;

        static PluginBridge()
        {
            _calculator = new Calculator();
            _stringUtilities = new StringUtilities();
            _randomGenerator = new RandomGenerator();
        }

        #region Math Operations

        /// <summary>
        /// Adds two integers and returns the result
        /// </summary>
        public static int Add(int a, int b)
        {
            return _calculator.Add(a, b);
        }

        /// <summary>
        /// Subtracts two integers and returns the result
        /// </summary>
        public static int Subtract(int a, int b)
        {
            return _calculator.Subtract(a, b);
        }

        /// <summary>
        /// Multiplies two floats and returns the result
        /// </summary>
        public static float Multiply(float a, float b)
        {
            return _calculator.Multiply(a, b);
        }

        /// <summary>
        /// Divides two floats and returns the result
        /// </summary>
        public static float Divide(float a, float b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero attempted");
                return float.NaN;
            }
            return _calculator.Divide(a, b);
        }

        #endregion

        #region String Operations

        /// <summary>
        /// Reverses the input string
        /// </summary>
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input string is null or empty");
                return input;
            }
            return _stringUtilities.Reverse(input);
        }

        /// <summary>
        /// Converts string to uppercase
        /// </summary>
        public static string ToUpper(string input)
        {
            return _stringUtilities.ToUpperCase(input);
        }

        /// <summary>
        /// Converts string to lowercase
        /// </summary>
        public static string ToLower(string input)
        {
            return _stringUtilities.ToLowerCase(input);
        }

        #endregion

        #region Random Generation

        /// <summary>
        /// Returns a random integer between min (inclusive) and max (exclusive)
        /// </summary>
        public static int GetRandomInt(int min, int max)
        {
            return _randomGenerator.GetRandomInt(min, max);
        }

        /// <summary>
        /// Returns a random float between min (inclusive) and max (inclusive)
        /// </summary>
        public static float GetRandomFloat(float min, float max)
        {
            return _randomGenerator.GetRandomFloat(min, max);
        }

        /// <summary>
        /// Returns a random boolean value
        /// </summary>
        public static bool GetRandomBool()
        {
            return _randomGenerator.GetRandomBool();
        }

        /// <summary>
        /// Initializes random generator with a specific seed
        /// </summary>
        public static void SetRandomSeed(int seed)
        {
            _randomGenerator = new RandomGenerator(seed);
        }

        #endregion

        #region Utility Methods

        /// <summary>
        /// Validates if the plugin is properly initialized and ready to use
        /// </summary>
        public static bool IsInitialized()
        {
            return _calculator != null &&
                   _stringUtilities != null &&
                   _randomGenerator != null;
        }

        /// <summary>
        /// Gets version information for the plugin
        /// </summary>
        public static string GetVersionInfo()
        {
            return "Unity Bridge Plugin v1.0.0 - Core Plugin Integration";
        }

        #endregion
    }
}