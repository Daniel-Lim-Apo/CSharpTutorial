using System;

namespace MySuperLogger
{
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}