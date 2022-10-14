using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Kaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int square = 0;
            int temp = 0;
            int count = 0;
            int firstPart = 0;
            int secondpart = 0;
            int sum = 0;
           
            while(temp!=0)
            {
                square = num * num;
                temp = square;
                count++;
                temp /= 10;
            }
            for(int i=count;i>0;i--)
            {
                firstPart = square / (int)Math.Pow(10, i);
                secondpart = square / (int)Math.Pow(10, i);
                if(firstPart==0|| secondpart==0)
                {
                    continue;
                    sum = firstPart + secondpart;
                }
                
                if(sum==num)
                {
                    Console.WriteLine(num+ "Number is Kaprekar");
                }
                else
                {
                    Console.WriteLine(num+ "Number is not Kaprekar");
                }
            }
        }
    }
}
