using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class A11
    {
        
       static void Main(string[] args)
            {
                int s;
                Console.WriteLine("Enter size");
                s = int.Parse(Console.ReadLine());

                int[] ar = new int[s];
                Console.WriteLine("Enter array");
                for (int i = 0; i < s; i++)
                {
                    ar[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Array is ");
                int sum = 0;
                for (int i = 0; i < s; i++)
                {
                    Console.Write(ar[i] + " ");
                    sum = sum + ar[i];
                }
                int avg = sum / s;
                Console.WriteLine($"\nAverage is : {avg}");
            }
        }
    }

