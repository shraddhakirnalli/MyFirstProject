﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Arithmetic
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int side1 = 4, side2 = 13, side3 = 15;
            Console.WriteLine($"Value of side1 = {side1}, side2 = {side2}, and side2 = {side2}");
            double semiperimeter = (side1 + side2 + side3) / 2;
            double Area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            Console.Write("Area of a Triangle = " + Area);
        }
    }
}
