using System;
using System.Collections.Generic;
class Program
{
    // define a method that returns sum of two int numbers 
    static int calculateSum(int x, int y)
    {
        return x + y;
    }

    // define a delegate
    public delegate int myDelegate(int num1, int num2);

    static void Main()
    {
        // create an instance of delegate by passing method name 
        myDelegate d = new myDelegate(calculateSum);

        // calling calculateSum() using delegate
        int result = d(5, 6);

        Console.WriteLine(result);
    }
}