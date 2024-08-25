using System.Runtime.CompilerServices;

namespace LearnCSharp.Helpers
{
    public static class Helper
    {
        public static void Output(
            string message,
            [CallerMemberName] string methodName = "",
            [CallerFilePath] string filePath = "")
        {
            string className = Path.GetFileNameWithoutExtension(filePath);
            Console.WriteLine($"[{className}: {methodName}]: {message}");
        }
    }
}