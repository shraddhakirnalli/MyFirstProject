using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
        class DemoFE
        {
            static void Main(string[] args)
            {
                int[] list = { 10, 34, 67, 83, 21, 11, 51 };
                Console.WriteLine("Length of array is" + list.Length);
                int[] temp = list;
                int[] t = new int[list.Length];
                Array.Copy(list, t, list.Length);
                Console.Write(":Copied array");

                foreach(int i in t)
                {
                    Console.Write(i + " ");
                }
            }
        }
}

