﻿using System;
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
                var Consulta = from fac in Declaraciones.Facturas join cl in Declaraciones.Clientes on fac.IdCliente equals cl.IdCliente where fac.IdCliente == int.Parse(dato) select new { Fecha = fac.Fecha };
                gridClientes.DataSource = null;
                gridClientes.DataSource = Consulta; 
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