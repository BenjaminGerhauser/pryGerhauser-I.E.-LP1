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
        //public string[,] matrizProductos = new string[10, 4];
        public string[,] matrizVentas = new string[10, 4];

        frmMain objetoMain = new frmMain();
        string varFecha, varProducto, varID, varCantidad;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //objetoMain.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //objetoMain.ShowDialog();
            //for (int i = 0; i < objetoMain.matrizProductos.GetLength(0); i++)
            //{
            //    if (matrizProductos[i, 0] != null)
            //    {
            //        if (cmbProducto.Items.Contains(objetoMain.matrizProductos[i, 0]) == false)
            //        {
            //            cmbProducto.Items.Add(objetoMain.matrizProductos[i, 0]);
            //        }
            //    }
            //}
        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {
            
        }

        int varAux, varCantidadTotal;
        public frmCargaVentas()
        {
            InitializeComponent();
        }

        


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //if (dtpFecha.Value.Date == DateTime.Today.Date) 
            //{
            //    varFecha = dtpFecha.Value.ToString();
                
            //    if(cmbProducto.SelectedIndex != -1)
            //    {
            //        varProducto = cmbProducto.Text.ToString();
            //        varID = nUDID.Value.ToString();
            //        varCantidad = nUDCantidad.Value.ToString();
            //    }
            //    else
            //    {
                    
            //    }

            //}
            //else
            //{

            //}

            //for (int i = 0; i < matrizVentas.GetLength(0); i++)
            //{
            //    if (varProducto == matrizProductos[i, 0] &&
            //         varFecha != matrizProductos[i, 2])
            //    {
            //        for (int c = 0; c < matrizVentas.GetLength(0); c++)
            //        {
            //            if (varProducto == matrizProductos[c, 0])
            //            {
            //                varCantidadTotal += Convert.ToInt32(matrizProductos[c, 3]);
            //            }
            //        }
            //        if (varCantidadTotal >= Convert.ToInt32(varCantidad))
            //        {

            //            if (Convert.ToInt32(varCantidad) <= Convert.ToInt32(matrizProductos[i, 3]))
            //            {

            //                if (matrizVentas[i, 1] != varID)
            //                {
            //                    matrizProductos[i, 3] = (Convert.ToInt32(matrizProductos[i, 3]) -
            //                    Convert.ToInt32(varCantidad)).ToString();

            //                    matrizVentas[i, 0] = varProducto;
            //                    matrizVentas[i, 1] = varID;
            //                    matrizVentas[i, 2] = varCantidad;
            //                    matrizVentas[i, 3] = varFecha;
            //                    lblErrorID.Visible = false;
            //                    break;
            //                }
            //                else
            //                {
            //                    lblErrorID.Visible = true;
            //                    break;
            //                }
            //            }
            //            else
            //            {
            //                varAux = Convert.ToUInt16(varCantidad) - Convert.ToInt32(matrizProductos[i, 3]);
            //                for (int f = i + 1; f < matrizProductos.GetLength(0); f++)
            //                {
            //                    if (varProducto == matrizProductos[f, 0] &&
            //                        varAux <= Convert.ToInt32(matrizProductos[f, 3]))
            //                    {
            //                        if (matrizVentas[i, 1] != varID)
            //                        {

            //                            matrizProductos[i, 3] = (Convert.ToInt32(matrizProductos[i, 3]) -
            //                            Convert.ToInt32(varCantidad)).ToString();
            //                            matrizProductos[f, 3] = (Convert.ToInt32(matrizProductos[f, 3]) -
            //                            Convert.ToInt32(varCantidad)).ToString();
            //                            matrizVentas[i, 0] = varProducto;
            //                            matrizVentas[i, 1] = varID;
            //                            matrizVentas[i, 2] = varCantidad;
            //                            matrizVentas[i, 3] = varFecha;
            //                            lblErrorID.Visible = false;
            //                            break;
            //                        }
            //                        else
            //                        {
            //                            lblErrorID.Visible = true;
            //                            break;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            lblErrorCantidad.Visible = true;
            //            break;
            //        }
            //    }




            //}
            //if (matrizVentas[i, 1] != varID)
            //{
            //    matrizVentas[i, 0] = varProducto;
            //    matrizVentas[i, 1] = varID;
            //    matrizVentas[i, 2] = varCantidad;
            //    matrizVentas[i, 3] = varFecha;
            //}
            //else
            //{

            //}
        }
    }
}
