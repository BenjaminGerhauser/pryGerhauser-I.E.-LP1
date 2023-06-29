namespace pryGerhauser_I.E.LP1
{
    partial class frmCargaProducto
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
            this.tabControlCargaProducto = new System.Windows.Forms.TabControl();
            this.VentanaRegistro = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mrcVistaPrevia = new System.Windows.Forms.GroupBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblProductoVP = new System.Windows.Forms.Label();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.nUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblErrorFecha = new System.Windows.Forms.Label();
            this.lblErrorID = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nUDID = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.VentanaConsulta = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridViewConsultaProducto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlCargaProducto.SuspendLayout();
            this.VentanaRegistro.SuspendLayout();
            this.mrcVistaPrevia.SuspendLayout();
            this.mrcRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).BeginInit();
            this.VentanaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaProducto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCargaProducto
            // 
            this.tabControlCargaProducto.Controls.Add(this.VentanaRegistro);
            this.tabControlCargaProducto.Controls.Add(this.VentanaConsulta);
            this.tabControlCargaProducto.Location = new System.Drawing.Point(24, 21);
            this.tabControlCargaProducto.Name = "tabControlCargaProducto";
            this.tabControlCargaProducto.SelectedIndex = 0;
            this.tabControlCargaProducto.Size = new System.Drawing.Size(366, 432);
            this.tabControlCargaProducto.TabIndex = 0;
            // 
            // VentanaRegistro
            // 
            this.VentanaRegistro.Controls.Add(this.btnCancelar);
            this.VentanaRegistro.Controls.Add(this.mrcVistaPrevia);
            this.VentanaRegistro.Controls.Add(this.mrcRegistro);
            this.VentanaRegistro.Controls.Add(this.btnRegistrar);
            this.VentanaRegistro.Location = new System.Drawing.Point(4, 22);
            this.VentanaRegistro.Name = "VentanaRegistro";
            this.VentanaRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaRegistro.Size = new System.Drawing.Size(358, 406);
            this.VentanaRegistro.TabIndex = 0;
            this.VentanaRegistro.Text = "Registrar";
            this.VentanaRegistro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(192, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mrcVistaPrevia
            // 
            this.mrcVistaPrevia.Controls.Add(this.lblDetalle);
            this.mrcVistaPrevia.Controls.Add(this.lblProductoVP);
            this.mrcVistaPrevia.Location = new System.Drawing.Point(80, 277);
            this.mrcVistaPrevia.Name = "mrcVistaPrevia";
            this.mrcVistaPrevia.Size = new System.Drawing.Size(207, 71);
            this.mrcVistaPrevia.TabIndex = 8;
            this.mrcVistaPrevia.TabStop = false;
            this.mrcVistaPrevia.Text = "Vista Previa";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(8, 32);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(85, 13);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "Detalle producto";
            // 
            // lblProductoVP
            // 
            this.lblProductoVP.AutoSize = true;
            this.lblProductoVP.Location = new System.Drawing.Point(8, 16);
            this.lblProductoVP.Name = "lblProductoVP";
            this.lblProductoVP.Size = new System.Drawing.Size(50, 13);
            this.lblProductoVP.TabIndex = 0;
            this.lblProductoVP.Text = "Producto";
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.nUDCantidad);
            this.mrcRegistro.Controls.Add(this.lblCantidad);
            this.mrcRegistro.Controls.Add(this.lblErrorFecha);
            this.mrcRegistro.Controls.Add(this.lblErrorID);
            this.mrcRegistro.Controls.Add(this.lblErrorNombre);
            this.mrcRegistro.Controls.Add(this.lblID);
            this.mrcRegistro.Controls.Add(this.lblFecha);
            this.mrcRegistro.Controls.Add(this.lblNombre);
            this.mrcRegistro.Controls.Add(this.lblTitulo);
            this.mrcRegistro.Controls.Add(this.dtpFecha);
            this.mrcRegistro.Controls.Add(this.txtNombre);
            this.mrcRegistro.Controls.Add(this.nUDID);
            this.mrcRegistro.Location = new System.Drawing.Point(79, 6);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(207, 265);
            this.mrcRegistro.TabIndex = 7;
            this.mrcRegistro.TabStop = false;
            // 
            // nUDCantidad
            // 
            this.nUDCantidad.Location = new System.Drawing.Point(37, 223);
            this.nUDCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCantidad.Name = "nUDCantidad";
            this.nUDCantidad.Size = new System.Drawing.Size(94, 20);
            this.nUDCantidad.TabIndex = 11;
            this.nUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(34, 207);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblErrorFecha
            // 
            this.lblErrorFecha.AutoSize = true;
            this.lblErrorFecha.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorFecha.Location = new System.Drawing.Point(34, 190);
            this.lblErrorFecha.Name = "lblErrorFecha";
            this.lblErrorFecha.Size = new System.Drawing.Size(167, 13);
            this.lblErrorFecha.TabIndex = 9;
            this.lblErrorFecha.Text = "Ingrese la fecha de hoy o superior";
            this.lblErrorFecha.Visible = false;
            // 
            // lblErrorID
            // 
            this.lblErrorID.AutoSize = true;
            this.lblErrorID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorID.Location = new System.Drawing.Point(21, 128);
            this.lblErrorID.Name = "lblErrorID";
            this.lblErrorID.Size = new System.Drawing.Size(186, 13);
            this.lblErrorID.TabIndex = 8;
            this.lblErrorID.Text = "Ingrese un ID valido(Maximo 4 digitos)";
            this.lblErrorID.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorNombre.Location = new System.Drawing.Point(34, 66);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(126, 13);
            this.lblErrorNombre.TabIndex = 7;
            this.lblErrorNombre.Text = "Ingrese un nombre valido";
            this.lblErrorNombre.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(34, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(34, 151);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitulo.Location = new System.Drawing.Point(66, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 17);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Producto";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(37, 167);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // nUDID
            // 
            this.nUDID.Location = new System.Drawing.Point(37, 105);
            this.nUDID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUDID.Name = "nUDID";
            this.nUDID.Size = new System.Drawing.Size(94, 20);
            this.nUDID.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(79, 365);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // VentanaConsulta
            // 
            this.VentanaConsulta.Controls.Add(this.btnConsultar);
            this.VentanaConsulta.Controls.Add(this.dataGridViewConsultaProducto);
            this.VentanaConsulta.Location = new System.Drawing.Point(4, 22);
            this.VentanaConsulta.Name = "VentanaConsulta";
            this.VentanaConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaConsulta.Size = new System.Drawing.Size(358, 406);
            this.VentanaConsulta.TabIndex = 1;
            this.VentanaConsulta.Text = "Consultar";
            this.VentanaConsulta.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(226, 340);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(77, 26);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dataGridViewConsultaProducto
            // 
            this.dataGridViewConsultaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ID,
            this.Cantidad,
            this.Fecha});
            this.dataGridViewConsultaProducto.Location = new System.Drawing.Point(4, 3);
            this.dataGridViewConsultaProducto.Name = "dataGridViewConsultaProducto";
            this.dataGridViewConsultaProducto.Size = new System.Drawing.Size(354, 331);
            this.dataGridViewConsultaProducto.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::pryGerhauser_I.E.LP1.Properties.Resources.kisspng_menu_computer_icons_button_menu_designs_5b2fd502079f35_6844543215298613780313;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productoToolStripMenuItem.Text = "Productos";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
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
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlCargaProducto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCargaProducto";
            this.Text = "frmCargaProducto";
            this.tabControlCargaProducto.ResumeLayout(false);
            this.VentanaRegistro.ResumeLayout(false);
            this.mrcVistaPrevia.ResumeLayout(false);
            this.mrcVistaPrevia.PerformLayout();
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).EndInit();
            this.VentanaConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaProducto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCargaProducto;
        private System.Windows.Forms.TabPage VentanaRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nUDID;
        private System.Windows.Forms.TabPage VentanaConsulta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox mrcVistaPrevia;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblProductoVP;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridViewConsultaProducto;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.Label lblErrorID;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nUDCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}