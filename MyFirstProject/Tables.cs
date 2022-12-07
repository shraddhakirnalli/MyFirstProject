using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Tables1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+" ");
                for (int j = 1; j <= 10; j++)
                {
                    if (i > 0) Console.Write(i * j+" \t ");
                    else Console.Write(j + " \t ");
                }
                Console.Write(" \n ");
            }
            Console.WriteLine();
        }
    }
}
