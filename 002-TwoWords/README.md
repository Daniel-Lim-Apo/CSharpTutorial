# 002 – Two Words

## Overview

A minimal "Hello World" style program that prints two lines to the console. It demonstrates the most basic structure of a C# class with a `Main` entry point.

## Concepts Covered

- Defining a `public class`
- `static void Main()` entry point (no `args`)
- `System.Console.WriteLine` with fully-qualified namespace (no `using` directive)

## Project Structure

```
002-TwoWords/
└── TwoWords/
    └── Program.cs
```

## Code Summary

```csharp
public class TwoNames
{
    public static void Main()
    {
        System.Console.WriteLine("Hello,");
        System.Console.WriteLine("Maria de Oliveira!");
    }
}
```

## How to Run

```bash
dotnet run --project TwoWords
```

### Expected Output

```
Hello,
Maria de Oliveira!
```

> **Note:** `System.Console` is used directly without a `using System;` directive, showing how the fully-qualified name works.
