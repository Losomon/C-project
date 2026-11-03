# C# Operators

---

## 1. What Are Operators?

Operators are used to perform operations on variables and values.

```csharp
int x = 100 + 50;
Console.WriteLine(x); // 150
```

The `+` operator can add values, variables, or a combination of both.

```csharp
int sum1 = 100 + 50;    // 150
int sum2 = sum1 + 250;  // 400
int sum3 = sum2 + sum2; // 800
```

---

## 2. Arithmetic Operators

Arithmetic operators perform common mathematical operations.

| Operator | Name           | Description           | Example |
| -------- | -------------- | --------------------- | ------- |
| `+`      | Addition       | Adds two values       | `x + y` |
| `-`      | Subtraction    | Subtracts values      | `x - y` |
| `*`      | Multiplication | Multiplies values     | `x * y` |
| `/`      | Division       | Divides values        | `x / y` |
| `%`      | Modulus        | Returns the remainder | `x % y` |
| `++`     | Increment      | Increases by 1        | `x++`   |
| `--`     | Decrement      | Decreases by 1        | `x--`   |

### Example

```csharp
int x = 10;
int y = 3;

Console.WriteLine(x + y); // 13
Console.WriteLine(x - y); // 7
Console.WriteLine(x * y); // 30
Console.WriteLine(x / y); // 3
Console.WriteLine(x % y); // 1

x++;
Console.WriteLine(x); // 11

y--;
Console.WriteLine(y); // 2
```

**Note:** Integer division removes the decimal part. `10 / 3` returns `3`.

To get a decimal result:

```csharp
double result = 10.0 / 3;
Console.WriteLine(result); // 3.333333...
```

---

## 3. Assignment Operators

Assignment operators assign values to variables or update existing values.

| Operator | Example   | Same As      |
| -------- | --------- | ------------ |
| `=`      | `x = 5`   | `x = 5`      |
| `+=`     | `x += 3`  | `x = x + 3`  |
| `-=`     | `x -= 3`  | `x = x - 3`  |
| `*=`     | `x *= 3`  | `x = x * 3`  |
| `/=`     | `x /= 3`  | `x = x / 3`  |
| `%=`     | `x %= 3`  | `x = x % 3`  |
| `&=`     | `x &= 3`  | `x = x & 3`  |
| `\|=`    | `x \|= 3` | `x = x \| 3` |
| `^=`     | `x ^= 3`  | `x = x ^ 3`  |
| `>>=`    | `x >>= 3` | `x = x >> 3` |
| `<<=`    | `x <<= 3` | `x = x << 3` |

### Example

```csharp
int x = 10;

x += 5;
Console.WriteLine(x); // 15

x -= 3;
Console.WriteLine(x); // 12

x *= 2;
Console.WriteLine(x); // 24

x /= 4;
Console.WriteLine(x); // 6

x %= 4;
Console.WriteLine(x); // 2
```

---

## 4. Comparison Operators

Comparison operators compare two values and return a Boolean result: `true` or `false`.

| Operator | Name                     | Example  |
| -------- | ------------------------ | -------- |
| `==`     | Equal to                 | `x == y` |
| `!=`     | Not equal                | `x != y` |
| `>`      | Greater than             | `x > y`  |
| `<`      | Less than                | `x < y`  |
| `>=`     | Greater than or equal to | `x >= y` |
| `<=`     | Less than or equal to    | `x <= y` |

### Example

```csharp
int x = 5;
int y = 3;

Console.WriteLine(x > y);  // True
Console.WriteLine(x < y);  // False
Console.WriteLine(x == y); // False
Console.WriteLine(x != y); // True
Console.WriteLine(x >= y); // True
Console.WriteLine(x <= y); // False
```

**Remember:**

- `=` assigns a value.
- `==` compares two values.

---

## 5. Logical Operators

Logical operators determine the logic between Boolean values or expressions.

| Operator | Name        | Description                            |
| -------- | ----------- | -------------------------------------- |
| `&&`     | Logical AND | True if both conditions are true       |
| `\|\|`   | Logical OR  | True if at least one condition is true |
| `!`      | Logical NOT | Reverses the result                    |

### Example

```csharp
int x = 5;

Console.WriteLine(x < 10 && x > 2); // True
Console.WriteLine(x < 5 || x > 2);  // True
Console.WriteLine(!(x < 10));       // False
```

### Real-World Example

```csharp
int age = 20;
bool hasID = true;

if (age >= 18 && hasID)
{
    Console.WriteLine("Access granted");
}
else
{
    Console.WriteLine("Access denied");
}
```

---

## 6. Practice Exercises

1. Create two integer variables and print their sum, difference, product, quotient, and remainder.
2. Create a variable `score = 50`. Increase it by 10 using `+=`.
3. Compare two numbers and print whether the first is greater than the second.
4. Create an age variable and check whether the person is eligible to vote.
5. Create two Boolean variables: `hasAccount` and `isVerified`. Use `&&` to check whether both are true.
6. Create a variable `number = 7`. Use increment and decrement operators and print the results.
7. Check whether a number is even or odd using the modulus operator.

---

## 7. Key Takeaways

- Arithmetic operators perform calculations.
- Assignment operators assign or update values.
- Comparison operators return Boolean values.
- Logical operators combine Boolean conditions.
- The modulus operator `%` returns the remainder.
- Increment `++` increases a variable by 1.
- Decrement `--` decreases a variable by 1.

---

**Next Topic:** C# Math
