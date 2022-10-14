using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class series
    {
        static void Main(string[] args)
        {
            int temp, n = 10;
            for(int i=1;i<=n;i++)
            {
                temp = i * i * i - 1;
                Console.WriteLine(temp+"");
            }
        }
    }
     
    class Series2
    {
        static void Main(string[] args)
        {
            
            for(int i=1;i<=10;i++)
            {
               for(int j=1;j<=i;j++)
                {
                    Console.WriteLine(1);
                    

                }
                Console.WriteLine();
                

                
            }
        }
    }
}
