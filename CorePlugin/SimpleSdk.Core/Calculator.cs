using System;

namespace SimpleSdk.Core
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }

        public float Divide(float a, float b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }
    }
}
