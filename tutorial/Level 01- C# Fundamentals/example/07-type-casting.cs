// C# Type Casting
// File: type-casting.cs

using System;

class TypeCasting
{
    static void Main()
    {
        // 1. Implicit Casting
        int myInt = 9;
        double myDouble = myInt;

        Console.WriteLine("=== Implicit Casting ===");
        Console.WriteLine($"Integer: {myInt}");
        Console.WriteLine($"Double: {myDouble}");

        // 2. Explicit Casting
        double number = 9.78;
        int convertedNumber = (int)number;

        Console.WriteLine("\n=== Explicit Casting ===");
        Console.WriteLine($"Original Double: {number}");
        Console.WriteLine($"Converted Integer: {convertedNumber}");

        // 3. Convert Methods
        int age = 21;
        double price = 5.25;
        bool isStudent = true;

        Console.WriteLine("\n=== Type Conversion Methods ===");
        Console.WriteLine($"Integer to String: {Convert.ToString(age)}");
        Console.WriteLine($"Integer to Double: {Convert.ToDouble(age)}");
        Console.WriteLine($"Double to Integer: {Convert.ToInt32(price)}");
        Console.WriteLine($"Boolean to String: {Convert.ToString(isStudent)}");

        // 4. Character to Integer
        char myLetter = 'A';
        int characterCode = myLetter;

        Console.WriteLine("\n=== Character Conversion ===");
        Console.WriteLine($"Character: {myLetter}");
        Console.WriteLine($"Unicode Value: {characterCode}");

        // 5. Comparing Explicit Casting and Convert.ToInt32()
        double myNumber = 9.78;

        int castResult = (int)myNumber;
        int convertResult = Convert.ToInt32(myNumber);

        Console.WriteLine("\n=== Casting vs Convert ===");
        Console.WriteLine($"Explicit Casting: {castResult}");
        Console.WriteLine($"Convert.ToInt32(): {convertResult}");

        // 6. Implicit Casting with Different Numeric Types
        int smallNumber = 100;
        long largeNumber = smallNumber;
        float floatNumber = largeNumber;
        double doubleNumber = floatNumber;

        Console.WriteLine("\n=== Numeric Conversion ===");
        Console.WriteLine($"Int: {smallNumber}");
        Console.WriteLine($"Long: {largeNumber}");
        Console.WriteLine($"Float: {floatNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
    }
}