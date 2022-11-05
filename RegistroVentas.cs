using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferreteria
{
    public partial class RegistroVentas : Form
    {

        public RegistroVentas()
        {
            InitializeComponent();
           // dgvRegistroVentas.DataSource = bd.SelectDataTable("select distinct id_factura N_Factura, productos_vendidos Productos_Comprados, fecha Fecha, total_factura Total_Facturado from Venta ");
        }

        private void dgvRegistroVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistroVentas_Load(object sender, EventArgs e)
        {

            var Consulta = Declaraciones.Productos.Select(x => x.Producto).ToList();

            foreach(var i in Consulta)
            {
                cbProductos.Items.Add(i);
            }
        }

        private void txtFecha_Click(object sender, EventArgs e)
        {

        }

        private void gridCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            float Total = 0;
            var Consulta1 = Declaraciones.Productos.Where(x => x.Producto == cbProductos.Text).Select(x => x.PrecioMayo).First();
            var Consulta2 = Declaraciones.Productos.Where(x => x.Producto == cbProductos.Text).Select(x => x.PrecioUni).First();

            if (int.Parse(txtCant.Text) >= 12)
            {
                Total = float.Parse(txtCant.Text) * Consulta1;
            }
            else
            {
                Total = float.Parse(txtCant.Text) * Consulta2;
            }

            /*Declaraciones.Facturas.Add(new Factura(
                int.Parse(txtNFac.Text),
                DateTime.Parse(dtFactura.Text),
                cbProductos.Text,
                int.Parse(txtCant.Text),
                int.Parse(txtIdCliente.Text),
                Total
                ));*/


            gridCProducto.DataSource = null;
            gridCProducto.DataSource = Declaraciones.Facturas;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Declaraciones.Carrito.Add(new Carrito(
                cbProductos.Text,
                int.Parse(txtCant.Text)
                ));
            gridCarrito.DataSource = null;
            gridCarrito.DataSource = Declaraciones.Carrito;
        }
    }
}
