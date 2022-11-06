using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace ferreteria
{
    public partial class AgregarProducto : Form
    {
        bool agregar = false;

        public AgregarProducto()
        {
            InitializeComponent();

        }

        void Limpiar()
        {
            txtDescProducto.Clear();
            txtDescProducto.Focus();
            txtIdProducto.Clear();
            txtMayorista.Text = "0.0";
            txtCosto.Text = "0.0";
            txtSMax.Text = "0";
            txtSMin.Text = "0";
            txtUnitario.Text = "0.0";
            txtExistencia.Text = "0";
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

            gridProductos.DataSource = null;
            gridProductos.DataSource = Declaraciones.Productos;
        }

        private void solotex(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtUnitario_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private async void txtbNombreProducto_KeyPress(object senderTxtb, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                await Task.Delay(1200);
            }
        }


        private void SoloNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.')> -1))
            {
                e.Handled = true;
            }
        }
        public void calculos(object sender, KeyEventArgs e)
        {
            
        }

      
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (txtIdProducto.Text == "" ||  txtDescProducto.Text == "" || txtCosto.Text == "" || txtUnitario.Text == "" || txtMayorista.Text == "" || txtExistencia.Text == "" || txtSMax.Text == "" || txtSMin.Text == "")
            {
                erroragregar.SetError(btnAgregarProducto, "Uno o varios campos aun no llenos");
            }
            else
            {
                erroragregar.SetError(btnAgregarProducto, "");


                Declaraciones.Productos.Add(new Ferreteria ( 
                    txtDescProducto.Text,
                    int.Parse(txtIdProducto.Text),
                    float.Parse(txtCosto.Text),
                    float.Parse(txtUnitario.Text),
                    float.Parse(txtMayorista.Text),
                    int.Parse(txtExistencia.Text),
                    int.Parse(txtSMax.Text),
                    int.Parse(txtSMin.Text)
                ));

                gridProductos.DataSource = null;
                gridProductos.DataSource = Declaraciones.Productos;


                agregar = true;
                Limpiar();
            }
        }
        private void validarCampos(object sender, MouseEventArgs e)
        {
            if (!agregar)
            {
                if (txtDescProducto.Text == "")
                {
                    errorluz.SetError(txtIdProducto, "Debe llenar este campo");
                }
                if (txtDescProducto.Text == "")
                {
                    errorPeso.SetError(txtDescProducto, "Debe llenar este campo");
                }
            }
            agregar = false;
        }


    }
}
