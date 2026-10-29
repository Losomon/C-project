# Level 00 — Getting Started with C#

Welcome to your first C# lesson!

In this level, you will learn how to create, run, and understand your first C# program.

You do not need to understand everything immediately. Read each explanation, run the code, and experiment with it.

## 🎯 Learning Objectives

By the end of this lesson, you should be able to:

- Understand what C# is.
- Understand what a program does.
- Recognize the basic structure of a C# program.
- Print messages on the screen using `Console.WriteLine()`.
- Run a C# program and observe its output.
- Explain what each line of your first program does.

## 1. What Is C#?

C# (pronounced "C-sharp") is a programming language.

A programming language allows us to give instructions to a computer.

For example, we can tell a computer to:

- Display a message.
- Add two numbers.
- Ask someone for their name.
- Build a game.
- Create a website or business application.

Think of programming as giving instructions to a very fast machine that follows instructions according to the rules of the language.

## 2. What Is a Program?

A program is a set of instructions that a computer runs to perform a task.

Imagine telling a robot:

1. Walk forward.
2. Pick up a book.
3. Put the book on a table.

Those are instructions. A computer program works similarly, except the instructions must be written in a language the computer can process.

## 3. Your First C# Program

Open `Program.cs` and write the following code:

```csharp
// This program displays a message on the screen.

Console.WriteLine("Hello, World!");
```

### Expected Output

```text
Hello, World!
```

Congratulations! You have written your first C# program.

## 4. Understanding the Code

### `Console.WriteLine("Hello, World!");`

Let's break this instruction into smaller pieces.

- `Console` — gives us access to the console, where text can be displayed.
- `WriteLine` — displays text and then moves to a new line.
- `("Hello, World!")` — tells the computer which message to display.
- `"Hello, World!"` — the text we want to display. Text surrounded by double quotation marks is called a string.
- `;` — marks the end of this C# statement.

Think of `Console.WriteLine()` as telling the computer:

"Please write this message on the screen, then move to the next line."

## 5. Why Do We Use Comments?

A comment is a note written inside your code for people to read.

Example:

```csharp
// This line prints a greeting.
Console.WriteLine("Hello!");
```

The computer ignores the comment when compiling your program. It executes the actual instruction instead.

In C#, `//` starts a single-line comment.

Use comments to explain why something happens or to help another person understand your code.

## 6. Display Multiple Messages

Try this program:

```csharp
// Display the first message.
Console.WriteLine("Hello!");

// Display the second message.
Console.WriteLine("I am learning C#.");

// Display the third message.
Console.WriteLine("Programming is giving instructions to a computer.");
```

### Expected Output

```text
Hello!
I am learning C#.
Programming is giving instructions to a computer.
```

Each `Console.WriteLine()` displays its message on a separate line.

## 7. What Is a Semicolon?

In C#, a semicolon (`;`) usually marks the end of a statement.

Correct:

```csharp
Console.WriteLine("Hello!");
```

Incorrect:

```csharp
Console.WriteLine("Hello!")
```

The second example is missing a semicolon and will produce a compilation error in this context.

Remember: statements usually need to end with a semicolon.

## 8. Your First Experiments

Do not just copy the examples. Change them.

**Experiment 1:** Replace `Hello!` with your own greeting.

**Experiment 2:** Print your name.

**Experiment 3:** Display three different messages.

**Experiment 4:** Remove a semicolon and run the program. Read the error, then fix it.

**Experiment 5:** Change `WriteLine` to `Write` and observe the difference.

Example:

```csharp
Console.Write("Hello ");
Console.Write("there!");
```

Output:

```text
Hello there!
```

`Write()` displays text without automatically moving to a new line. `WriteLine()` displays text and then moves to a new line.

## 9. Practice Questions

Answer these questions without looking at the explanations.

1. What is C#?
2. What is a computer program?
3. What does `Console.WriteLine()` do?
4. Why do we put text inside double quotation marks?
5. What does `//` mean?
6. Why is the semicolon important?
7. What is the difference between `Write()` and `WriteLine()`?

## 10. Mini Project — My Introduction

Create a program that introduces you to the computer.

Your program must display:

- A greeting.
- Your name.
- The programming language you are learning.
- One reason you want to learn programming.

Example output:

```text
Hello!
My name is Alex.
I am learning C#.
I want to build useful software.
```

Write the code yourself, then run it.

## ✅ Level 00 Completion Checklist

- [ ] I understand what C# is.
- [ ] I can create and run a C# program.
- [ ] I understand `Console.WriteLine()`.
- [ ] I can write comments using `//`.
- [ ] I understand strings and quotation marks.
- [ ] I understand why statements use semicolons.
- [ ] I have completed the mini project.

## What Comes Next?

After completing this lesson, continue to **Level 01 — Fundamentals**.

You will learn about variables, data types, numbers, text, and how to store information in a program.

**Remember:** A good programmer does not merely memorize code. A good programmer understands what the code tells the computer to do.
