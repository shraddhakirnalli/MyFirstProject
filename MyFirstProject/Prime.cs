using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Prime
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i % j == 0)
                        count++;

                }
                if (count == 1)
                {

                    Console.WriteLine(i);
                }
                count = 0;
            }

            Console.WriteLine();
        }
    }
}
    

