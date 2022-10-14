using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionalDemo
{
    class Age
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter My Age");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Friend Age");
            int frndage = int.Parse(Console.ReadLine());



            if (myage>frndage)
            {
                Console.WriteLine("HIIIII");
            }
            else if(myage<frndage)
            {
                Console.WriteLine("GOOD MORNING");
            }
            else
            {
                Console.WriteLine("HOW ARE YOU");
            }




        }
    }
}
