using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria
{
    public class Carrito
    {
        public string Producto { get; set; }
        public int Cantidad {get; set; }

        public Carrito(string p, int c)
        {
            Producto = p;
            Cantidad = c;
        }
    }
}
