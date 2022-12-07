using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Mock
    {
        static void Main(string[] args)
        {


            int a = 2;
            int b = 5;
            int res = 0;
            for (int i = 1; i <= a; i++)
            {
                res += b;
            }
            Console.WriteLine(res);
        }
    }
    
}
