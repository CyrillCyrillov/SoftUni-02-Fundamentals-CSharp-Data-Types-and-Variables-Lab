using System;

namespace Task09_Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string stringOfchars = first.ToString() + second.ToString() + third.ToString();


            Console.WriteLine(stringOfchars);
        }
    }
}
