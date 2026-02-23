# 002 – Two Words

## Overview

A minimal "Hello World" style program that prints two lines to the console. This project demonstrates the fundamental structure of a C# class and the `Main` entry point, which is where every C# application begins its execution.

## Concepts Covered

- **Defining a `public class`**: Learn how to declare a class that is accessible globally.
- **`static void Main()` entry point**: Understand the method where the program starts. This version doesn't use command-line arguments (`args`).
- **Fully-Qualified Names**: Using `System.Console.WriteLine` directly without a `using` directive.

## Project Structure

```text
002-TwoWords/
└── TwoWords/
    ├── Program.cs        # Main application source code
    └── TwoWords.csproj   # Project configuration file
```

## Code Preview

The following code is the core of this project:

```csharp
public class TwoWords
{
    public static void Main()
    {
        System.Console.WriteLine("Hello,");
        System.Console.WriteLine("Maria de Oliveira!");
    }
}
```

## How to Run

Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

1. Open a terminal in the `002-TwoWords` directory.
2. Run the project using the .NET CLI:

```powershell
dotnet run --project TwoWords
```

### Expected Output

```text
Hello,
Maria de Oliveira!
```

## Technical Notes

> [!NOTE]
> **Namespace Qualification**: In this example, we use `System.Console.WriteLine` instead of just `Console.WriteLine`. 
> 
> Direct use of `System.` shows how types are organized into namespaces. In larger projects, you would typically add `using System;` at the top of the file to avoid typing `System.` every time.

## What's Next?

In the next tutorial, we will explore how to simplify this code using the `using` directive and how to handle user input.

