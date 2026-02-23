# 024 – LINQ Filter (Query and Method Syntax)

## Overview

Introduces **LINQ (Language Integrated Query)** to filter a list of integers. The example demonstrates both **query syntax** (similar to SQL) and **method/lambda syntax** to filter even and odd numbers from a list.

## Concepts Covered

- `using System.Linq;`
- `List<int>` initialisation
- **Query syntax:** `from ... where ... select ...`
- **Method syntax:** `list.Where(n => n % 2 == 0)`
- Lambda expressions as filter predicates
- `foreach` to iterate over LINQ results

## Project Structure

```
024-LINQ-Filter/
└── AppLinqFilter/
    ├── AppLinqFilter.csproj
    ├── AppLinqFilter.sln
    └── Program.cs
```

## Code Summary

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Query syntax (SQL-like)
var evenNumbers = from number in numbers
                  where number % 2 == 0
                  select number;

// Method / lambda syntax (equivalent)
var oddNumbers = numbers.Where(n => n % 2 != 0);
```

## How to Run

```bash
dotnet run --project AppLinqFilter
```

### Expected Output

```
Even Numbers:
2
4
6
8
10
Odd Numbers:
1
3
5
7
9
```
