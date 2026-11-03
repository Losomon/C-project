// C# Operators
// File: operators.cs

using System;

class Operators
{
    static void Main()
    {
        // 1. Arithmetic Operators
        int x = 10;
        int y = 3;

        Console.WriteLine("=== Arithmetic Operators ===");
        Console.WriteLine($"Addition: {x + y}");
        Console.WriteLine($"Subtraction: {x - y}");
        Console.WriteLine($"Multiplication: {x * y}");
        Console.WriteLine($"Division: {x / y}");
        Console.WriteLine($"Modulus: {x % y}");

        x++;
        Console.WriteLine($"Increment: {x}");

        y--;
        Console.WriteLine($"Decrement: {y}");

        // 2. Assignment Operators
        int number = 10;

        Console.WriteLine("\n=== Assignment Operators ===");
        Console.WriteLine($"Original Value: {number}");

        number += 5;
        Console.WriteLine($"Addition Assignment (+=): {number}");

        number -= 3;
        Console.WriteLine($"Subtraction Assignment (-=): {number}");

        number *= 2;
        Console.WriteLine($"Multiplication Assignment (*=): {number}");

        number /= 4;
        Console.WriteLine($"Division Assignment (/=): {number}");

        number %= 3;
        Console.WriteLine($"Modulus Assignment (%=): {number}");

        // 3. Comparison Operators
        int a = 10;
        int b = 5;

        Console.WriteLine("\n=== Comparison Operators ===");
        Console.WriteLine($"Equal to (==): {a == b}");
        Console.WriteLine($"Not Equal (!=): {a != b}");
        Console.WriteLine($"Greater than (>): {a > b}");
        Console.WriteLine($"Less than (<): {a < b}");
        Console.WriteLine($"Greater than or Equal (>=): {a >= b}");
        Console.WriteLine($"Less than or Equal (<=): {a <= b}");

        // 4. Logical Operators
        int age = 21;
        bool hasID = true;

        Console.WriteLine("\n=== Logical Operators ===");
        Console.WriteLine($"Logical AND (&&): {age >= 18 && hasID}");
        Console.WriteLine($"Logical OR (||): {age < 18 || hasID}");
        Console.WriteLine($"Logical NOT (!): {!hasID}");

        // 5. Practical Example: Even or Odd
        int evenOddNumber = 7;

        Console.WriteLine("\n=== Even or Odd ===");

        if (evenOddNumber % 2 == 0)
        {
            Console.WriteLine($"{evenOddNumber} is Even");
        }
        else
        {
            Console.WriteLine($"{evenOddNumber} is Odd");
        }

        // 6. Practical Example: Voting Eligibility
        int voterAge = 20;
        bool registered = true;

        Console.WriteLine("\n=== Voting Eligibility ===");

        if (voterAge >= 18 && registered)
        {
            Console.WriteLine("Eligible to vote");
        }
        else
        {
            Console.WriteLine("Not eligible to vote");
        }
    }
}