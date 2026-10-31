# Exercise 06 — Math

## Core Concepts Tested
- Floating-point arithmetic pitfalls
- `Math` class methods
- Rounding modes and strategies
- Precision vs accuracy
- Integer math edge cases

---

## Questions

### Q1 — Integer Division Pitfalls

Write code for each of the following and observe the results:

```csharp
int a = 7;
int b = 2;

1. a / b          // What is the result?
2. a % b          // What is the result?
3. (double)a / b  // What is the result?
4. a / (double)b  // What is the result?
5. (double)(a / b) // What is the result?
```

**Questions:**
1. Why does `a / b` produce `3` instead of `3.5`?
2. Which of the casts in questions 3-5 produce the correct result `3.5`?
3. What is the difference between `(double)a / b` and `(double)(a / b)`?
4. Why is this a common source of bugs?

---

### Q2 — Floating-Point Precision

Write a program that demonstrates floating-point imprecision:

```csharp
double sum = 0.0;
for (int i = 0; i < 10; i++)
{
    sum += 0.1;
}
Console.WriteLine(sum);  // What does this print?
```

1. What value does `sum` produce? Why is it not exactly `1.0`?
2. Is `sum == 1.0` true or false?
3. How would you fix this for a use case where exact decimal values are needed?

---

### Q3 — `Math` Class: Rounding

Write code using the `Math` class for each:

1. `Math.Round(3.14159)` — what is the result?
2. `Math.Round(3.14159, 2)` — what is the result?
3. `Math.Round(2.5)` — what is the result? (This is "banker's rounding")
4. `Math.Round(3.5)` — what is the result?
5. `Math.Floor(3.9)` — what is the result?
6. `Math.Ceiling(3.1)` — what is the result?
7. `Math.Truncate(3.9)` — what is the result?
8. `Math.Abs(-5)` — what is the result?

**Follow-up:**
- What is the difference between `Math.Round`, `Math.Floor`, `Math.Ceiling`, and `Math.Truncate`?
- Why does `Math.Round(2.5)` return `2` instead of `3`? Explain "round half to even."

---

### Q4 — `Math` Class: Powers and Roots

Write code using the `Math` class:

1. `Math.Pow(2, 10)` — what is the result?
2. `Math.Sqrt(144)` — what is the result?
3. `Math.Sqrt(2)` — what is the result? Is it exact?
4. `Math.Exp(1)` — what is the result? What mathematical constant does this represent?
5. `Math.Log(100)` — what is the result? (Natural logarithm)
6. `Math.Log10(1000)` — what is the result?

**Extension:** Calculate `e^5` using the `Math` class. Calculate the square root of `2` to 10 decimal places.

---

### Q5 — `Math` Class: Trigonometry and Constants

Write code using the `Math` class:

1. `Math.PI` — what is the value?
2. `Math.E` — what is the value?
3. `Math.Sin(Math.PI / 2)` — what is the result?
4. `Math.Cos(0)` — what is the result?
5. `Math.Tan(0)` — what is the result?
6. `Math.Asin(1)` — what is the result?

**Reflection:** Angles in `Math` methods are in radians, not degrees. Write a method to convert degrees to radians.

---

### Q6 — Practical: Compound Interest Calculator

Create a compound interest calculator:

1. Ask the user for:
   - Principal amount (decimal)
   - Annual interest rate (as a percentage, e.g., 5 for 5%)
   - Number of years (int)
   - Number of times compounded per year (int)
2. Use the compound interest formula: `A = P * (1 + r/n)^(nt)`
3. Display the final amount.
4. Display the total interest earned.

**Challenge:** Implement this using `Math.Pow()` for the exponentiation.

---

### Q7 — Practical: Distance Calculator

Write a program that calculates the Euclidean distance between two points `(x1, y1)` and `(x2, y2)`:

1. Ask the user for four numbers: `x1`, `y1`, `x2`, `y2`.
2. Use the formula: `distance = sqrt((x2-x1)^2 + (y2-y1)^2)`
3. Display the distance.
4. Modify it to work in 3D (add `z` coordinates).

---

### Q8 — Edge Case: Division by Zero

Write code that demonstrates what happens with:

1. `int a = 5; int b = 0; Console.WriteLine(a / b);` — What exception is thrown?
2. `double x = 5.0; double y = 0.0; Console.WriteLine(x / y);` — What is the result? (Note: this does NOT throw an exception!)
3. `decimal d = 5.0m; decimal e = 0.0m; Console.WriteLine(d / e);` — What happens?

**Reflection:** Why does floating-point division by zero not throw an exception but integer division by zero does? What are the IEEE 754 special values for floating-point division by zero?

---

### Q9 — Conceptual: Precision vs Accuracy

Explain the difference between precision and accuracy with an example. How does this relate to choosing between `float`, `double`, and `decimal` in C#?