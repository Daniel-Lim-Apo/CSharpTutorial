using System;

namespace TypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Numeric types
            int age = 30; // Represents whole numbers
            double pi = 3.14159; // Represents decimal numbers
            decimal price = 12.99m; // Suitable for financial calculations

            // Character type
            char initial = 'A'; // Stores a single character

            // Boolean type
            bool isEligible = true; // Represents true/false values

            // String type
            string name = "Maria da Silva"; // Stores a sequence of characters

            // Declare a variable without assigning a value
            int unknownNumber = 0; // Value is not initialized

            // Output values to the console
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Pi: {0}", pi);
            Console.WriteLine("Price: {0}", price);
            Console.WriteLine("Initial: {0}", initial);
            Console.WriteLine("Eligible: {0}", isEligible);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Unknown number: {0}", unknownNumber);

            // Additional examples
            double temperature = -10.5; // Represents negative decimal values
            long population = 789_000_000; // Stores larger whole numbers
            float distance = 12.5f; // Used for smaller decimal values
            char grade = 'B'; // Represents a single character ('A', 'B', 'C', etc.)
            bool isActive = false; // Indicates an inactive state

            // Output additional values to the console
            Console.WriteLine("Temperature: {0}", temperature);
            Console.WriteLine("Population: {0}", population);
            Console.WriteLine("Distance: {0}", distance);
            Console.WriteLine("Grade: {0}", grade);
            Console.WriteLine("Is Active: {0}", isActive);
        }
    }
}
