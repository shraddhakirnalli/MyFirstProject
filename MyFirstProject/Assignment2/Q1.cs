using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment2
{
    class Q1
    {
        static void Main(string[] args)
        {
            for(int i=121;i<=229;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Q2
    {
        static void Main(string[] args)
        {
            for(int i=529;i>=229;i--)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Q3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10;i++)
            {
                if(i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }

    class Q4
    {
        static void Main(string[] args)
        {
            int val1, val2, gcd, lcm, rem,numr,denr;
            Console.WriteLine("Enter First Numbers:");
             val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Numbers:");
            val2 = int.Parse(Console.ReadLine());
            if(val1>val2)
            {
                numr = val1;
                denr = val2;
            }
            else
            {
                numr = val2;
                denr = val1;
            }
            rem = val1 % val2;
            while(rem!=0)
            {
                numr = denr;
                denr = rem;
                rem = numr % denr;
            }
            gcd = denr;
            lcm = val1 * val2 / gcd;
            Console.WriteLine("GCD="+val1+" "+val2+" "+gcd);
            Console.WriteLine("LCM="+val1+" "+val2+" "+lcm);





        }
    }
    class Q5
    {
        static void Main(string[] args)
        {
            char ch;
            for(ch='a';ch<='z';ch++)
            {
                Console.WriteLine(ch);

            }
        }
    }
    class Q6
    {
        static void Main(string[] args)
        {
            int i, num, sum = 0;
            Console.WriteLine("Enter Any number");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=2;i<=num;i+=2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of even number between 1 to"+ num +"="+sum);
        }
    }
    class Q7
    {
        static void Main(string[] args)
        {
            int i, num, sum = 0;
            Console.WriteLine("Enter Any number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of odd number between 1 to" + num + "=" + sum);

        }
    }
    class Q8
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            Console.WriteLine("Enter the number");
            int no = int.Parse(Console.ReadLine());
            while(no!=0)
            {
                no = no / 10;
                count++;
            }
            Console.WriteLine("NUmber has"+count+"digits");
        }
    }

    class Q9
    {
        static void Main(string[] args)
        {
            
            int prod=1,k;
            Console.WriteLine("Enter the number");
            int no = Convert.ToInt32(Console.ReadLine());
            while (no != 0)
            {
                k = no % 10;
                no = no / 10;
                prod = prod * k;
            }
            Console.WriteLine("product of digit is"+prod);

        }
    }
    
    
}
