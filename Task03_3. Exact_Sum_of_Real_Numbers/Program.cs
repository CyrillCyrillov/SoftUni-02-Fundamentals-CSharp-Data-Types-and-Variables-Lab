using System;

namespace Task03_3._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum = sum + decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);



        }
    }
}
