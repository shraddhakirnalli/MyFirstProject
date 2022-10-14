using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{
    class Car
    {
        public string carcolour;
        public string carbrand;
        public int modelno;
        public int price;
        
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.carcolour="Red";
            car1.carbrand = "Tata";
            car1.modelno = 172;
            car1.price = 700000;
            Console.WriteLine(car1.carcolour+ " " +car1.carbrand+ " " +car1.modelno+ " " +car1.price);

            Car car2 = new Car();
            car2.carcolour = "White";
            car2.carbrand = "Maruti";
            car2.modelno = 173;
            car2.price = 800000;
            Console.WriteLine(car2.carcolour + " " + car2.carbrand + " " + car2.modelno + " " + car2.price);

            Car car3 = new Car();
            car3.carcolour = "Grey";
            car3.carbrand = "Audi";
            car3.modelno = 174;
            car3.price = 1000000;
            Console.WriteLine(car3.carcolour + " " + car3.carbrand + " " + car3.modelno + " " + car3.price);



        }

    }
}
