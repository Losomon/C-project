# Exercise 03 — Type Casting

## Core Concepts Tested
- Implicit vs explicit casting
- Truncation vs rounding
- `Convert` class vs explicit casting
- Character-to-integer conversion (Unicode)
- Data loss scenarios
- Casting direction and safety

---

## Questions

### Q1 — Implicit Casting Direction

C# allows implicit casting along this widening path:
```text
char → int → long → float → double
```

1. Write code that performs each of these implicit conversions and displays the results:
   - `char` to `int`
   - `int` to `long`
   - `long` to `float`
   - `float` to `double`
2. For the `char` to `int` conversion, what value does the `int` hold? Why?

---

### Q2 — Explicit Casting and Truncation

1. Declare a `double` variable `rating = 9.78`.
2. Explicitly cast it to `int`: `int whole = (int)rating;`.
3. Display both values.
4. Now try with `rating = -3.65`. What happens to the fractional part? Does it round or truncate?
5. Repeat with `rating = 5.999`. What is the result?

**Follow-up:** The C# spec says explicit numeric conversion **truncates** (discards) the fractional part. What does this mean for negative numbers? Test `-2.7` and `-2.3`.

---

### Q3 — `(int)` vs `Convert.ToInt32()`

Write a program that demonstrates the difference:

```csharp
double number = 9.78;
int castResult = (int)number;
int convertResult = Convert.ToInt32(number);
```

1. What are the two results?
2. Why does `Convert.ToInt32()` produce a different result than `(int)`?
3. Test with `number = 9.5`. What does each method produce now?
4. Research: What rounding mode does `Convert.ToInt32()` use? (Hint: it's "round half to even" — also called banker's rounding.)

---

### Q4 — Character to Integer Conversion

1. Declare a `char` variable `letter = 'A';`.
2. Implicitly convert it to an `int` and display the result.
3. Repeat for `'Z'`, `'a'`, `'0'`, and `'\\n'`.
4. Explain the relationship between a character and its numeric Unicode value.
5. What is the Unicode value of the character `'K'`? Calculate it without running code.

---

### Q5 — String Conversion Using `Convert`

1. Write code that uses `Convert.ToString()` to convert:
   - An `int` to a `string`
   - A `double` to a `string`
   - A `bool` to a `string`
   - A `char` to a `string`
2. Display all results.
3. Can you reverse the process — convert a `string` back to an `int`? Demonstrate.

---

### Q6 — Data Loss Scenarios

For each of the following conversions, determine whether data **could** be lost and why:

1. `int` → `long`
2. `long` → `int`
3. `double` → `float`
4. `float` → `double`
5. `int` → `double`
6. `double` → `int`
7. `decimal` → `double`
8. `double` → `decimal`

**Extension:** For the conversions where data can be lost, write code that demonstrates the loss.

---

### Q7 — Practical: Temperature Converter

Create a temperature conversion program:

1. Ask the user (or hardcode) a temperature in Celsius as a `double`.
2. Convert it to Fahrenheit: `F = C * 9/5 + 32`.
3. Display the result as a `double`.
4. Now display the Fahrenheit temperature as an `int` using **both**:
   - Explicit casting `(int)`
   - `Convert.ToInt32()`
5. Compare the two results and explain why they differ.

---

### Q8 — Advanced: Overflow in Explicit Casting

1. Declare a `long` variable with a value larger than `int.MaxValue` (e.g., `3000000000L`).
2. Explicitly cast it to `int`: `int result = (int)largeValue;`.
3. Display the result. What happened?
4. Explain **why** this happens (overflow during narrowing conversion).
5. How could you detect this overflow before casting? (Hint: think about `checked` keyword or range checking.)

---

### Q9 — Conceptual: When to Cast

You are building an application. For each scenario, decide whether you need explicit casting, implicit casting, or no casting at all, and justify:

1. Storing a person's age (entered as text) into an `int` variable.
2. Calculating a product's discounted price (a `double`) and storing it in a `decimal` variable for financial accuracy.
3. Passing an `int` counter to a method that expects a `double` parameter.
4. Converting a `double` result to display as a whole number in a report.