using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{
    class DivisibilityCheck
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number :");
            n = int.Parse(Console.ReadLine());
            if (n % 5 == 0)
            {
                Console.WriteLine("Entered Number is Divisible by 5 ");
            }
            else
            {
                Console.WriteLine("Entered Number is Not Divisible by 5");
            }
            if (n % 11 == 0)
            {
                Console.WriteLine("Entered Number is Divisible by 11");
            }
            else
            {
                Console.WriteLine("Entered Number is Not Divisible by 11");
            }
            Console.ReadLine();
        }
    }
}
