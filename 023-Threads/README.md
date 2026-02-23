# 023 – Threads

## Overview

Demonstrates **multi-threading** in C# using the `System.Threading.Thread` class. Two threads run concurrently: one prints numbers 1–20 and another prints letters a–j, while the main thread completes almost immediately.

## Concepts Covered

- `Thread` class and `ThreadStart` delegate
- `thread.Start()` to begin execution
- `Thread.Sleep(ms)` to simulate work and produce interleaved output
- Concurrency: threads run simultaneously, so output order is non-deterministic
- Main thread vs. worker threads

## Project Structure

```
023-Threads/
└── AppThreads/
    ├── AppThreads.csproj
    ├── AppThreads.sln
    └── Program.cs
```

## Code Summary

```csharp
Thread thread1 = new Thread(new ThreadStart(PrintNumbers));
Thread thread2 = new Thread(new ThreadStart(PrintLetters));

thread1.Start();
thread2.Start();

Console.WriteLine("Main thread completes.");

static void PrintNumbers()
{
    for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine($"Thread PrintNumbers -> Number: {i}");
        Thread.Sleep(500);
    }
}
```

## How to Run

```bash
dotnet run --project AppThreads
```

### Sample Output (order varies between runs)

```
Main thread completes.
Thread PrintNumbers -> Number: 1
Thread PrintLetters -> Letter: a
Thread PrintNumbers -> Number: 2
Thread PrintLetters -> Letter: b
...
```

> **Note:** Because both threads sleep for 500 ms between iterations, their output is typically interleaved. The main thread finishes almost instantly since it does not wait for the worker threads to complete.
