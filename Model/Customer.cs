using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public string id;
        public string nameC;
        public string cargoC;
        public string city;
        public string region;

        public Customer()
        {

        }

       public Customer(string cod, string nom, string cargo, string ciudad, string region)
        {
            id = cod;
            nameC = nom;
            cargoC = cargo;
            city = ciudad;
            this.region = region;
        }
    } 

}
