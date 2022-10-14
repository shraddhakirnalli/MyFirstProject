using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Arithmetic
{
    class equilateral
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Length of Side:\t");
            float side = float.Parse(Console.ReadLine());

            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;

            Console.WriteLine("Area of Equilateral Triangle is:\t" + area);
        }
    }
}
