# Exercise 08 — Booleans

## Core Concepts Tested
- Boolean logic and truth values
- Logical operators (`&&`, `||`, `!`)
- Short-circuit evaluation
- Boolean expressions in conditions
- Common boolean pitfalls
- De Morgan's laws
- Comparisons producing booleans

---

## Questions

### Q1 — Boolean Basics

1. Declare a `bool` variable and assign it `true`. Display it.
2. Declare a `bool` variable and assign it `false`. Display it.
3. Can you assign `1` to a `bool`? Can you assign `"true"` (string)? Try and explain the compiler behavior.
4. What are the only two valid values for a `bool`?

---

### Q2 — Comparison Operators Producing Booleans

Write code that demonstrates that comparison operators return `bool` values:

```csharp
int a = 10, b = 5;
bool result = a > b;  // This is a bool
```

1. Store the result of each comparison in a `bool` variable and display it:
   - `a > b`
   - `a < b`
   - `a == b`
   - `a != b`
   - `a >= b`
   - `a <= b`
2. What happens if you try to use a comparison result directly in an arithmetic expression?

---

### Q3 — Logical Operators

Evaluate the following expressions **without running code first**, then verify:

```csharp
bool t = true, f = false;

1.  t && t
2.  t && f
3.  f && t
4.  f && f
5.  t || t
6.  t || f
7.  f || t
8.  f || f
9.  !t
10. !f
11. !t && f
12. !(t && f)
13. t || !t
14. f || !f
```

**Follow-up:** Draw the truth tables for `AND`, `OR`, and `NOT`. Which of these are tautologies (always true)?

---

### Q4 — Short-Circuit Evaluation

Write a program that demonstrates short-circuit evaluation:

```csharp
bool result1 = false && (10 / 0 > 0);
bool result2 = true || (10 / 0 > 0);
```

1. What are the results?
2. Why does the first one not throw an exception despite containing a division by zero?
3. Explain short-circuit evaluation in your own words.
4. Now write the same expressions using `&` and `|` (non-short-circuit operators). What happens?

**Follow-up:** When would you choose `&&` over `&`, and vice versa?

---

### Q5 — De Morgan's Laws

De Morgan's Laws state:
- `!(A && B)` is equivalent to `!A || !B`
- `!(A || B)` is equivalent to `!A && !B`

1. Write a program that verifies these laws for all combinations of `A` and `B` (both `true` and `false`).
2. Display the results in a table.
3. Are the laws always true?

**Extension:** Why are De Morgan's Laws useful? Give a practical example from real code.

---

### Q6 — Practical: Access Control

Write a program that determines whether a user has access based on multiple conditions:

1. Ask the user (or hardcode) the following:
   - Is the user logged in? (bool)
   - Is the user an admin? (bool)
   - Is the user within business hours? (bool)
2. Apply these access rules:
   - Rule 1: Admins can access anytime.
   - Rule 2: Regular users can access only during business hours.
   - Rule 3: Users who are not logged in cannot access at all.
3. Display whether access is granted.

**Extension:** How would you test this with different combinations of inputs?

---

### Q7 — Practical: Traffic Light Simulator

Create a traffic light system:

1. Define a variable for the current light state: `"Red"`, `"Yellow"`, or `"Green"`.
2. Based on the light, determine:
   - Should the car stop? (Red or Yellow)
   - Should the car go? (Green)
   - Is the light about to change? (Green → Yellow, Yellow → Red, Red → Green)
3. Display the appropriate action.

**Extension:** Add a pedestrian crossing mode. When the light is Red, pedestrians can cross. When Green or Yellow, they cannot.

---

### Q8 — Boolean Pitfalls

1. **Assignment vs Comparison:** Write code that accidentally uses `=` (assignment) instead of `==` (comparison) in a condition. What happens? (In C#, this is actually a compiler error in many contexts — explain why this is a safety feature.)

2. **Chained comparisons:** In C#, you cannot chain comparisons like `5 < x < 10`. Why? Write the correct way.

3. **Boolean default value:** What is the default value of a `bool` variable? What is the default value of a `bool?` (nullable bool)?

4. **`bool` vs `int`:** Why does C# not allow implicit conversion between `bool` and `int`? What design benefit does this provide?

---

### Q9 — Conceptual: Truth and Logic

1. In your own words, what does it mean for a boolean expression to "evaluate to true"?
2. Why are booleans essential for control flow (if/else, loops)?
3. How do booleans enable decision-making in programs? Give a real-world analogy.