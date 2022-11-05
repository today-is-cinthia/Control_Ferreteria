using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria
{
    public class Carrito
    {
        public int IdFactura { get; set; }
        public string Producto { get; set; }
        public int Cantidad {get; set; }

        public Carrito(int i,string p, int c)
        {
            IdFactura = i;
            Producto = p;
            Cantidad = c;
        }
    }
}
