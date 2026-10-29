//==============================================
// LEVEL 00 - GETTING STARTED
//TOPICS:Get Started,syntax,comments and outputs
//==============================================


// TOPIC: Get Started
//Using System; is a directive that allows you to use classes from the System namespace, which contains fundamental classes for basic operations in C#.
// without writing system.console every time you want to use a class from the System namespace.

using System;

//A namespace is a way to organize code and prevent naming conflicts. It allows you to group related classes, interfaces, and other types together under a common name. In this case, the namespace is named HelloWorld, which indicates that the code within it is related to the HelloWorld application.
namespace HelloWorld
{
    //A class is a blueprint for creating objects in object-oriented programming. It defines the properties and behaviors that objects of that class will have. In this case, the class is named Program, which is a common convention for the main entry point of a C# application.
    class Program
    {
        // Main method is the entry point of a C# console application. It is where the program starts executing. The Main method is defined as static, which means it can be called without creating an instance of the Program class. It takes an array of strings (args) as a parameter, which can be used to pass command-line arguments to the program.
        //Execution begins here
        //static means that the method belongs to the class itself rather than an instance of the class. This allows the Main method to be called without creating an object of the Program class.
        //void indicates that the Main method does not return any value. It is a common convention for the entry point of a C# application to have a void return type.
        //strings []args can hold command-line arguments
        static void Main(string[]args)
        {
            //-------------------------------------
            //TOPIC 1:GET STARTED
            //-------------------------------------

            // Display our first message.
            Console.WriteLine("Hello, World!");

            //----------------------------------------
            // TOPIC 2:C# SYBTAX
            //----------------------------------------

            // C# syntax follows rules.
            // Statements commonly end with a semicolon.
            Console.WriteLine("I am learning C# syntax.");

            // C# is case-sensitive.
            // Console and console are not interchangeable.

            // ------------------------------------------
            // TOPIC 3: C# OUTPUT
            // ------------------------------------------

            // WriteLine displays text and starts a new line.
            Console.WriteLine("First line");
            Console.WriteLine("Second line");

            // Write displays text without starting a new line.
            Console.Write("Hello, ");
            Console.Write("learner!");
            Console.WriteLine();

            // Numbers can be displayed without quotation marks.
            Console.WriteLine(25);

            // C# calculates expressions before displaying results.
            Console.WriteLine(3 + 3);
            Console.WriteLine(10 - 4);
            Console.WriteLine(5 * 2);
            Console.WriteLine(12 / 3);

            // ------------------------------------------
            // TOPIC 4: C# COMMENTS
            // ------------------------------------------

            // This is a single-line comment.

            /*
             This is a multi-line comment.
             It can explain an idea using several lines.
             The computer ignores this comment.
            */

            Console.WriteLine("Comments help humans understand code.");

            // The following instruction is commented out.
            // Console.WriteLine("This message will not appear.");

            // End of Level 00 demonstration.
        }
    }
}