using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Encapsulation
{
    class StudProperty
    {
        int stud_id;
        String name;
        int age;

        public int Stud_id
        {
            set
            {
                stud_id = value;
            }
            get
            {
                return stud_id;
            }


        }
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
    }
    class Studdetails
    {
        static void Main(string[] args)
        {
            StudProperty sp = new StudProperty();
            sp.Stud_id = 1;
            sp.Name = "John";
            sp.Age = 20;
            Console.WriteLine(sp.Stud_id + " " + sp.Name + " " + sp.Age);

        }
    }
}
