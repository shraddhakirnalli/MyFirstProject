using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class WhileDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;
            while (number != 1)
            {
                fact = fact * number;
                number = number - 1;
            }

            Console.Write(fact);
            Console.ReadLine();
        }
    }

    class WhilePrime
    {
        static void Main(string[] args)
        {
            int num, i, f;

            

            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            f = 0;
            i = 2;
            while (i <= num / 2)
            {
                if (num % i == 0)
                {
                    f = 1;
                    break;
                }
                i++;
            }
            if (f == 0)
                Console.WriteLine(num + " is a Prime Number");
            else
                Console.WriteLine(num + " is not a Prime Number");
        }
    }
}
