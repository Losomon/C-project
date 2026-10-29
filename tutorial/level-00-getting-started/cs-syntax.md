# C# Syntax — Understanding the Rules of C#

Welcome to the second lesson!

In this lesson, you will learn how C# code is organized and how to explain its structure to someone who has never programmed before.

## 🎯 Learning Objectives

By the end of this lesson, you should understand:

- What C# syntax means.
- What `using System;` does.
- What a `namespace` is.
- What a `class` is.
- What the `Main()` method does.
- What curly braces `{}` mean.
- Why semicolons `;` matter.
- Why C# is case-sensitive.

## 1. What Is Syntax?

Syntax means the rules for writing instructions in a programming language.

Think of the English language. We arrange words according to grammar rules so that people can understand us.

C# also has rules. If you break certain rules, your program may fail to compile.

For example:

**Correct code:**

```csharp
Console.WriteLine("Hello!");
```

**Incorrect code:**

```csharp
Console.WriteLine("Hello!")
```

The second example is missing a semicolon. In this context, the compiler reports an error.

## 2. Your First Traditional C# Program

Open `Program.cs`. The following is the traditional structure you will encounter in many C# tutorials.

```csharp
// Import tools from the System namespace.
using System;

// Organize related code under the HelloWorld namespace.
namespace HelloWorld
{
    // Define a class named Program.
    class Program
    {
        // This is the traditional entry point of the program.
        static void Main(string[] args)
        {
            // Display a message on the screen.
            Console.WriteLine("Hello, World!");
        }
    }
}
```

### Expected output

```text
Hello, World!
```

**Important:** Your modern .NET project may use top-level statements, which allow you to write `Console.WriteLine("Hello, World!");` without the traditional class and `Main()` method. Both approaches are valid. This lesson shows the traditional structure so you can recognize it when you see it.

## 3. Understand Each Part

### A. `using System;`

```csharp
using System;
```

This makes types in the `System` namespace available by their short names when applicable.

Think of `System` as a toolbox. The `using` directive makes it easier to refer to tools inside that toolbox.

Without the directive, you can write:

```csharp
System.Console.WriteLine("Hello!");
```

### B. `namespace HelloWorld`

```csharp
namespace HelloWorld
{
    // Related code belongs here.
}
```

A namespace groups related types and helps prevent naming conflicts.

Think of it as a labeled folder that helps organize your code.

### C. `class Program`

```csharp
class Program
{
    // Class members belong here.
}
```

A class defines a type that can contain data and methods.

Think of a class as a blueprint describing what an object can contain or do.

A class is not required in every C# program because modern C# supports top-level statements.

### D. Curly braces `{}`

```csharp
{
    Console.WriteLine("Hello!");
}
```

Curly braces mark a block of code in this example.

Think of them as the beginning and end of a container holding related instructions.

The opening brace `{` begins the block, and the closing brace `}` ends it.

### E. `static void Main(string[] args)`

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Hello!");
}
```

In this traditional example, `Main()` is the entry point: execution begins there.

Here is a simple explanation of each word:

- `static` — the method belongs to the class rather than requiring an object instance.
- `void` — the method does not return a value.
- `Main` — the method's name.
- `string[] args` — an array of text values that can contain command-line arguments.

You do not need to memorize all these details immediately. For now, remember that `Main()` is where execution begins in this traditional program structure.

### F. `Console.WriteLine()`

```csharp
Console.WriteLine("Hello, World!");
```

This displays the text inside the quotation marks and then moves to the next line.

The text `"Hello, World!"` is a string.

### G. Semicolon `;`

```csharp
Console.WriteLine("Hello!");
```

The semicolon marks the end of this statement.

Many C# statements require semicolons, although not every line of C# code does.

### H. Blank lines and indentation

```csharp
Console.WriteLine("First message.");

Console.WriteLine("Second message.");
```

C# generally ignores blank lines between statements. Indentation also helps people read code but usually does not determine the meaning of the statements.

Good formatting makes code easier to maintain and explain.

## 4. C# Is Case-Sensitive

C# distinguishes between uppercase and lowercase letters.

For example:

```csharp
Console.WriteLine("Hello!");
```

This is correct.

```csharp
console.WriteLine("Hello!");
```

This will normally produce an error because `console` and `Console` are different identifiers, and there is no standard lowercase `console` variable defined here.

Remember to spell names with the correct capitalization.

## 5. Does the File Name Have to Match the Class Name?

Not necessarily.

A file named `Program.cs` can contain a class named `School`.

```csharp
class School
{
}
```

C# does not generally require the file name to match the class name, although matching them is a common convention that helps keep projects organized.

## 6. Practice: Change the Program

Modify your existing `Program.cs` to display three messages.

```csharp
// Display the first message.
Console.WriteLine("Welcome to C#.");

// Display the second message.
Console.WriteLine("I am learning syntax.");

// Display the third message.
Console.WriteLine("I can explain my code.");
```

Run the program from your `HelloWorld` directory:

```powershell
dotnet run
```

Expected output:

```text
Welcome to C#.
I am learning syntax.
I can explain my code.
```

## 7. Exercises

Try these without copying the answers from above.

1. Write a program that displays your name.
2. Add a comment explaining what each output statement does.
3. Remove a semicolon and observe the error.
4. Change `Console` to `console` and observe the error.
5. Write the traditional `Main()` program structure and explain the purpose of its main parts.
6. Explain the difference between a comment and an instruction that the computer executes.

## 8. Mini Project — My Introduction

Write a program that displays:

```text
Hello!
I am learning C# syntax.
I understand that code has rules.
I will practise until I understand.
```

Your challenge is to write the program yourself and add comments that explain each instruction.

## ✅ Completion Checklist

- [ ] I understand what syntax means.
- [ ] I can use `Console.WriteLine()`.
- [ ] I understand the purpose of `using System;`.
- [ ] I can explain what a namespace and class are.
- [ ] I understand the traditional `Main()` method.
- [ ] I know what curly braces and semicolons do.
- [ ] I understand that C# is case-sensitive.
- [ ] I completed the mini project.

## What Comes Next?

Continue to **C# Output**, where you will practise displaying text, numbers, and multiple messages using `Console.Write()` and `Console.WriteLine()`.

Do not move forward just because the code runs. Move forward when you can explain what the important parts do.
