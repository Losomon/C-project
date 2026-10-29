# C# Output — Displaying Information

## 🎯 Learning Objectives

By the end of this lesson, you should be able to:

- Display messages on the screen.
- Use `Console.WriteLine()`.
- Use `Console.Write()`.
- Print numbers and calculate simple sums.
- Explain the difference between `Write()` and `WriteLine()`.

## 1. What Is Output?

Output is the information a computer gives back to us after receiving instructions.

Imagine asking a robot to say "Hello!" When the robot displays that message, it is producing output.

In C#, we can display output in the console using `Console.WriteLine()` and `Console.Write()`.

## 2. Display Your First Message

```csharp
// Display a greeting on the screen.
Console.WriteLine("Hello, World!");
```

### Output

```text
Hello, World!
```

### Explanation

- `Console` gives us access to console-related functionality.
- `WriteLine()` displays the message and moves to the next line.
- `"Hello, World!"` is the text we want to display.
- `;` marks the end of the statement.

## 3. Display Multiple Messages

```csharp
// Display the first message.
Console.WriteLine("Hello, World!");

// Display the second message.
Console.WriteLine("I am learning C#.");

// Display the third message.
Console.WriteLine("Programming is interesting.");
```

### Output

```text
Hello, World!
I am learning C#.
Programming is interesting.
```

Each call to `WriteLine()` starts a new line after displaying its message.

## 4. Display Numbers

You can display numbers without surrounding them with quotation marks.

```csharp
// Display the number 25.
Console.WriteLine(25);

// Display the number 100.
Console.WriteLine(100);
```

### Output

```text
25
100
```

Notice the difference:

```csharp
// This displays the number 25.
Console.WriteLine(25);

// This displays the text "25".
Console.WriteLine("25");
```

Both display `25`, but the first uses a number and the second uses text. That distinction matters when you begin performing calculations.

## 5. Perform Calculations

C# can calculate an answer before displaying it.

```csharp
// Add two numbers and display the answer.
Console.WriteLine(3 + 3);

// Subtract two numbers.
Console.WriteLine(10 - 4);

// Multiply two numbers.
Console.WriteLine(5 * 2);

// Divide two numbers.
Console.WriteLine(12 / 3);
```

### Output

```text
6
6
10
4
```

The symbols mean:

- `+` — addition.
- `-` — subtraction.
- `*` — multiplication.
- `/` — division.

The computer calculates each expression before displaying the result.

## 6. Understand `Console.Write()`

`Console.Write()` displays information without automatically moving to the next line.

```csharp
// Display the first part of a sentence.
Console.Write("Hello, ");

// Display the second part on the same line.
Console.Write("World!");
```

### Output

```text
Hello, World!
```

The second message continues directly after the first.

## 7. Compare `Write()` and `WriteLine()`

### Using `WriteLine()`

```csharp
Console.WriteLine("Hello");
Console.WriteLine("World");
```

Output:

```text
Hello
World
```

### Using `Write()`

```csharp
Console.Write("Hello");
Console.Write("World");
```

Output:

```text
HelloWorld
```

### Key difference

| Method                | What it does                                               |
| --------------------- | ---------------------------------------------------------- |
| `Console.Write()`     | Displays output without automatically starting a new line. |
| `Console.WriteLine()` | Displays output and then starts a new line.                |

You can add a space inside a string when you want separation between words.

## 8. Practical Example — A Simple Receipt

Let's display a pretend shopping receipt.

```csharp
// Display the shop name.
Console.WriteLine("MY SHOP");

// Display a separator.
Console.WriteLine("----------------");

// Display the item and its price.
Console.WriteLine("Soap: KSh 100");

// Display another item and its price.
Console.WriteLine("Lotion: KSh 250");

// Calculate and display the total.
Console.WriteLine(100 + 250);
```

### Output

```text
MY SHOP
----------------
Soap: KSh 100
Lotion: KSh 250
350
```

The total is `350`. Notice that this example only calculates the two numbers; it does not yet combine the currency label and calculated total into one message. You will learn how to do that when you study strings and variables.

## 9. Exercises

Try these yourself before looking at the examples.

1. Display your name.
2. Display three messages, each on its own line.
3. Display the number `500`.
4. Display the result of `20 + 30`.
5. Display the result of `100 - 45`.
6. Use `Console.Write()` to display two words on the same line.
7. Write a program that displays a simple receipt with two items and their total.

## 10. Mini Project — My Daily Expenses

Create a program that displays:

```text
DAILY EXPENSES
----------------
Breakfast: 100
Transport: 80
Lunch: 150
Total: 330
```

Requirements:

- Use `Console.WriteLine()` to display the headings and item descriptions.
- Calculate the total using `100 + 80 + 150`.
- Add comments explaining each instruction.
- Run your program and compare its output with the expected result.

## ✅ Completion Checklist

- [ ] I can display text using `Console.WriteLine()`.
- [ ] I can display numbers.
- [ ] I can perform calculations inside an output statement.
- [ ] I understand how `Console.Write()` works.
- [ ] I can explain the difference between `Write()` and `WriteLine()`.
- [ ] I completed the mini project without copying the entire solution.

## What Comes Next?

Continue to **C# Comments** to learn how to write notes inside your code that help you and other programmers understand it.

Remember: Running code proves that it executes. Explaining why it works proves that you are learning.
