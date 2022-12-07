using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class pri
    {
        static void Main()
        {
            int n = 5, a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine(" is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            
        }
    }
}
    
