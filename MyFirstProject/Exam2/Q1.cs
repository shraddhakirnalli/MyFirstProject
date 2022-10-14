using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam2
{
    class Q1
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);

            }
        }

    class Q2
    {
        static void Main(string[] args)
        {
            int i = 1,k = 1;
            while(i++<=5)
            {
                k *= i;
            }
            Console.WriteLine("k=" +k+ "i=" +i);
        }
    }
    }

