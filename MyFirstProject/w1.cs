using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class w1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            if(n%2!=0)
            {
                Console.WriteLine("Weird");
            }else if(n%2==0)
                {
                for (int i = 2; i <= 5; i++)
                {
                    Console.WriteLine("Not Weird");

                }

                if (n%2==0)
                {
                    for(int i=6;i<=20;i++)
                    {
                        Console.WriteLine("Weird");
                    }
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
              

            }
           

        }
        
    }
}
