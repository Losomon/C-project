# C# Data Types

## 1. Introduction

In C#, every variable must have a specified data type. A data type determines the kind of value a variable can store, such as a whole number, decimal number, character, or text.

### Example

```csharp
int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating-point number
char myLetter = 'D';         // Single character
bool myBool = true;           // Boolean value
string myText = "Hello";      // Text
```

Choosing the correct data type helps:

- Prevent errors.
- Use memory efficiently.
- Make code readable and maintainable.
- Ensure variables store appropriate values.

---

## 2. Common C# Data Types

| Data Type | Size     | Description                                                                     |
| --------- | -------- | ------------------------------------------------------------------------------- |
| `int`     | 4 bytes  | Stores whole numbers                                                            |
| `long`    | 8 bytes  | Stores large whole numbers                                                      |
| `float`   | 4 bytes  | Stores decimal numbers with approximately 6–7 significant digits                |
| `double`  | 8 bytes  | Stores decimal numbers with approximately 15–16 significant digits              |
| `decimal` | 16 bytes | Stores high-precision decimal numbers, commonly used for financial calculations |
| `bool`    | 1 byte   | Stores `true` or `false`                                                        |
| `char`    | 2 bytes  | Stores a single UTF-16 character                                                |
| `string`  | Variable | Stores a sequence of characters                                                 |

> Note: `string` does not use a fixed number of bytes per character. Its memory usage depends on the string's contents and runtime representation.

---

## 3. Numeric Data Types

Numeric data types are divided into two main groups:

1. **Integer types** — store whole numbers without decimal points.
2. **Floating-point types** — store numbers with fractional parts.

### 3.1 Integer Types

#### `int`

The `int` data type stores whole numbers between:

- Minimum: `-2,147,483,648`
- Maximum: `2,147,483,647`

It is the preferred choice for most whole-number calculations.

```csharp
int myNum = 100000;

Console.WriteLine(myNum);
```

**Output:**

```text
100000
```

#### `long`

The `long` data type stores larger whole numbers than `int`.

- Minimum: `-9,223,372,036,854,775,808`
- Maximum: `9,223,372,036,854,775,807`

Use `long` when a value exceeds the range of `int`.

```csharp
long myNum = 15000000000L;

Console.WriteLine(myNum);
```

**Output:**

```text
15000000000
```

The `L` suffix tells C# that the literal is a `long`.

---

### 3.2 Floating-Point Types

Use floating-point types when working with numbers that contain fractional parts.

#### `float`

The `float` data type uses 4 bytes and provides approximately 6–7 significant digits of precision.

```csharp
float myNum = 5.75F;

Console.WriteLine(myNum);
```

**Output:**

```text
5.75
```

The `F` suffix identifies the value as a `float`.

#### `double`

The `double` data type uses 8 bytes and provides approximately 15–16 significant digits of precision.

```csharp
double myNum = 19.99D;

Console.WriteLine(myNum);
```

**Output:**

```text
19.99
```

The `D` suffix identifies the value as a `double`. It is optional because `double` is the default type for decimal-point numeric literals.

### Float vs. Double

| Feature                 | `float`                                 | `double`                                      |
| ----------------------- | --------------------------------------- | --------------------------------------------- |
| Memory                  | 4 bytes                                 | 8 bytes                                       |
| Precision               | 6–7 significant digits                  | 15–16 significant digits                      |
| Default decimal literal | No                                      | Yes                                           |
| Typical use             | Graphics, memory-sensitive calculations | General scientific and numerical calculations |

**Rule:** Use `double` for most general floating-point calculations unless you have a specific reason to use `float`.

---

### 3.3 Decimal Type

The `decimal` type provides higher decimal precision and is commonly used for financial calculations.

```csharp
decimal price = 1250.50m;

Console.WriteLine(price);
```

**Output:**

```text
1250.50
```

The `m` suffix identifies the value as a `decimal`.

