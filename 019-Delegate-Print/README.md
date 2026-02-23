# 019 – Delegates: Print (Callback Pattern)

## Overview

A practical application of **delegates as callbacks**. Two delegate instances are created using **lambda expressions**: one prints to the console, and another appends text to a file. The chosen delegate is then passed into a method to control *how* that method outputs its log messages.

## Concepts Covered

- Delegate type declaration (`delegate void PrintDelegate(string text)`)
- **Lambda expressions** `(string text) => { ... }` assigned to delegates
- Passing a delegate as a method parameter (callback / strategy pattern)
- `File.AppendAllText` for simple file I/O
- Separating *what to do* from *how to do it*

## Project Structure

```
019-Delegate-Print/
└── DelegatePrint/
    ├── Program.cs
    └── logs.txt        ← generated at runtime
```

## Code Summary

```csharp
// Delegate definition
delegate void PrintDelegate(string text);

// Two implementations via lambda expressions
PrintDelegate PrintConsole = (string text) => { Console.WriteLine(text); };
PrintDelegate PrintToFile  = (string text) => { File.AppendAllText("./logs.txt", text); };

// Passing a delegate as a callback
void ConnectToDatabase(PrintDelegate log)
{
    log("Inserting a new record to the database\n");
    log("The record was inserted\n");
}

ConnectToDatabase(PrintToFile);   // logs to file
```

## How to Run

```bash
dotnet run --project DelegatePrint
```

### Expected Output (console)

```
Hello, World!
Hello from delegate
Hello from delegate to file
```

The `logs.txt` file will contain:

```
Inserting a new record to the database
The record was inserted
```
