using System;

public class LargestInFour
{
   public static void Main()
   {
       int num1, num2, num3, num4;
       Console.Write("\n\n");
       Console.Write("Find the largest of four numbers:\n");
       Console.Write("------------------------------------\n\n");

       Console.Write("Input the 1st number: ");
       num1 = Convert.ToInt32(Console.ReadLine());
       Console.Write("Input the 2nd number: ");
       num2 = Convert.ToInt32(Console.ReadLine());
       Console.Write("Input the 3rd number: ");
       num3 = Convert.ToInt32(Console.ReadLine());
       Console.Write("Input the 4th number: ");
       num4 = Convert.ToInt32(Console.ReadLine());

       int largest = num1;  // Assume num1 is the largest initially

       // Compare with other numbers to find the actual largest
       if (num2 > largest)
       {
           largest = num2;
       }
       if (num3 > largest)
       {
           largest = num3;
       }
       if (num4 > largest)
       {
           largest = num4;
       }

       Console.Write("The largest number is: {0}\n\n", largest);
   }
}
