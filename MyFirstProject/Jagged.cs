using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Jagged
    {
        static void Main(string[] args)
        {

            
         int[][] jaggedArray = {
         new int[] {1, 3, 5},
         new int[] {2, 4},
        };

            
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
            Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);
            Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);

            Console.ReadLine();
        }
    }
}

