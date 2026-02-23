# C# Tutorial – Example Index

A collection of C# examples progressing from basic console I/O to advanced patterns such as delegates, threads, and LINQ. Each folder contains a self-contained project with its own `README.md`.

---

## 📚 Examples

| # | Topic | Key Concepts | Folder |
|---|-------|-------------|--------|
| 001 | [External Argument](./001-ExternalArgument/README.md) | `Main(string[] args)`, command-line arguments, `for` loop | `001-ExternalArgument` |
| 002 | [Two Words](./002-TwoWords/README.md) | Basic class structure, `System.Console.WriteLine` | `002-TwoWords` |
| 003 | [Min & Max Range of Data Types](./003-MinimumRange/README.md) | `Decimal`, `Single`, `Double` min/max values, exponential format | `003-MinimumRange` |
| 004 | [Operators](./004-Operators/README.md) | Arithmetic, logical, comparison operators, `switch` statement | `004-Operators` |
| 005 | [Largest of Four Numbers](./005-Four-Numbers/README.md) | `if` comparisons, sequential max-finding | `005-Four-Numbers` |
| 006 | [Five Numbers – Sum & Average](./006-Five-Numbers-Sum-and-Average/README.md) | `for` loop, accumulator, integer vs. float division | `006-Five-Numbers-Sum-and-Average` |
| 007 | [Two Numbers Triangle](./007-Two-Numbers-Triangle/README.md) | Nested loops, triangle pattern, decrement | `007-Two-Numbers-Triangle` |
| 008 | [C# Types](./008-CSharp-Types/README.md) | `int`, `long`, `float`, `double`, `decimal`, `char`, `bool`, `string` | `008-CSharp-Types` |
| 009 | [Number to Words](./009-Num-to-Words/README.md) | `while` loop, modulo, string array, string concatenation | `009-Num-to-Words` |
| 010 | [Explicit Type Casting](./010-Cast-Int-Short-and-Float-Int/README.md) | `(short)`, `(int)` casts, data loss, `GetType()` | `010-Cast-Int-Short-and-Float-Int` |
| 011 | [Class – Before .NET 5](./011-Class-Before-dotnet-5/README.md) | Traditional class + `Main` boilerplate, `using System` | `011-Class-Before-dotnet-5` |
| 012 | [Class – After .NET 5](./012-Class-After-dotnet-5/README.md) | Top-level statements, minimal syntax | `012-Class-After-dotnet-5` |
| 013 | [Arrays Without Try-Catch](./013-Without-Try-Catch-Numbers-Array/README.md) | Arrays, `IndexOutOfRangeException` crash | `013-Without-Try-Catch-Numbers-Array` |
| 014 | [Arrays With Try-Catch](./014-Try-Catch-Numbers-Array/README.md) | `try`/`catch`, `Exception.Message` | `014-Try-Catch-Numbers-Array` |
| 015 | [Try-Catch Custom Error Messages](./015-Try-Catch-Numbers-Array-CustomErrorMessage/README.md) | Multiple `catch` blocks, specific exception types | `015-Try-Catch-Numbers-Array-CustomErrorMessage` |
| 016 | [Namespaces – Calculator](./016-Namespace-Calculator/README.md) | `namespace`, multi-file project, `using` directives | `016-Namespace-Calculator` |
| 017 | [Solution with Multiple Projects](./017-Solution-and-projects/README.md) | `.sln`, `dotnet new classlib`, project references | `017-Solution-and-projects` |
| 018 | [Delegates – Calculate](./018-Delegate-Calculate/README.md) | `delegate` type, delegate instance, method reference | `018-Delegate-Calculate` |
| 019 | [Delegates – Print (Callback)](./019-Delegate-Print/README.md) | Lambda expressions, delegate as parameter, `File.AppendAllText` | `019-Delegate-Print` |
| 020 | [Play Sound with NAudio](./020-Play-Sound-Naudio/README.md) | NuGet package, embedded resources, `Mp3FileReader`, `WaveOutEvent` | `020-Play-Sound-Naudio` |
| 021 | [Observer Design Pattern](./021-Observer-Pattern/README.md) | Observer pattern, `interface`, `List<T>`, polymorphism | `021-Observer-Pattern` |
| 023 | [Threads](./023-Threads/README.md) | `Thread`, `ThreadStart`, `Thread.Sleep`, concurrency | `023-Threads` |
| 024 | [LINQ Filter](./024-LINQ-Filter/README.md) | `System.Linq`, query syntax, method/lambda syntax, `Where()` | `024-LINQ-Filter` |

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5 or later recommended)

### Running an Example

Navigate to the inner project folder (the one containing the `.csproj` file) and run:

```bash
dotnet run
```

Or from the example's root folder:

```bash
dotnet run --project <ProjectFolderName>
```

**Example:**

```bash
cd 001-ExternalArgument
dotnet run --project ExternalArgumentApp -- Hello World
```

---

## 📂 Repository Layout

```
CSharpTutorial/
├── README.md                        ← You are here
├── 001-ExternalArgument/
│   ├── README.md
│   └── ExternalArgumentApp/
├── 002-TwoWords/
│   ├── README.md
│   └── TwoWords/
... (one folder per example)
└── 024-LINQ-Filter/
    ├── README.md
    └── AppLinqFilter/
```

---

## 🗂️ Topics by Category

### Basics
- [001 – External Argument](./001-ExternalArgument/README.md)
- [002 – Two Words](./002-TwoWords/README.md)
- [008 – C# Types](./008-CSharp-Types/README.md)
- [011 – Class Before .NET 5](./011-Class-Before-dotnet-5/README.md)
- [012 – Class After .NET 5](./012-Class-After-dotnet-5/README.md)

### Control Flow & Loops
- [004 – Operators](./004-Operators/README.md)
- [005 – Largest of Four Numbers](./005-Four-Numbers/README.md)
- [006 – Five Numbers: Sum & Average](./006-Five-Numbers-Sum-and-Average/README.md)
- [007 – Two Numbers Triangle](./007-Two-Numbers-Triangle/README.md)
- [009 – Number to Words](./009-Num-to-Words/README.md)

### Types & Conversions
- [003 – Min & Max Range](./003-MinimumRange/README.md)
- [010 – Explicit Casting](./010-Cast-Int-Short-and-Float-Int/README.md)

### Error Handling
- [013 – Arrays Without Try-Catch](./013-Without-Try-Catch-Numbers-Array/README.md)
- [014 – Arrays With Try-Catch](./014-Try-Catch-Numbers-Array/README.md)
- [015 – Custom Error Messages](./015-Try-Catch-Numbers-Array-CustomErrorMessage/README.md)

### Project Organisation
- [016 – Namespaces](./016-Namespace-Calculator/README.md)
- [017 – Solution & Multiple Projects](./017-Solution-and-projects/README.md)

### Advanced Patterns
- [018 – Delegates: Calculate](./018-Delegate-Calculate/README.md)
- [019 – Delegates: Print / Callback](./019-Delegate-Print/README.md)
- [020 – Play Sound (NuGet / NAudio)](./020-Play-Sound-Naudio/README.md)
- [021 – Observer Pattern](./021-Observer-Pattern/README.md)
- [023 – Threads](./023-Threads/README.md)
- [024 – LINQ Filter](./024-LINQ-Filter/README.md)
