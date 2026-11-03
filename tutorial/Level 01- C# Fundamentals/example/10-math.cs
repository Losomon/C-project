
// C# Math
// File: math.cs

using System;

class MathMethods
{
    static void Main()
    {
        // 1. Math.Max() - Returns the highest value
        int maxNumber = Math.Max(5, 10);

        Console.WriteLine("=== Math.Max() ===");
        Console.WriteLine($"Highest Value: {maxNumber}");

        // 2. Math.Min() - Returns the lowest value
        int minNumber = Math.Min(5, 10);

        Console.WriteLine("\n=== Math.Min() ===");
        Console.WriteLine($"Lowest Value: {minNumber}");

        // 3. Math.Sqrt() - Returns the square root
        double squareRoot = Math.Sqrt(64);

        Console.WriteLine("\n=== Math.Sqrt() ===");
        Console.WriteLine($"Square Root of 64: {squareRoot}");

        // 4. Math.Abs() - Returns the absolute (positive) value
        double absoluteValue = Math.Abs(-4.7);

        Console.WriteLine("\n=== Math.Abs() ===");
        Console.WriteLine($"Absolute Value: {absoluteValue}");

        // 5. Math.Round() - Rounds to the nearest whole number
        double roundedNumber = Math.Round(9.99);

        Console.WriteLine("\n=== Math.Round() ===");
        Console.WriteLine($"Rounded Number: {roundedNumber}");

        // 6. Additional Math Methods

        // Math.Pow() - Raises a number to a power
        double power = Math.Pow(2, 3);

        // Math.Ceiling() - Rounds up
        double roundedUp = Math.Ceiling(4.2);

        // Math.Floor() - Rounds down
        double roundedDown = Math.Floor(4.8);

        Console.WriteLine("\n=== Additional Math Methods ===");
        Console.WriteLine($"2 to the power of 3: {power}");
        Console.WriteLine($"Rounded Up: {roundedUp}");
        Console.WriteLine($"Rounded Down: {roundedDown}");

        // 7. Practical Example: Finding the Larger Number
        int number1 = 25;
        int number2 = 40;

        Console.WriteLine("\n=== Comparing Numbers ===");
        Console.WriteLine($"Number 1: {number1}");
        Console.WriteLine($"Number 2: {number2}");
        Console.WriteLine($"Larger Number: {Math.Max(number1, number2)}");

        // 8. Practical Example: Calculating Square Root
        double number = 144;

        Console.WriteLine("\n=== Square Root Calculator ===");
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Square Root: {Math.Sqrt(number)}");
    }
}
