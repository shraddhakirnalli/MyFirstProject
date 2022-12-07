using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Time
    {
        int hour;
        int min;

        public int Hour
        {
            set
            {
                hour = value;
            }
            get
            {
                return hour;
            }

        }
        public int Min
        {
            set
            {
                min = value;
            }
            get
            {
                return min;
            }
        }
        public void display()
        {
            Console.WriteLine(hour+" "+min+" ");
        }
        

    }
    
}
