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
        float precio = 0, exitencia = 0, precio_gramo = 0;

        /*Crea la base de datos global
        BaseDeDatos bd = new BaseDeDatos();*/
        public AgregarCliente()
        {
            InitializeComponent();
           // dgvAgregarMaterial.DataSource = bd.SelectDataTable("select nombre_material Nombre, marca Marca, precio_gramo Precio_Gramo, precio_material Precio, existencia Existencia  from Material");
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

       /* private void calculos(object sender, KeyEventArgs e)
        {
            if (txtDireccion.Text != "" && txtTelefono.Text != "")
            {
                precio = float.Parse(txtDireccion.Text);
                exitencia = float.Parse(txtTelefono.Text);
                if (precio == 0)
                {
                    precio_gramo = 1;
                }
                if (exitencia > 1)
                {
                    precio_gramo = precio / exitencia;
                }
                else
                {
                    MessageBox.Show("La existencia no puede ser menor o igual a cero");
                }
            }
        }*/

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            /*string buscarPorid;
            string dato = Buscar.Text;
            if (dato == "")
            {
                buscarPorid = "select nombre_material Nombre, marca Marca, precio_material Precio_kg, existencia Existencia  from Material ORDER BY id_material ASC";
                //  buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos ORDER BY id_productos ASC";
            }
            else
            {
                buscarPorid = "select nombre_material Nombre, marca Marca, precio_material Precio_kg, existencia Existencia  from Material  where nombre_material LIKE '%" + dato + "%' ORDER BY nombre_material ASC";
                // buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
            }*/

            //dgvAgregarMaterial.DataSource = bd.SelectDataTable(buscarPorid);
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
