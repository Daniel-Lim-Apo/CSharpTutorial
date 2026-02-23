# 010 – Explicit Type Casting: int → short and float → int

## Overview

Demonstrates **explicit (narrowing) type casting** in C#. When converting a value to a type with a smaller range, an explicit cast is required and potential data loss may occur (e.g., truncation of decimal digits).

## Concepts Covered

- Explicit cast syntax: `(TargetType)value`
- `int` → `short` conversion (potential overflow if value exceeds `short` range: `-32,768` to `32,767`)
- `float` → `int` conversion (decimal part is **truncated**, not rounded)
- `GetType()` to display the runtime type of a variable

## Project Structure

```
010-Cast-Int-Short-and-Float-Int/
└── CastIntToShortAndFloatToInt/
    └── Program.cs
```

## Code Summary

```csharp
int originalInt = 12345;
short convertedShort = (short)originalInt;
// Output: int 12345 converted to short 12345

float originalFloat = 3.14159f;
int convertedInt = (int)originalFloat;
// Output: float 3.14159 converted to int 3  ← decimal part dropped
```

## How to Run

```bash
dotnet run --project CastIntToShortAndFloatToInt
```

### Expected Output

```
originalInt is System.Int32
convertedShort is System.Int16
int 12345 converted to short 12345

originalFloat is System.Single
convertedInt is System.Int32
float 3.14159 converted to int 3
```

> **Warning:** If the `int` value exceeds `short`'s maximum (`32767`), the result will **overflow** and produce an unexpected value.
