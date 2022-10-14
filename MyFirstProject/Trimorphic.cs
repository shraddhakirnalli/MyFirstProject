using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            int c;
            int rem;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;

            c = num * num * num;
            rem = c % 10;

            if(temp==rem)
            {
                Console.WriteLine("trimorphic");
            }
            else
            {
                Console.WriteLine("not a trimorphic");
            }

            
            }
        }
    }


