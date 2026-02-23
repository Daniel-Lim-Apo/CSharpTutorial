# 007 – Two Numbers Triangle

## Overview

Prints a **right-triangle pattern** made of a repeated digit. The user provides the digit to print and the width (number of columns) of the triangle. Each successive row has one fewer character than the previous.

## Concepts Covered

- Nested `for` loops
- Decrementing the inner loop bound (`width--`) each iteration
- User input for controlling loop parameters

## Project Structure

```
007-Two-Numbers-Triangle/
└── TwoNumbersTriangle/
    └── Program.cs
```

## Code Summary

```csharp
for (int row = 0; row < height; ++row)
{
    for (int column = 0; column < width; ++column)
        Console.Write(number);

    Console.WriteLine();
    width--;   // reduce width each row → triangle shape
}
```

## How to Run

```bash
dotnet run --project TwoNumbersTriangle
```

### Example Session

```
Input a number to be used: 7
Input the desired width for a triangle be done: 5
77777
7777
777
77
7
```
