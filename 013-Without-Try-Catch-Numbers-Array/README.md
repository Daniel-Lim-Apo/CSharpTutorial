# 013 – Arrays Without Try-Catch (Out-of-Range Crash)

## Overview

This intentionally **buggy** example demonstrates what happens when you access an array element at an **index that does not exist** — without any error handling. The program will crash with an `IndexOutOfRangeException`.

## Concepts Covered

- Array declaration and initialisation with `{ }` syntax
- Zero-based indexing
- What `IndexOutOfRangeException` is and why it is thrown
- The need for error handling (contrast with [014](../014-Try-Catch-Numbers-Array/README.md) and [015](../015-Try-Catch-Numbers-Array-CustomErrorMessage/README.md))

## Project Structure

```
013-Without-Try-Catch-Numbers-Array/
└── WithoutTryCatchNumbersArray/
    └── Program.cs
```

## Code

```csharp
int myIndex = 3;
int myOtherIndex = 5;  // ← index 5 is out of range! (array has 5 elements: 0..4)

int[] myNumbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(myNumbers[myIndex]);       // prints 40 (OK)
Console.WriteLine(myNumbers[myOtherIndex]);  // ← CRASHES HERE
```

## How to Run

```bash
dotnet run --project WithoutTryCatchNumbersArray
```

### Expected Output

```
40
Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
```

> **Next Step:** See [014 – Try-Catch Numbers Array](../014-Try-Catch-Numbers-Array/README.md) for the same program with proper error handling.
