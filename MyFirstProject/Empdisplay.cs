using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Empdisplay
    {
        String name;
        int id;
        double salary;


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
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }


        static void Main(string[] args)
        {
            Empdisplay ed = new Empdisplay();
            ed.name = "John";
            ed.id = 11;
            ed.salary = 50000;
            Console.WriteLine(ed.name + " " + ed.id + " " + ed.salary);

            Empdisplay ed2 = new Empdisplay();
            ed2.name = "peter";
            ed2.id = 12;
            ed2.salary = 80000;
            Console.WriteLine(ed2.name + " " + ed2.id + " " + ed2.salary);
            if (ed2.salary > ed.salary)
            {
                Console.WriteLine(ed2.name + " " + ed2.id + " " + ed2.salary);
            }
            
            else
            {
                
                Console.WriteLine(ed.name + " " + ed.id + " " + ed.salary);

            }
        

        }
    }
}

