using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Person
    {
        String name;
        int age;
        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }

        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Peter";
            p.age = 45;
            Console.WriteLine(p.name+" "+p.age+" ");

            Person p2 = new Person();
            p2.name = "John";
            p2.age = 56;
            Console.WriteLine(p2.name + " " + p2.age + " ");
            if (p2.age > p.age)
            {
                Console.WriteLine("John  is Elder");
            }
            else
            {
                Console.WriteLine("Peter  is Elder");
            }

        }


    }

}

