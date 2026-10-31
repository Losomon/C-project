# C# User Input

## 1. Introduction

In C#, user input allows a program to receive information from the keyboard while it is running.

Previously, we used:

- `Console.WriteLine()` – displays information on the screen.
- `Console.ReadLine()` – reads input entered by the user.

The `Console.ReadLine()` method reads a line of text and returns it as a string.

---

## 2. Getting User Input

To receive input from a user, use `Console.ReadLine()`.

### Example

```csharp
// Ask the user to enter a username
Console.WriteLine("Enter username:");

// Read and store user input
string userName = Console.ReadLine() ?? "";

// Display the username
Console.WriteLine("Username is: " + userName);
```

**Example output:**

```text
Enter username:
John
Username is: John
```

### Explanation

1. `Console.WriteLine()` displays a message asking for a username.
2. `Console.ReadLine()` waits for the user to enter text.
3. The entered text is stored in the `userName` variable.
4. The program displays the entered username.

---

## 3. User Input and Numbers

The `Console.ReadLine()` method returns a string, even when the user enters a number.

Therefore, you cannot directly store its result in an integer variable.

### Incorrect Example

```csharp
Console.WriteLine("Enter your age:");

int age = Console.ReadLine();

Console.WriteLine("Your age is: " + age);
```

This produces a compilation error because C# cannot implicitly convert a string into an integer.

### Correct Example: Convert.ToInt32()

You can use `Convert.ToInt32()` to convert the input into an integer.

```csharp
Console.WriteLine("Enter your age:");

int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your age is: " + age);
```

**Example output:**

```text
Enter your age:
21
Your age is: 21
```

---

## 4. Converting User Input into Different Data Types

Since `Console.ReadLine()` returns a string, you need conversion methods when you want to work with other data types.

| Conversion Method     | Resulting Data Type |
| --------------------- | ------------------- |
| `Convert.ToInt32()`   | `int`               |
| `Convert.ToInt64()`   | `long`              |
| `Convert.ToDouble()`  | `double`            |
| `Convert.ToSingle()`  | `float`             |
| `Convert.ToDecimal()` | `decimal`           |
| `Convert.ToBoolean()` | `bool`              |

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your height:");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your course fee:");
        decimal fee = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("\n=== User Information ===");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Course Fee: {fee}");
    }
}
```

**Example output:**

```text
Enter your age:
21
Enter your height:
5.9
Enter your course fee:
25000

=== User Information ===
Age: 21
Height: 5.9
Course Fee: 25000
```

---

## 5. Using int.TryParse() for Safe Input

`Convert.ToInt32()` can throw an exception when the user enters invalid numerical input.

For example, entering `"John"` when an integer is expected causes a conversion error.

A safer approach is `int.TryParse()`.

It attempts to convert a string into an integer without throwing an exception when the input is invalid.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");

        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int age))
        {
            Console.WriteLine($"Your age is: {age}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
```

**Example 1: Valid input**

```text
Enter your age:
21
Your age is: 21
```

**Example 2: Invalid input**

```text
Enter your age:
John
Invalid input. Please enter a valid number.
```

### Explanation

- `int.TryParse()` attempts to convert the input into an integer.
- `input` contains the text entered by the user.
- `out int age` receives the converted integer when conversion succeeds.
- The method returns `true` when conversion succeeds and `false` when it fails.

**Engineering recommendation:** Prefer `TryParse()` when accepting numerical input from users in real applications.

---

## 6. Practical Example: Student Information System

This program receives information from a student and displays it.

```csharp
using System;

class StudentInformation
{
    static void Main()
    {
        // Get student name
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine() ?? "";

        // Get student age
        Console.WriteLine("Enter your age:");
        string ageInput = Console.ReadLine() ?? "";

        // Validate age
        if (!int.TryParse(ageInput, out int age))
        {
            Console.WriteLine("Invalid age entered.");
            return;
        }

        // Get student course
        Console.WriteLine("Enter your course:");
        string course = Console.ReadLine() ?? "";

        // Get student grade
        Console.WriteLine("Enter your grade:");
        string gradeInput = Console.ReadLine() ?? "";

        if (!char.TryParse(gradeInput, out char grade))
        {
            Console.WriteLine("Invalid grade entered.");
            return;
        }

        // Display student information
        Console.WriteLine("\n=== Student Information ===");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Grade: {grade}");
    }
}
```

**Example output:**

```text
Enter your name:
John Doe
Enter your age:
21
Enter your course:
Computer Science
Enter your grade:
A

=== Student Information ===
Name: John Doe
Age: 21
Course: Computer Science
Grade: A
```

---

## 7. Important Things to Remember

- `Console.WriteLine()` displays output.
- `Console.ReadLine()` receives keyboard input.
- `Console.ReadLine()` returns a string.
- Use conversion methods when working with numerical input.
- `Convert.ToInt32()` converts input into an integer.
- `int.TryParse()` safely validates integer input.
- Invalid input can cause conversion errors when using methods such as `Convert.ToInt32()`.
- Use meaningful variable names to make programs easier to understand.

---

## 8. Practice Exercises

Try solving these exercises independently.

1. Write a program that asks the user to enter their name and displays a welcome message.
2. Ask the user to enter their age and display it.
3. Ask the user to enter two integers and display their sum.
4. Ask the user to enter their height as a decimal number.
5. Ask the user to enter their course name and registration number.
6. Ask the user to enter their school fees and display the amount.
7. Use `int.TryParse()` to validate a user's age.
8. Create a program that asks for a username and password, then displays the entered username. Do not display the password in a real authentication system.

### Challenge: Simple Calculator

Create a program that:

1. Asks the user to enter the first number.
2. Asks the user to enter the second number.
3. Converts both inputs into `double` values.
4. Calculates their sum.
5. Calculates their difference.
6. Calculates their product.
7. Calculates their division, ensuring the second number is not zero.
8. Displays all the results.

---

## 9. Key Takeaways

| Concept               | Purpose                                     |
| --------------------- | ------------------------------------------- |
| `Console.WriteLine()` | Displays information                        |
| `Console.ReadLine()`  | Receives user input                         |
| `Convert.ToInt32()`   | Converts input into an integer              |
| `Convert.ToDouble()`  | Converts input into a double                |
| `int.TryParse()`      | Safely converts and validates integer input |
| `char.TryParse()`     | Safely converts a string into a character   |

**Next lesson:** C# Operators.
