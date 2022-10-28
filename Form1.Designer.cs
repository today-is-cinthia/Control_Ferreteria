namespace ferreteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.icbtn_categorias = new FontAwesome.Sharp.IconButton();
            this.panel_Ventas = new System.Windows.Forms.Panel();
            this.icbtn_registroVenta = new FontAwesome.Sharp.IconButton();
            this.icbtn_ventas = new FontAwesome.Sharp.IconButton();
            this.panel_materiales = new System.Windows.Forms.Panel();
            this.icbtn_ingresarMaterial = new FontAwesome.Sharp.IconButton();
            this.icbtn_materiales = new FontAwesome.Sharp.IconButton();
            this.panel_Productos = new System.Windows.Forms.Panel();
            this.icbtn_agregraProducto = new FontAwesome.Sharp.IconButton();
            this.icbtn_Productos = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_barra = new System.Windows.Forms.Panel();
            this.iconbtn_home = new FontAwesome.Sharp.IconButton();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_lateral.SuspendLayout();
            this.panel_Ventas.SuspendLayout();
            this.panel_materiales.SuspendLayout();
            this.panel_Productos.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel_lateral.Controls.Add(this.icbtn_categorias);
            this.panel_lateral.Controls.Add(this.panel_Ventas);
            this.panel_lateral.Controls.Add(this.icbtn_ventas);
            this.panel_lateral.Controls.Add(this.panel_materiales);
            this.panel_lateral.Controls.Add(this.icbtn_materiales);
            this.panel_lateral.Controls.Add(this.panel_Productos);
            this.panel_lateral.Controls.Add(this.icbtn_Productos);
            this.panel_lateral.Controls.Add(this.panel_logo);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(200, 622);
            this.panel_lateral.TabIndex = 0;
            this.panel_lateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_lateral_Paint);
            // 
            // icbtn_categorias
            // 
            this.icbtn_categorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_categorias.FlatAppearance.BorderSize = 0;
            this.icbtn_categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_categorias.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_categorias.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.icbtn_categorias.IconColor = System.Drawing.Color.White;
            this.icbtn_categorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_categorias.IconSize = 35;
            this.icbtn_categorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_categorias.Location = new System.Drawing.Point(0, 338);
            this.icbtn_categorias.Name = "icbtn_categorias";
            this.icbtn_categorias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.icbtn_categorias.Size = new System.Drawing.Size(200, 40);
            this.icbtn_categorias.TabIndex = 10;
            this.icbtn_categorias.Text = "Facturas y Clientes";
            this.icbtn_categorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_categorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_categorias.UseVisualStyleBackColor = true;
            this.icbtn_categorias.Click += new System.EventHandler(this.icbtnCategoria_Click);
            // 
            // panel_Ventas
            // 
            this.panel_Ventas.Controls.Add(this.icbtn_registroVenta);
            this.panel_Ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Ventas.Location = new System.Drawing.Point(0, 294);
            this.panel_Ventas.Name = "panel_Ventas";
            this.panel_Ventas.Size = new System.Drawing.Size(200, 44);
            this.panel_Ventas.TabIndex = 8;
            // 
            // icbtn_registroVenta
            // 
            this.icbtn_registroVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_registroVenta.FlatAppearance.BorderSize = 0;
            this.icbtn_registroVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_registroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_registroVenta.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_registroVenta.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.icbtn_registroVenta.IconColor = System.Drawing.Color.White;
            this.icbtn_registroVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_registroVenta.IconSize = 35;
            this.icbtn_registroVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_registroVenta.Location = new System.Drawing.Point(0, 0);
            this.icbtn_registroVenta.Name = "icbtn_registroVenta";
            this.icbtn_registroVenta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtn_registroVenta.Size = new System.Drawing.Size(200, 40);
            this.icbtn_registroVenta.TabIndex = 4;
            this.icbtn_registroVenta.Text = "Facturar Compra";
            this.icbtn_registroVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_registroVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_registroVenta.UseVisualStyleBackColor = true;
            this.icbtn_registroVenta.Click += new System.EventHandler(this.icbtn_registroVenta_Click);
            // 
            // icbtn_ventas
            // 
            this.icbtn_ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_ventas.FlatAppearance.BorderSize = 0;
            this.icbtn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_ventas.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_ventas.IconChar = FontAwesome.Sharp.IconChar.CcDinersClub;
            this.icbtn_ventas.IconColor = System.Drawing.Color.White;
            this.icbtn_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_ventas.IconSize = 35;
            this.icbtn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_ventas.Location = new System.Drawing.Point(0, 254);
            this.icbtn_ventas.Name = "icbtn_ventas";
            this.icbtn_ventas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.icbtn_ventas.Size = new System.Drawing.Size(200, 40);
            this.icbtn_ventas.TabIndex = 7;
            this.icbtn_ventas.Text = "Facturas";
            this.icbtn_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_ventas.UseVisualStyleBackColor = true;
            this.icbtn_ventas.Click += new System.EventHandler(this.icbtn_ventas_Click);
            // 
            // panel_materiales
            // 
            this.panel_materiales.Controls.Add(this.icbtn_ingresarMaterial);
            this.panel_materiales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_materiales.Location = new System.Drawing.Point(0, 212);
            this.panel_materiales.Name = "panel_materiales";
            this.panel_materiales.Size = new System.Drawing.Size(200, 42);
            this.panel_materiales.TabIndex = 6;
            // 
            // icbtn_ingresarMaterial
            // 
            this.icbtn_ingresarMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_ingresarMaterial.FlatAppearance.BorderSize = 0;
            this.icbtn_ingresarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_ingresarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_ingresarMaterial.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_ingresarMaterial.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icbtn_ingresarMaterial.IconColor = System.Drawing.Color.White;
            this.icbtn_ingresarMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_ingresarMaterial.IconSize = 35;
            this.icbtn_ingresarMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_ingresarMaterial.Location = new System.Drawing.Point(0, 0);
            this.icbtn_ingresarMaterial.Name = "icbtn_ingresarMaterial";
            this.icbtn_ingresarMaterial.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtn_ingresarMaterial.Size = new System.Drawing.Size(200, 40);
            this.icbtn_ingresarMaterial.TabIndex = 4;
            this.icbtn_ingresarMaterial.Text = "Ingresar Cliente";
            this.icbtn_ingresarMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_ingresarMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_ingresarMaterial.UseVisualStyleBackColor = true;
            this.icbtn_ingresarMaterial.Click += new System.EventHandler(this.icbtn_ingresarMaterial_Click);
            // 
            // icbtn_materiales
            // 
            this.icbtn_materiales.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_materiales.FlatAppearance.BorderSize = 0;
            this.icbtn_materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_materiales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_materiales.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_materiales.IconChar = FontAwesome.Sharp.IconChar.Pagelines;
            this.icbtn_materiales.IconColor = System.Drawing.Color.White;
            this.icbtn_materiales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_materiales.IconSize = 35;
            this.icbtn_materiales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_materiales.Location = new System.Drawing.Point(0, 166);
            this.icbtn_materiales.Name = "icbtn_materiales";
            this.icbtn_materiales.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.icbtn_materiales.Size = new System.Drawing.Size(200, 46);
            this.icbtn_materiales.TabIndex = 13;
            this.icbtn_materiales.Text = "Clientes";
            this.icbtn_materiales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_materiales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_materiales.UseVisualStyleBackColor = true;
            this.icbtn_materiales.Click += new System.EventHandler(this.icbtn_materiales_Click);
            // 
            // panel_Productos
            // 
            this.panel_Productos.Controls.Add(this.icbtn_agregraProducto);
            this.panel_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Productos.Location = new System.Drawing.Point(0, 112);
            this.panel_Productos.Name = "panel_Productos";
            this.panel_Productos.Size = new System.Drawing.Size(200, 54);
            this.panel_Productos.TabIndex = 4;
            // 
            // icbtn_agregraProducto
            // 
            this.icbtn_agregraProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_agregraProducto.FlatAppearance.BorderSize = 0;
            this.icbtn_agregraProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_agregraProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_agregraProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_agregraProducto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icbtn_agregraProducto.IconColor = System.Drawing.Color.White;
            this.icbtn_agregraProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_agregraProducto.IconSize = 35;
            this.icbtn_agregraProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_agregraProducto.Location = new System.Drawing.Point(0, 0);
            this.icbtn_agregraProducto.Name = "icbtn_agregraProducto";
            this.icbtn_agregraProducto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtn_agregraProducto.Size = new System.Drawing.Size(200, 40);
            this.icbtn_agregraProducto.TabIndex = 0;
            this.icbtn_agregraProducto.Text = "Agregar Producto";
            this.icbtn_agregraProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_agregraProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_agregraProducto.UseVisualStyleBackColor = true;
            this.icbtn_agregraProducto.Click += new System.EventHandler(this.icbtn_agregraProducto_Click);
            // 
            // icbtn_Productos
            // 
            this.icbtn_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtn_Productos.FlatAppearance.BorderSize = 0;
            this.icbtn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_Productos.ForeColor = System.Drawing.SystemColors.Window;
            this.icbtn_Productos.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.icbtn_Productos.IconColor = System.Drawing.Color.White;
            this.icbtn_Productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_Productos.IconSize = 35;
            this.icbtn_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Productos.Location = new System.Drawing.Point(0, 72);
            this.icbtn_Productos.Name = "icbtn_Productos";
            this.icbtn_Productos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.icbtn_Productos.Size = new System.Drawing.Size(200, 40);
            this.icbtn_Productos.TabIndex = 12;
            this.icbtn_Productos.Text = "Productos";
            this.icbtn_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_Productos.UseVisualStyleBackColor = true;
            this.icbtn_Productos.Click += new System.EventHandler(this.icbtn_Productos_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 72);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_barra
            // 
            this.panel_barra.Controls.Add(this.iconbtn_home);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Location = new System.Drawing.Point(200, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(713, 72);
            this.panel_barra.TabIndex = 1;
            this.panel_barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barra_MouseDown);
            // 
            // iconbtn_home
            // 
            this.iconbtn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconbtn_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconbtn_home.FlatAppearance.BorderSize = 0;
            this.iconbtn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtn_home.ForeColor = System.Drawing.SystemColors.Window;
            this.iconbtn_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconbtn_home.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.iconbtn_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtn_home.IconSize = 60;
            this.iconbtn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtn_home.Location = new System.Drawing.Point(0, 0);
            this.iconbtn_home.Name = "iconbtn_home";
            this.iconbtn_home.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.iconbtn_home.Size = new System.Drawing.Size(713, 72);
            this.iconbtn_home.TabIndex = 13;
            this.iconbtn_home.Text = "Home";
            this.iconbtn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtn_home.UseVisualStyleBackColor = false;
            this.iconbtn_home.Click += new System.EventHandler(this.iconbtn_home_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.Silver;
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(200, 72);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(713, 550);
            this.panel_contenedor.TabIndex = 2;
            this.panel_contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(913, 622);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_barra);
            this.Controls.Add(this.panel_lateral);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_lateral.ResumeLayout(false);
            this.panel_Ventas.ResumeLayout(false);
            this.panel_materiales.ResumeLayout(false);
            this.panel_Productos.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_barra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Panel panel_logo;
        private FontAwesome.Sharp.IconButton icbtn_ingresarMaterial;
        private FontAwesome.Sharp.IconButton icbtn_registroVenta;
        private System.Windows.Forms.Panel panel_Productos;
        private System.Windows.Forms.Panel panel_materiales;
        private FontAwesome.Sharp.IconButton icbtn_categorias;
        private System.Windows.Forms.Panel panel_Ventas;
        private FontAwesome.Sharp.IconButton icbtn_ventas;
        private System.Windows.Forms.Panel panel_barra;
        private FontAwesome.Sharp.IconButton icbtn_materiales;
        private FontAwesome.Sharp.IconButton icbtn_Productos;
        private FontAwesome.Sharp.IconButton iconbtn_home;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton icbtn_agregraProducto;
    }
}

