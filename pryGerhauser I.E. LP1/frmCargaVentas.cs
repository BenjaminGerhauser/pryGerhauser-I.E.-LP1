using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGerhauser_I.E.LP1
{
    public partial class frmCargaVentas : Form
    {
        frmMain objetoMain = new frmMain();
        string[,] matrizVentas = new string[10, 4];

        string varFecha, varProducto, varID, varCantidad;
        int varAux, varCantidadTotal, indicefila;

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
            txtProductoConsulta.Text = string.Empty;
            txtProductoConsulta.Enabled = false;
            cboProductosConsulta.Enabled = true;
            

                for (int i = 0; i < 10; i++)
                {
                    if (matrizVentas[i, 0] != null)
                    {
                        if (cboProductosConsulta.Items.Contains(matrizVentas[i, 0]) == false)
                        {
                            cboProductosConsulta.Items.Add(matrizVentas[i, 0]);
                        }
                    }
                }
            
        }

        private void rbCantidad_CheckedChanged(object sender, EventArgs e)
        {
            cboProductosConsulta.Enabled = false;
            txtProductoConsulta.Enabled = true;

        }

        private void txtProductoConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbCantidad.Checked)
            {
                if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaProducto CargarProducto = new frmCargaProducto();
            this.Hide();
            CargarProducto.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objetoMain.Listado.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            { 
                if (matrizVentas[i, 0] != null)
                {
                    dataGridView1.Rows.Add(matrizVentas[i, 0], matrizVentas[i, 1], matrizVentas[i, 2], matrizVentas[i, 3]);
                }
            }
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();


            if (rbCantidad.Checked)
            {
                if(int.Parse(txtProductoConsulta.Text) > 0 && int.Parse(txtProductoConsulta.Text) < 10000)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (Convert.ToInt16(matrizVentas[i, 2]) >= Convert.ToInt16(txtProductoConsulta.Text) && matrizVentas[i, 2] != null)
                        {

                            dataGridView1.Rows.Add(matrizVentas[i, 0], matrizVentas[i, 1], matrizVentas[i, 2], matrizVentas[i, 3]);
                        }
                    }                    
                }
               
            }
            else if(rbProducto.Checked)
            {
               
                for (int i = 0; i < 10; i++)
                {
                    if (matrizVentas[i, 0] != null)
                    {
                        if (cboProductosConsulta.Items.Equals(matrizVentas[i, 0]))
                        {
                            dataGridView1.Rows.Add(matrizVentas[i, 0], matrizVentas[i, 1], matrizVentas[i, 2], matrizVentas[i, 3]);

                        }
                    }
                }
            }
        }

        

        public frmCargaVentas()
        {
            InitializeComponent();
          
        }

        


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value.Date == DateTime.Today.Date)
            {
                varFecha = dtpFecha.Value.ToString();

                if (txtProdcuto.Text != "")
                {
                    varProducto = txtProdcuto.Text;
                    varID = nUDID.Value.ToString();
                    varCantidad = nUDCantidad.Value.ToString();

                    matrizVentas[indicefila, 0] = varProducto;
                    matrizVentas[indicefila, 1] = varID ;
                    matrizVentas[indicefila, 2] = varCantidad;
                    matrizVentas[indicefila, 3] = varFecha;

                    objetoMain.Listado.matrizVentas[indicefila, 0] = varProducto;
                    objetoMain.Listado.matrizVentas[indicefila, 1] = varID;
                    objetoMain.Listado.matrizVentas[indicefila, 2] = varCantidad;
                    objetoMain.Listado.matrizVentas[indicefila, 3] = varFecha;
                    
                    dataGridView1.Rows.Add(matrizVentas[indicefila, 0], matrizVentas[indicefila, 1], matrizVentas[indicefila, 2], matrizVentas[indicefila, 3]);

                    MessageBox.Show("Venta realizada");
                    txtProdcuto.Text = string.Empty;
                    nUDID.Value = 0;
                    nUDCantidad.Value = 1;
                    
                    indicefila++;
                }
                else
                {

                }
            }
            else
            {

            }


        }
    }
}
