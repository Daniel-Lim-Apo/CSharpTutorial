using System;

public class FiveNumbers
{
    public static void Main()
    {
        int i, n, sum = 0;
        double avg;

        Console.Write("\n\n");
        Console.Write("Read 5 numbers and calculate sum and average:\n");
        Console.Write("----------------------------------------------\n\n");

        Console.Write("Input the 5 numbers: \n");
        for (i = 1; i <= 5; i++)
        {
            Console.Write("Number-{0} :", i);
            n = Convert.ToInt32(Console.ReadLine());
            sum += n;
        }

        avg = sum / 5.0;  // Calculate average for 5 numbers
        Console.Write("The sum of 5 numbers is : {0}\nThe Average is : {1}\n", sum, avg);
    }
}