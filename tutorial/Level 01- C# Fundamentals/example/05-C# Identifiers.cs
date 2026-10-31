using System;
namespace Identifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //good
            int minutesperHour=60;

              // OK, but not so easy to understand what m actually is
              int m=60;

              Console.WriteLine(minutesperHour);
              Console.WriteLine(m);
        }
    }
}