using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Count
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int r;
            Console.Write("Enter the Number: ");
            int number = int.Parse(Console.ReadLine());
            while(number>0)
            {
                r = number % 10;
                sum += r;
                if(r%2!=0)
                {
                    
                    Console.WriteLine(r);
                    

                }
                number = number / 10;
                
            }
            


        }
    }
            
            
}
    
            

