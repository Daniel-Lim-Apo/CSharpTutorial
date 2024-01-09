using System;

namespace DataConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            // int to short (explicit cast)
            int originalInt = 12345;
            Console.WriteLine("originalInt is " + originalInt.GetType());
            short convertedShort = (short)originalInt;
            Console.WriteLine("convertedShort is " + convertedShort.GetType());
            Console.WriteLine("int {0} converted to short {1}", originalInt, convertedShort);
            Console.WriteLine();

            // float to int (explicit cast)
            float originalFloat = 3.14159f;
            Console.WriteLine("originalFloat is " + originalFloat.GetType());
            int convertedInt = (int)originalFloat;
            Console.WriteLine("convertedInt is " + convertedInt.GetType());
            Console.WriteLine("float {0} converted to int {1}", originalFloat, convertedInt);
            Console.WriteLine();
        }
    }
}