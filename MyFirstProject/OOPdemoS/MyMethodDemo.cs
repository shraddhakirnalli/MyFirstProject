using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{
    class MyMethodDemo
    {

        //AccessModifier return_type method_name(paramterlist)
        //{
                //logic
        //}

        //no return _type no paramter
        public void ShowDetails()
        {
            Console.WriteLine("Hiii");
        }
        //no return type with parmter
        public void AcceptData(String name,int salary)
        {
            Console.WriteLine("name="+name+"  salary="+salary);
        }
        public int Sum()
        {
            /* int c = 10 + 30;
             return c;*/
            return (10 + 20);
         }

        public double Calculate_Area(int r,double PI)
        {
            return PI * r * r;
        }

        static void Main(string[] args)
        {
            MyMethodDemo m = new MyMethodDemo();
            m.ShowDetails();
            m.AcceptData("Neha",67000);

            /* int ans = m.Sum();
             Console.WriteLine("Sum="+ans);*/

            Console.WriteLine(m.Sum());

            //Console.WriteLine(m.Calculate_Area(3,3.14));\
            Console.WriteLine("Enter the radius");
            int rd = int.Parse(Console.ReadLine());
            double pi = 3.14;
            Console.WriteLine(m.Calculate_Area(rd,pi));
        }
    }
}
