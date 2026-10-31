# C# Type Casting

## 1. Introduction

Type casting is the process of converting a value from one data type to another.

For example, converting an `int` into a `double`, or a `double` into an `int`.

C# supports two main types of casting:

1. **Implicit Casting** – automatic conversion performed by the compiler.
2. **Explicit Casting** – manual conversion performed by the programmer.

---

## 2. Implicit Casting

Implicit casting happens automatically when converting a type to another type that can safely represent the original value's range.

A common conversion sequence is:

```text
char → int → long → float → double
```

### Example

```csharp
int myInt = 9;

double myDouble = myInt; // Automatic conversion: int to double

Console.WriteLine(myInt);
Console.WriteLine(myDouble);
```

**Output:**

```text
9
9
```

### Explanation

- `myInt` stores the integer value `9`.
- `myDouble` receives the value of `myInt`.
- C# automatically converts the integer into a double.

No manual casting is required.

### Another Example

```csharp
char myLetter = 'A';

int myNumber = myLetter;

Console.WriteLine(myLetter);
Console.WriteLine(myNumber);
```

**Output:**

```text
A
65
```

The character `'A'` has the Unicode value `65`.

---

## 3. Explicit Casting

Explicit casting happens when you manually convert a value from one data type to another.

It is commonly required when converting between numeric types where information could be lost.

### Syntax

```csharp
targetDataType variableName = (targetDataType) value;
```

### Example

```csharp
double myDouble = 9.78;

int myInt = (int)myDouble; // Manual conversion: double to int

Console.WriteLine(myDouble);
Console.WriteLine(myInt);
```

**Output:**

```text
9.78
9
```

### Explanation

- `myDouble` contains `9.78`.
- `(int)` explicitly converts the double into an integer.
- The decimal portion is discarded.
- The resulting integer is `9`.

**Important:** Explicit casting from `double` to `int` truncates the fractional part. It does not round to the nearest integer.

### Another Example

```csharp
double price = 125.99;

int wholePrice = (int)price;

Console.WriteLine(wholePrice);
```

**Output:**

```text
125
```

---

## 4. Type Conversion Methods

C# also provides built-in conversion methods through the `Convert` class.

These methods allow you to convert values between different data types.

Common methods include:

| Method                | Conversion                    |
| --------------------- | ----------------------------- |
| `Convert.ToBoolean()` | Converts a value to `bool`    |
| `Convert.ToDouble()`  | Converts a value to `double`  |
| `Convert.ToString()`  | Converts a value to `string`  |
| `Convert.ToInt32()`   | Converts a value to `int`     |
| `Convert.ToInt64()`   | Converts a value to `long`    |
| `Convert.ToDecimal()` | Converts a value to `decimal` |

### Example

```csharp
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));
Console.WriteLine(Convert.ToDouble(myInt));
Console.WriteLine(Convert.ToInt32(myDouble));
Console.WriteLine(Convert.ToString(myBool));
```

**Output:**

```text
10
10
5
True
```

### Explanation

- `Convert.ToString(myInt)` converts an integer into a string.
- `Convert.ToDouble(myInt)` converts an integer into a double.
- `Convert.ToInt32(myDouble)` converts a double into an integer.
- `Convert.ToString(myBool)` converts a Boolean value into a string.

**Important difference:** `Convert.ToInt32()` rounds floating-point values to the nearest integer, using midpoint-to-even rounding. This differs from explicit casting, which truncates.

For example:

```csharp
double number = 9.78;

int castResult = (int)number;
int convertResult = Convert.ToInt32(number);

Console.WriteLine(castResult);
Console.WriteLine(convertResult);
```

**Output:**

```text
9
10
```

---

## 5. Implicit Casting vs Explicit Casting

| Feature          | Implicit Casting                                      | Explicit Casting                           |
| ---------------- | ----------------------------------------------------- | ------------------------------------------ |
| Conversion       | Automatic                                             | Manual                                     |
| Syntax           | No casting operator                                   | Uses `(type)`                              |
| Common direction | Narrower to wider compatible types                    | Potentially lossy or narrowing conversions |
| Data loss        | Not necessarily value-preserving for every conversion | Possible                                   |
| Example          | `double x = myInt;`                                   | `int x = (int)myDouble;`                   |

> Note: Implicit conversions are not always completely lossless. For example, converting a large `long` to `float` can lose numerical precision.

---

## 6. Practical Example: Complete Program

The following program demonstrates implicit casting, explicit casting, and conversion methods.

```csharp
using System;

class TypeCasting
{
    static void Main()
    {
        // 1. Implicit Casting
        int myInt = 100;

        double myDouble = myInt;

        Console.WriteLine("Implicit Casting:");
        Console.WriteLine($"Integer: {myInt}");
        Console.WriteLine($"Double: {myDouble}");

        // 2. Explicit Casting
        double price = 99.99;

        int wholePrice = (int)price;

        Console.WriteLine("\nExplicit Casting:");
        Console.WriteLine($"Original Price: {price}");
        Console.WriteLine($"Converted Price: {wholePrice}");

        // 3. Convert Methods
        int age = 21;
        string name = "John";
        bool isStudent = true;

        Console.WriteLine("\nType Conversion Methods:");
        Console.WriteLine($"Age as Double: {Convert.ToDouble(age)}");
        Console.WriteLine($"Name as String: {Convert.ToString(name)}");
        Console.WriteLine($"Student Status: {Convert.ToBoolean(isStudent)}");

        // 4. Character to Integer
        char letter = 'A';

        int characterCode = letter;

        Console.WriteLine("\nCharacter Conversion:");
        Console.WriteLine($"Character: {letter}");
        Console.WriteLine($"Unicode Value: {characterCode}");
    }
}
```

---

## 7. Important Things to Remember

- Implicit casting is performed automatically by C#.
- Explicit casting requires the programmer to specify the target type.
- Explicit casting can result in data loss.
- Casting a `double` to an `int` removes the fractional part.
- `Convert.ToInt32()` rounds floating-point values rather than simply truncating them.
- Some conversions can throw exceptions when values are outside the supported range.
- Not every data type can be directly converted into every other data type.

---

## 8. Practice Exercises

Try solving these exercises without copying the examples above.

1. Declare an `int` variable with the value `50` and implicitly convert it into a `double`.
2. Declare a `double` variable with the value `45.89` and explicitly convert it into an `int`.
3. Convert an integer into a string using `Convert.ToString()`.
4. Convert a double into an integer using `Convert.ToInt32()`.
5. Convert a character `'B'` into its integer Unicode value.
6. Convert a Boolean value into a string.
7. Create a program demonstrating the difference between `(int)` and `Convert.ToInt32()`.

### Challenge

Create a simple student information program.

Your program should:

- Store a student's age as an `int`.
- Convert the age into a `double`.
- Store a student's grade as a `char`.
- Convert the grade into its integer Unicode value.
- Convert the student's age into a `string`.
- Display all original and converted values.

---

## 9. Key Takeaways

| Concept             | Meaning                                   |
| ------------------- | ----------------------------------------- |
| Implicit Casting    | Automatic type conversion                 |
| Explicit Casting    | Manual type conversion                    |
| `Convert` Class     | Provides built-in conversion methods      |
| `(int)`             | Explicitly converts a value to an integer |
| `Convert.ToInt32()` | Converts a value to a 32-bit integer      |

**Next lesson:** C# User Input (`Console.ReadLine()`).
