using System;

namespace SimpleSdk.Core
{
    public class StringUtilities
    {
        public string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string ToUpperCase(string input)
        {
            return input?.ToUpper();
        }

        public string ToLowerCase(string input)
        {
            return input?.ToLower();
        }
    }
}
