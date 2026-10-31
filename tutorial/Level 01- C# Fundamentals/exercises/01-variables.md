# Exercise 01 — Variables & Constants

## Core Concepts Tested
- Variable declaration, assignment, and reassignment
- The difference between `var` and explicit types
- Constants (`const`) and their compile-time nature
- Identifier naming rules and conventions
- Memory and mutability mental model

---

## Questions

### Q1 — Declare and Mutate

Declare an `int` variable named `counter` with an initial value of `10`. Then, in order:

1. Display the current value.
2. Reassign `counter` to `20` and display it.
3. Add `5` to `counter` using compound assignment (`+=`) and display it.
4. Subtract `3` from `counter` using compound assignment (`-=`) and display it.

**Follow-up reflection:** Each time you reassigned `counter`, did the memory location change, or did the value at that location change? Explain in terms of what a variable actually is.

---

### Q2 — Type Inference vs Explicit Type

Write two versions of the same program:

**Version A:** Use `var` for type inference:
```csharp
var a = 100;
var b = "hello";
```

**Version B:** Use explicit types:
```csharp
int a = 100;
string b = "hello";
```

Now, in each version, try to reassign `a` with a `string` value (`a = "world"`) and `b` with an `int` (`b = 42`).

**Questions:**
1. Which version compiles? Which fails? Why?
2. What does this tell you about the difference between `var` and a static type?
3. At compile time, what is the actual type of a `var`-declared variable?

---

### Q3 — Constants and Immutability

1. Declare a `const int MAX_USERS = 50;`.
2. Display its value.
3. Attempt to reassign it: `MAX_USERS = 100;`.
4. Observe the compiler error and explain **why** a `const` cannot be reassigned.
5. Now declare a `readonly` field or variable (if you know it) or explain: what is the difference between a value that is fixed at compile time (`const`) and one that is fixed at runtime (`readonly`)?

---

### Q4 — Identifier Validity

Determine which of the following are **valid** C# identifiers and which are **invalid**. For each invalid one, explain the specific rule it violates:

```csharp
studentName
2student
student_age
student age
totalPrice
myVar
myvar
class
_int
$price
student#name
```

**Follow-up:** `myVar` and `myvar` are both valid — are they the same variable? Demonstrate with code.

---

### Q5 — The Variable as a Container

Write a program that:

1. Declares an `int` variable `age` and assigns it `25`.
2. Declares a `double` variable `weight` and assigns it `72.5`.
3. Declares a `bool` variable `isStudent` and assigns it `true`.
4. Declares a `string` variable `name` and assigns it `"Alice"`.
5. Displays all four values, each on a separate line, with a label.

**Reflection:** Each of these variables stores a fundamentally different kind of data. What does this tell you about the role of a data type in a variable declaration?

---

### Q6 — Multiple Variable Declaration

Write a single statement that declares and initializes three `int` variables (`x`, `y`, `z`) with values `5`, `10`, and `15` respectively. Then display their sum.

**Extension:** Now write a second version where you declare all three in one line but assign them the same value (`50`) using chained assignment: `x = y = z = 50;`. Explain the order of evaluation in the chained assignment.

---

### Q7 — Practical: Bank Account Simulator

Create a program that models a simple bank account:

1. Declare a `string` variable for the account holder's name.
2. Declare a `decimal` variable for the account balance (use `decimal` for financial precision).
3. Display the initial balance.
4. Deposit `500.00` and display the new balance.
5. Withdraw `150.00` and display the new balance.
6. Attempt to withdraw `1000.00` (more than the balance). What happens? Should a real program check before withdrawing? Explain.

---

### Q8 — Conceptual: What Is a Variable?

In 2-3 sentences, explain in your own words: **What is a variable, and why does a program need variables?**

Then, contrast a variable with a **constant**. When would you choose one over the other?