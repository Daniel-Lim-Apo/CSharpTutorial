# 018 – Delegates: Calculate

## Overview

Introduces **delegates** in C# — a type-safe way to store and invoke a reference to a method. This example defines a delegate that matches an `int Add(int, int)` signature and uses it to call a `calculateSum` method indirectly.

## Concepts Covered

- `delegate` keyword to define a method signature type
- Creating a delegate instance: `new myDelegate(calculateSum)`
- Invoking a method through a delegate: `d(5, 6)`
- Why delegates are useful (callback patterns, event handling, strategy pattern)

## Project Structure

```
018-Delegate-Calculate/
└── DelegateCalculate/
    └── Program.cs
```

## Code Summary

```csharp
// Define a delegate with a specific signature
public delegate int myDelegate(int num1, int num2);

// A method that matches the delegate signature
static int calculateSum(int x, int y) => x + y;

// Create a delegate instance pointing to calculateSum
myDelegate d = new myDelegate(calculateSum);

// Call calculateSum indirectly via the delegate
int result = d(5, 6);
Console.WriteLine(result);  // 11
```

## How to Run

```bash
dotnet run --project DelegateCalculate
```

### Expected Output

```
11
```

> **Next Step:** See [019 – Delegate Print](../019-Delegate-Print/README.md) for a more practical use-case where a delegate is passed as a parameter to a method (callback pattern).
