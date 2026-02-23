# 004 – Operators

## Overview

An interactive **calculator / operator demo** that reads two integers from the user and then performs one of eight operations based on a menu selection. This example covers all major categories of C# operators.

## Concepts Covered

- Arithmetic operators: `+`, `-`, `*`, `/`, `%`
- Increment (`++`) and decrement (`--`) operators (pre and post)
- Logical operators: `==`, `!=`, `!`, `>`
- Comparison operators: `>`, `<=`
- `switch` statement with `char` cases
- Division-by-zero guard with `if`
- `Convert.ToInt32` and `Convert.ToChar` for user input parsing

## Project Structure

```
004-Operators/
└── Operators/
    └── Program.cs
```

## How to Run

```bash
dotnet run --project Operators
```

### Example Session

```
Enter the First Number: 10
Enter the Second Number: 3
Main Menu
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Modulus (remainder of division)
6. Increment and Decrement
7. Logical Operators
8. Comparison Operators
Enter the Operation you choose to perform: 4
The result of Division is: 3
```

> **Tip:** Option `4` performs integer division. For example, `10 / 3 = 3` (remainder is discarded). Use option `5` to get the remainder (`10 % 3 = 1`).
