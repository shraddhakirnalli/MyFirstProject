using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class L2
    {
        static void Main(string[] args)
        {
            for(int num=1;num<=10;num++)
            {
                bool isPrime = true;
                for(int i=2;i<num;i++)
                {
                    if(num%i==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime==true)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }

        //write code to display table btwn 1 to 5

    class Tables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n*i);
            }

        }
    }

    class k1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num>0)
            {
                int n = num % 10;
                int fact = 1;
                for(int i=1;i<=n;i++)
                {
                    fact = fact * i;

                }
                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
