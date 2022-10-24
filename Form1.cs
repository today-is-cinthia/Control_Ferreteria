using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; 

namespace ferreteria
{
    public partial class Form1 : Form
    {
        private IconButton botonactual;
        private Panel bordelateralbtn;
        private Form formularioactual;
        private bool submenuBool;

        //constructor
        public Form1()
        {
            InitializeComponent();
            bordelateralbtn = new Panel();
            bordelateralbtn.Size = new Size(7,39);
            panel_lateral.Controls.Add(bordelateralbtn);
            ocultarSubMenu();
            this.Text = string.Empty;
        }

        /*Crea la base de datos global*/
        //BaseDeDatos bd = new BaseDeDatos();

        //estructura para colores
        private struct RGBcolore
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 162, 252);
        }

        private void AbrirFormularioHijo(Form formhijo)
        {
            if(formularioactual != null)
            {
                //Abrir
                formularioactual.Close();
            }
            formularioactual = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(formhijo);
            panel_contenedor.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }

        private void ocultarSubMenu()/*con este método ocultamos los paneles seleccionados dandoles un valor de falso*/
        {
             panel_Productos.Visible = false;
             panel_materiales.Visible = false;
             panel_Ventas.Visible = false;
        }
        private void mostrarSubMenu(Panel subMenu)/*con estemetodo mostramos los paneles seleccionados dandoles un valor de verdadero*/
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
                submenuBool = true;
                //Este bool no permite que se acceda al form inicial mientras no se toque el botón Home
            }
            /*El siguiente código está comentado para que no se cierre el panel reciente*/
            else
            {
                subMenu.Visible = true;
            }
        }

        private void icbtn_Productos_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new VerProductos());
            mostrarSubMenu(panel_Productos);
            Activarboton(sender, RGBcolore.color1);
        }
        private void icbtn_ventas_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new VerVentas());
            mostrarSubMenu(panel_Ventas);
            Activarboton(sender, RGBcolore.color2);
        }
        private void icbtn_materiales_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new VerMateriales());
            mostrarSubMenu(panel_materiales);
            Activarboton(sender, RGBcolore.color3);
        }
        private void icbtnCategoria_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            //AbrirFormularioHijo(new VerCategorias());
            Activarboton(sender, RGBcolore.color6);
        }
        private void panel_lateral_Paint(object sender, PaintEventArgs e)
        {
            if(submenuBool == false)
            {
                //AbrirFormularioHijo(new Inicio());
            }
            else
            {
                return;
            }
        }
        private void icbtn_ingresarMaterial_Click(object sender, EventArgs e)
        {
            Activarbotondepanel(sender, RGBcolore.color3);
            //AbrirFormularioHijo(new AgregarCliente());
        }

        private void reset() /**/
        {
            Desactivarboton();
            bordelateralbtn.Visible = false;
            iconbtn_home.IconChar = IconChar.Home;
            iconbtn_home.IconColor = Color.MediumPurple;
            iconbtn_home.Text = "Home";
            ocultarSubMenu();
        }

        //Abrir y cerrar botones
        private void Activarboton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                Desactivarboton();
                botonactual = (IconButton)senderBtn;
                botonactual.BackColor = Color.FromArgb(37, 36, 81);
                botonactual.ForeColor = color;
                botonactual.TextAlign = ContentAlignment.MiddleCenter;
                botonactual.IconColor = color;
                botonactual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonactual.ImageAlign = ContentAlignment.MiddleRight;
                //borde del boton
                bordelateralbtn.BackColor = color;
                bordelateralbtn.Location = new Point(0, botonactual.Location.Y);
                bordelateralbtn.Visible = true;
                bordelateralbtn.BringToFront();
                //
                iconbtn_home.IconChar = botonactual.IconChar;
                iconbtn_home.IconColor = color;
                iconbtn_home.Text = botonactual.Text;
            }
        }
        //Abrir y cerrar botones
        private void Activarbotondepanel(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                Desactivarboton();
                botonactual = (IconButton)senderBtn;
                botonactual.BackColor = Color.FromArgb(37, 36, 81);
                botonactual.ForeColor = color;
                botonactual.TextAlign = ContentAlignment.MiddleCenter;
                botonactual.IconColor = color;
                botonactual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonactual.ImageAlign = ContentAlignment.MiddleRight;
                //
                iconbtn_home.IconChar = botonactual.IconChar;
                iconbtn_home.IconColor = color;
                iconbtn_home.Text = botonactual.Text;
            }
        }

        private void Desactivarboton()
        {
            if (botonactual != null)
            {
                botonactual.BackColor = Color.FromArgb(31, 30, 68);
                botonactual.ForeColor = Color.Gainsboro;
                botonactual.TextAlign = ContentAlignment.MiddleLeft;
                botonactual.IconColor = Color.Gainsboro;
                botonactual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonactual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Arrastrar Formulario
        [DllImport("user32.DLL",EntryPoint = "RealseCapture")]
        private extern static void RealseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,int wParam, int lparam);

        private void panel_barra_MouseDown(object sender, MouseEventArgs e)
        {
            /*RealseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);*/
        }

        private void iconbtn_home_Click(object sender, EventArgs e)
        {
            submenuBool = false;
            //AbrirFormularioHijo(new Inicio());
            reset();
        }

        private void icbtn_registroVenta_Click(object sender, EventArgs e)
        {
            Activarbotondepanel(sender, RGBcolore.color2);
            //AbrirFormularioHijo(new RegistroVentas());
        }

        private void icbtn_agregraProducto_Click(object sender, EventArgs e)
        {
            Activarbotondepanel(sender, RGBcolore.color1);
            //AbrirFormularioHijo(new AgregarProducto());
        }

        private void icbtn_modificarProducto_Click_1(object sender, EventArgs e)
        {
            Activarbotondepanel(sender, RGBcolore.color1);
           // AbrirFormularioHijo(new ModificarProducto());
        }

        private void panel_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
