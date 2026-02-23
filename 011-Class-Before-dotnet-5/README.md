# 011 – Class Structure Before .NET 5

## Overview

Shows the **traditional, verbose class structure** required in C# programs before .NET 5. Every program required an explicit `using` directive, a class definition, and a `Main` method.

## Concepts Covered

- `using System;` directive to import a namespace
- Explicit class declaration
- `public static void Main()` entry-point method
- This is the **pre-.NET 5** way of writing C# programs

## Project Structure

```
011-Class-Before-dotnet-5/
└── ClassBeforeDotnet5/
    └── Program.cs
```

## Code

```csharp
using System;

class MyClass
{
    public static void Main()
    {
        // Use the Console class from the System namespace.
        Console.WriteLine("Hello, world!");
    }
}
```

## How to Run

```bash
dotnet run --project ClassBeforeDotnet5
```

### Expected Output

```
Hello, world!
```

> **Compare with:** [012 – Class After .NET 5](../012-Class-After-dotnet-5/README.md) to see how the same program looks with the modern top-level statements syntax.
