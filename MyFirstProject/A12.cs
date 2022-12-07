using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class A12
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
            Console.WriteLine("Negative element are : ");
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] < 0)
                {
                    Console.Write(ar[i] + " ");
                    count++;
                }
            }

            Console.WriteLine($"\nTotal negative numbers are : {count}");
        }
    }

    class Array3
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


            int[] even = new int[s];
            int[] odd = new int[s];
            int[] add = new int[s];
            int e, o, a;
            e = 0;
            o = 0;
            a = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    even[e++] = ar[i];

                }
                else
                {
                    odd[o++] = ar[i];

                }

            }
            for (int i = 0; i < s; i = i + 2)
            {
                add[a++] = ar[i];
            }

            Console.WriteLine("Even array : ");
            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }

            Console.WriteLine("\nOdd array : ");
            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }
            Console.WriteLine("\nAdd array : ");
            for (int i = 0; i < s; i = i + 2)
            {
                Console.Write(add[o] + " ");
            }
        }
    }
    class Array4
    {
        static void Main(string[] args)
        {
            int s;
            int sum = 0;
            Console.WriteLine("enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < s; j = j + 2)
            {
                sum = sum + ar[j];
            }
            Console.WriteLine("sum is:=" + sum);
        }
    }
    class A1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element of an array");
            int ele = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ele)
                {
                    Console.WriteLine($"{ele} is present at index {i}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{ele} is not present in an array");
            }
        }
    }
    class Maxmin
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter array elements:");
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int max = arr[0];
            int min = arr[0];
            for (i = 1; i < size; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("\nMaximum element: " + max);
            Console.WriteLine("Minimun element: " + min);
        }
    }

    class Find
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of negative numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
    class ArrayPrime
    {
        static void Main(string[] args)
        {
            int i, j, p;
            int[] arr = new int[5];

            Console.Write("Enter array elements:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(" Prime Elements are:");
            for (i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
    class CharArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Char Array:=");
            for (int i = 0; i < s; i++)
            {
                Console.Write(ar[i] + " ");
            }
        }
    }
    class Occurence
    {
        static void Main()
        {
            int i = 0;
            int count = 0;
            int item = 0;

            int[] arr1 = new int[5];


            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter item : ");
            item = int.Parse(Console.ReadLine());

            for (i = 0; i < 5; i++)
            {
                if (item == arr1[i])
                {
                    count++;
                }
            }

            Console.WriteLine("Total occurrence of item " + item + " is : " + count);

            Console.WriteLine();
        }
    }
    class SampleArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            char[] upper = new char[s];
            char[] lower = new char[s];
            int u = 0, l = 0;

            for (int i = 0; i < s; i++)
            {
                if (ar[i] > 'a' && ar[i] < 'z')
                {
                    lower[l++] = ar[i];
                }
                else
                {
                    upper[u++] = ar[i];
                }
            }
            Console.WriteLine("Uppercase array:");
            for (int i = 0; i < u; i++)
            {
                Console.Write(upper[i] + " ");
            }
            Console.WriteLine("\nLowercase array:");
            for (int i = 0; i < l; i++)
            {
                Console.Write(lower[i] + " ");
            }
        }
    }
    class Equal
    {
        static void Main(string[] args)
        {

            Boolean isArrayEqual = true;

            int[] arr1 = { 1, 2, 2, 4, 4, 5 };
            int[] arr2 = { 1, 2, 3, 4, 4, 5 };
            if (arr1.Length == arr2.Length)
            {


                for (int i = 0; i < arr2.Length; i++)
                {


                    if (arr2[i] != arr1[i])
                    {

                        isArrayEqual = false;
                        break;
                    }
                }
            }


            if (isArrayEqual)
            {
                Console.WriteLine("Both arrays are equal");

            }
            else
            {
                Console.WriteLine("Both arrays are not equals");

            }
        }
    }
    class Concat
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[10];
            int[] arr2 = new int[5];



            Console.WriteLine("Enter elements of Array1 : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Enter elements of Array2 : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }


            for (i = 0, j = 0; i < 5; i++)
            {
                arr1[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                arr1[j++] = arr2[i];
            }


            Console.WriteLine("Elements of Array1 : ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr1[i]);

            }

            Console.WriteLine();
        }
    }

    class ConcatAlternate
    {
        static void Main(string[] args)
        {
            int i, j;
            int size1 = 5;
            Console.WriteLine("Enter 5 elements of first array:");
            int[] arr1 = new int[size1];
            for (i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int size2 = 5;
            Console.WriteLine("Enter 5 elements of second array:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] arr3 = new int[size1 + size2];
            for (i = j = 0; i < size1; i++)
            {
                arr3[j++] = arr1[i];
                arr3[j++] = arr2[i];
            }

            Console.WriteLine("Alternate Elements of array 3 are:");
            for (i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }
    class Sort
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;


            Console.Write("\n\nSort elements of array in ascending order :\n");
            Console.Write("----------------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");
        }
    }
    class CharOccur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter character to check");
            char ch = Convert.ToChar(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ch)
                {
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine($"{ch} is not present in array");
            }
            else
            {
                Console.WriteLine($"{ch} is present in array");
            }
        }
    }
    
}



    

    

    
    





