using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Fact
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number:");
            num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class check
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    
                    Console.WriteLine(i);

                }
                else if(i%2!=0)
                {
                    i *= i;
                    Console.WriteLine(i);
                    
                }
                
            }
        }
    }
}
