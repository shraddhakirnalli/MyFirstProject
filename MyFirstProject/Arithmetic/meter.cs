using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Arithmetic
{
    class meter
    {
        static void Main(string[] args)
        {
            double cm, meter, kilometer;
            cm = 1000;

            // Converting centimeter
            // into meter and kilometer
            meter = cm / 100.0;
            kilometer = cm / 100000.0;

            Console.WriteLine("Length in " +
                                "meter = " +
                               meter + "m");


            Console.WriteLine("Length in " +
                            "Kilometer = " +
                          kilometer + "km");
        }
    }
}
