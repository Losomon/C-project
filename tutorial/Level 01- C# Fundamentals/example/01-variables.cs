using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "SOLO CS";
            int age = 20;
            double salary = 50000.01;
            string ranking = "A+";       
            bool isEmployed = true;     

            Console.WriteLine($"My name is {fullname}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"I earn {salary} per month");
            Console.WriteLine($"I have an {ranking} rank on GitHub");
            Console.WriteLine(isEmployed ? "Yes, I am employed" : "No, I am not employed");
        }
    }
}