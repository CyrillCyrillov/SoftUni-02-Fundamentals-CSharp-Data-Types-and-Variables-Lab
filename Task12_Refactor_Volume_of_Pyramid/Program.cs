﻿using System;

namespace Task11_Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //double dul, sh, V = 0;
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            
            
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            
            
            double volume = (lenght * width ) * height / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");

        }
    }
}
