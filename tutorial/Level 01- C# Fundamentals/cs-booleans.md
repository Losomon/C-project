# C# Booleans

---

## 1. What Is a Boolean?

A Boolean (`bool`) is a data type that can store only one of two values:

- `true`
- `false`

Booleans are useful when a program needs to make decisions.

```csharp
bool isStudent = true;
bool isGraduated = false;

Console.WriteLine(isStudent);
Console.WriteLine(isGraduated);
```

**Output:**

```text
True
False
```

---

## 2. Creating Boolean Variables

### Syntax

```csharp
bool variableName = true;
```

### Example

```csharp
// Store whether a user is logged in
bool isLoggedIn = true;

// Display the Boolean value
Console.WriteLine(isLoggedIn);
```

**Output:**

```text
True
```

C# uses lowercase `true` and `false` in code. The console displays them as `True` and `False`.

---

## 3. Boolean Expressions

A Boolean expression is an expression that evaluates to either `true` or `false`.

Comparison operators are commonly used to create Boolean expressions.

| Operator | Meaning                  | Example  |
| -------- | ------------------------ | -------- |
| `==`     | Equal to                 | `5 == 5` |
| `!=`     | Not equal to             | `5 != 3` |
| `>`      | Greater than             | `8 > 4`  |
| `<`      | Less than                | `2 < 6`  |
| `>=`     | Greater than or equal to | `5 >= 5` |
| `<=`     | Less than or equal to    | `4 <= 7` |

### Example

```csharp
int x = 10;
int y = 5;

// Compare the values
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x == y);
```

**Output:**

```text
True
False
False
```

---

## 4. Using Boolean Values in Conditions

Booleans are often used with `if` statements to control what a program does.

```csharp
bool isRaining = true;

// Check whether it is raining
if (isRaining)
{
    Console.WriteLine("Take an umbrella.");
}
else
{
    Console.WriteLine("No umbrella needed.");
}
```

**Output:**

```text
Take an umbrella.
```

The `if` block runs when its condition is `true`. The `else` block runs when the condition is `false`.

---

## 5. Boolean Variables from Comparisons

You can assign the result of a comparison to a Boolean variable.

```csharp
int age = 20;

// Check whether the person is at least 18
bool canVote = age >= 18;

Console.WriteLine(canVote);
```

**Output:**

```text
True
```

The variable `canVote` stores the result of the comparison.

---

## 6. Logical Operators

Logical operators combine or reverse Boolean expressions.

| Operator | Name | Meaning                                 |
| -------- | ---- | --------------------------------------- | --- | ---------------------------------------- |
| `&&`     | AND  | True only when both conditions are true |
| `        |      | `                                       | OR  | True when at least one condition is true |
| `!`      | NOT  | Reverses a Boolean value                |

### AND (`&&`)

Both conditions must be true.

```csharp
int age = 20;
bool hasID = true;

// Both conditions must be true
bool canEnter = age >= 18 && hasID;

Console.WriteLine(canEnter);
```

**Output:**

```text
True
```

### OR (`||`)

At least one condition must be true.

```csharp
bool isWeekend = false;
bool isHoliday = true;

// Either condition can be true
bool canRelax = isWeekend || isHoliday;

Console.WriteLine(canRelax);
```

**Output:**

```text
True
```

### NOT (`!`)

The NOT operator reverses a Boolean value.

```csharp
bool isLoggedIn = false;

// Reverse the Boolean value
Console.WriteLine(!isLoggedIn);
```

**Output:**

```text
True
```

---

## 7. Real-World Application

Booleans are used in systems to represent states and make decisions, such as:

- Whether a user is logged in
- Whether a product is available
- Whether an order has been paid
- Whether a form is valid
- Whether a user has permission to access a page

### Example: Checking Product Availability

```csharp
string productName = "Face Cream";
bool isAvailable = true;

// Check whether the product is available
if (isAvailable)
{
    Console.WriteLine($"{productName} is available.");
}
else
{
    Console.WriteLine($"{productName} is out of stock.");
}
```

**Output:**

```text
Face Cream is available.
```

---

## 8. Exercises

Try solving these without looking at the solutions.

### Exercise 1: Boolean Variables

Create two Boolean variables:

- `isStudent` set to `true`
- `hasGraduated` set to `false`

Print both values.

### Exercise 2: Comparisons

Create two integer variables, `x = 15` and `y = 10`.

Print the results of:

- `x > y`
- `x < y`
- `x == y`

### Exercise 3: Age Check

Create an integer variable called `age`.

Create a Boolean variable called `isAdult` that checks whether the age is at least 18. Print the result.

### Exercise 4: AND Operator

Create two Boolean variables:

- `hasUsername = true`
- `hasPassword = true`

Use `&&` to check whether both are true.

### Exercise 5: OR Operator

Create two Boolean variables:

- `isWeekend = false`
- `isHoliday = true`

Use `||` to check whether either is true.

### Exercise 6: NOT Operator

Create a Boolean variable called `isAvailable` and set it to `false`.

Print the opposite value using `!`.

### Exercise 7: Login Check

Create a Boolean variable called `isLoggedIn`.

If it is `true`, print `"Welcome back!"`. Otherwise, print `"Please log in."`.

### Exercise 8: Product Availability

Create a product name and a Boolean variable called `isInStock`.

Use an `if...else` statement to print whether the product is available.

---

## 9. Summary

| Concept     | Description                            |
| ----------- | -------------------------------------- | --- | --------------------------------------- |
| `bool`      | Stores `true` or `false`               |
| `==`        | Checks equality                        |
| `!=`        | Checks inequality                      |
| `>` / `<`   | Compares greater or less than          |
| `>=` / `<=` | Compares greater/less than or equal to |
| `&&`        | AND: both conditions must be true      |
| `           |                                        | `   | OR: at least one condition must be true |
| `!`         | NOT: reverses a Boolean value          |
| `if...else` | Runs code based on a condition         |

---

## 10. Level 1 Completion

You have now covered the Level 1 topics:

- [ ] Variables
- [ ] Data Types
- [ ] Type Casting
- [ ] User Input
- [ ] Operators
- [ ] Math
- [ ] Strings
- [ ] Booleans

**Next:** Complete the Level 1 calculator mini-project and assessment before moving to Level 2: Decisions and Loops.
