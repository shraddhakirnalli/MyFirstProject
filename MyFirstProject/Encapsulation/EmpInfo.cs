using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Encapsulation
{


    class Employee
    {
        int eid;
        String ename;
        int salary;
        public int Eid
        {
            set
            {
                eid = value;
            }
            get
            {
                return eid;
            }
        }
        public String Ename
        {
            set
            {
                ename = value;
            }
            get
            {
                return ename;
            }
        }
        public int Salary
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
    }
    class EmpInfo
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Eid = 100;
            e.Ename = "Amit";
            e.Salary = 89000;

            Console.WriteLine(e.Eid);
            Console.WriteLine(e.Ename);

            Console.WriteLine(e.Salary);
        }
    }
}
