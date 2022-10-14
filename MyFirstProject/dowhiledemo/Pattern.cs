using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.dowhiledemo
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=2;j++)
                {
                    Console.WriteLine(j);
                }

            }
        }
    }

    class P2
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }

    class P3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();

            }
        }
    }

    
    class P5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <=i ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }

    class P6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j<=4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }

    class P7
    {
        static void Main(string[] args)
        {
            for (int i = 4; i>= 1; i--)
            {
                for (int j= 1; j<= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }

}
