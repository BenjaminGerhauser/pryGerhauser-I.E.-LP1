namespace pryGerhauser_I.E.LP1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mrcTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblTituloBienvenida = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.mrcTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(274, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.ventasToolStripMenuItem});
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
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // mrcTitulo
            // 
            this.mrcTitulo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mrcTitulo.Controls.Add(this.lblTitulo);
            this.mrcTitulo.Location = new System.Drawing.Point(38, 42);
            this.mrcTitulo.Name = "mrcTitulo";
            this.mrcTitulo.Size = new System.Drawing.Size(199, 33);
            this.mrcTitulo.TabIndex = 6;
            this.mrcTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitulo.Location = new System.Drawing.Point(36, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de registro";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBienvenida.Location = new System.Drawing.Point(109, 134);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(46, 17);
            this.lblBienvenida.TabIndex = 7;
            this.lblBienvenida.Text = "label1";
            // 
            // lblTituloBienvenida
            // 
            this.lblTituloBienvenida.ActiveLinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloBienvenida.AutoSize = true;
            this.lblTituloBienvenida.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblTituloBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTituloBienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloBienvenida.LinkColor = System.Drawing.Color.White;
            this.lblTituloBienvenida.Location = new System.Drawing.Point(91, 97);
            this.lblTituloBienvenida.Name = "lblTituloBienvenida";
            this.lblTituloBienvenida.Size = new System.Drawing.Size(87, 20);
            this.lblTituloBienvenida.TabIndex = 8;
            this.lblTituloBienvenida.TabStop = true;
            this.lblTituloBienvenida.Text = "Bienvenido";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(274, 335);
            this.Controls.Add(this.lblTituloBienvenida);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.mrcTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 374);
            this.MinimumSize = new System.Drawing.Size(290, 374);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mrcTitulo.ResumeLayout(false);
            this.mrcTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.GroupBox mrcTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.LinkLabel lblTituloBienvenida;
        public System.Windows.Forms.Label lblBienvenida;
    }
}