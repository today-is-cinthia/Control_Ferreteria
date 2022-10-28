using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria
{
    public class Factura
    {
        public int NFactura { set; get; }
        public DateTime Fecha { set; get; }
        public List<Carrito> Productos { set; get; }
        public int Descuento { set; get; }
        public float Total { set; get; }

        public int IdCliente { set; get; }  
        public Factura(int n, DateTime F, List <Carrito> P, int Desc, int idc)
        {
            NFactura = n;
            Productos = P;
            Fecha = F;
            Descuento = Desc;
            IdCliente = idc;
        }
    }
}
