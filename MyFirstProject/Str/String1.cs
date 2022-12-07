using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String
{
    class String1
    {
        static void Main(string[] args)
        {
            string s, rev = "";
            Console.WriteLine("Enter String");
            s = Console.ReadLine();
            for(int i=s.Length-1;i>=0;i--)
            {
                rev += s[i].ToString();
            }
            if(rev==s)
            {
                Console.WriteLine("String is Palindrome",s,rev);
            }
            else
            {
                Console.WriteLine("String is not Palindrome",s,rev);
            }
            Console.ReadKey();
        }
    }
    class StringMethod3
    {
        static void Main(string[] args)
        {
            string str = "  I Like India Country";
            string s = str.ToUpper();
            Console.WriteLine(s);

            string s1 = str.ToLower();
            Console.WriteLine(s1);
            Console.WriteLine(".............");
            char[] ch = str.ToCharArray();
            foreach (char c in ch)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine(str.Substring(4));
            Console.WriteLine("...............");
            Console.WriteLine(str.Substring(4, 6));
            Console.WriteLine("...............");
            string[] mywords = str.Split();
            foreach (string w in mywords)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine(str.IndexOf('b'));
            Console.WriteLine(str[5]);
            Console.WriteLine(str.Replace("like", "love"));
            Console.WriteLine(str.Contains("Like"));
            Console.WriteLine(str);
            Console.WriteLine(str.Trim());

        }
    }
    class StringMethod2
    {
        static void Main(string[] args)
        {

            string str = "Hello";
            string str2 = "Hello";
            string s = new string("Pune");
            Console.WriteLine(str + "  " + str2);

            Console.WriteLine(str == str2);
            Console.WriteLine(str.Equals(str2));

            Console.WriteLine(str.GetHashCode());
            str = str + " .net";

            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str + "  " + str2);
            Console.WriteLine(str == str2);
            Console.WriteLine(str.Equals(str2));

            string str3 = "Hello";
            string str4 = "hello";

            int x = str3.CompareTo(str4);
            Console.WriteLine(x);
            int y = str4.CompareTo(str3);
            Console.WriteLine(y);
        }


    }
    class StringTask
    {
        // no. of character from string
        public int NumOfChar(string str)
        {
            char[] ch = str.ToCharArray();
            int CharCnt = 0;
            foreach (Char c in ch)
            {
                CharCnt++;
            }
            return CharCnt;
        }

        // No. of words in string
        public int NumOfWords(string str)
        {
            char[] ch = str.ToCharArray();
            int WordCnt = 1;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == ' ')
                {
                    WordCnt++;
                }
            }
            return WordCnt;
        }
        public int NumOfWord2(string str)
        {
            string[] strr = str.Split();
            int WordCnt = strr.Length;
            return WordCnt;
        }

        // reverse string word except first and last word
        public string ReverseWords(string s)
        {
            string[] str = s.Split();
            string mywords = "";
            for (int i = 0; i < str.Length; i++)
            {
                string wordvalue = str[i];
                string revword = "";
                if (i != 0 && i != str.Length - 1)
                {
                    for (int j = 0; j < wordvalue.Length; j++)
                    {
                        revword = wordvalue[j] + revword;
                    }
                }
                else
                {
                    revword = wordvalue;
                }
                mywords = mywords + "  " + revword;
            }
            return mywords;
        }

        // string in a pattern form
        public string[] PatternForm(string s)
        {
            string[] str = s.Split();
            string[] str2 = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    str2[i] = str2[i] + str[j];
                }
            }
            return str2;
        }
        // string in a pattern form
        public void PatternForm2(string s)
        {
            string[] str = s.Split();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(str[j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            StringTask s = new StringTask();
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("No of char := ");
            Console.WriteLine(s.NumOfChar(str));
            Console.WriteLine("No. of words in string := ");
            Console.WriteLine(s.NumOfWords(str));
            Console.WriteLine(s.NumOfWord2(str));
            Console.WriteLine("Reverse of Words := ");
            Console.WriteLine(s.ReverseWords(str));
            Console.WriteLine("Pattern form is := ");
            string[] strarr = s.PatternForm(str);
            foreach (string item in strarr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Second Pattern form is := ");
            s.PatternForm2(str);
        }
    }
    class String2
    {
        // to calculate avg of digits present in string
        public static int AvgOfDigit(string s)
        {
            char[] ch = s.ToCharArray();
            int sum = 0, cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsDigit(ch[i]))
                {
                    sum = sum + (int)char.GetNumericValue(ch[i]);
                    cnt++;
                }
            }
            int avg = sum / cnt;
            return avg;
        }
        // name to abbrevation
        public static string ToAbbrevatedForm(string s)
        {
            string[] str = s.Split();
            string abbrevation = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    Char[] Word = str[i].ToCharArray();
                    for (int j = 0; j < 1; j++)
                    {
                        if (j == 0)
                        {
                            abbrevation = abbrevation + Word[j] + ". ";
                        }
                    }
                }
                else
                {
                    abbrevation = abbrevation + str[i];
                }
            }
            return abbrevation;
        }
        // valid string or not
        public static void ValidString(string str)
        {
            if (str.Length >= 3)
            {
                char[] ch = str.ToCharArray();
                bool IsDigit = true;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (char.IsLetter(ch[i]))
                    {
                        Console.WriteLine("Error");
                        IsDigit = false;
                        break;
                    }
                }
                if (IsDigit)
                {
                    int StartSum = 0, LastSum = 0;
                    for (int S = 0, L = ch.Length - 1; S < 3; S++, L--)
                    {
                        StartSum += ch[S];
                        LastSum += ch[L];
                    }
                    if (StartSum == LastSum)
                    {
                        Console.WriteLine("Valid String");
                    }
                    else
                    {
                        Console.WriteLine("Not Valid String");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        // occurance of each character
        public static void OccuranceOfChar(string str)
        {
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                int cnt = 1;
                bool flag = true;
                for (int j = i - 1; j > -1; j--)
                {
                    if (ch[i] == ch[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            cnt++;
                        }
                    }
                    Console.WriteLine($" \'{ch[i]}\' Present {cnt} Time");
                }
            }
        }
        // count vowel in a string
        public static int CountVowel(string str)
        {
            char[] ch = str.ToCharArray();
            int VowelCount = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' ||
                    ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')
                {
                    VowelCount++;
                }
            }
            return VowelCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            // Console.WriteLine("Avg of Numbers in a string := "+StringTask2.AvgOfDigit(str));
            //Console.WriteLine("Abbrevated Name := \n"+StringTask2.ToAbbrevatedForm(str));
            String2.ValidString(str);
            //StringTask2.OccuranceOfChar(str);

            // Console.WriteLine("Vowel Count := "+StringTask2.CountVowel(str));

        }
    }
}
