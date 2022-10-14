using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            if (ch == 1)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Sum = {0}", c);
            }
            else if (ch == 2)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a - b;
                Console.WriteLine("Difference = {0}", c);
            }
            else if (ch == 3)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a * b;
                Console.WriteLine("Product = {0}", c);
            }
            else if (ch == 4)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Quotient = {0}", c);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.ReadLine();
        }
    }
}
