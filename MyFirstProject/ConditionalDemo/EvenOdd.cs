using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine(num + "is Even");
            }
            else
            {
                Console.WriteLine(num + "is odd");
            }
        }
    }
}
