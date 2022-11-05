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
        //List<Carrito> Productos { set; get; }

        public float Total { set; get; }

        public int IdCliente { set; get; }  
        public Factura(int n, DateTime F, int idc, float T)
        {
            NFactura = n;
           // Productos = P;
            Fecha = F; 
            IdCliente = idc;
            Total = T;
        }
    }
}
