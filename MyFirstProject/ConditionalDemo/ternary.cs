using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{
    class ternary
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            String str = (n % 2 == 0) ? "Even" : "Odd";

            Console.WriteLine(n + "is" + str);
            Console.ReadLine();
        }
        
    }  
}
