namespace ferreteria
{
    partial class RegistroVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.txtVerTituloFechaRegistroVenta = new System.Windows.Forms.Label();
            this.lblProductosCom = new System.Windows.Forms.Label();
            this.txtAdvertencia = new System.Windows.Forms.Label();
            this.txtNFactura = new System.Windows.Forms.Label();
            this.gridCompras = new System.Windows.Forms.DataGridView();
            this.txtNFac = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroFactura.Location = new System.Drawing.Point(89, 11);
            this.lblNumeroFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(82, 16);
            this.lblNumeroFactura.TabIndex = 1;
            this.lblNumeroFactura.Text = "N_Factura:";
            // 
            // txtVerTituloFechaRegistroVenta
            // 
            this.txtVerTituloFechaRegistroVenta.AutoSize = true;
            this.txtVerTituloFechaRegistroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerTituloFechaRegistroVenta.ForeColor = System.Drawing.Color.Black;
            this.txtVerTituloFechaRegistroVenta.Location = new System.Drawing.Point(117, 54);
            this.txtVerTituloFechaRegistroVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerTituloFechaRegistroVenta.Name = "txtVerTituloFechaRegistroVenta";
            this.txtVerTituloFechaRegistroVenta.Size = new System.Drawing.Size(54, 16);
            this.txtVerTituloFechaRegistroVenta.TabIndex = 2;
            this.txtVerTituloFechaRegistroVenta.Text = "Fecha:";
            // 
            // lblProductosCom
            // 
            this.lblProductosCom.AutoSize = true;
            this.lblProductosCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosCom.ForeColor = System.Drawing.Color.Black;
            this.lblProductosCom.Location = new System.Drawing.Point(86, 97);
            this.lblProductosCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosCom.Name = "lblProductosCom";
            this.lblProductosCom.Size = new System.Drawing.Size(85, 16);
            this.lblProductosCom.TabIndex = 4;
            this.lblProductosCom.Text = "Descuento:";
            // 
            // txtAdvertencia
            // 
            this.txtAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdvertencia.AutoSize = true;
            this.txtAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvertencia.ForeColor = System.Drawing.Color.Black;
            this.txtAdvertencia.Location = new System.Drawing.Point(528, 324);
            this.txtAdvertencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAdvertencia.Name = "txtAdvertencia";
            this.txtAdvertencia.Size = new System.Drawing.Size(0, 16);
            this.txtAdvertencia.TabIndex = 22;
            // 
            // txtNFactura
            // 
            this.txtNFactura.AutoSize = true;
            this.txtNFactura.BackColor = System.Drawing.Color.White;
            this.txtNFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFactura.ForeColor = System.Drawing.Color.Black;
            this.txtNFactura.Location = new System.Drawing.Point(176, 11);
            this.txtNFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNFactura.Name = "txtNFactura";
            this.txtNFactura.Size = new System.Drawing.Size(0, 16);
            this.txtNFactura.TabIndex = 23;
            // 
            // gridCompras
            // 
            this.gridCompras.AllowUserToAddRows = false;
            this.gridCompras.AllowUserToOrderColumns = true;
            this.gridCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.gridCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCompras.ColumnHeadersHeight = 30;
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCompras.EnableHeadersVisualStyles = false;
            this.gridCompras.Location = new System.Drawing.Point(14, 200);
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.ReadOnly = true;
            this.gridCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCompras.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCompras.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCompras.Size = new System.Drawing.Size(716, 294);
            this.gridCompras.TabIndex = 36;
            this.gridCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroVentas_CellClick);
            this.gridCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompras_CellContentClick);
            // 
            // txtNFac
            // 
            this.txtNFac.Location = new System.Drawing.Point(192, 10);
            this.txtNFac.Name = "txtNFac";
            this.txtNFac.Size = new System.Drawing.Size(61, 20);
            this.txtNFac.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(192, 97);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(61, 20);
            this.txtDescuento.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Id Cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(192, 156);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(61, 20);
            this.txtIdCliente.TabIndex = 41;
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(357, 49);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(96, 21);
            this.cbProductos.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(378, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fecha:";
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(742, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNFac);
            this.Controls.Add(this.gridCompras);
            this.Controls.Add(this.txtNFactura);
            this.Controls.Add(this.txtAdvertencia);
            this.Controls.Add(this.lblProductosCom);
            this.Controls.Add(this.txtVerTituloFechaRegistroVenta);
            this.Controls.Add(this.lblNumeroFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistroVentas";
            this.Text = "RegistroVentas";
            this.Load += new System.EventHandler(this.RegistroVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label txtVerTituloFechaRegistroVenta;
        private System.Windows.Forms.Label lblProductosCom;
        private System.Windows.Forms.Label txtAdvertencia;
        private System.Windows.Forms.Label txtNFactura;
        private System.Windows.Forms.DataGridView gridCompras;
        private System.Windows.Forms.TextBox txtNFac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label2;
    }
}