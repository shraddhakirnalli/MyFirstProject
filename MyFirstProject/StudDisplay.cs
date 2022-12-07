using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class StudDisplay
    {
        String name;
        int id;
        double per;
        

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
        public double Per
        {
            set
            {
                per = value;
            }
            get
            {
                return per;
            }
        }
        

        static void Main(string[] args)
        {
            StudDisplay sd1 = new StudDisplay();
            sd1.name ="John";
            sd1.id =11;
            sd1.per = 80.41;
            Console.WriteLine(sd1.name+" "+sd1.id+" "+sd1.per);

            StudDisplay sd2 = new StudDisplay();
            sd2.name = "peter";
            sd2.id = 12;
            sd2.per = 71.44;
            Console.WriteLine(sd2.name + " " + sd2.id+" "+sd2.per);
            if(sd1.per>sd2.per)
            {
                Console.WriteLine("John Percentage is greater");
            }
            else
            {
                Console.WriteLine("Peter percentage is greater");
            }

        }
    }
}
