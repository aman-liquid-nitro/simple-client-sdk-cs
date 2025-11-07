using System;

namespace SimpleSdk.Core
{
    public class RandomGenerator
    {
        private Random _random;

        public RandomGenerator()
        {
            _random = new Random();
        }

        public RandomGenerator(int seed)
        {
            _random = new Random(seed);
        }

        public int GetRandomInt(int min, int max)
        {
            return _random.Next(min, max);
        }

        public float GetRandomFloat(float min, float max)
        {
            return (float)(_random.NextDouble() * (max - min) + min);
        }

        public bool GetRandomBool()
        {
            return _random.Next(0, 2) == 1;
        }
    }
}
