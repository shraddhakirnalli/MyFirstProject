using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class D2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            int s=1;
            int d;
            int count = 0;
            int temp = num;
            int org = num;
            
            while(num>0)
            {
                d = num % 10;
                
                num = num /10;
                count++;

            }
            Console.WriteLine(count);
            num = temp;
            int power = 1;
            int Base = 10;
            
            s = num * num;
            for(int i=1;i<=count;i++)
            {
                power = power * Base;

            }
            
            int last = s % power;
            
            Console.WriteLine(s);
            if(num==last)
            {
                Console.WriteLine("Automorphic");

            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }
        }
    }
}
