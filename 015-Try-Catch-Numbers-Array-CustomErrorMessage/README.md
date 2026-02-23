# 015 – Try-Catch With Custom Error Messages

## Overview

Extends the try-catch pattern from [014](../014-Try-Catch-Numbers-Array/README.md) by using **multiple catch blocks** to handle different exception types with custom, user-friendly messages.

## Concepts Covered

- Multiple `catch` blocks for different exception types
- Catching a specific exception: `IndexOutOfRangeException`
- Fallback `catch (Exception e)` for any other errors
- Division by zero as a runtime `DivideByZeroException`
- Execution continues after the `try-catch` block

## Project Structure

```
015-Try-Catch-Numbers-Array-CustomErrorMessage/
└── TryCatchNumbersArraysCustomErrorMessage/
    └── Program.cs
```

## Code

```csharp
try
{
    int[] myNumbers = { 10, 20, 30, 40, 50 };
    Console.WriteLine(myNumbers[4]);      // 50
    Console.WriteLine(myNumbers[4]/10);   // 5
    Console.WriteLine(myNumbers[4]/0);    // ← DivideByZeroException!
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Original message: " + e.Message);
    Console.WriteLine("You got an error, ambitious youngster. We do not have so many items in this array.");
}
catch (Exception e)
{
    Console.WriteLine("Original message: " + e.Message);
    Console.WriteLine("You got an error!");
}

Console.WriteLine("No error!");
```

## How to Run

```bash
dotnet run --project TryCatchNumbersArraysCustomErrorMessage
```

### Expected Output (with divide-by-zero active)

```
50
5
Original message: Attempted to divide by zero.
You got an error!
No error!
```

> **Tip:** Uncomment `myNumbers[5]` to trigger the `IndexOutOfRangeException` branch and see the different custom message.