Unlike `float` and `double`, `decimal` can represent many decimal fractions exactly, making it more suitable for monetary calculations.

---

## 4. Scientific Numbers

C# supports scientific notation using `e` or `E` to represent powers of 10.

```csharp
float f1 = 35e3F;
double d1 = 12E4D;

Console.WriteLine(f1);
Console.WriteLine(d1);
```

**Output:**

```text
35000
120000
```

Explanation:

- `35e3` means \(35 \times 10^3\).
- `12E4` means \(12 \times 10^4\).

---

## 5. Boolean Data Type

The `bool` data type stores only two possible values:

- `true`
- `false`

Boolean values are commonly used in conditional statements and logical expressions.

```csharp
bool isCSharpFun = true;
bool isFishTasty = false;

Console.WriteLine(isCSharpFun);
Console.WriteLine(isFishTasty);
```

**Output:**

```text
True
False
```

### Example: Boolean in a Condition

```csharp
bool isLoggedIn = true;

if (isLoggedIn)
{
    Console.WriteLine("Welcome back!");
}
else
{
    Console.WriteLine("Please log in.");
}
```

**Output:**

```text
Welcome back!
```

---

## 6. Character Data Type

The `char` data type stores a single UTF-16 character.

Character values must be enclosed in single quotes.

```csharp
char myGrade = 'B';

Console.WriteLine(myGrade);
```

**Output:**

```text
B
```

Additional examples:

```csharp
char letter = 'A';
char digit = '7';
char symbol = '#';
```

> A `char` represents one UTF-16 code unit. Some Unicode characters require more than one `char`.

---

## 7. String Data Type

The `string` data type stores a sequence of characters, commonly used for text.

String values must be enclosed in double quotes.

```csharp
string greeting = "Hello World";

Console.WriteLine(greeting);
```

**Output:**

```text
Hello World
```

### Example: Combining Strings

```csharp
string firstName = "John";
string lastName = "Doe";

string fullName = firstName + " " + lastName;

Console.WriteLine(fullName);
```

**Output:**

```text
John Doe
```

### Example: String Interpolation

String interpolation allows variables to be inserted directly into a string using `$`.

```csharp
string name = "John";
int age = 20;

Console.WriteLine($"My name is {name} and I am {age} years old.");
```

**Output:**

```text
My name is John and I am 20 years old.
```

---

## 8. Complete Practice Program

The following program demonstrates the common C# data types together.

```csharp
using System;

class Program
{
    static void Main()
    {
        int age = 20;
        long population = 15000000000L;
        float height = 5.9F;
        double pi = 3.141592653589793D;
        decimal price = 2500.50m;
        bool isStudent = true;
        char grade = 'A';
        string name = "John Doe";

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Population: {population}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Pi: {pi}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Is Student: {isStudent}");
        Console.WriteLine($"Grade: {grade}");
    }
}
```

---

## 9. Key Takeaways

- `int` stores whole numbers.
- `long` stores larger whole numbers.
- `float` stores decimal numbers with lower precision.
- `double` stores decimal numbers with higher precision.
- `decimal` is suitable for financial calculations.
- `bool` stores `true` or `false`.
- `char` stores a single UTF-16 code unit.
- `string` stores text.
- Numeric suffixes such as `L`, `F`, `D`, and `m` identify specific numeric types.

---

## 10. Practice Exercises

1. Declare an `int` variable named `studentAge` and assign your age.
2. Declare a `long` variable that stores a number larger than 2 billion.
3. Declare a `float` variable named `temperature`.
4. Declare a `double` variable named `distance`.
5. Declare a `decimal` variable named `productPrice`.
6. Declare a `bool` variable named `isEnrolled`.
7. Declare a `char` variable named `studentGrade`.
8. Declare a `string` variable named `studentName`.
9. Print all the variables using `Console.WriteLine()`.
10. Create a program that displays a student's name, age, course, grade, and enrollment status.

---

**Next lesson:** C# Type Casting — converting values from one data type to another.
