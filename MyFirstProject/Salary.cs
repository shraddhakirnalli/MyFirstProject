using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Salary
    {
        Double hra;
        Double da;
        Double basic;
        Double Gross_Salary;
    public Salary()
        {
            basic = 20000.50;
            if (basic <= 10000)
            {
                da = basic * 0.8;
                hra = basic * 0.2;
            }
            else if (basic <= 20000)
            {
                da = basic * 0.9;
                hra = basic * 0.25;
            }
            else
            {
                da = basic * 0.95;
                hra = basic * 0.3;
            }
            Gross_Salary = basic + da + hra;
        }

        public void display()
        {
            Console.WriteLine("Basic Salary = " + basic);
            Console.WriteLine("HRA = " + hra);
            Console.WriteLine("DA = " + da);
            Console.WriteLine("Gross Salary = " + Gross_Salary);
        }
        public static void Main(string[] args)
        {

            Salary S = new Salary();
            S.display();
        }
    }
}