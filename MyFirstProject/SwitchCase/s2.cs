using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.SwitchCase
{
    class s2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Choice");
            char ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'R': Console.WriteLine("Area of Rectangle is");
                    Console.WriteLine("Enter the Length of a Rectangle: ");
                    int Length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Breadth of a Rectangle: ");
                    int Breadth = Convert.ToInt32(Console.ReadLine());
                    int Area = Length * Breadth;
                    Console.WriteLine($"Area of Length {Length} and Breadth {Breadth} Rectangle is {Area}");
                    break;

                case 'T': Console.WriteLine("Area of Triangle is");
                    int side1 = 4, side2 = 13, side3 = 15;
                    Console.WriteLine($"Value of side1 = {side1}, side2 = {side2}, and side2 = {side2}");
                    double semiperimeter = (side1 + side2 + side3) / 2;
                    double area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
                    Console.Write("Area of a Triangle = " + area);
                    break;




            }
        }
    }
}
