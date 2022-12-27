using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Str
{
    class S3
    {
        public static bool IsPalindrome(string str)
        {
            char[] ch = str.ToCharArray();
            char[] temp = new char[ch.Length];
            Array.Copy(ch, temp, ch.Length);
            Array.Reverse(ch);
            string str1 = new string(ch);
            string str2 = new string(temp);

            return str1.Equals(str2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();

            if (S3.IsPalindrome(str))
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
        }
    }

    class S4
    {
        public static string LongestWord(string str)
        {
            string[] Words = str.Split();
            string LongestWord = Words[0];
            for (int i = 0; i < Words.Length; i++)
            {
                if (LongestWord.Length < Words[i].Length)
                {
                    LongestWord = Words[i];
                }
            }
            return LongestWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();

            Console.WriteLine(S4.LongestWord(str));
        }
    }

    class S5
    {
        public static bool IsPalindrome(StringBuilder sbr)
        {
            string str = sbr.ToString();
            char[] ch = str.ToCharArray();
            char[] temp = new char[ch.Length];
            Array.Copy(ch, temp, ch.Length);
            Array.Reverse(ch);
            string str1 = new string(ch);
            string str2 = new string(temp);
            bool check = str1.Equals(str2);
            return check;
        }



        static void Main(string[] args)
        {
            StringBuilder sbr = new StringBuilder();
            Console.WriteLine("Enter string");
            sbr.Append(Console.ReadLine());

            if (S5.IsPalindrome(sbr))
            {
                Console.WriteLine("String is Palindrom");
            }
            else
            {
                Console.WriteLine("String is not Palindrom");
            }

        }
    }
}

