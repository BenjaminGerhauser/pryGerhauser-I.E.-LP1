using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public string[] vectorProductos = new string[10];

        string varFecha, varProducto, varID, varCantidad;
        int varAux, varCantidadTotal, indicefila;

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < 10; f++)
            {
                if (matrizVentas[f, 0] != null)
                {
                    dataGridView1.Rows.Add(matrizVentas[f, 0].ToUpper(), matrizVentas[f, 1],
                            matrizVentas[f, 2], matrizVentas[f, 3]);

                }

            }
        }

        private void rbCantidad_CheckedChanged(object sender, EventArgs e)
        {
            nUDCantidadConsulta.Visible = true;
            cmbProductoConsulta.Visible = false;
            dataGridView1.Rows.Clear();
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
            cmbProductoConsulta.Visible = true;
            nUDCantidadConsulta.Visible = false;
            dataGridView1.Rows.Clear();


        }

        private void cmbProductoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (matrizVentas[i,0] == cmbProductoConsulta.Text)
                {
                    dataGridView1.Rows.Add(matrizVentas[i, 0], matrizVentas[i, 1], matrizVentas[i, 2], matrizVentas[i, 3]);
                }
            }
        }

        private void nUDCantidadConsulta_Enter(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToDecimal(matrizVentas[i, 2]) == nUDCantidad.Value)
                {
                    dataGridView1.Rows.Add(matrizVentas[i, 0], matrizVentas[i, 1], matrizVentas[i, 2], matrizVentas[i, 3]);

                }

            }
        }

      
        

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
         
        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (vectorProductos[i] != null && cmbProducto.Items.ToString() != vectorProductos[i])
                {
                    cmbProducto.Items.Add(vectorProductos[i].ToUpper());
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (vectorProductos[i] != null && cmbProductoConsulta.Items.ToString() != vectorProductos[i])
                {
                    cmbProductoConsulta.Items.Add(vectorProductos[i].ToUpper());
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

                if (cmbProducto.SelectedIndex != -1)
                {
                    varProducto = cmbProducto.Text.ToString();
                    
                    varCantidad = nUDCantidad.Value.ToString();

                    matrizVentas[indicefila, 0] = varProducto;
                    matrizVentas[indicefila, 1] = (Convert.ToInt16(indicefila) + 1).ToString() ;
                    matrizVentas[indicefila, 2] = varCantidad;
                    matrizVentas[indicefila, 3] = varFecha;

                    objetoMain.Listado.matrizVentas[indicefila, 0] = varProducto;
                    objetoMain.Listado.matrizVentas[indicefila, 1] = varID;
                    objetoMain.Listado.matrizVentas[indicefila, 2] = varCantidad;
                    objetoMain.Listado.matrizVentas[indicefila, 3] = varFecha;
                    
                    dataGridView1.Rows.Add(matrizVentas[indicefila, 0].ToUpper(), matrizVentas[indicefila, 1], matrizVentas[indicefila, 2], matrizVentas[indicefila, 3]);

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
