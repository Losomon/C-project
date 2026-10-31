# Exercise 05 — Operators

## Core Concepts Tested
- Arithmetic operators (+, -, *, /, %)
- Assignment operators (=, +=, -=, etc.)
- Comparison operators (==, !=, <, >, <=, >=)
- Logical operators (&&, ||, !)
- Operator precedence and associativity
- Compound assignment semantics
- Side effects and evaluation order

---

## Questions

### Q1 — Arithmetic Operator Behavior

Evaluate the following expressions **without writing code first**, then verify:

```csharp
1.  10 + 5 * 2
2.  (10 + 5) * 2
3.  20 / 3          // int division
4.  20 / 3.0        // double division
5.  20 % 3
6.  20 % 3.0
7.  -10 % 3
8.  10 % -3
9.  17 / 5 * 2
10. 17.0 / 5 * 2
```

**Follow-up:** Explain the difference between integer division and floating-point division. What happens to the remainder in integer division?

---

### Q2 — Compound Assignment

Write code that:

1. Declares `int x = 10;`.
2. Uses compound assignment to:
   - `x += 5` (add 5)
   - `x -= 3` (subtract 3)
   - `x *= 2` (multiply by 2)
   - `x /= 4` (divide by 4)
   - `x %= 3` (modulo 3)
3. Display `x` after each operation.

**Question:** Is `x += 5` exactly the same as `x = x + 5`? Are there any cases where they differ? (Hint: consider type conversion and overflow.)

---

### Q3 — Operator Precedence

Without running code, determine the output of each:

```csharp
int a = 10, b = 5, c = 2;

1.  a + b * c
2.  a * b + c
3.  a + b % c
4.  a % b + c
5.  a / b * c
6.  a * b / c
7.  a + b > c * a
8.  a < b || c > a
9.  !true || false && true
10. true || !false && false
```

**Reflection:** What is the precedence order of these operators? List them from highest to lowest: `*`, `/`, `%`, `+`, `-`, `<`, `>`, `==`, `!=`, `&&`, `||`, `!`, `=`.

---

### Q4 — Logical Operators and Short-Circuit Evaluation

Write a program that demonstrates short-circuit evaluation:

```csharp
bool result1 = false && (10 / 0 > 0);  // Does this throw an exception?
bool result2 = true || (10 / 0 > 0);   // Does this throw an exception?
```

1. What are the results?
2. Why does the first one not throw an exception despite containing a division by zero?
3. Explain short-circuit evaluation in your own words.
4. Now write the same expressions using `&` and `|` (non-short-circuit operators). What happens?

**Follow-up:** When would you choose `&&` over `&`, and vice versa?

---

### Q5 — Comparison Operators with Different Types

1. Can you compare an `int` with a `double`? Demonstrate.
2. Can you compare a `char` with an `int`? Demonstrate.
3. Can you compare a `string` with another `string` using `==`? Demonstrate. What is actually being compared?
4. Can you compare a `bool` with an `int`? Try and explain the compiler behavior.

---

### Q6 — Chained Comparisons

In C#, you cannot chain comparisons like `5 < x < 10`. Why? Write the correct way to express "x is between 5 and 10 (exclusive)."

Now write expressions for:

1. "x is greater than 5 AND less than 10"
2. "x is less than 5 OR greater than 15"
3. "x is NOT equal to 0"
4. "x is between -10 and 10 (inclusive)"

---

### Q7 — Practical: Grade Evaluator

Write a program that:

1. Asks the user for a numeric grade (0-100).
2. Uses comparison operators and logical operators to determine the letter grade:
   - 90-100: A
   - 80-89: B
   - 70-79: C
   - 60-69: D
   - 0-59: F
3. Display the letter grade.
4. Also determine if the student passed (grade >= 60) using a `bool` variable.
5. Display a message based on the `bool`.

**Extension:** What happens if the user enters a grade outside 0-100? Add input validation.

---

### Q8 — Assignment as an Expression

In C#, assignment returns the assigned value. Write code that exploits this:

```csharp
int x, y;
x = y = 10;  // What is the value of x and y?
```

1. What is the value of `x` and `y` after this statement?
2. Now write: `int z = (x = 20);`. What is `z`? What is `x`?
3. Can you use assignment inside a condition? For example: `if ((x = getValue()) != null)`. Is this valid C#? Why or why not?

---

### Q9 — Conceptual: Operator Design

Why does C# not allow implicit conversion from `bool` to `int` (unlike C/C++)? What design benefit does this provide? Think about error prevention and code clarity.