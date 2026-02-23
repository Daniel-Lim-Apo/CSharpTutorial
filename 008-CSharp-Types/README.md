# 008 – C# Types

## Overview

A comprehensive demonstration of the most common **built-in value and reference types** in C#. Each variable is declared, optionally assigned a value, and then printed to the console.

## Concepts Covered

| Type | Keyword | Description |
|------|---------|-------------|
| Integer | `int` | Whole numbers |
| Long integer | `long` | Larger whole numbers (uses `_` separator) |
| Floating-point | `float` | Smaller decimal values (suffix `f`) |
| Double | `double` | Standard decimal values |
| Decimal | `decimal` | High-precision, ideal for finance (suffix `m`) |
| Character | `char` | Single character (single quotes) |
| Boolean | `bool` | `true` / `false` |
| String | `string` | Sequence of characters (double quotes) |

## Project Structure

```
008-CSharp-Types/
└── CSharpTypes/
    └── Program.cs
```

## Key Example

```csharp
long population = 789_000_000; // digit separator '_' for readability
decimal price = 12.99m;        // 'm' suffix for decimal literals
float distance = 12.5f;        // 'f' suffix for float literals
```

## How to Run

```bash
dotnet run --project CSharpTypes
```

### Expected Output (excerpt)

```
Age: 30
Pi: 3.14159
Price: 12.99
Initial: A
Eligible: True
Name: Maria da Silva
...
```
