using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Constructor
{
    class C1
    {
        int roll;
        String name;
        int marks;
        public C1(int roll, String name, int marks)
        {

            this.roll = roll;
            this.name = name;
            this.marks = marks;
        }
        public void Display()
        {
            Console.WriteLine("roll=" + roll);
            Console.WriteLine("name=" + name);
            Console.WriteLine("marks=" + marks);
        }

        static void Main(string[] args)
        {
            C1 c = new C1(1, "John", 78);
            c.Display();

        }
    }

    
}
