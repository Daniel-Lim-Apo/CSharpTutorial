using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Define a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Use LINQ to filter the list for even numbers
        var evenNumbers = from number in numbers
                          where number % 2 == 0
                          select number;

        var oddNumbers = numbers.Where(n => n % 2 != 0);

        // Alternatively, you can use method syntax
        // var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even Numbers:");

        // Iterate over each even number and print it
        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Odd Numbers:");
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
