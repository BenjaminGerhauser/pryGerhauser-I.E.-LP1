namespace pryGerhauser_I.E.LP1
{
    partial class frmCargaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaVentas));
            this.tabControlCargaVenta = new System.Windows.Forms.TabControl();
            this.VentanaRegistro = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.mrcCargaVenta = new System.Windows.Forms.GroupBox();
            this.nUDID = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.txtProdcuto = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPtoducto = new System.Windows.Forms.Label();
            this.nUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.VentanaConsulta = new System.Windows.Forms.TabPage();
            this.cboProductosConsulta = new System.Windows.Forms.ComboBox();
            this.txtProductoConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rbCantidad = new System.Windows.Forms.RadioButton();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlCargaVenta.SuspendLayout();
            this.VentanaRegistro.SuspendLayout();
            this.mrcCargaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).BeginInit();
            this.VentanaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCargaVenta
            // 
            this.tabControlCargaVenta.Controls.Add(this.VentanaRegistro);
            this.tabControlCargaVenta.Controls.Add(this.VentanaConsulta);
            this.tabControlCargaVenta.Location = new System.Drawing.Point(14, 27);
            this.tabControlCargaVenta.Name = "tabControlCargaVenta";
            this.tabControlCargaVenta.SelectedIndex = 0;
            this.tabControlCargaVenta.Size = new System.Drawing.Size(373, 536);
            this.tabControlCargaVenta.TabIndex = 1;
            // 
            // VentanaRegistro
            // 
            this.VentanaRegistro.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VentanaRegistro.Controls.Add(this.btnRegistrar);
            this.VentanaRegistro.Controls.Add(this.mrcCargaVenta);
            this.VentanaRegistro.Location = new System.Drawing.Point(4, 22);
            this.VentanaRegistro.Name = "VentanaRegistro";
            this.VentanaRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaRegistro.Size = new System.Drawing.Size(365, 510);
            this.VentanaRegistro.TabIndex = 0;
            this.VentanaRegistro.Text = "Registrar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(138, 374);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 27);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // mrcCargaVenta
            // 
            this.mrcCargaVenta.Controls.Add(this.nUDID);
            this.mrcCargaVenta.Controls.Add(this.lblID);
            this.mrcCargaVenta.Controls.Add(this.txtProdcuto);
            this.mrcCargaVenta.Controls.Add(this.lblTitulo);
            this.mrcCargaVenta.Controls.Add(this.lblFecha);
            this.mrcCargaVenta.Controls.Add(this.lblCantidad);
            this.mrcCargaVenta.Controls.Add(this.lblPtoducto);
            this.mrcCargaVenta.Controls.Add(this.nUDCantidad);
            this.mrcCargaVenta.Controls.Add(this.dtpFecha);
            this.mrcCargaVenta.Location = new System.Drawing.Point(84, 81);
            this.mrcCargaVenta.Name = "mrcCargaVenta";
            this.mrcCargaVenta.Size = new System.Drawing.Size(201, 259);
            this.mrcCargaVenta.TabIndex = 0;
            this.mrcCargaVenta.TabStop = false;
            // 
            // nUDID
            // 
            this.nUDID.Location = new System.Drawing.Point(23, 150);
            this.nUDID.Name = "nUDID";
            this.nUDID.Size = new System.Drawing.Size(141, 20);
            this.nUDID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 134);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // txtProdcuto
            // 
            this.txtProdcuto.Location = new System.Drawing.Point(24, 47);
            this.txtProdcuto.Name = "txtProdcuto";
            this.txtProdcuto.Size = new System.Drawing.Size(140, 20);
            this.txtProdcuto.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitulo.Location = new System.Drawing.Point(69, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 17);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Venta";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(21, 190);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(20, 85);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPtoducto
            // 
            this.lblPtoducto.AutoSize = true;
            this.lblPtoducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtoducto.Location = new System.Drawing.Point(21, 29);
            this.lblPtoducto.Name = "lblPtoducto";
            this.lblPtoducto.Size = new System.Drawing.Size(58, 13);
            this.lblPtoducto.TabIndex = 4;
            this.lblPtoducto.Text = "Producto";
            // 
            // nUDCantidad
            // 
            this.nUDCantidad.Location = new System.Drawing.Point(23, 101);
            this.nUDCantidad.Name = "nUDCantidad";
            this.nUDCantidad.Size = new System.Drawing.Size(141, 20);
            this.nUDCantidad.TabIndex = 2;
            this.nUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(23, 206);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(141, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // VentanaConsulta
            // 
            this.VentanaConsulta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VentanaConsulta.Controls.Add(this.cboProductosConsulta);
            this.VentanaConsulta.Controls.Add(this.txtProductoConsulta);
            this.VentanaConsulta.Controls.Add(this.btnConsultar);
            this.VentanaConsulta.Controls.Add(this.btnFiltrar);
            this.VentanaConsulta.Controls.Add(this.rbCantidad);
            this.VentanaConsulta.Controls.Add(this.rbProducto);
            this.VentanaConsulta.Controls.Add(this.dataGridView1);
            this.VentanaConsulta.Location = new System.Drawing.Point(4, 22);
            this.VentanaConsulta.Name = "VentanaConsulta";
            this.VentanaConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaConsulta.Size = new System.Drawing.Size(365, 510);
            this.VentanaConsulta.TabIndex = 1;
            this.VentanaConsulta.Text = "Consultar";
            // 
            // cboProductosConsulta
            // 
            this.cboProductosConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductosConsulta.FormattingEnabled = true;
            this.cboProductosConsulta.Location = new System.Drawing.Point(19, 37);
            this.cboProductosConsulta.Name = "cboProductosConsulta";
            this.cboProductosConsulta.Size = new System.Drawing.Size(100, 21);
            this.cboProductosConsulta.TabIndex = 2;
            // 
            // txtProductoConsulta
            // 
            this.txtProductoConsulta.Location = new System.Drawing.Point(125, 38);
            this.txtProductoConsulta.Name = "txtProductoConsulta";
            this.txtProductoConsulta.Size = new System.Drawing.Size(105, 20);
            this.txtProductoConsulta.TabIndex = 3;
            this.txtProductoConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoConsulta_KeyPress);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Location = new System.Drawing.Point(141, 479);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 25);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar todo";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Location = new System.Drawing.Point(236, 38);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 22);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // rbCantidad
            // 
            this.rbCantidad.AutoSize = true;
            this.rbCantidad.Checked = true;
            this.rbCantidad.Location = new System.Drawing.Point(125, 15);
            this.rbCantidad.Name = "rbCantidad";
            this.rbCantidad.Size = new System.Drawing.Size(107, 17);
            this.rbCantidad.TabIndex = 1;
            this.rbCantidad.TabStop = true;
            this.rbCantidad.Text = "Cantidad mayor a";
            this.rbCantidad.UseVisualStyleBackColor = true;
            this.rbCantidad.CheckedChanged += new System.EventHandler(this.rbCantidad_CheckedChanged);
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Location = new System.Drawing.Point(19, 15);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(68, 17);
            this.rbProducto.TabIndex = 0;
            this.rbProducto.Text = "Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            this.rbProducto.CheckedChanged += new System.EventHandler(this.rbProducto_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.ID,
            this.Cantidad,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(9, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(350, 408);
            this.dataGridView1.TabIndex = 5;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 55;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 55;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::pryGerhauser_I.E.LP1.Properties.Resources.kisspng_menu_computer_icons_button_menu_designs_5b2fd502079f35_6844543215298613780313;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(399, 566);
            this.Controls.Add(this.tabControlCargaVenta);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 605);
            this.MinimumSize = new System.Drawing.Size(415, 605);
            this.Name = "frmCargaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.tabControlCargaVenta.ResumeLayout(false);
            this.VentanaRegistro.ResumeLayout(false);
            this.mrcCargaVenta.ResumeLayout(false);
            this.mrcCargaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).EndInit();
            this.VentanaConsulta.ResumeLayout(false);
            this.VentanaConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCargaVenta;
        private System.Windows.Forms.TabPage VentanaRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox mrcCargaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPtoducto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TabPage VentanaConsulta;
        private System.Windows.Forms.RadioButton rbCantidad;
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nUDCantidad;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtProdcuto;
        private System.Windows.Forms.TextBox txtProductoConsulta;
        private System.Windows.Forms.ComboBox cboProductosConsulta;
        private System.Windows.Forms.NumericUpDown nUDID;
        private System.Windows.Forms.Label lblID;
    }
}