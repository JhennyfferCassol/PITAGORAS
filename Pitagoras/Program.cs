﻿using System;

namespace Pitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, area, perimetro, diagonal;
            b = double.Parse(Console.ReadLine());
            a = double.Parse(Console.ReadLine());

            area = b * a;
            perimetro = 2 * b + 2 * a;
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4"));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"));

            Console.ReadLine();

        }
    }
}
