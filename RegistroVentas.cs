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
        int id_venta= 0;

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
    }
}
