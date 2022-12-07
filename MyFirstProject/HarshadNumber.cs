using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class HarshadNumber
    {
        static void Main(string[] args)
        {
            int num = 0;
            int rem = 0;
            int sum = 0;
            
            
            Console.WriteLine("Enter the Number:");
            num = int.Parse(Console.ReadLine());
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
                Console.WriteLine(sum);
            }
            if(num%sum==0)
            {
                Console.WriteLine(num+"is a harshad number:");
            }
            else
            {
                Console.WriteLine(num+"is not a harshad number:");
            }
            
        }
        


    }
}
