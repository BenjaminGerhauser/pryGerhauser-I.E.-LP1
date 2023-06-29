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
            this.tabControlCargaVenta = new System.Windows.Forms.TabControl();
            this.VentanaRegistro = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.mrcCargaVenta = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPtoducto = new System.Windows.Forms.Label();
            this.nUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.VentanaConsulta = new System.Windows.Forms.TabPage();
            this.nUDCantidadConsulta = new System.Windows.Forms.NumericUpDown();
            this.rbCantidad = new System.Windows.Forms.RadioButton();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.cmbProductoConsulta = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlCargaVenta.SuspendLayout();
            this.VentanaRegistro.SuspendLayout();
            this.mrcCargaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).BeginInit();
            this.VentanaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidadConsulta)).BeginInit();
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
            this.tabControlCargaVenta.Size = new System.Drawing.Size(373, 497);
            this.tabControlCargaVenta.TabIndex = 0;
            // 
            // VentanaRegistro
            // 
            this.VentanaRegistro.Controls.Add(this.btnCancelar);
            this.VentanaRegistro.Controls.Add(this.btnRegistrar);
            this.VentanaRegistro.Controls.Add(this.mrcCargaVenta);
            this.VentanaRegistro.Location = new System.Drawing.Point(4, 22);
            this.VentanaRegistro.Name = "VentanaRegistro";
            this.VentanaRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaRegistro.Size = new System.Drawing.Size(365, 471);
            this.VentanaRegistro.TabIndex = 0;
            this.VentanaRegistro.Text = "Registrar";
            this.VentanaRegistro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(195, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(84, 336);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // mrcCargaVenta
            // 
            this.mrcCargaVenta.Controls.Add(this.lblTitulo);
            this.mrcCargaVenta.Controls.Add(this.lblFecha);
            this.mrcCargaVenta.Controls.Add(this.lblCantidad);
            this.mrcCargaVenta.Controls.Add(this.lblPtoducto);
            this.mrcCargaVenta.Controls.Add(this.nUDCantidad);
            this.mrcCargaVenta.Controls.Add(this.dtpFecha);
            this.mrcCargaVenta.Controls.Add(this.cmbProducto);
            this.mrcCargaVenta.Location = new System.Drawing.Point(84, 43);
            this.mrcCargaVenta.Name = "mrcCargaVenta";
            this.mrcCargaVenta.Size = new System.Drawing.Size(201, 259);
            this.mrcCargaVenta.TabIndex = 8;
            this.mrcCargaVenta.TabStop = false;
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
            this.lblFecha.Location = new System.Drawing.Point(21, 172);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(21, 99);
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
            this.nUDCantidad.Location = new System.Drawing.Point(24, 115);
            this.nUDCantidad.Name = "nUDCantidad";
            this.nUDCantidad.Size = new System.Drawing.Size(141, 20);
            this.nUDCantidad.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(24, 188);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(141, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(24, 45);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(141, 21);
            this.cmbProducto.TabIndex = 0;
            // 
            // VentanaConsulta
            // 
            this.VentanaConsulta.Controls.Add(this.nUDCantidadConsulta);
            this.VentanaConsulta.Controls.Add(this.rbCantidad);
            this.VentanaConsulta.Controls.Add(this.rbProducto);
            this.VentanaConsulta.Controls.Add(this.cmbProductoConsulta);
            this.VentanaConsulta.Controls.Add(this.dataGridView1);
            this.VentanaConsulta.Location = new System.Drawing.Point(4, 22);
            this.VentanaConsulta.Name = "VentanaConsulta";
            this.VentanaConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaConsulta.Size = new System.Drawing.Size(365, 471);
            this.VentanaConsulta.TabIndex = 1;
            this.VentanaConsulta.Text = "Consultar";
            this.VentanaConsulta.UseVisualStyleBackColor = true;
            // 
            // nUDCantidadConsulta
            // 
            this.nUDCantidadConsulta.Location = new System.Drawing.Point(146, 38);
            this.nUDCantidadConsulta.Name = "nUDCantidadConsulta";
            this.nUDCantidadConsulta.Size = new System.Drawing.Size(84, 20);
            this.nUDCantidadConsulta.TabIndex = 4;
            this.nUDCantidadConsulta.Visible = false;
            this.nUDCantidadConsulta.Enter += new System.EventHandler(this.nUDCantidadConsulta_Enter);
            // 
            // rbCantidad
            // 
            this.rbCantidad.AutoSize = true;
            this.rbCantidad.Location = new System.Drawing.Point(93, 15);
            this.rbCantidad.Name = "rbCantidad";
            this.rbCantidad.Size = new System.Drawing.Size(67, 17);
            this.rbCantidad.TabIndex = 3;
            this.rbCantidad.TabStop = true;
            this.rbCantidad.Text = "Cantidad";
            this.rbCantidad.UseVisualStyleBackColor = true;
            this.rbCantidad.CheckedChanged += new System.EventHandler(this.rbCantidad_CheckedChanged);
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Checked = true;
            this.rbProducto.Location = new System.Drawing.Point(19, 15);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(68, 17);
            this.rbProducto.TabIndex = 2;
            this.rbProducto.TabStop = true;
            this.rbProducto.Text = "Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            this.rbProducto.CheckedChanged += new System.EventHandler(this.rbProducto_CheckedChanged);
            // 
            // cmbProductoConsulta
            // 
            this.cmbProductoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductoConsulta.FormattingEnabled = true;
            this.cmbProductoConsulta.Location = new System.Drawing.Point(19, 38);
            this.cmbProductoConsulta.Name = "cmbProductoConsulta";
            this.cmbProductoConsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbProductoConsulta.TabIndex = 1;
            this.cmbProductoConsulta.SelectedIndexChanged += new System.EventHandler(this.cmbProductoConsulta_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.ID,
            this.Cantidad,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(6, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 55;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 55;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::pryGerhauser_I.E.LP1.Properties.Resources.kisspng_menu_computer_icons_button_menu_designs_5b2fd502079f35_6844543215298613780313;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem1,
            this.mostrarToolStripMenuItem1});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // cargarToolStripMenuItem1
            // 
            this.cargarToolStripMenuItem1.Name = "cargarToolStripMenuItem1";
            this.cargarToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.cargarToolStripMenuItem1.Text = "Cargar";
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.ventasToolStripMenuItem1});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem1.Text = "Productos";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 557);
            this.Controls.Add(this.tabControlCargaVenta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCargaVentas";
            this.Text = "frmCargaVentas";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.tabControlCargaVenta.ResumeLayout(false);
            this.VentanaRegistro.ResumeLayout(false);
            this.mrcCargaVenta.ResumeLayout(false);
            this.mrcCargaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).EndInit();
            this.VentanaConsulta.ResumeLayout(false);
            this.VentanaConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidadConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCargaVenta;
        private System.Windows.Forms.TabPage VentanaRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox mrcCargaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPtoducto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TabPage VentanaConsulta;
        private System.Windows.Forms.NumericUpDown nUDCantidadConsulta;
        private System.Windows.Forms.RadioButton rbCantidad;
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.ComboBox cmbProductoConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.NumericUpDown nUDCantidad;
    }
}