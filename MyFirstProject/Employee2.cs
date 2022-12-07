using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
  
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

            public Employee()
            {
                Id = 0;
                Name = "";
                Salary = 0;
            }
            public Employee(int id, string name, int salary)
            {
                this.Id = id;
                this.Name = name;
                this.Salary = salary;
            }
            public void Display()
            {
                Console.WriteLine(Id + "\t" + Name + "\t" + Salary);
            }
            static void Main(string[] args)
            {
                Employee[] emp = new Employee[3];
                for (int i = 0; i < emp.Length; i++)
                {
                    Console.WriteLine("Enter Id");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Salary");
                    int salary = int.Parse(Console.ReadLine());
                    emp[i] = new Employee(id, name, salary);
                }

                Console.WriteLine("ID\tName\tSalary");
                foreach (Employee e in emp)
                {
                    e.Display();
                }

            }



        }
}
