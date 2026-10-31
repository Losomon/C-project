# Exercise 04 — User Input

## Core Concepts Tested
- `Console.ReadLine()` behavior and return type
- Converting strings to numeric types
- `Convert` class vs `TryParse`
- Exception safety
- Input validation strategies
- `out` parameter usage

---

## Questions

### Q1 — Basic Input and Output

1. Write a program that asks the user for their name and displays a personalized greeting.
2. Modify it to also ask for their age. Display both.
3. What type does `Console.ReadLine()` return? Why is this significant?

---

### Q2 — Reading Numbers

1. Ask the user to enter their age.
2. Attempt to store it directly in an `int` variable without conversion:
   ```csharp
   int age = Console.ReadLine();
   ```
   What happens? Explain the compiler error.
3. Fix it using `Convert.ToInt32()`.
4. Display the age.

---

### Q3 — `Convert` vs `TryParse`

1. Write a program that asks the user for their age using `Convert.ToInt32()`.
2. Test it with a valid number (e.g., `25`).
3. Now test it with an invalid input (e.g., `twenty-five` or `abc`). What happens?
4. Rewrite the program using `int.TryParse()` to handle invalid input gracefully.
5. Explain the difference in behavior and why `TryParse` is preferred for production code.

---

### Q4 — Multiple Inputs with Validation

Create a program that:

1. Asks for the user's name.
2. Asks for their age (validate with `TryParse`).
3. Asks for their height in meters (use `double.TryParse`).
4. Asks for their student ID (use `long.TryParse`).
5. If any input is invalid, display an error and stop.
6. If all inputs are valid, display a formatted summary.

**Extension:** What happens if the user enters a negative age or height? Should you validate for that too? Implement range validation.

---

### Q5 — The `out` Parameter

1. Research the syntax of `TryParse`: `int.TryParse(input, out int result)`.
2. What is the `out` parameter? How is it different from a `ref` parameter?
3. Write a method that uses `out` to return multiple values from a single method call.
4. Demonstrate how `TryParse` uses `out` to return the parsed value while also returning success/failure via its `bool` return value.

---

### Q6 — Practical: Simple Calculator with Validation

Create a calculator that:

1. Asks the user to enter two numbers (as strings).
2. Attempts to parse both as `double` values using `double.TryParse`.
3. If either fails, display an error message.
4. If both succeed, perform the following operations:
   - Addition
   - Subtraction
   - Multiplication
   - Division (check for division by zero)
5. Display all results.

**Reflection:** Why is it better to use `TryParse` here rather than wrapping `Convert.ToDouble` in a `try/catch` block?

---

### Q7 — Input Edge Cases

Test your calculator from Q6 with the following inputs and describe the behavior:

1. Empty input (`Enter` with nothing)
2. Whitespace only (`   `)
3. Very large numbers (`99999999999999999999`)
4. Negative numbers (`-42`)
5. Decimal numbers (`3.14159`)
6. Scientific notation (`1.5e3`)
7. Letters mixed with numbers (`12abc`)
8. `null` (if applicable in your environment)

**Question:** Which of these should be accepted, and which should be rejected? Justify each decision.

---

### Q8 — Practical: Student Registration

Create a student registration form that collects:

1. Full name (string)
2. Age (int, validated)
3. Course name (string)
4. Course fee (decimal, validated)
5. Grade (char, validated — must be a single character)

Display a formatted receipt. Use the appropriate `TryParse` method for each numeric/char input.

---

### Q9 — Conceptual: Why `Console.ReadLine()` Returns `string`

Explain in your own words:
1. Why does `Console.ReadLine()` always return a `string`, even when the user types a number?
2. What is the conceptual model of "everything is text" when it comes to terminal input?
3. Why does this design force the programmer to perform explicit type conversion?