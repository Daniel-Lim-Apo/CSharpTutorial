# 009 – Number to Words

## Overview

Converts a positive integer entered by the user into its **English word representation**, digit by digit. For example, `123` → `"one two three"`.

## Concepts Covered

- `while` loop
- Modulo operator (`%`) to extract the last digit
- Integer division (`/`) to remove the last digit
- String array lookup (`digits[digit]`)
- String concatenation / prepending
- `String.Trim()` to remove leading spaces

## Project Structure

```
009-Num-to-Words/
└── NumToWords/
    └── Program.cs
```

## Algorithm

The digits are extracted from right to left using `num % 10`, then prepended to the result string. This reverses the order so the output reads left to right.

```csharp
static string[] digits = { "zero","one","two","three","four",
                            "five","six","seven","eight","nine" };

while (num > 0)
{
    int digit = num % 10;
    word = digits[digit] + " " + word;  // prepend
    num /= 10;
}
Console.WriteLine("Number in words: " + word.Trim());
```

## How to Run

```bash
dotnet run --project NumToWords
```

### Example Session

```
Enter the number:
4275
Number in words: four two seven five
```

> **Note:** The program only handles positive integers. Leading zeros are not shown (e.g., input `0` produces no output since the `while` condition is `num > 0`).
