# 014 – Arrays With Try-Catch

## Overview

Builds directly on [013](../013-Without-Try-Catch-Numbers-Array/README.md) by wrapping the array access in a **`try-catch` block**. Instead of crashing, the program now handles the `IndexOutOfRangeException` gracefully and prints a message.

## Concepts Covered

- `try` / `catch` blocks
- Catching the base `Exception` class
- `e.Message` to read the runtime error message
- Difference between a crash and a handled exception

## Project Structure

```
014-Try-Catch-Numbers-Array/
└── TryCatchNumbersArray/
    └── Program.cs
```

## Code

```csharp
int myIndex = 3;
int myOtherIndex = 5;  // still out of range

try
{
    int[] myNumbers = { 10, 20, 30, 40, 50 };
    Console.WriteLine(myNumbers[myIndex]);       // prints 40
    Console.WriteLine(myNumbers[myOtherIndex]);  // throws exception
}
catch (Exception e)
{
    Console.WriteLine(e.Message);  // prints error message, no crash
}
```

## How to Run

```bash
dotnet run --project TryCatchNumbersArray
```

### Expected Output

```
40
Index was outside the bounds of the array.
```

> **Next Step:** See [015 – Custom Error Message](../015-Try-Catch-Numbers-Array-CustomErrorMessage/README.md) to learn how to catch specific exception types with friendly custom messages.
