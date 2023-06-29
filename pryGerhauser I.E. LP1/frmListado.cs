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

        public string[,] matrizProductos = new string[10, 3];

        public string[,] matrizVentas = new string[10, 4];

        public frmListado()
        {
            InitializeComponent();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridViewListado.Rows.Clear();

            if (rbProdcuctos.Checked)
            {

                for (int i = 0; i < 10; i++)
                {
                    if (matrizProductos[i, 0] != null)
                    {
                        dataGridViewListado.Rows.Add(matrizProductos[i, 0], matrizProductos[i, 1],"", matrizProductos[i, 3]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (matrizVentas[i, 0] != null)
                    {
                        dataGridViewListado.Rows.Add(matrizVentas[i, 0], matrizVentas[i, 1],
                        matrizVentas[i, 2], matrizVentas[i, 3]);
                    }
                }
            }


        }

        
        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewListado.Rows.Clear();

            for (int f = 0; f < 10; f++)
            {
                if (matrizVentas[f, 0] == cboProductos.Text)
                {
                    dataGridViewListado.Rows.Add(matrizVentas[f, 0], matrizVentas[f, 1],
                       matrizVentas[f, 2], matrizVentas[f, 3]); 

                }

            }
        }

        

        private void rbVentas_CheckedChanged(object sender, EventArgs e)
        {
            lblProductos.Visible = true;
            cboProductos.Visible = true;

            for (int i = 0; i < 10; i++)
            {
                if( matrizVentas[i, 0] != null)
                {
                    if (cboProductos.Items.Contains(matrizVentas[i, 0]) == false)
                    {
                        cboProductos.Items.Add(matrizVentas[i, 0]);

                    }
                }
            }
        }

        private void rbProdcuctos_CheckedChanged(object sender, EventArgs e)
        {
            lblProductos.Visible = false;
            cboProductos.Visible = false;
        }

       
    }
}
