using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{
    class Method
    {
        int sid;
        string sname;
        int physics, chemistry, maths;
        double percentage;




        public void Accept_details(int id, string name, int mk1, int mk2, int mk3)
        {
            sid = id;
            sname = name;
            physics = mk1;
            chemistry = mk2;
            maths = mk3;
            


        }
        public void Count(int physics,int chemistry,int maths)
        {

            
            percentage = (physics + chemistry + maths *100)/300;
        }
        
        public void Display()
        {
            Console.WriteLine(sid+" "+sname+" "+physics+" "+chemistry+" "+maths+" ");
            Console.WriteLine(percentage+" ");
            

        }
        static void Main(string[] args)
        {
            Method m = new Method();
            m.Accept_details(1,"srushti",78,60,65);
            m.Count(78,60,65);
            m.Display();
        }
    }
}
