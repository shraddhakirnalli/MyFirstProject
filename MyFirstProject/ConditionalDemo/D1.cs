using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{
    class D1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age:");
            int age = int.Parse(Console.ReadLine());
            if((age>13) && (age<=19))
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Not a Teenager");
            }
        }
    }
}
