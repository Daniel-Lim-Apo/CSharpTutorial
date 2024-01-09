using System;

namespace Program
{
   class Program
   {
       static void Main(string[] args)
       {
           int Num1, Num2, result;
           char option;

           Console.Write("Enter the First Number: ");
           Num1 = Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter the Second Number: ");
           Num2 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Main Menu");
           Console.WriteLine("1. Addition");
           Console.WriteLine("2. Subtraction");
           Console.WriteLine("3. Multiplication");
           Console.WriteLine("4. Division");
           Console.WriteLine("5. Modulus (remainder of division)");
           Console.WriteLine("6. Increment and Decrement");
           Console.WriteLine("7. Logical Operators");
           Console.WriteLine("8. Comparison Operators");
           Console.Write("Enter the Operation you choose to perform: ");
           option = Convert.ToChar(Console.ReadLine());

           switch (option)
           {
               case '1':
                   result = Num1 + Num2;
                   Console.WriteLine("The result of Addition is: {0}", result);
                   break;
               case '2':
                   result = Num1 - Num2;
                   Console.WriteLine("The result of Subtraction is: {0}", result);
                   break;
               case '3':
                   result = Num1 * Num2;
                   Console.WriteLine("The result of Multiplication is: {0}", result);
                   break;
               case '4':
                   if (Num2 == 0)
                   {
                       Console.WriteLine("Error: Division by zero");
                   }
                   else
                   {
                       result = Num1 / Num2;
                       Console.WriteLine("The result of Division is: {0}", result);
                   }
                   break;
               case '5':
                   result = Num1 % Num2;
                   Console.WriteLine("The remainder of Division (Modulus) is: {0}", result);
                   break;
               case '6':
                   Console.WriteLine("Incrementing Num1 by 1: {0}", ++Num1);  // Pre-increment
                   Console.WriteLine("Decrementing Num2 by 1: {0}", Num2--);  // Post-decrement
                   break;
               case '7':
                   bool isEqual = Num1 == Num2;
                   Console.WriteLine("Are the numbers equal? {0}", isEqual);
                   bool isNotGreater = !(Num1 > Num2);
                   Console.WriteLine("Is Num1 NOT greater than Num2? {0}", isNotGreater);
                   break;
               case '8':
                   Console.WriteLine("Is Num1 greater than Num2? {0}", Num1 > Num2);
                   Console.WriteLine("Is Num1 less than or equal to Num2? {0}", Num1 <= Num2);
                   break;
               default:
                   Console.WriteLine("Invalid Option");
                   break;
           }

           Console.ReadLine();
       }
   }
}
