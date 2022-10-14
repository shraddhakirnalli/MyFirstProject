using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.SwitchCase
{
    class IntegerDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                case 8:
                    Console.WriteLine("INVALID CHOICE");
                    break;
            }

        }
    }

    class s1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The char");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A':
                    Console.WriteLine("Vowel");
                    break;
                case 'E':
                    Console.WriteLine("Vowel");
                    break;
                case 'I':
                    Console.WriteLine("Vowel");
                    break;
                case 'O':
                    Console.WriteLine("Vowel");
                    break;
                case 'U':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;
            }
            }
        }

    }

