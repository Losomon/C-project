using System;

namespace DisplayVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="john";
            string firstname="solo";
            string lastname="cs";
            string fullname=firstname + " " + lastname;
            int x = 5;
            int y = 6;

            Console.WriteLine($"hello {name}");

            Console.Write($"My Name is{fullname}");
            Console.WriteLine(x + y); // Print the value of x + y

        }
    }
}
