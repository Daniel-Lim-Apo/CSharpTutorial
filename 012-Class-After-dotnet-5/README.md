# 012 – Class Structure After .NET 5 (Top-Level Statements)

## Overview

Demonstrates the **modern, minimal C# syntax** introduced in .NET 5 (released November 2020). With **top-level statements**, you can write executable code directly in a file without wrapping it in a class or a `Main` method.

## Concepts Covered

- Top-level statements (no explicit `class` or `Main` required)
- `System.Console.WriteLine` with fully-qualified namespace (no `using` needed)
- How the compiler auto-generates the `Main` entry point behind the scenes

## Project Structure

```
012-Class-After-dotnet-5/
└── ClassAfterDotnet5/
    └── Program.cs
```

## Code

```csharp
// .NET 5 release date: 10 November 2020
// Top-level statements: the Main method can be omitted
System.Console.WriteLine("Hello, world! Enxuto.");
```

## How to Run

```bash
dotnet run --project ClassAfterDotnet5
```

### Expected Output

```
Hello, world! Enxuto.
```

> **Compare with:** [011 – Class Before .NET 5](../011-Class-Before-dotnet-5/README.md)  
> **Reference:** [.NET 5 – Top-Level Statements (pt-BR)](https://learn.microsoft.com/pt-br/dotnet/core/whats-new/dotnet-5)
