using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Creating the first thread to print numbers
        Thread thread1 = new Thread(new ThreadStart(PrintNumbers));
        thread1.Start(); // Starting the first thread

        // Creating the second thread to print letters
        Thread thread2 = new Thread(new ThreadStart(PrintLetters));
        thread2.Start(); // Starting the second thread

        Console.WriteLine("Main thread completes.");
    }

    // Method to be executed by thread1
    static void PrintNumbers()
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"Thread PrintNumbers -> Number: {i}");
            Thread.Sleep(500); // Simulate some work
        }
    }

    // Method to be executed by thread2
    static void PrintLetters()
    {
        char letter = 'a';
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Thread PrintLetters -> Letter: {letter}");
            letter++;
            Thread.Sleep(500); // Simulate some work
        }
    }
}
