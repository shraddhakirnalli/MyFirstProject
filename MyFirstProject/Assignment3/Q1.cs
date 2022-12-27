using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment3
{
    class Q1
    {
        static void Main(string[] args)
        {
            string str= "Hello My Is Shraddha";
            string str2 = "I Am From Pune";

            Console.WriteLine(str.Contains("Hello"));
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Substring(1));
            Console.WriteLine(str.IndexOf("Hello"));
            int length = str.Length;
            Console.WriteLine("Length"+length);
            string join = string.Concat(str, str2);
            Console.WriteLine("Joined string"+join);
            bool res = str.Equals(str2);
            Console.WriteLine("Equal"+res);
            str.CompareTo(str2);
            


        }
    }
    class Q2
    {
        static void Main(string[] args)
        {
            string str = "Happy New Year";
            char ch = 'p';
            int cnt = 0;
            foreach(char c in str)
            {
                if(c==ch)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);


        }
    }
    class Q3
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            //str.Trim();
            Console.WriteLine(str.Trim());


        }
    }
    class Q4
    {
        static void Main(string[] args)
        {
            string str = "Happy New Year";
            char[] ch = str.ToCharArray();
            int wrdcnt = 1;
            for(int i=0;i<str.Length;i++)
            {
                if(ch[i]==' ')
                {
                    wrdcnt++;
                }

            }
            Console.WriteLine("There are" +wrdcnt+ "words in the string");
        }
    }
    class Q5
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine("Enter String");
            s = Console.ReadLine();
            for(int i=s.Length-1;i>=0;i--)
            {
                revs += s[i].ToString();

            }
            if(revs==s)
            {
                Console.WriteLine("Palindrome",s,revs);
            }
            else
            {
                Console.WriteLine("Not Palindrome",s,revs);
            }
        }
    }
    class Q6
    {
        static void Main(string[] args)
        {
            string str="Hello My Name is Shraddha ";
            string[] Words =str.Split(" ");
            string LongestWord = Words[0];
            for(int i=0;i<Words.Length;i++)
            {
                if(LongestWord.Length<Words[i].Length)
                {
                    LongestWord = Words[i];
                }
            }
            Console.WriteLine("Longest Word"+LongestWord);

        }
    }
    class Q7
    {
        static void Main(string[] args)
        {
            string str = "my country name is India and I love it";
            Console.WriteLine(str);
            Console.WriteLine("........................");
            string[] starr = str.Split();

            string ReverseString = "";
            for (int i = 0; i < starr.Length; i++)
            {
                if (i != 0 && i != starr.Length - 1)
                {
                    char[] word = starr[i].ToCharArray();
                    string RevWord = "";
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        RevWord = RevWord + word[j];
                    }
                    ReverseString = ReverseString + RevWord + " ";
                }
                else
                {
                    ReverseString = ReverseString + starr[i] + " ";
                }
            }
            Console.WriteLine(ReverseString);
        }
    }
    //Given a sentence and a word, find if the word can be formed from given characters in the sentence.
    //For example, 
    //s1=”THE SKY IS THE LIMIT”
    //word = "AXE", -> No
    //word = "SIT", -> Yes can be formed
    //word = "AMIT", -> Yes can be formed
    class Class3
    {
        static void Main(string[] args)
        {
            string str = "THE SKY IS THE LIMIT";
            Console.WriteLine(str);
            Console.WriteLine("Enter Word");
            string givenwrd = Console.ReadLine();
            int samechar = 0;

            for (int i = 0; i < givenwrd.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (givenwrd[i] == str[j])
                    {
                        samechar++;
                        break;
                    }
                }
            }
            if (samechar == givenwrd.Length)
            {
                Console.WriteLine("Yes Formed");
            }
            else
            {
                Console.WriteLine("Not Formed");
            }
        }
    }
}
