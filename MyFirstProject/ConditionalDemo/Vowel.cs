using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }

        }

    }
}
