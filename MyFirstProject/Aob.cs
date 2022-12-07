using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Student
    {
        static void Main(string[] args)
        {

            Student[] stud = new Student[3];
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student();
                Console.WriteLine("Enter Id=");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name=");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks=");
                int marks = int.Parse(Console.ReadLine());

               // stud[i].Id = id;
                //stud[i].Name = name;
                //stud[i].Marks = marks;
            }
            Console.WriteLine("Id\tName\tMarks");
            for(int i=0;i<stud.Length;i++)
            {
                //Console.WriteLine(stud[i].Id + "\t" + stud[i].Name+"\t" +stud[i].Marks); 
            }
            Console.ReadKey();

        }
    }
}
