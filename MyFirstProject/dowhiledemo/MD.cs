using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.dowhiledemo
{
    class MD
    {
        static void Main(string[] args)
        {
            char ch;
            do
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
                Console.WriteLine("Do you want to Continue");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');
        }
    }
}
