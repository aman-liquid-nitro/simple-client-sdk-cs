using System;

namespace SimpleSdk.Core
{
    internal class InternalUtilities
    {
        internal static string FormatMessage(string message)
        {
            return $"[Core] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}";
        }
    }
}