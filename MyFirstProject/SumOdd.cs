using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class SumOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while(n>0)
            {
                int s = n % 10;
                if(s%2!=0)
                {
                    sum += s;
                }
                n = n / 10;
            }
            Console.WriteLine(sum+" ");

            }
        }
    }

