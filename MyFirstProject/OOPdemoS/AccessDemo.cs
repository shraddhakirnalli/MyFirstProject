using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{


    class AccessModifersDemo
    {


       private int x = 10;
        internal int y = 30;
        protected int z = 40;

        static void Main(string[] args)
        {
            AccessModifersDemo d = new AccessModifersDemo();
            Console.WriteLine(d.x);
            Console.WriteLine(d.y);
            Console.WriteLine(d.z);
        }
    }

    class AccessDemo:AccessModifersDemo
    {
        static void Main(string[] args)
        {
            AccessModifersDemo access = new AccessModifersDemo();
            // Console.WriteLine(access.x);//private is not accessible
            Console.WriteLine(access.y);
            // Console.WriteLine(access.z);

            AccessDemo a = new AccessDemo();
            Console.WriteLine(a.z);
        }
    }
}
