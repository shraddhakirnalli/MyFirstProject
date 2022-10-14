using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Arithmetic
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of a Rectangle: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of a Rectangle: ");
            int Breadth = Convert.ToInt32(Console.ReadLine());
            int Area = Length * Breadth;
            Console.WriteLine($"Area of Length {Length} and Breadth {Breadth} Rectangle is {Area}");
        }
    }
}
