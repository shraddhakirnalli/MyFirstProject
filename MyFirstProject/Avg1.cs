using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Avg1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0;
            int sum = 0;
            int count = 0;
            while(n>0)
            {
                
                 t = n % 10;
                
                n = n / 10;
                Console.WriteLine(t);
                sum = sum + t;
                count++;
                 
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
            
        }
    }
}
