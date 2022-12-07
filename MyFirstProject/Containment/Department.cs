using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Department
    {
        int DeptId;
        string DeptName;

        public Department(int id, string name)
        {
            this.DeptId = id;
            this.DeptName = name;
        }
        public void DisplayDept()
        {
            Console.WriteLine("Department ID : " + DeptId + "\nDepartment Name : " + DeptName);
        }
    }
    class Employee
    {
        int EmpId;
        string EmpName;
        int EmpSalary;
        Department EmpDept;

        Employee(int empid, string empname, int empsal, Department empdept)
        {
            this.EmpId = empid;
            this.EmpName = empname;
            this.EmpSalary = empsal;
            this.EmpDept = empdept;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employe ID : " + EmpId + "\nEmploye Name : " + EmpName + "\nEmploye " +
                "Salary : " + EmpSalary);
            EmpDept.DisplayDept();
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Pavan", 50000, new Department
                (21, "Research & Develoment"));
            emp1.DisplayDetails();
        }
    }
}

