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
        }
        private void SoloNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void solotex(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
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

            Declaraciones.Facturas.Add(new Factura(
                int.Parse(txtNFac.Text),
                DateTime.Parse(dtFactura.Text),
                Declaraciones.Carrito,
                int.Parse(txtIdCliente.Text),
                Total
                ));


            gridCProducto.DataSource = null;
            gridCProducto.DataSource = Declaraciones.Facturas;

  
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Declaraciones.Carrito.Add(new Carrito(
                int.Parse(txtNFac.Text),
                cbProductos.Text,
                int.Parse(txtCant.Text)
                ));
            gridCarrito.DataSource = null;
            gridCarrito.DataSource = Declaraciones.Carrito;

        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            var Consulta3 = Declaraciones.Carrito.Where(x => x.IdFactura == int.Parse(txtNFac.Text)).Select(c => new {Producto =  c.Producto, Cantidad = c.Cantidad}).ToList();
            gridProductos.DataSource = null;
            gridProductos.DataSource = Consulta3;
        }

        private void solotex(object sender, MouseEventArgs e)
        {

        }

        private void validar(object sender, MouseEventArgs e)
        {
            if (txtNFac.Text == "")
            {
                error.SetError(txtNFac, "Debe llenar este campo");
            }
            if (cbProductos.Text == "")
            {
                error.SetError(cbProductos, "Debe llenar este campo");
            }
        }

        private void val(object sender, MouseEventArgs e)
        {
            if (txtNFac.Text == "")
            {
                error.SetError(txtNFac, "Debe llenar este campo");
            }
            if (txtIdCliente.Text == "")
            {
                error.SetError(txtIdCliente, "Debe llenar este campo");
            }
        }
    }
}
