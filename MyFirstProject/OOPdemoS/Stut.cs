using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{
    class Student
    {
        public int stud_id;
        public string stud_name;
        public int stud_marks1;
        public int stud_marks2;
        public int stud_marks3;
        public float percentage;
        public int total;
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.stud_id = 10;
            std1.stud_name = "Srushti";
            std1.stud_marks1 = 55;
            std1.stud_marks2 = 67;
            std1.stud_marks3 = 76;
            std1.total = 55 + 67 + 76;
            std1.percentage = std1.total / 3;
            Console.WriteLine("Percentage="+std1.percentage);

        }
    }
}
