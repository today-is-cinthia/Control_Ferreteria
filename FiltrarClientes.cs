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
        string estado = "s";
        float precio_gramo = 0, precioMaterial = 0, existencia = 0, nuevaExistencia = 0;

        private bool existenciaBool = false;
        /*Crea la base de datos global*/
        //BaseDeDatos bd = new BaseDeDatos();
        /*datatable global en private para leer los datos*/
        private DataTable dt = new DataTable();

        public FiltrarClientes()
        {
            InitializeComponent();
            //dgvVerMateriales.DataSource = bd.SelectDataTable("select nombre_material Nombre, marca Marca, precio_material Precio_kg, existencia Existencia, estado Estado  from Material ");
            todo_falso();
        }

        private async void btnActualizarMaterial_Click(object sender, EventArgs e)
        {
            var cliente = Declaraciones.Clientes;
            string dato = Buscar.Text;
            if (dato == "")
            {
                errornombre.SetError(Buscar, "Por favor llene este campo");
                // gridClie;ntes.DataSource = Consulta.ToList()
                //  buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos ORDER BY id_productos ASC";
            }
            else
            {
                var Consulta = cliente.Where(x => x.Nombre.Contains(dato)).Select(c => new {Nombres = c.Nombre}).ToList();
                gridClientes.DataSource = Consulta;
                // buscarPorid = "select nombre_material Nombre, marca Marca, precio_material Precio_kg, existencia Existencia, estado Estado  from Material  where nombre_material LIKE '%" + dato + "%' ORDER BY nombre_material ASC";
                // buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
            }

        }

        private void valirCampos(object sender, MouseEventArgs e)
        {
            /*if (!agregar)
            {
                if (txtbVerNomMaterial.Text == "")
                {
                    errornombre.SetError(txtbVerNomMaterial, "Debe llenar este campo");
                }
                if (txtbVerMarcaMaterial.Text == "")
                {
                    errormarca.SetError(txtbVerMarcaMaterial, "Debe llenar este campo");
                }
                if (txtbVerExistenciaMaterial.Text == "")
                {
                    errorexistencia.SetError(txtbVerExistenciaMaterial, "Debe llenar este campo");
                }
                if (txtbVerPreciomaterial.Text == "")
                {
                    errorPrecio.SetError(txtbVerPreciomaterial, "Debe llenar este campo");
                }
            }*/
            agregar = false;
        }

        private void validar(object sender, EventArgs e)
        {
            /*if (txtbVerNomMaterial.Text != "")
            {
                errornombre.SetError(txtVerNombreMaterial, "");
            }
            if (txtbVerMarcaMaterial.Text != "")
            {
                errormarca.SetError(txtbVerMarcaMaterial, "");
            }
            if (txtVerExistenciaMaterial.Text != "")
            {
                errorexistencia.SetError(txtbVerExistenciaMaterial, "");
            }
            if (txtbVerPreciomaterial.Text != "")
            {
                errorPrecio.SetError(txtbVerPreciomaterial, "");
            }*/
        }

       
        private void todo_falso()
        {
           /* txtbVerNomMaterial.Enabled = false;
            txtbVerPreciomaterial.Enabled = false;
            checkModEstadoMaterial.Enabled = false;
            txtbVerMarcaMaterial.Enabled = false;
            txtbVerExistenciaMaterial.Enabled = false;*/
        }

        private void dgvVerMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           /* txtbVerNomMaterial.Text = (string)dgvVerMateriales.CurrentRow.Cells["Nombre"].Value;
            txtbVerMarcaMaterial.Text = (string)dgvVerMateriales.CurrentRow.Cells["Marca"].Value;
            txtbVerPreciomaterial.Text = ((float)dgvVerMateriales.CurrentRow.Cells["Precio_kg"].Value).ToString();
            txtbVerExistenciaMaterial.Text = ((float)dgvVerMateriales.CurrentRow.Cells["Existencia"].Value).ToString();
            string estado = ((string)dgvVerMateriales.CurrentRow.Cells["Estado"].Value);
            if (estado == "s")
            {
                checkModEstadoMaterial.Checked = true;
            }
            else
            {
                checkModEstadoMaterial.Checked = false;
            }

            txtbVerNomMaterial.Enabled = true;
            txtbVerPreciomaterial.Enabled = true;
            checkModEstadoMaterial.Enabled = true;
            txtbVerMarcaMaterial.Enabled = true;
            txtbVerExistenciaMaterial.Enabled = true;

            precioMaterial = float.Parse(txtbVerPreciomaterial.Text);
            nuevaExistencia = float.Parse(this.txtbVerExistenciaMaterial.Text);
           */
        }

        private void FiltrarClientes_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            /*var cliente = Declaraciones.Clientes;
            string dato = Buscar.Text;
            if (dato == "")
            {
                var Consulta = cliente.SelectMany(x => x.Nombre);
                lb.DataSource = null;
                lb.DataSource = Consulta.ToList();
               // gridClie;ntes.DataSource = Consulta.ToList()
                //  buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos ORDER BY id_productos ASC";
            }
            else
            {
                var Consulta = cliente.Where(x => x.Nombre.Contains(dato)).Select(x => x);
                // buscarPorid = "select nombre_material Nombre, marca Marca, precio_material Precio_kg, existencia Existencia, estado Estado  from Material  where nombre_material LIKE '%" + dato + "%' ORDER BY nombre_material ASC";
                // buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
            }*/

           // dgvVerMateriales.DataSource = bd.SelectDataTable(buscarPorid);
        }

        private void soloTexto(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
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
