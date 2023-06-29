using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGerhauser_I.E.LP1
{
    public partial class frmMain : Form
    {
            
        public frmListado Listado = new frmListado();

        public frmMain()
        {
            InitializeComponent();
            
        }

       

      

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaProducto CargaProducto = new frmCargaProducto();
            frmCargaVentas CargaVentas = new frmCargaVentas();

            CargaProducto.ShowDialog();
        }

       
    }
}
