# 017 – Solution with Multiple Projects

## Overview

Demonstrates how to structure a **.NET solution** that contains multiple projects: one **console application** (`MyCalc`) and two **class libraries** (`SuperLogger` and `SuperCalcMachine`). The console app references both libraries.

This is the recommended structure for larger applications where code is split into reusable, independently-compilable components.

## Concepts Covered

- `dotnet new sln` – creating a solution file
- `dotnet new console` and `dotnet new classlib` – project types
- `dotnet sln add` – adding projects to a solution
- `dotnet add reference` – adding project-to-project references
- `dotnet build` / `dotnet run --project`

## Project Structure

```
017-Solution-and-projects/
├── MySolution.sln
├── MyCalc/             ← Console app (entry point)
│   ├── Program.cs
│   └── MyCalc.csproj
├── SuperCalcMachine/   ← Class library (Calculator logic)
│   ├── Calculator.cs
│   └── SuperCalcMachine.csproj
└── SuperLogger/        ← Class library (logging utility)
    ├── Logger.cs
    └── SuperLogger.csproj
```

## Setup Commands

Run these commands inside the `017-Solution-and-projects/` folder to recreate the solution from scratch:

```bash
dotnet new sln -n MySolution

dotnet new console -n MyCalc
dotnet new classlib -n SuperLogger
dotnet new classlib -n SuperCalcMachine

dotnet sln MySolution.sln add .\MyCalc\MyCalc.csproj
dotnet sln MySolution.sln add .\SuperLogger\SuperLogger.csproj
dotnet sln MySolution.sln add .\SuperCalcMachine\SuperCalcMachine.csproj

dotnet add .\MyCalc\MyCalc.csproj reference .\SuperLogger\SuperLogger.csproj
dotnet add .\MyCalc\MyCalc.csproj reference .\SuperCalcMachine\SuperCalcMachine.csproj
```

## How to Build and Run

```bash
dotnet build
dotnet run --project .\MyCalc\MyCalc.csproj
```

### Expected Output

```
[LOG] Starting the program...
Addition result: 8
Subtraction result: 6
[LOG] Program completed.
```
