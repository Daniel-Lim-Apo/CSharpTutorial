using System;
public class TwoNumbersTriangle
{
  public static void Main()
  {
   Console.Write("Input a number to be used: ");
   int number = Convert.ToInt32( Console.ReadLine() );
 
   Console.Write("Input the desired width for a triangle be done: ");
   int width = Convert.ToInt32( Console.ReadLine() );
 
   int height = width;   
   for (int row=0; row < height; ++row)
   {
    for (int column=0; column < width; ++column)
   {
   Console.Write(number);
  }
 
   Console.WriteLine();
   width--;
  }
 }
} 
