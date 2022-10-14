using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Spy
    {
        static void Main(string[] args)
        {
            int n, sum = 0, temp=1;
            
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());

            while(n>0)
            {
                n = n % 10;
                sum += n;
                temp *= n;
                
            }
            if(n==temp)
            {
                Console.WriteLine("Number is spy");

            }
            else
            {
                Console.WriteLine("Number is not spy");
            }


        }
    }
}
