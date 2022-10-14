using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{
    class Employee
    {
        public int eid;
        public String name;
        public int salary;

    
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.eid = 200;
            emp1.name = "Nikhil";
            emp1.salary = 890000;
            Console.WriteLine(emp1.eid+" "+emp1.name+" "+emp1.salary);

            Employee emp2 = new Employee();
            emp2.eid = 102;
            emp2.name = "Neha";
            emp2.salary = 78000;

            Console.WriteLine(emp2.eid+" "+" "+emp2.name+" "+emp2.salary);
            

        }
    }
}
