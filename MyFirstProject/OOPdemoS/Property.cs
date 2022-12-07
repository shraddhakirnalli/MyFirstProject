using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{
    class Property
    {
        public int order_id;
        public String city;
        public String cust_name;
        public String isDelivered;
        static void Main(string[] args)
        {
            Property p1 = new Property();
            p1.order_id = 10;
            p1.city = "Pune";
            p1.cust_name = "John";
            p1.isDelivered = "Yes";
            Console.WriteLine(p1.order_id+" "+p1.city+" "+p1.cust_name+" "+p1.isDelivered);
            



        }
    }
}
