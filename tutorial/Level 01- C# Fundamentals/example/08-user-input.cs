using  System;
namespace userInput {

class Program
{
    static void Main(string []args){

        Console.WriteLine("Enter Username");
        string username = Console.ReadLine();
        Console.WriteLine("Hello, " + username);

        Console.WriteLine("Enter Age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You are " + age + " years old.");

        Console.WriteLine("Enter your height in meters (e.g., 1.75):");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You are " + height + " meters tall.");
        
    }

  }


}