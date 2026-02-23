# 006 – Five Numbers: Sum and Average

## Overview

Reads **five integers** from the user using a `for` loop, then calculates and displays the **sum** and the **average**.

## Concepts Covered

- `for` loop for repeated input
- Accumulator pattern (`sum += n`)
- Integer vs. floating-point division (`sum / 5.0` forces a `double` result)
- `double` type for the average

## Project Structure

```
006-Five-Numbers-Sum-and-Average/
└── FiveNumbers/
    └── Program.cs
```

## Code Summary

```csharp
for (i = 1; i <= 5; i++)
{
    Console.Write("Number-{0} :", i);
    n = Convert.ToInt32(Console.ReadLine());
    sum += n;
}

avg = sum / 5.0;  // 5.0 ensures floating-point division
Console.Write("The sum of 5 numbers is : {0}\nThe Average is : {1}\n", sum, avg);
```

## How to Run

```bash
dotnet run --project FiveNumbers
```

### Example Session

```
Input the 5 numbers:
Number-1 :10
Number-2 :20
Number-3 :30
Number-4 :40
Number-5 :50
The sum of 5 numbers is : 150
The Average is : 30
```
