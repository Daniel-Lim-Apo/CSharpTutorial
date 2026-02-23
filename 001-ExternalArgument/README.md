# 001 – External Argument

## Overview

This example demonstrates how to pass **command-line arguments** to a C# program and how to access them inside `Main(string[] args)`.

## Concepts Covered

- `string[] args` parameter in the `Main` method
- `args.Length` to count the number of arguments passed
- Iterating over arguments with a `for` loop
- `Console.WriteLine` for output

## Project Structure

```
001-ExternalArgument/
└── ExternalArgumentApp/
    └── Program.cs
```

## Code Summary

```csharp
class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);

        // Display all the string arguments.
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
    }
}
```

## How to Run

```bash
cd CSharpTutorial\001-ExternalArgument\ExternalArgumentApp
dotnet run --project ExternalArgumentApp.csproj -- Hello World 123
```

### Expected Output

```
3
Hello
World
123
```

> **Note:** Arguments are passed after `--` in the `dotnet run` command. They are zero-indexed in the array (`args[0]`, `args[1]`, etc.).
