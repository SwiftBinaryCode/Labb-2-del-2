using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_del_2
{
    class Products
    {


        private string name;
        private double price;
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Products(string _name, double _price)
        {

            name = _name;
            price = _price;




        }
    }
}
