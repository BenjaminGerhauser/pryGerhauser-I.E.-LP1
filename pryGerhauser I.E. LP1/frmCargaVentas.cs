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
        string varFecha, varProducto, varID, varCantidad;
        int varAux, varCantidadTotal, indicefila;

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
         
        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            
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
                    varID = nUDID.Value.ToString();
                    varCantidad = nUDCantidad.Value.ToString();

                    matrizVentas[indicefila, 0] = varProducto;
                    matrizVentas[indicefila, 1] = varID;
                    matrizVentas[indicefila, 2] = varCantidad;
                    matrizVentas[indicefila, 3] = varFecha;

                    objetoMain.Listado.matrizVentas[indicefila, 0] = varProducto;
                    objetoMain.Listado.matrizVentas[indicefila, 1] = varID;
                    objetoMain.Listado.matrizVentas[indicefila, 2] = varCantidad;
                    objetoMain.Listado.matrizVentas[indicefila, 3] = varFecha;
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
