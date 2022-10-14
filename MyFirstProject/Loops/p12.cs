using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class p12
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4;i++)
            {
                /*for(int k=i;k<i;k++)
                {
                    Console.Write(" ");
                }*/
                for (int j = 0; j <= 4; j++)
                {
                    if (j == 1 || j == 4 || (i == j && j != 0 && j != 4))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    class P13
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(i==3 || j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();


            }
        }
    }

    class P14
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    if ( i== 1 || j== 1 || i==4 || j==4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    

                }
                Console.WriteLine();
            }
        }
    }
}
