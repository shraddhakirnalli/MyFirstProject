using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{
    class Box
    {
        public int height;
        public int width;
        public int length;
        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.height = 5;
            box1.width = 3;
            box1.length = 10;
            int area = box1.width * box1.height;
            Console.WriteLine(area);
        }
    }
}
