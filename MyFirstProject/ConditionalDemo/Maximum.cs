using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int num3 = int.Parse(Console.ReadLine());
            int max = 0;
            if(num1>num2)
            {
                if(num1>num3)
                {
                    max = num1;
                }
            }
            else if(num2>num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine("Greatest Number is=" + max);

        }
    }
}
