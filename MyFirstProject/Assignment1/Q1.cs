using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{
    class Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year:");
            int Year = int.Parse(Console.ReadLine());
            if(((Year%4==0 && Year%100 !=0))||(Year%400==0))
            {
                Console.WriteLine("Year is a Leap year:",Year);
            }
            else
            {
                Console.WriteLine("Year is not a Leap Year:",Year);
            }
        }
    }

    class Q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int no = int.Parse(Console.ReadLine());
            if ((no % 5 == 0 && no % 11 == 0))
            {
                Console.WriteLine("Number is divisible by 5 and 11:", no);
            }
            else if(no%5==0)
            {
                Console.WriteLine("Number is divisible by 5 :", no);
            }
            else if(no%11==0)
            {
                Console.WriteLine("Number is divisible by 11:",no);
            }
            
        }
    }

    class Q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third Number:");
            int num3 = int.Parse(Console.ReadLine());
            int max = 0;
            if(num1>num2)
            {
                if(num1>num3)
                {
                    max = num1;
                }
            }
            else if(num2>num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine("Greatest Number is:"+max);



        }
    }
    class Q4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character:");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
            {
                Console.WriteLine("Vowel:");
            }
            else
            {
                Console.WriteLine("Consonent:");
            }

        }
    }

    class Q5
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Calculator");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Substract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divide");
                Console.Write("Enter Choice(1-4):");
                int ch = Int32.Parse(Console.ReadLine());
                int a, b, c;
                if (ch == 1)
                {
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum = {0}", c);
                }
                else if (ch == 2)
                {
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);
                }
                else if (ch == 3)
                {
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Product = {0}", c);
                }
                else if (ch == 4)
                {
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Quotient = {0}", c);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
                Console.ReadLine();
        }
    }
    class Q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("Number is Positive:");
            }
            else
            {
                Console.WriteLine("Number is Negative:");
            }
        }
    }

    class Q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Character:");
            char ch = Convert.ToChar(Console.ReadLine());
            if((ch>='a'&& ch<='z')||(ch>='A'&&ch>='Z'))
            {
                Console.WriteLine(ch+"Is An Alphabet:");
            }
            else if(ch>='0'&& ch<='9')
            {
                Console.WriteLine(ch+"Is a Digit:");
            }
            else
            {
                Console.WriteLine(ch+"is a special character:");
            }
        }
    }

    class Q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Number is Even:");
            }
            else
            {
                Console.WriteLine("Number is Odd:");
            }
        }
    }
    
    class Q9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount:");
            int amt = int.Parse(Console.ReadLine());
            int a, b, c, d, e, f, g, h, p, q, r, s, t, u;
            a = amt / 2000;   p = amt % 2000;
                              q = p % 500;
            b = p / 500;       r = q % 200;
            c = q / 200;       s = r % 100;
            d = r / 100;       t = s % 50;
            e = s / 50;        u = t % 20;
            f = t / 20;        h = u % 10;
            g = u / 10;

          Console.WriteLine($" 2000 : {a} \n  500 : {b} \n  200 : {c} \n  100 : {d}" +
                $"\n   50 : {e} \n   20 : {f} \n   10 : {g} \n    1 : {h}");

        }
    }

    class Q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Basic Salary");
            int s = int.Parse(Console.ReadLine());

            if (s <= 10000)
            {
                Console.WriteLine("Gross Salary is : " + (s + (s * 0.2) + (s * 0.8)));
            }
            else if (s <= 20000)
            {
                Console.WriteLine("Gross Salary is : " + (s + (s * 0.25) + (s * 0.9)));
            }
            else
            {
                Console.WriteLine("Gross Salary is : " + (s + (s * 0.3) + (s * 0.95)));
            }
        }
    }

    class Q11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum = {0}", c);
                    break;
                case 2:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);
                    break;
                case 3:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Product = {0}", c);
                    break;
                case 4:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Quotient = {0}", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice:");
                    break;


            }
        }
    }

    class Q12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice:");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Monday:");
                    break;
                case 2:
                    Console.WriteLine("Tuesday:");
                    break;
                case 3:
                    Console.WriteLine("Wednesday:");
                    break;
                case 4:
                    Console.WriteLine("Thursday:");
                    break;
                case 5:
                    Console.WriteLine("Friday:");
                    break;
                case 6:
                    Console.WriteLine("Saturday:");
                    break;
                case 7:
                    Console.WriteLine("Sunday:");
                    break;
                default:
                    Console.WriteLine("INVALID CHOICE");
                    break;
            }
        }
    }
    class Q13
    {
        public static void Main()
        {
            
            int cdigit;
            Console.WriteLine("Accept digit and display in word");
            Console.Write("input Digit(0-9)");
            cdigit = Convert.ToInt32(Console.ReadLine());
            switch(cdigit)
            {
                case 0:
                    Console.Write("Zero\n");
                    break;
                case 1:
                    Console.Write("One\n");
                    break;
                case 2:
                    Console.Write("Two\n");
                    break;
                case 3:
                    Console.Write("Three\n");
                    break;
                case 4:
                    Console.Write("Four\n");
                    break;
                case 5:
                    Console.Write("Five\n");
                    break;
                case 6:
                    Console.Write("Six\n");
                    break;
                case 7:
                    Console.Write("Seven\n");
                    break;
                case 8:
                    Console.Write("Eight\n");
                    break;
                case 9:
                    Console.Write("Nine\n");
                    break;
                default:
                    Console.WriteLine("INVALID CHOICE");
                    break;
            }
        }
    }
}
    

