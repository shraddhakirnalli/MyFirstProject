using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class D1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int n = int.Parse(Console.ReadLine());
            int org = n;
            int Base = 1;
            int count = 0;
            int sum = 0;

            while (n > 0)
            {

                int rem = n % 10;
                Base = rem;
                n = n / 10;
                count++;
            }
            Console.WriteLine(count);
            n = org;
            while (n > 0)
            {
                int power = 1;
                int r = n % 10;
                for (int i = 1; i <= count; i++)
                {
                    power = power * r;

                }
                sum = sum + power;
                count--;
                n = n / 10;


            }
            Console.WriteLine(sum);

            Console.WriteLine(org);
            if(org==sum)
            {
                Console.WriteLine("Desarium");
            }
            else
            {
                Console.WriteLine("Not Desarium");
            }
        }



    }
}

