using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String
{
    class StringRev
    {
        public string DoReverse(string s)
        {
            string s2 = "";
            for (int i = 0; i < s.Length; i++)
            {
                s2 = s[i] + s2;
            }
            return s2;
        }

        public string ReverseWords(string s)
        {
            string[] str = s.Split();
            string mywords = "";
            for (int i = 0; i < str.Length; i++)
            {
                string wordvalue = str[i];
                string revword = "";
                for (int j = 0; j < wordvalue.Length; j++)
                {
                    revword = wordvalue[j] + revword;
                }
                mywords = mywords + "  " + revword;
            }
            return mywords;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            StringRev r = new StringRev();
            Console.WriteLine(r.DoReverse(str));

            Console.WriteLine(r.ReverseWords(str));
        }
    }
}

