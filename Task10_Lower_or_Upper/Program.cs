using System;

namespace Task10_Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if(64 <= input && input <= 90)
            {
                Console.WriteLine("upper-case");
            }

            if (97 <= input && input <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
