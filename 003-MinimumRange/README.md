# 003 – Minimum and Maximum Range of Data Types

## Overview

This example displays the **minimum and maximum values** of three floating-point data types in C#: `Decimal`, `Single` (float), and `Double`. It also shows how to format numbers in **exponential / scientific notation**.

## Concepts Covered

- `Decimal.MinValue` / `Decimal.MaxValue`
- `Single.MinValue` / `Single.MaxValue`
- `Double.MinValue` / `Double.MaxValue`
- String format specifier `{0:E}` for exponential notation
- `namespace` declaration
- `Console.ReadLine()` to pause the console

## Project Structure

```
003-MinimumRange/
└── MinimumMaxRange/
    └── Program.cs
```

## Code Summary

```csharp
using System;

namespace maxdatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal Data Type:");
            Console.WriteLine("  Minimum Value: {0}", Decimal.MinValue);
            Console.WriteLine("  Maximum Value: {0}", Decimal.MaxValue);
            Console.WriteLine("  Exponent Form (Min): {0:E}", Decimal.MinValue);
            // ... Similar output for Single and Double
        }
    }
}
```

## How to Run

```bash
dotnet run --project MinimumMaxRange
```

### Expected Output (excerpt)

```
Decimal Data Type:
  Minimum Value: -79228162514264337593543950335
  Maximum Value: 79228162514264337593543950335
  Exponent Form (Min): -7.922816E+028

Float (Single) Data Type:
  Minimum Value: -3.4028235E+38
  ...

Double Data Type:
  Minimum Value: -1.7976931348623157E+308
  ...
```
