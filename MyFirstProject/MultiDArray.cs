/*using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class MultiDArray
    {

        int[,] arr = new int[3, 3];

        public void accept()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());

                }
            }
        }

        public void display()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            MultiDArray m = new MultiDArray();
            Console.WriteLine("Enter element");
            m.accept();
            Console.WriteLine("Multi diamensional array:");
            m.display();
            Console.WriteLine("Row wise sum:");
            m.rowWiseSum();
            Console.WriteLine("Diagonal Sum:");
            m.DiagonalSum();
            Console.WriteLine("Anti Diagonal sum:");
            m.AntiDiagonalSum();
            Console.WriteLine("lower triangle");
            m.IsLowerTriangular();
        }




        public void rowWiseSum()
        {

            int sum;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine($"Addition of {i} row is {sum}");
            }
        }
        public int DiagonalSum()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[j, i];
                    }
                }
            }
            return sum;
        }
        public int AntiDiagonalSum()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) == (arr.GetLength(0) - 1))
                    {
                        sum += arr[j, i];
                    }
                }
            }
            return sum;
        }



        public void Display()
        {
            Console.WriteLine("Matrix is := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine("");
            }
        }
        int[,] matrix = new int[3, 3]
            {
            {1,0,0 },
            {4,5,0 },
            {7,8,9 }
            };
    
        public bool IsLowerTriangular()
        {
            bool lowerTriangular = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            lowerTriangular = false;
                            break;
                        }

                    }
                }
            }
            return lowerTriangular;
        }

        class Matrix
        {
            
            static void Main(string[] args)
            {
                
                //Matrix obj = new Matrix();
                //obj.Display();
                //if (m.IsLowerTriangular())
                    Console.WriteLine("Given Matrix is Lower Triangular Matrix");
                else
                    Console.WriteLine("Not Lower Triangular Matrix");
                Console.ReadKey();
            }
        }
    }
}*/

        



    


