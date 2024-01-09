using System;

namespace maxdatatype
{
   class Program
   {
       static void Main(string[] args)
       {
           // Display minimum and maximum ranges for each data type
           Console.WriteLine("Decimal Data Type:");
           Console.WriteLine("  Minimum Value: {0}", Decimal.MinValue);
           Console.WriteLine("  Maximum Value: {0}", Decimal.MaxValue);
           Console.WriteLine("  Exponent Form (Min): {0:E}", Decimal.MinValue);
           Console.WriteLine("  Exponent Form (Max): {0:E}", Decimal.MaxValue);

           Console.WriteLine("\nFloat (Single) Data Type:");
           Console.WriteLine("  Minimum Value: {0}", Single.MinValue);
           Console.WriteLine("  Maximum Value: {0}", Single.MaxValue);
           Console.WriteLine("  Exponent Form (Min): {0:E}", Single.MinValue);
           Console.WriteLine("  Exponent Form (Max): {0:E}", Single.MaxValue);

           Console.WriteLine("\nDouble Data Type:");
           Console.WriteLine("  Minimum Value: {0}", Double.MinValue);
           Console.WriteLine("  Maximum Value: {0}", Double.MaxValue);
           Console.WriteLine("  Exponent Form (Min): {0:E}", Double.MinValue);
           Console.WriteLine("  Exponent Form (Max): {0:E}", Double.MaxValue);
           
           Console.ReadLine();
       }
   }
}
