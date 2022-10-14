using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Reverse
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }


    class Odd
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Even
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=20;i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }

    class Base
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base:");
            int basee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Exponent");
            int exponent = int.Parse(Console.ReadLine());
            int power = 1;
           
            for(int i=1;i<=exponent;i++)
            {
                power = power * basee;
                Console.WriteLine(power);
            }
        }
    }
    
    class Factorial
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Number:");
            int a= int.Parse(Console.ReadLine());
            int fact = 1;
            for( int i=1;i<=a;i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);

        }
    }

    class Task1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("The sum of first 10 numbers is :");
            for(int i=1;i<=10;i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);

            }
        }
    }
    class AddEven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("The Sum of Even Numbers is:");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i=2;i<=10;i+=2)
            {
                sum +=  i;
                
            }
            Console.WriteLine(sum);

        }
    }
}

