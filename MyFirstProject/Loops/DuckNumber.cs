using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class DuckNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int org = num;
            bool duck = true;
            while(num>0)
            {
                if(num%10==0)
                {
                    duck = false;
                    break;
                }
                num = num / 10;
            }
            if(org>0 || duck==false)
            {

            }

        }
    }
}
