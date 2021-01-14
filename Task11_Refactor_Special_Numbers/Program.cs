using System;

namespace Task12_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //int obshto = 0;
            //int takova = 0;
            //bool toe = false;
            for (int i = 1; i <= number; i++)
            {
                int nextNumber = i;
                int sum = 0;
                while (nextNumber > 0)
                {
                   sum += nextNumber % 10;
                    nextNumber = nextNumber / 10;
                }
                
                if(sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }

        }
    }
}
