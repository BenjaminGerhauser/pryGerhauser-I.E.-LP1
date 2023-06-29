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
    public partial class frmListado : Form
    {

        public string[,] matrizProductos = new string[10, 4];
        public string[,] matrizVentas = new string[10, 4];

        public frmListado()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            for (int f = 0; f < matrizProductos.GetLength(0); f++)
            {
                if (matrizProductos[f, 0] != null) 
                {
                    dataGridView1.Rows.Add(matrizProductos[f, 0].ToUpper(), matrizProductos[f, 1],
                        matrizProductos[f, 2], matrizProductos[f, 3]);

                }
                if (matrizVentas[f, 0] != null)
                {
                    dataGridView2.Rows.Add(matrizVentas[f, 0].ToUpper(), matrizVentas[f, 1],
                       matrizVentas[f, 2], matrizVentas[f, 3]);

                }
            }

        }
    }
}
