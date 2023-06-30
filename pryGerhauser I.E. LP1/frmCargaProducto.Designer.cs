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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProducto));
            this.tabControlCargaProducto = new System.Windows.Forms.TabControl();
            this.VentanaRegistro = new System.Windows.Forms.TabPage();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
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
            this.dataGridViewConsultaProducto = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlCargaProducto.SuspendLayout();
            this.VentanaRegistro.SuspendLayout();
            this.mrcRegistro.SuspendLayout();
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
            this.tabControlCargaProducto.Location = new System.Drawing.Point(44, 41);
            this.tabControlCargaProducto.Name = "tabControlCargaProducto";
            this.tabControlCargaProducto.SelectedIndex = 0;
            this.tabControlCargaProducto.Size = new System.Drawing.Size(335, 432);
            this.tabControlCargaProducto.TabIndex = 0;
            // 
            // VentanaRegistro
            // 
            this.VentanaRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VentanaRegistro.Controls.Add(this.mrcRegistro);
            this.VentanaRegistro.Controls.Add(this.btnRegistrar);
            this.VentanaRegistro.Location = new System.Drawing.Point(4, 22);
            this.VentanaRegistro.Name = "VentanaRegistro";
            this.VentanaRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaRegistro.Size = new System.Drawing.Size(327, 406);
            this.VentanaRegistro.TabIndex = 0;
            this.VentanaRegistro.Text = "Registrar";
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.BackColor = System.Drawing.SystemColors.ButtonShadow;
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
            this.mrcRegistro.Location = new System.Drawing.Point(59, 46);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(207, 265);
            this.mrcRegistro.TabIndex = 7;
            this.mrcRegistro.TabStop = false;
            // 
            // lblErrorFecha
            // 
            this.lblErrorFecha.AutoSize = true;
            this.lblErrorFecha.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorFecha.Location = new System.Drawing.Point(31, 223);
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
            this.lblErrorID.Location = new System.Drawing.Point(31, 146);
            this.lblErrorID.Name = "lblErrorID";
            this.lblErrorID.Size = new System.Drawing.Size(161, 13);
            this.lblErrorID.TabIndex = 8;
            this.lblErrorID.Text = "ID perteneciente a otro producto";
            this.lblErrorID.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorNombre.Location = new System.Drawing.Point(31, 73);
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
            this.lblID.Location = new System.Drawing.Point(31, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(31, 184);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 35);
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
            this.dtpFecha.Location = new System.Drawing.Point(34, 200);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // nUDID
            // 
            this.nUDID.Location = new System.Drawing.Point(34, 123);
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
            this.btnRegistrar.Location = new System.Drawing.Point(116, 336);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // VentanaConsulta
            // 
            this.VentanaConsulta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VentanaConsulta.Controls.Add(this.dataGridViewConsultaProducto);
            this.VentanaConsulta.Location = new System.Drawing.Point(4, 22);
            this.VentanaConsulta.Name = "VentanaConsulta";
            this.VentanaConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.VentanaConsulta.Size = new System.Drawing.Size(327, 406);
            this.VentanaConsulta.TabIndex = 1;
            this.VentanaConsulta.Text = "Consultar";
            // 
            // dataGridViewConsultaProducto
            // 
            this.dataGridViewConsultaProducto.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewConsultaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ID,
            this.Fecha});
            this.dataGridViewConsultaProducto.Location = new System.Drawing.Point(15, 6);
            this.dataGridViewConsultaProducto.Name = "dataGridViewConsultaProducto";
            this.dataGridViewConsultaProducto.ReadOnly = true;
            this.dataGridViewConsultaProducto.Size = new System.Drawing.Size(299, 394);
            this.dataGridViewConsultaProducto.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 55;
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
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::pryGerhauser_I.E.LP1.Properties.Resources.kisspng_menu_computer_icons_button_menu_designs_5b2fd502079f35_6844543215298613780313;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(426, 487);
            this.Controls.Add(this.tabControlCargaProducto);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 526);
            this.MinimumSize = new System.Drawing.Size(442, 526);
            this.Name = "frmCargaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.tabControlCargaProducto.ResumeLayout(false);
            this.VentanaRegistro.ResumeLayout(false);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown nUDID;
        private System.Windows.Forms.TabPage VentanaConsulta;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridViewConsultaProducto;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.Label lblErrorID;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}