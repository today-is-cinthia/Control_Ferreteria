using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria
{
    public class Carrito
    {
        public string Nproducto { get; set; }
        public int Cantidad { get; set; }

        public Carrito(string n, int c)
        {
            Nproducto = n;
            Cantidad = c;
        }
    }
}
