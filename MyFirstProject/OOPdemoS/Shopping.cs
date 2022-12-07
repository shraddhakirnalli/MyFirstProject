using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPdemoS
{
    class Shopping
    {
        string prod_name;
        int quantity;
        int price;

        public void Accept_details(string pname,int qty,int pri)
        {
            prod_name = pname;
            quantity = qty;
            price = pri;
        }
    }
}
