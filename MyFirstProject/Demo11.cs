using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Demo11
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 88, 45, 76 };
            Console.WriteLine("Array (Old):");
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }

            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("Array (After using Clear):");
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }
        }
    }
   
}

