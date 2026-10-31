# Exercise 02 — Data Types

## Core Concepts Tested
- Numeric type ranges, sizes, and precision
- Literal suffixes (`L`, `F`, `D`, `m`)
- Choosing the right type for a use case
- Floating-point precision pitfalls
- `char` vs `string` semantics
- `bool` and reference type behavior

---

## Questions

### Q1 — Type Sizes and Ranges

Answer the following without running code first, then verify:

1. What is the size (in bytes) and value range of `int`, `long`, `float`, `double`, and `decimal`?
2. Which type would you use for:
   - A person's age?
   - A bank account balance?
   - The speed of a car (in km/h with one decimal)?
   - The population of a country?
   - A product price (e.g., `19.99`)?
3. Justify each choice.

---

### Q2 — Literal Suffixes

For each of the following literals, determine whether the suffix is **required**, **optional**, or **invalid**, and explain why:

```csharp
long a = 15000000000;      // No suffix
long b = 15000000000L;     // L suffix
float c = 5.75;            // No suffix
float d = 5.75F;           // F suffix
double e = 19.99;          // No suffix
double f = 19.99D;         // D suffix
decimal g = 1250.50;       // No suffix
decimal h = 1250.50m;      // m suffix
```

**Follow-up:** What happens if you write `double x = 1250.50m;`? Why?

---

### Q3 — Precision and Rounding

Write a program that demonstrates floating-point imprecision:

```csharp
double a = 0.1;
double b = 0.2;
Console.WriteLine(a + b);  // What does this print?
```

1. What value does `0.1 + 0.2` produce? Why is it not exactly `0.3`?
2. How does `decimal` handle this differently? Rewrite using `decimal` and show the result.
3. Which type should be used for monetary calculations, and why?

---

### Q4 — `float` vs `double` Precision

1. Declare a `float` and a `double`, each assigned the value `1.23456789123456789`.
2. Display both.
3. How many significant digits does each actually preserve?
4. At what point does the `float` lose precision compared to the `double`?

---

### Q5 — `char` vs `string`

1. Declare a `char` variable and assign it `'A'`.
2. Declare a `string` variable and assign it `"A"`.
3. Display both, along with their types (using `GetType()`).
4. Can you assign a `string` to a `char`? Can you assign a `char` to a `string`? Try and explain the compiler behavior.
5. What is the fundamental difference between a single character and a sequence of characters?

---

### Q6 — `bool` Behavior

1. Declare a `bool` variable `flag` and assign it `true`.
2. Can you assign `1` to `flag`? Can you assign `"true"` (a string) to it? Try and explain.
3. What is the only valid assignment for a `bool` variable?
4. How does C# handle `bool` values in output (e.g., `Console.WriteLine(true)`)?

---

### Q7 — Scientific Notation

Write a program that uses scientific notation to define values:

```csharp
float f1 = 35e3F;
double d1 = 12E4D;
```

1. What values do `f1` and `d1` hold?
2. Write a `double` literal using scientific notation that equals `0.001`.
3. Write a `float` literal using scientific notation that equals `150000`.

---

### Q8 — Practical: Type Selection Challenge

You are designing variables for a weather monitoring system. Choose the appropriate type for each of the following and justify:

1. Temperature in degrees Celsius (could be negative, with decimals).
2. Humidity percentage (whole number, 0-100).
3. Atmospheric pressure in pascals (large number, possibly with decimals).
4. Wind direction as a compass point (e.g., "N", "NE", "SW").
5. Whether it is currently raining.

---

### Q9 — Edge Case: Overflow

Write a program that:

1. Assigns `int.MaxValue` to an `int` variable.
2. Displays it.
3. Adds `1` to it using `+ 1` and display the result. What happens? (This is called **integer overflow**.)
4. Repeat step 3 but using `unchecked` context if you know it, or explain what `checked` does in C#.

**Reflection:** Why is integer overflow dangerous in production systems?