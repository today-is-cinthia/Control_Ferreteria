using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria
{
    public class Ferreteria
    {
        public string Producto { set; get; }
        public int IdProducto { set; get; }
        public float Costo { set; get; }
        public float PrecioUni { set; get; }
        public float PrecioMayo { set; get; }
        public int Existencia { set; get; }
        public int StockMax { set; get; }
        public int StockMin { set; get; }

        public Ferreteria(string Desc, int Id, float Cos, float Uni, float Mayo, int Ex, int Max, int Min)
        {
            Producto = Desc;
            IdProducto = Id;
            Costo = Cos;
            PrecioUni = Uni;
            PrecioMayo = Mayo;
            Existencia = Ex;
            StockMax = Max;
            StockMin = Min;
        }
    }
}
