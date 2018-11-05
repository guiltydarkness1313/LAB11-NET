using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int id { get; set; }
        public string apellidos { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public string ciudad { get; set; }
        public Employee()
        {

        }
        public Employee(int cod,string ap,string nom, string car,string ciu)
        {
            id = cod;
            apellidos = ap;
            nombre = nom;
            cargo = car;
            ciudad = ciu;
        }
    }
}
