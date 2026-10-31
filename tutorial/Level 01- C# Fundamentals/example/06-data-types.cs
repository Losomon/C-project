// C# Data Types
// File: data-types.cs

using System;

class DataTypes
{
    static void Main()
    {
        // 1. Integer Types
        int myNum = 100000;
        long myLongNum = 15000000000L;

        Console.WriteLine("Integer Types:");
        Console.WriteLine($"int: {myNum}");
        Console.WriteLine($"long: {myLongNum}");

        // 2. Floating-Point Types
        float myFloatNum = 5.75F;
        double myDoubleNum = 19.99D;
        decimal myDecimalNum = 2500.50m;

        Console.WriteLine("\nFloating-Point Types:");
        Console.WriteLine($"float: {myFloatNum}");
        Console.WriteLine($"double: {myDoubleNum}");
        Console.WriteLine($"decimal: {myDecimalNum}");

        // 3. Scientific Numbers
        float f1 = 35e3F;
        double d1 = 12E4D;

        Console.WriteLine("\nScientific Numbers:");
        Console.WriteLine($"float: {f1}");
        Console.WriteLine($"double: {d1}");

        // 4. Boolean Type
        bool isCSharpFun = true;
        bool isFishTasty = false;

        Console.WriteLine("\nBoolean Types:");
        Console.WriteLine($"Is C# fun? {isCSharpFun}");
        Console.WriteLine($"Is fish tasty? {isFishTasty}");

        // 5. Character Type
        char myLetter = 'D';
        char myGrade = 'A';

        Console.WriteLine("\nCharacter Types:");
        Console.WriteLine($"Letter: {myLetter}");
        Console.WriteLine($"Grade: {myGrade}");

        // 6. String Type
        string greeting = "Hello World";
        string firstName = "John";
        string lastName = "Doe";

        Console.WriteLine("\nString Types:");
        Console.WriteLine($"Greeting: {greeting}");
        Console.WriteLine($"Full Name: {firstName} {lastName}");

        // 7. String Interpolation
        int age = 20;
        string name = "John";

        Console.WriteLine(
            $"\nMy name is {name} and I am {age} years old."
        );

        // 8. Boolean Conditional Example
        bool isLoggedIn = true;

        if (isLoggedIn)
        {
            Console.WriteLine("Welcome back!");
        }
        else
        {
            Console.WriteLine("Please log in.");
        }
    }
}
