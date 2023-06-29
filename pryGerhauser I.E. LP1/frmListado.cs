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
            dataGridViewProductos.Rows.Clear();

            for (int f = 0; f < matrizProductos.GetLength(0); f++)
            {
                if (matrizProductos[f, 0] != null) 
                {
                    dataGridViewProductos.Rows.Add(matrizProductos[f, 0].ToUpper(), matrizProductos[f, 1],
                        matrizProductos[f, 2], matrizProductos[f, 3]);
                }
            }

        }

        private void rbVentas_CheckedChanged(object sender, EventArgs e)
        {

            dataGridViewProductos.Visible = false;
            if (rbVentas.Checked)
            {

                lblProductos.Visible = true;
                cboProductos.Visible = true;
                dataGridViewVentas.Visible = true;
            }
            
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (matrizProductos[i, 0] != null && cboProductos.Items.ToString() != matrizProductos[i, 0])
                {
                    cboProductos.Items.Add(matrizProductos[i, 0].ToUpper());
                }
            }
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewVentas.Rows.Clear();

            for (int f = 0; f < 10; f++)
            {
                if (matrizVentas[f, 0] != null)
                {
                    dataGridViewVentas.Rows.Add(matrizVentas[f, 0].ToUpper(), matrizVentas[f, 1],
                       matrizVentas[f, 2], matrizVentas[f, 3]);

                }

            }
        }

        private void rbProdcuctos_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVentas.Visible = false;


            if (rbProdcuctos.Checked) 
            { 
                dataGridViewProductos.Rows.Clear();

                for (int f = 0; f < matrizProductos.GetLength(0); f++)
                {
                    if (matrizProductos[f, 0] != null)
                    {
                        dataGridViewProductos.Rows.Add(matrizProductos[f, 0].ToUpper(), matrizProductos[f, 1],
                            matrizProductos[f, 2], matrizProductos[f, 3]);
                    }
                }

                lblProductos.Visible = false;
                cboProductos.Visible = false;
                dataGridViewProductos.Visible = true;
            }


        }
    }
}
