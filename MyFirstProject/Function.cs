using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Function
    {
        public void show()
        {
            int a, b, sum;
            a = 9;
            b = 4;
            sum = a + b;
            Console.WriteLine("Addition is"+sum);
        }
        public void add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("Addition is"+sum);
        }
        public int sum(int a,int b)
        {
            int s = a + b;
            return s;
        }
    }
}
