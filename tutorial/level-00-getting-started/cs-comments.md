# C# Comments — Writing Notes Inside Your Code

Welcome to the next lesson!

In this lesson, you will learn how to write notes inside your C# programs to explain what the code does.

## 🎯 Learning Objectives

By the end of this lesson, you should be able to:

- Explain what a comment is.
- Write single-line comments using `//`.
- Write multi-line comments using `/* */`.
- Write comments at the end of a line of code.
- Temporarily disable code while testing.
- Write useful comments that help other programmers understand your work.

## 1. What Is a Comment?

A comment is a note written inside your code for people to read.

Imagine writing instructions for a child to follow. You might add a note explaining why a particular step is important.

Programmers use comments for the same reason: to explain code, record important decisions, or make complicated sections easier to understand.

C# ignores comments when compiling your program.

## 2. Single-Line Comments

A single-line comment starts with two forward slashes: `//`.

Everything after `//` on that line is treated as a comment.

### Example

```csharp
// Display a greeting on the screen.
Console.WriteLine("Hello, World!");
```

### Output

```text
Hello, World!
```

### Explanation

- `//` tells C# that the rest of the line is a comment.
- `Display a greeting on the screen.` explains the instruction to a human.
- `Console.WriteLine()` is the actual instruction that runs.

Think of `//` as saying, "This is a note for the programmer, not an instruction for the computer."

## 3. Comments at the End of a Line

You can also put a comment after an instruction.

```csharp
Console.WriteLine("Hello, World!"); // Display a greeting.
```

### Output

```text
Hello, World!
```

The computer executes `Console.WriteLine()` and ignores the comment.

You do not have to put every comment on a separate line.

## 4. Multi-Line Comments

Sometimes you need more than one line to explain something.

C# supports multi-line comments using `/*` to begin and `*/` to end the comment.

### Example

```csharp
/*
This program displays a greeting.
It then displays a second message.
The notes in this block are ignored by C#.
*/

Console.WriteLine("Hello, World!");
Console.WriteLine("I am learning C#.");
```

### Output

```text
Hello, World!
I am learning C#.
```

Everything between `/*` and `*/` is treated as a comment.

**Important:** Close the comment with `*/`. If you forget the closing marker, your code may produce a compilation error or cause later code to be treated as part of the comment.

## 5. Single-Line vs Multi-Line Comments

| Feature        | Single-line           | Multi-line                             |
| -------------- | --------------------- | -------------------------------------- |
| Opening symbol | `//`                  | `/*`                                   |
| Closing symbol | End of line           | `*/`                                   |
| Best use       | Short notes           | Longer explanations                    |
| Example        | `// Print a greeting` | `/* Print a greeting to the screen */` |

Use whichever form makes the explanation clear.

## 6. Using Comments to Disable Code

Comments can help you test a program by temporarily preventing a line from running.

### Example

```csharp
Console.WriteLine("First message.");

// Console.WriteLine("Second message.");

Console.WriteLine("Third message.");
```

### Output

```text
First message.
Third message.
```

The second instruction does not run because it has been turned into a comment.

This is useful when testing different versions of a program.

**Warning:** Commenting out code is not the same as deleting it. The original instruction remains in the file.

## 7. Writing Good Comments

Comments should explain something useful. They should not simply repeat the code.

### Weak comment

```csharp
// Print Hello.
Console.WriteLine("Hello!");
```

This is not wrong, but the code is already easy to understand.

### More useful comment

```csharp
// Show a welcome message before displaying the menu.
Console.WriteLine("Welcome to the shop!");
```

This explains the purpose of the message in the program.

As your projects become larger, useful comments should explain **why** a decision was made when that reason is not obvious.

Avoid writing a comment for every single line if the code is already clear.

## 8. Mini Project — A Commented Introduction

Create this program in your `Program.cs` file:

```csharp
// This program introduces me to the computer.

// Display a greeting.
Console.WriteLine("Hello!");

// Display information about my learning.
Console.WriteLine("I am learning C#.");

/*
This is a multi-line comment.
It explains that I am practising
how to write readable code.
*/

// Display my final message.
Console.WriteLine("I will keep practising.");
```

### Expected output

```text
Hello!
I am learning C#.
I will keep practising.
```

Notice that none of the comments appear in the output.

## 9. Exercises

Complete these tasks without copying the mini project.

1. Write a single-line comment above a `Console.WriteLine()` statement.
2. Add a comment at the end of a statement.
3. Write a multi-line comment containing three lines.
4. Comment out one output statement and observe what happens.
5. Write a program with three messages and explain the purpose of the program in a comment.
6. Explain why comments do not appear in the console output.

## 10. Common Mistakes

### Mistake 1: Using one slash

```csharp
/ This is not a valid C# comment
```

Correct version:

```csharp
// This is a valid C# comment
```

### Mistake 2: Forgetting to close a multi-line comment

```csharp
/*
This comment has no closing marker.
```

Correct version:

```csharp
/*
This comment is properly closed.
*/
```

### Mistake 3: Expecting comments to display on the screen

```csharp
// Hello!
```

This produces no output. To display text, use:

```csharp
Console.WriteLine("Hello!");
```

## ✅ Completion Checklist

- [ ] I understand what comments are.
- [ ] I can write single-line comments.
- [ ] I can write multi-line comments.
- [ ] I can add a comment at the end of a statement.
- [ ] I can temporarily disable code with comments.
- [ ] I know how to write useful comments.
- [ ] I completed the exercises.

## What Comes Next?

Continue to **C# Variables**.

You will learn how a program stores information, such as a person's name, age, or the price of an item.

Remember: comments explain your code, but clear code and correct logic are still your responsibility.
