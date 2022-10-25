namespace ferreteria
{
    partial class AgregarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIngMatNombre = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIngMatMarca = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIngMatPreciomaterial = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtIngMatExistencia = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.txtAdvertencia = new System.Windows.Forms.Label();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.erroragregar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errornombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errormarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorprecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorexistencia = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorexistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngMatNombre
            // 
            this.txtIngMatNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngMatNombre.AutoSize = true;
            this.txtIngMatNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMatNombre.ForeColor = System.Drawing.Color.Black;
            this.txtIngMatNombre.Location = new System.Drawing.Point(100, 64);
            this.txtIngMatNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIngMatNombre.Name = "txtIngMatNombre";
            this.txtIngMatNombre.Size = new System.Drawing.Size(66, 16);
            this.txtIngMatNombre.TabIndex = 4;
            this.txtIngMatNombre.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreCliente.BackColor = System.Drawing.Color.White;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCliente.Location = new System.Drawing.Point(192, 64);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(123, 20);
            this.txtNombreCliente.TabIndex = 39;
            this.txtNombreCliente.Click += new System.EventHandler(this.validar);
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solotex);
            // 
            // txtIngMatMarca
            // 
            this.txtIngMatMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngMatMarca.AutoSize = true;
            this.txtIngMatMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMatMarca.ForeColor = System.Drawing.Color.Black;
            this.txtIngMatMarca.Location = new System.Drawing.Point(100, 27);
            this.txtIngMatMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIngMatMarca.Name = "txtIngMatMarca";
            this.txtIngMatMarca.Size = new System.Drawing.Size(76, 16);
            this.txtIngMatMarca.TabIndex = 6;
            this.txtIngMatMarca.Text = "Id Cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCliente.BackColor = System.Drawing.Color.White;
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.ForeColor = System.Drawing.Color.Black;
            this.txtIdCliente.Location = new System.Drawing.Point(192, 24);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(48, 22);
            this.txtIdCliente.TabIndex = 38;
            this.txtIdCliente.Click += new System.EventHandler(this.validar);
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            // 
            // txtIngMatPreciomaterial
            // 
            this.txtIngMatPreciomaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngMatPreciomaterial.AutoSize = true;
            this.txtIngMatPreciomaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMatPreciomaterial.ForeColor = System.Drawing.Color.Black;
            this.txtIngMatPreciomaterial.Location = new System.Drawing.Point(369, 27);
            this.txtIngMatPreciomaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIngMatPreciomaterial.Name = "txtIngMatPreciomaterial";
            this.txtIngMatPreciomaterial.Size = new System.Drawing.Size(77, 16);
            this.txtIngMatPreciomaterial.TabIndex = 10;
            this.txtIngMatPreciomaterial.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(479, 24);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(164, 56);
            this.txtDireccion.TabIndex = 11;
            this.txtDireccion.Click += new System.EventHandler(this.validar);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solotex);
            // 
            // txtIngMatExistencia
            // 
            this.txtIngMatExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngMatExistencia.AutoSize = true;
            this.txtIngMatExistencia.BackColor = System.Drawing.Color.Silver;
            this.txtIngMatExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngMatExistencia.ForeColor = System.Drawing.Color.Black;
            this.txtIngMatExistencia.Location = new System.Drawing.Point(100, 116);
            this.txtIngMatExistencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIngMatExistencia.Name = "txtIngMatExistencia";
            this.txtIngMatExistencia.Size = new System.Drawing.Size(73, 16);
            this.txtIngMatExistencia.TabIndex = 12;
            this.txtIngMatExistencia.Text = "Teléfono:";
            this.txtIngMatExistencia.Click += new System.EventHandler(this.txtIngMatExistencia_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(192, 110);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 22);
            this.txtTelefono.TabIndex = 13;
            this.txtTelefono.Click += new System.EventHandler(this.validar);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            this.txtTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyUp);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnAgregarMaterial.FlatAppearance.BorderSize = 0;
            this.btnAgregarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMaterial.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(445, 135);
            this.btnAgregarMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(76, 33);
            this.btnAgregarMaterial.TabIndex = 16;
            this.btnAgregarMaterial.Text = "Agregar";
            this.btnAgregarMaterial.UseVisualStyleBackColor = false;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            this.btnAgregarMaterial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.validarCampos);
            // 
            // txtAdvertencia
            // 
            this.txtAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdvertencia.AutoSize = true;
            this.txtAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvertencia.ForeColor = System.Drawing.Color.Black;
            this.txtAdvertencia.Location = new System.Drawing.Point(166, 352);
            this.txtAdvertencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAdvertencia.Name = "txtAdvertencia";
            this.txtAdvertencia.Size = new System.Drawing.Size(0, 16);
            this.txtAdvertencia.TabIndex = 17;
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToOrderColumns = true;
            this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.ColumnHeadersHeight = 30;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.Location = new System.Drawing.Point(29, 211);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridClientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(650, 264);
            this.gridClientes.TabIndex = 37;
            // 
            // erroragregar
            // 
            this.erroragregar.ContainerControl = this;
            // 
            // errornombre
            // 
            this.errornombre.ContainerControl = this;
            // 
            // errormarca
            // 
            this.errormarca.ContainerControl = this;
            // 
            // errorprecio
            // 
            this.errorprecio.ContainerControl = this;
            // 
            // errorexistencia
            // 
            this.errorexistencia.ContainerControl = this;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(719, 539);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.txtAdvertencia);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtIngMatExistencia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtIngMatPreciomaterial);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtIngMatMarca);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIngMatNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarCliente";
            this.Text = "IngresarMaterial";
            this.Load += new System.EventHandler(this.IngresarMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorexistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtIngMatNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label txtIngMatMarca;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label txtIngMatPreciomaterial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label txtIngMatExistencia;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Label txtAdvertencia;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.ErrorProvider erroragregar;
        private System.Windows.Forms.ErrorProvider errornombre;
        private System.Windows.Forms.ErrorProvider errormarca;
        private System.Windows.Forms.ErrorProvider errorprecio;
        private System.Windows.Forms.ErrorProvider errorexistencia;
    }
}