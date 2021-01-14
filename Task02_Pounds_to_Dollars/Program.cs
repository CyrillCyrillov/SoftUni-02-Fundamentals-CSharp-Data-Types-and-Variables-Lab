using System;

namespace Task02_Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double britushPounds = double.Parse(Console.ReadLine());
            Console.WriteLine($"{britushPounds * 1.31:f3}");
            */

            double num = double.Parse(Console.ReadLine());

            double result = num * 1.31;

            Console.WriteLine($"{result:f3}");
        }
    }
}
