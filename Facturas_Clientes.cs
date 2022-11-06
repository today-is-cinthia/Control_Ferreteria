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
    public partial class Facturas_Clientes : Form
    {
        bool agregar = false;


        public Facturas_Clientes()
        {
            InitializeComponent();
        }

        private async void btnActualizarMaterial_Click(object sender, EventArgs e)
        {
            string dato = Buscar.Text;
            if (dato == "")
            {
                errornombre.SetError(Buscar, "Por favor llene este campo");
               
            }
            else
            {
                var Consulta = Declaraciones.Facturas.Where(item => item.IdCliente == int.Parse(Buscar.Text)).ToList();
                gridClientes.DataSource = null;
                gridClientes.DataSource = Consulta;
                var Consulta1 = Declaraciones.Facturas.Where(x => x.IdCliente == int.Parse(dato)).Select(x => x.NFactura).First();
                var Consulta2 = Declaraciones.Carrito.Where(x => x.IdFactura == Consulta1).Select(c => new {Producto = c.Producto, Cantidad = c.Cantidad}).ToList();
                gridProductos.DataSource = null;
                gridProductos.DataSource = Consulta2;
            }

        }

        private void valirCampos(object sender, MouseEventArgs e)
        {
            if (!agregar)
            {
                if (Buscar.Text == "")
                {
                    errornombre.SetError(Buscar, "Debe llenar este campo");
                }
            }
            agregar = false;
        }

        private void validar(object sender, EventArgs e)
        {

        }

       
        private void todo_falso()
        {
        }

        private void dgvVerMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FiltrarClientes_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void soloNum(object sender, KeyPressEventArgs e)
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

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
