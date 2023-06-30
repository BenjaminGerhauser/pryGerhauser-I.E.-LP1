namespace pryGerhauser_I.E.LP1
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.rbProdcuctos = new System.Windows.Forms.RadioButton();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.dataGridViewListado = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.mrcFiltro = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).BeginInit();
            this.mrcFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProductos
            // 
            this.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(84, 66);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(133, 21);
            this.cboProductos.TabIndex = 0;
            this.cboProductos.Visible = false;
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            // 
            // rbProdcuctos
            // 
            this.rbProdcuctos.AutoSize = true;
            this.rbProdcuctos.Checked = true;
            this.rbProdcuctos.Location = new System.Drawing.Point(13, 19);
            this.rbProdcuctos.Name = "rbProdcuctos";
            this.rbProdcuctos.Size = new System.Drawing.Size(80, 19);
            this.rbProdcuctos.TabIndex = 1;
            this.rbProdcuctos.TabStop = true;
            this.rbProdcuctos.Text = "Productos";
            this.rbProdcuctos.UseVisualStyleBackColor = true;
            this.rbProdcuctos.CheckedChanged += new System.EventHandler(this.rbProdcuctos_CheckedChanged);
            // 
            // rbVentas
            // 
            this.rbVentas.AutoSize = true;
            this.rbVentas.Location = new System.Drawing.Point(13, 44);
            this.rbVentas.Name = "rbVentas";
            this.rbVentas.Size = new System.Drawing.Size(62, 19);
            this.rbVentas.TabIndex = 2;
            this.rbVentas.Text = "Ventas";
            this.rbVentas.UseVisualStyleBackColor = true;
            this.rbVentas.CheckedChanged += new System.EventHandler(this.rbVentas_CheckedChanged);
            // 
            // dataGridViewListado
            // 
            this.dataGridViewListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ID,
            this.Cantidad,
            this.Fecha});
            this.dataGridViewListado.Location = new System.Drawing.Point(25, 116);
            this.dataGridViewListado.Name = "dataGridViewListado";
            this.dataGridViewListado.ReadOnly = true;
            this.dataGridViewListado.Size = new System.Drawing.Size(444, 272);
            this.dataGridViewListado.TabIndex = 3;
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
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(25, 406);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(98, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar todo";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(81, 48);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(136, 15);
            this.lblProductos.TabIndex = 6;
            this.lblProductos.Text = "Seleccione un producto";
            this.lblProductos.Visible = false;
            // 
            // mrcFiltro
            // 
            this.mrcFiltro.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mrcFiltro.Controls.Add(this.lblProductos);
            this.mrcFiltro.Controls.Add(this.rbVentas);
            this.mrcFiltro.Controls.Add(this.rbProdcuctos);
            this.mrcFiltro.Controls.Add(this.cboProductos);
            this.mrcFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.mrcFiltro.Location = new System.Drawing.Point(25, 9);
            this.mrcFiltro.Name = "mrcFiltro";
            this.mrcFiltro.Size = new System.Drawing.Size(444, 101);
            this.mrcFiltro.TabIndex = 7;
            this.mrcFiltro.TabStop = false;
            this.mrcFiltro.Text = "Filtro";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(498, 459);
            this.Controls.Add(this.mrcFiltro);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataGridViewListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 498);
            this.MinimumSize = new System.Drawing.Size(514, 498);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).EndInit();
            this.mrcFiltro.ResumeLayout(false);
            this.mrcFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.RadioButton rbProdcuctos;
        private System.Windows.Forms.RadioButton rbVentas;
        private System.Windows.Forms.DataGridView dataGridViewListado;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.GroupBox mrcFiltro;
    }
}