# C# Math

---

## 1. Introduction to C# Math

The C# `Math` class provides built-in methods for performing mathematical operations on numbers.

These methods help programmers perform calculations without writing mathematical logic from scratch.

To use the Math class:

```csharp
using System;
```

---

## 2. Math.Max()

The `Math.Max(x, y)` method returns the highest value between two numbers.

### Example

```csharp
int highest = Math.Max(5, 10);

Console.WriteLine(highest); // 10
```

---

## 3. Math.Min()

The `Math.Min(x, y)` method returns the lowest value between two numbers.

### Example

```csharp
int lowest = Math.Min(5, 10);

Console.WriteLine(lowest); // 5
```

---

## 4. Math.Sqrt()

The `Math.Sqrt(x)` method returns the square root of a number.

### Example

```csharp
double result = Math.Sqrt(64);

Console.WriteLine(result); // 8
```

---

## 5. Math.Abs()

The `Math.Abs(x)` method returns the absolute (non-negative) value of a number.

It removes the negative sign from a negative number.

### Example

```csharp
double result = Math.Abs(-4.7);

Console.WriteLine(result); // 4.7
```

---

## 6. Math.Round()

The `Math.Round(x)` method rounds a number to the nearest whole number by default.

### Example

```csharp
double result = Math.Round(9.99);

Console.WriteLine(result); // 10
```

**Important:** C# uses midpoint-to-even rounding by default.

```csharp
Console.WriteLine(Math.Round(2.5)); // 2
Console.WriteLine(Math.Round(3.5)); // 4
```

To round midpoint values away from zero:

```csharp
Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); // 3
```

---

## 7. Additional Math Methods

C# provides other useful mathematical methods.

### Math.Pow()

Raises a number to a specified power.

```csharp
double result = Math.Pow(2, 3);

Console.WriteLine(result); // 8
```

### Math.Ceiling()

Rounds a number up to the next integer.

```csharp
double result = Math.Ceiling(4.2);

Console.WriteLine(result); // 5
```

### Math.Floor()

Rounds a number down to the previous integer.

```csharp
double result = Math.Floor(4.8);

Console.WriteLine(result); // 4
```

---

## 8. Summary of Math Methods

| Method           | Description               | Example             | Result |
| ---------------- | ------------------------- | ------------------- | -----: |
| `Math.Max()`     | Returns highest value     | `Math.Max(5, 10)`   |     10 |
| `Math.Min()`     | Returns lowest value      | `Math.Min(5, 10)`   |      5 |
| `Math.Sqrt()`    | Calculates square root    | `Math.Sqrt(64)`     |      8 |
| `Math.Abs()`     | Returns absolute value    | `Math.Abs(-4.7)`    |    4.7 |
| `Math.Round()`   | Rounds to nearest integer | `Math.Round(9.99)`  |     10 |
| `Math.Pow()`     | Calculates a power        | `Math.Pow(2, 3)`    |      8 |
| `Math.Ceiling()` | Rounds up                 | `Math.Ceiling(4.2)` |      5 |
| `Math.Floor()`   | Rounds down               | `Math.Floor(4.8)`   |      4 |

---

## 9. Practice Exercises

Try solving these exercises without copying the examples.

1. Use `Math.Max()` to find the highest number between 25 and 75.
2. Use `Math.Min()` to find the lowest number between 100 and 45.
3. Calculate the square root of 144 using `Math.Sqrt()`.
4. Use `Math.Abs()` to convert -150 into a positive value.
5. Use `Math.Round()` to round 15.78.
6. Use `Math.Pow()` to calculate 5 raised to the power of 3.
7. Use `Math.Ceiling()` to round 8.3 upwards.
8. Use `Math.Floor()` to round 8.9 downwards.

### Mini Project: Simple Math Calculator

Create a program that:

- Declares two numerical variables.
- Finds their highest and lowest values.
- Calculates their sum and product.
- Calculates the square root of each number.
- Displays all results using `Console.WriteLine()`.

---

## 10. Key Takeaways

- The `Math` class contains built-in mathematical methods.
- `Math.Max()` finds the highest value.
- `Math.Min()` finds the lowest value.
- `Math.Sqrt()` calculates square roots.
- `Math.Abs()` returns absolute values.
- `Math.Round()` rounds numbers.
- `Math.Pow()` calculates powers.
- `Math.Ceiling()` rounds upwards.
- `Math.Floor()` rounds downwards.

---

**Next Topic: C# Strings**
