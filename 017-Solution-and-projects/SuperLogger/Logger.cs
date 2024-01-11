using System;

namespace SuperLogger
{
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}