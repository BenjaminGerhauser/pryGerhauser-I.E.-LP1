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
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.rbProdcuctos = new System.Windows.Forms.RadioButton();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(25, 73);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(117, 21);
            this.cboProductos.TabIndex = 0;
            this.cboProductos.Visible = false;
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            // 
            // rbProdcuctos
            // 
            this.rbProdcuctos.AutoSize = true;
            this.rbProdcuctos.Checked = true;
            this.rbProdcuctos.Location = new System.Drawing.Point(25, 22);
            this.rbProdcuctos.Name = "rbProdcuctos";
            this.rbProdcuctos.Size = new System.Drawing.Size(73, 17);
            this.rbProdcuctos.TabIndex = 1;
            this.rbProdcuctos.TabStop = true;
            this.rbProdcuctos.Text = "Productos";
            this.rbProdcuctos.UseVisualStyleBackColor = true;
            this.rbProdcuctos.CheckedChanged += new System.EventHandler(this.rbProdcuctos_CheckedChanged);
            // 
            // rbVentas
            // 
            this.rbVentas.AutoSize = true;
            this.rbVentas.Location = new System.Drawing.Point(113, 22);
            this.rbVentas.Name = "rbVentas";
            this.rbVentas.Size = new System.Drawing.Size(58, 17);
            this.rbVentas.TabIndex = 2;
            this.rbVentas.Text = "Ventas";
            this.rbVentas.UseVisualStyleBackColor = true;
            this.rbVentas.CheckedChanged += new System.EventHandler(this.rbVentas_CheckedChanged);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ID,
            this.Cantidad,
            this.Fecha});
            this.dataGridViewProductos.Location = new System.Drawing.Point(25, 136);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(442, 241);
            this.dataGridViewProductos.TabIndex = 3;
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
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre2,
            this.ID2,
            this.Cantidad2,
            this.Fecha2});
            this.dataGridViewVentas.Location = new System.Drawing.Point(473, 136);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.Size = new System.Drawing.Size(442, 241);
            this.dataGridViewVentas.TabIndex = 4;
            this.dataGridViewVentas.Visible = false;
            // 
            // Nombre2
            // 
            this.Nombre2.HeaderText = "Nombre";
            this.Nombre2.Name = "Nombre2";
            // 
            // ID2
            // 
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            // 
            // Cantidad2
            // 
            this.Cantidad2.HeaderText = "Cantidad";
            this.Cantidad2.Name = "Cantidad2";
            // 
            // Fecha2
            // 
            this.Fecha2.HeaderText = "Fecha";
            this.Fecha2.Name = "Fecha2";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(25, 415);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(72, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(22, 57);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(120, 13);
            this.lblProductos.TabIndex = 6;
            this.lblProductos.Text = "Seleccione un producto";
            this.lblProductos.Visible = false;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 459);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataGridViewVentas);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.rbVentas);
            this.Controls.Add(this.rbProdcuctos);
            this.Controls.Add(this.cboProductos);
            this.Name = "frmListado";
            this.Text = "frmListado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.RadioButton rbProdcuctos;
        private System.Windows.Forms.RadioButton rbVentas;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha2;
    }
}