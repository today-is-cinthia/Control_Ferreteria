using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria
{
    public class Cliente
    {
        public int IdCliente { set; get; }
        public string Nombre { set; get; }
        public string Telefono { set; get; }
        public string Direccion { set; get; }

        public Cliente(int id, string n, string t, string d)
        {
            IdCliente = id;
            Nombre = n;
            Telefono = t;
            Direccion = d;
        }
    }
}
