using System;

public class ConvertDigitsToWords
{
    public static void Main()
    {
        // Complexity: O(1)
        int num;
        string word = "";

        Console.WriteLine("Enter the number:");
        num = Convert.ToInt32(Console.ReadLine());

        // Complexity: O(log n), where n is the number of digits in num
        while (num > 0)
        {
            int digit = num % 10;
            word = digits[digit] + " " + word;  // Concatenation is O(n) for strings
            num /= 10;
        }

        Console.WriteLine("Number in words: " + word.Trim()); // Trim to remove leading space
        Console.ReadLine();
    }

    // Complexity: O(1)
    static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
}
