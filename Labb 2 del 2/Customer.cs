using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_del_2
{


     class Customers
    {

        public class Customer
        {
            public string Name { get; private set; }

            private string Password { get; set }

            private List<Product> _cart;
            public List<Product> Cart { get { return _cart; } }

            public Kund(string name, string password)
            {
                this.Name = name;
                this.Password = password;
                this._cart = new List<Product>();
            }
        }//sparade kunder








    }
}
