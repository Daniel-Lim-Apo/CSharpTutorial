using System;
using MySuperLogger;
using MyCalcMachine;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            Logger.Log("Starting the program...");

            int resultAddition = Calculator.Add(5, 3);
            int resultSubtraction = Calculator.Subtract(10, 4);

            Console.WriteLine($"Addition result: {resultAddition}");
            Console.WriteLine($"Subtraction result: {resultSubtraction}");

            Logger.Log("Program completed.");
        }
    }
}