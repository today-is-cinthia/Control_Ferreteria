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
    public partial class Facturas : Form
    {
        bool agregar = false;

        float Costo_T = 0;


        public Facturas()
        {
            InitializeComponent();
            todo_falso();
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


        private async void btnActualizarMaterial_Click(object sender, EventArgs e)
        {

            var producto = Declaraciones.Facturas;
            string dato = Buscar.Text;
            if (dato == "")
            {
                errornombre.SetError(Buscar, "Por favor llene este campo");

            }
            else
            {
                var Consulta = producto.Where(x => x.NFactura == int.Parse(dato)).Select(c => new { NFactura = c.NFactura, Fecha = c.Fecha, Total = c.Total, IdCliente = c.IdCliente }).ToList();
                gridClientes.DataSource = Consulta;
                int conteo = 0;
                conteo = gridClientes.RowCount;

                for (int i = 0; i < conteo; i++)
                {
                    Costo_T += float.Parse(gridClientes.Rows[i].Cells[4].Value.ToString());
                }
                labelTotal.Text = Costo_T.ToString();
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

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {


        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            float total_desc = 0;
            float desc = float.Parse(txtDescuento.Text) / 100;

            total_desc = Costo_T * desc;

            labelTotal.Text = (Costo_T - total_desc).ToString();
        }

        private void validar(object sender, MouseEventArgs e)
        {
            if (txtDescuento.Text == "")
            {
                errornombre.SetError(txtDescuento, "Debe llenar este campo");
            }
        }
    }
}
