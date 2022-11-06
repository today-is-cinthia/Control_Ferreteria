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
    public partial class FiltrarClientes : Form
    {
        bool agregar = false;

        private bool existenciaBool = false;
        private DataTable dt = new DataTable();

        public FiltrarClientes()
        {
            InitializeComponent();
        }

        private async void btnActualizarMaterial_Click(object sender, EventArgs e)
        {
            var cliente = Declaraciones.Clientes;
            string dato = Buscar.Text;
            if (dato == "")
            {
                errornombre.SetError(Buscar, "Por favor llene este campo");
               
            }
            else
            {
                var Consulta = cliente.Where(x => x.Nombre.Contains(dato)).Select(c => new {Id = c.IdCliente ,Nombres = c.Nombre, Teléfono = c.Telefono, Direccion = c.Direccion}).ToList();
                gridClientes.DataSource = Consulta;
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

        private void soloTexto(object sender, KeyPressEventArgs e)
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

    }
}
