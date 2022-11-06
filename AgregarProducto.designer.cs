namespace ferreteria
{
    partial class AgregarProducto
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtVerPrecioTotal = new System.Windows.Forms.Label();
            this.txtDescProducto = new System.Windows.Forms.TextBox();
            this.txtVerPesoProducto = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.erroragregar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errornombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.errormaterial = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorluz = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPeso = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMayorista = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSMin = new System.Windows.Forms.TextBox();
            this.txtSMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorluz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.Location = new System.Drawing.Point(588, 212);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(76, 30);
            this.btnAgregarProducto.TabIndex = 24;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            this.btnAgregarProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.validarCampos);
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCosto.BackColor = System.Drawing.Color.White;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.Black;
            this.txtCosto.Location = new System.Drawing.Point(207, 179);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(74, 21);
            this.txtCosto.TabIndex = 22;
            this.txtCosto.Text = "0.0";
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            // 
            // txtVerPrecioTotal
            // 
            this.txtVerPrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerPrecioTotal.AutoSize = true;
            this.txtVerPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerPrecioTotal.ForeColor = System.Drawing.Color.Black;
            this.txtVerPrecioTotal.Location = new System.Drawing.Point(57, 185);
            this.txtVerPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerPrecioTotal.Name = "txtVerPrecioTotal";
            this.txtVerPrecioTotal.Size = new System.Drawing.Size(68, 15);
            this.txtVerPrecioTotal.TabIndex = 21;
            this.txtVerPrecioTotal.Text = "Costo C$:";
            // 
            // txtDescProducto
            // 
            this.txtDescProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescProducto.BackColor = System.Drawing.Color.White;
            this.txtDescProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProducto.ForeColor = System.Drawing.Color.Black;
            this.txtDescProducto.Location = new System.Drawing.Point(507, 26);
            this.txtDescProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescProducto.Multiline = true;
            this.txtDescProducto.Name = "txtDescProducto";
            this.txtDescProducto.Size = new System.Drawing.Size(168, 38);
            this.txtDescProducto.TabIndex = 13;
            this.txtDescProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solotex);
            // 
            // txtVerPesoProducto
            // 
            this.txtVerPesoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVerPesoProducto.AutoSize = true;
            this.txtVerPesoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerPesoProducto.ForeColor = System.Drawing.Color.Black;
            this.txtVerPesoProducto.Location = new System.Drawing.Point(388, 29);
            this.txtVerPesoProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVerPesoProducto.Name = "txtVerPesoProducto";
            this.txtVerPesoProducto.Size = new System.Drawing.Size(87, 15);
            this.txtVerPesoProducto.TabIndex = 12;
            this.txtVerPesoProducto.Text = "Descripción:";
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToOrderColumns = true;
            this.gridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.gridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductos.ColumnHeadersHeight = 30;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProductos.EnableHeadersVisualStyles = false;
            this.gridProductos.Location = new System.Drawing.Point(37, 265);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProductos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductos.Size = new System.Drawing.Size(646, 269);
            this.gridProductos.TabIndex = 36;
            // 
            // erroragregar
            // 
            this.erroragregar.ContainerControl = this;
            // 
            // errornombre
            // 
            this.errornombre.ContainerControl = this;
            // 
            // errorcategoria
            // 
            this.errorcategoria.ContainerControl = this;
            // 
            // errormaterial
            // 
            this.errormaterial.ContainerControl = this;
            // 
            // errorluz
            // 
            this.errorluz.ContainerControl = this;
            // 
            // errorPeso
            // 
            this.errorPeso.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Precio Unitario C$:";
            // 
            // txtUnitario
            // 
            this.txtUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitario.BackColor = System.Drawing.Color.White;
            this.txtUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitario.ForeColor = System.Drawing.Color.Black;
            this.txtUnitario.Location = new System.Drawing.Point(207, 74);
            this.txtUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(74, 21);
            this.txtUnitario.TabIndex = 40;
            this.txtUnitario.Text = "0.0";
            this.txtUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitario.EnabledChanged += new System.EventHandler(this.txtUnitario_EnabledChanged);
            this.txtUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Precio Mayorista C$:";
            // 
            // txtMayorista
            // 
            this.txtMayorista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMayorista.BackColor = System.Drawing.Color.White;
            this.txtMayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayorista.ForeColor = System.Drawing.Color.Black;
            this.txtMayorista.Location = new System.Drawing.Point(207, 127);
            this.txtMayorista.Margin = new System.Windows.Forms.Padding(2);
            this.txtMayorista.Name = "txtMayorista";
            this.txtMayorista.Size = new System.Drawing.Size(74, 21);
            this.txtMayorista.TabIndex = 42;
            this.txtMayorista.Text = "0.0";
            this.txtMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMayorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdProducto.BackColor = System.Drawing.Color.White;
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.Color.Black;
            this.txtIdProducto.Location = new System.Drawing.Point(207, 29);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(66, 21);
            this.txtIdProducto.TabIndex = 43;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Id Producto:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(57, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Existencia:";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExistencia.BackColor = System.Drawing.Color.White;
            this.txtExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.ForeColor = System.Drawing.Color.Black;
            this.txtExistencia.Location = new System.Drawing.Point(207, 227);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(66, 21);
            this.txtExistencia.TabIndex = 46;
            this.txtExistencia.Text = "0";
            this.txtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Stock Máximo:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(388, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "Stock Mínimo:";
            // 
            // txtSMin
            // 
            this.txtSMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSMin.BackColor = System.Drawing.Color.White;
            this.txtSMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMin.ForeColor = System.Drawing.Color.Black;
            this.txtSMin.Location = new System.Drawing.Point(507, 101);
            this.txtSMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtSMin.Name = "txtSMin";
            this.txtSMin.Size = new System.Drawing.Size(66, 21);
            this.txtSMin.TabIndex = 49;
            this.txtSMin.Text = "0";
            this.txtSMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            // 
            // txtSMax
            // 
            this.txtSMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSMax.BackColor = System.Drawing.Color.White;
            this.txtSMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMax.ForeColor = System.Drawing.Color.Black;
            this.txtSMax.Location = new System.Drawing.Point(507, 174);
            this.txtSMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtSMax.Name = "txtSMax";
            this.txtSMax.Size = new System.Drawing.Size(66, 21);
            this.txtSMax.TabIndex = 50;
            this.txtSMax.Text = "0";
            this.txtSMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNum);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(717, 546);
            this.Controls.Add(this.txtSMax);
            this.Controls.Add(this.txtSMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtMayorista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtVerPrecioTotal);
            this.Controls.Add(this.txtDescProducto);
            this.Controls.Add(this.txtVerPesoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroragregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errormaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorluz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label txtVerPrecioTotal;
        private System.Windows.Forms.TextBox txtDescProducto;
        private System.Windows.Forms.Label txtVerPesoProducto;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.ErrorProvider erroragregar;
        private System.Windows.Forms.ErrorProvider errornombre;
        private System.Windows.Forms.ErrorProvider errorcategoria;
        private System.Windows.Forms.ErrorProvider errormaterial;
        private System.Windows.Forms.ErrorProvider errorluz;
        private System.Windows.Forms.ErrorProvider errorPeso;
        private System.Windows.Forms.TextBox txtMayorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtSMax;
        private System.Windows.Forms.TextBox txtSMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label4;
    }
}