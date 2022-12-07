using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Encapsulation
{
    class CarProperty
    {
        int model_no;
        String car_name;
        int car_price;
        String car_colour;

        public int Model_no
        {
            set
            {
                model_no = value;
            }
            get
            {
                return model_no;

            }
        }
        public String Car_name
        {
            set
            {
                car_name = value;
            }
            get
            {
                return car_name;
            }
        }
        public int Car_price
        {
            set
            {
                car_price = value;
            }
            get
            {
                return car_price;
            }
        }
        public String Car_colour
        {
            set
            {
                car_colour = value;
            }
            get
            {
                return car_colour;
            }
        }


    }
    class CarInfo
    {
        static void Main(string[] args)
        {
            CarProperty cp = new CarProperty();
            cp.Model_no = 121;
            cp.Car_name = "Tata";
            cp.Car_price = 1100000;
            cp.Car_colour = "blue";

            Console.WriteLine(cp.Model_no);
            Console.WriteLine(cp.Car_name);
            Console.WriteLine(cp.Car_price);
            Console.WriteLine(cp.Car_colour);

            

        }
    }
    
}
