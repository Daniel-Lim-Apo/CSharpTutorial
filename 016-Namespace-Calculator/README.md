# 016 – Namespaces with Calculator and Logger

## Overview

Demonstrates how to **organise code using namespaces** across multiple files within a single project. Two helper classes (`Calculator` and `Logger`) are each placed in their own namespace and file, then consumed from `Program.cs`.

## Concepts Covered

- `namespace` declarations to organise code
- `using` directive to import a namespace
- Multiple `.cs` files in a single project
- Static utility classes (`public static class`)
- String interpolation with `$"...{variable}"`

## Project Structure

```
016-Namespace-Calculator/
└── NamespaceCalculator/
    ├── Calculator.cs   (namespace MyCalcMachine)
    ├── Logger.cs       (namespace MySuperLogger)
    └── Program.cs      (namespace MyNamespace)
```

## Files Overview

### `Calculator.cs` – namespace `MyCalcMachine`
```csharp
public class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
}
```

### `Logger.cs` – namespace `MySuperLogger`
```csharp
public class Logger
{
    public static void Log(string message) =>
        Console.WriteLine($"[LOG] {message}");
}
```

### `Program.cs`
```csharp
using MySuperLogger;
using MyCalcMachine;

Logger.Log("Starting the program...");
int resultAddition = Calculator.Add(5, 3);
Console.WriteLine($"Addition result: {resultAddition}");
Logger.Log("Program completed.");
```

## How to Run

```bash
dotnet run --project NamespaceCalculator
```

### Expected Output

```
[LOG] Starting the program...
Addition result: 8
Subtraction result: 6
[LOG] Program completed.
```
