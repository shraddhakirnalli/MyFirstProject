using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class P11
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int k=1;k<=i;k++)
                {
                    Console.Write(" ");
                }
                for(int j=4;j>=i;j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
