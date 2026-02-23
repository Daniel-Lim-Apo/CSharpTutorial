# 005 – Find the Largest of Four Numbers

## Overview

This program reads **four integers** from the user and determines which one is the **largest**, using a sequential `if` comparison approach.

## Concepts Covered

- Reading multiple user inputs with `Console.ReadLine()` and `Convert.ToInt32`
- Using `if` statements to compare values
- Variable assignment to track a running maximum

## Project Structure

```
005-Four-Numbers/
└── FourNumbers/
    └── Program.cs
```

## Code Summary

The algorithm starts by assuming `num1` is the largest, then compares it against `num2`, `num3`, and `num4` in sequence, updating the `largest` variable whenever a bigger number is found.

```csharp
int largest = num1;
if (num2 > largest) largest = num2;
if (num3 > largest) largest = num3;
if (num4 > largest) largest = num4;
```

## How to Run

```bash
dotnet run --project FourNumbers
```

### Example Session

```
Find the largest of four numbers:
------------------------------------

Input the 1st number: 12
Input the 2nd number: 45
Input the 3rd number: 7
Input the 4th number: 33
The largest number is: 45
```
