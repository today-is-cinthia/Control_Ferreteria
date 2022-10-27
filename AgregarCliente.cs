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
    public partial class AgregarCliente : Form
    {
        bool agregar = false;


        public AgregarCliente()
        {
            InitializeComponent();
          
        }

        void Limpiar()
        {
            txtIdCliente.Clear();
            txtDireccion.Clear();
            txtNombreCliente.Clear();
            txtTelefono.Clear();
            txtIdCliente.Focus();
        }

        //evento keypress para solo pasar numeros a al peso y al costo_luz
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

        private void validarCampos(object sender, MouseEventArgs e)
        {
            if (!agregar)
            {
                if (txtNombreCliente.Text == "")
                {
                    errornombre.SetError(txtNombreCliente, "Debe llenar este campo");
                }
                if (txtIdCliente.Text == "")
                {
                    errormarca.SetError(txtIdCliente, "Debe llenar este campo");
                }
                if (txtDireccion.Text == "")
                {
                    errorprecio.SetError(txtDireccion, "Debe llenar este campo");
                }
                if (txtTelefono.Text == "")
                {
                    errorexistencia.SetError(txtTelefono, "Debe llenar este campo");
                }
            }
            agregar = false;
        }


        private void Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVerNombreMaterial_Click(object sender, EventArgs e)
        {

        }

        private void IngresarMaterial_Load(object sender, EventArgs e)
        {
            gridClientes.DataSource = null;
            gridClientes.DataSource = Declaraciones.Clientes;
        }

        private void txtTelefono_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtIngMatExistencia_Click(object sender, EventArgs e)
        {

        }

        private void validar(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text != "")
            {
                errornombre.SetError(txtNombreCliente, "");
            }
            if (txtIdCliente.Text != "")
            {
                errormarca.SetError(txtIdCliente, "");
            }
            if (txtDireccion.Text != "")
            {
                errorprecio.SetError(txtDireccion, "");
            }
            if (txtTelefono.Text != "")
            {
                errorexistencia.SetError(txtTelefono, "");
            }
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "" || txtIdCliente.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == "")
            {
                erroragregar.SetError(btnAgregarMaterial, "Uno o varios campos aun no llenos");
            }
            else
            {
                erroragregar.SetError(btnAgregarMaterial, "");

                Declaraciones.Clientes.Add(new Cliente(
                    int.Parse(txtIdCliente.Text),
                    txtNombreCliente.Text,
                    txtTelefono.Text,
                    txtDireccion.Text
                    ));

                gridClientes.DataSource = null;
                gridClientes.DataSource = Declaraciones.Clientes;

                agregar = true;

                Limpiar();
               // dgvAgregarMaterial.DataSource = bd.SelectDataTable("select nombre_material Nombre, marca Marca, precio_gramo Precio_Gramo, precio_material Precio, existencia Existencia  from Material");
            }
        }
    }
}
