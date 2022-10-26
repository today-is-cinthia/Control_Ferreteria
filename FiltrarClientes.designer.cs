namespace ferreteria
{
    partial class FiltrarClientes
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
        }
        */
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizarMaterial = new System.Windows.Forms.Button();
            this.txtAdvertencia = new System.Windows.Forms.Label();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.txtVerNombreMaterial = new System.Windows.Forms.Label();
            this.errorActualizarMaterial = new System.Windows.Forms.ErrorProvider(this.components);
            this.errornombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errormarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorexistencia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorActualizarMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorexistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarMaterial
            // 
            this.btnActualizarMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnActualizarMaterial.FlatAppearance.BorderSize = 0;
            this.btnActualizarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMaterial.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarMaterial.Location = new System.Drawing.Point(303, 145);
            this.btnActualizarMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarMaterial.Name = "btnActualizarMaterial";
            this.btnActualizarMaterial.Size = new System.Drawing.Size(85, 33);
            this.btnActualizarMaterial.TabIndex = 20;
            this.btnActualizarMaterial.Text = "Hecho";
            this.btnActualizarMaterial.UseVisualStyleBackColor = false;
            this.btnActualizarMaterial.Click += new System.EventHandler(this.btnActualizarMaterial_Click);
            this.btnActualizarMaterial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.valirCampos);
            // 
            // txtAdvertencia
            // 
            this.txtAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdvertencia.AutoSize = true;
            this.txtAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvertencia.ForeColor = System.Drawing.Color.White;
            this.txtAdvertencia.Location = new System.Drawing.Point(398, 344);
            this.txtAdvertencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAdvertencia.Name = "txtAdvertencia";
            this.txtAdvertencia.Size = new System.Drawing.Size(0, 13);
            this.txtAdvertencia.TabIndex = 22;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridClientes.ColumnHeadersHeight = 30;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.Location = new System.Drawing.Point(27, 210);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridClientes.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(650, 214);
            this.gridClientes.TabIndex = 37;
            this.gridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerMateriales_CellClick);
            // 
            // Buscar
            // 
            this.Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(236, 87);
            this.Buscar.Multiline = true;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(215, 42);
            this.Buscar.TabIndex = 40;
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            this.Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto);
            // 
            // txtVerNombreMaterial
            // 
            this.txtVerNombreMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerNombreMaterial.AutoSize = true;
            this.txtVerNombreMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerNombreMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtVerNombreMaterial.Location = new System.Drawing.Point(281, 38);
            this.txtVerNombreMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerNombreMaterial.Name = "txtVerNombreMaterial";
            this.txtVerNombreMaterial.Size = new System.Drawing.Size(117, 20);
            this.txtVerNombreMaterial.TabIndex = 39;
            this.txtVerNombreMaterial.Text = "Filtrar Cliente";
            // 
            // errorActualizarMaterial
            // 
            this.errorActualizarMaterial.ContainerControl = this;
            // 
            // errornombre
            // 
            this.errornombre.ContainerControl = this;
            // 
            // errormarca
            // 
            this.errormarca.ContainerControl = this;
            // 
            // errorexistencia
            // 
            this.errorexistencia.ContainerControl = this;
            // 
            // errorPrecio
            // 
            this.errorPrecio.ContainerControl = this;
            // 
            // FiltrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(714, 532);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.txtVerNombreMaterial);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.txtAdvertencia);
            this.Controls.Add(this.btnActualizarMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FiltrarClientes";
            this.Text = "VerMateriales";
            this.Load += new System.EventHandler(this.FiltrarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorActualizarMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorexistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizarMaterial;
        private System.Windows.Forms.Label txtAdvertencia;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label txtVerNombreMaterial;
        private System.Windows.Forms.ErrorProvider errorActualizarMaterial;
        private System.Windows.Forms.ErrorProvider errornombre;
        private System.Windows.Forms.ErrorProvider errormarca;
        private System.Windows.Forms.ErrorProvider errorexistencia;
        private System.Windows.Forms.ErrorProvider errorPrecio;
    }
}