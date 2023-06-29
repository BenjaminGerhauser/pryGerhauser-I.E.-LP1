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
    public partial class frmCargaProducto : Form
    {
        string varFecha, varNombre, varID, varCantidad;
        int IndiceFila, varAux;

        frmMain objetoMain = new frmMain();
        frmCargaVentas Ventas = new frmCargaVentas();
        string[,] matrizProductos = new string[10, 4];
        



        private void button1_Click(object sender, EventArgs e)
        {
            objetoMain.Listado.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridViewConsultaProducto.Rows.Clear();

            for (int f = 0; f < matrizProductos.GetLength(0); f++)
            {
                if (matrizProductos[f, 0] != null)
                {
                    dataGridViewConsultaProducto.Rows.Add(matrizProductos[f, 0].ToUpper(), matrizProductos[f, 1],
                        matrizProductos[f, 2], matrizProductos[f, 3]);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
          
        }

        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int i = 0;
            varAux = 0;

            if (dtpFecha.Value >= DateTime.Today)
            {
                varFecha = dtpFecha.Value.ToString();
                varCantidad = nUDCantidad.Value.ToString();
                if (txtNombre.Text != "")
                {
                    varNombre = txtNombre.Text.ToLower();
                    if (nUDID.Value < 9999)
                    {
                        varID = nUDID.Value.ToString();



                        for (int f = 0; f < 10; f++)
                        {
                            if(varNombre == matrizProductos[f, 0])
                            {
                                if(varID == matrizProductos[f, 1])
                                {
                                    matrizProductos[IndiceFila, 0] = varNombre;
                                    matrizProductos[IndiceFila, 1] = varID;
                                    matrizProductos[IndiceFila, 2] = varCantidad;
                                    matrizProductos[IndiceFila, 3] = varFecha;

                                    Ventas.vectorProductos[IndiceFila] = varNombre;

                                    objetoMain.Listado.matrizProductos[IndiceFila, 0] = varNombre;
                                    objetoMain.Listado.matrizProductos[IndiceFila, 1] = varID;
                                    objetoMain.Listado.matrizProductos[IndiceFila, 2] = varCantidad;
                                    objetoMain.Listado.matrizProductos[IndiceFila, 3] = varFecha;

                                    dataGridViewConsultaProducto.Rows.Add(matrizProductos[IndiceFila, 0].ToUpper(), matrizProductos[IndiceFila, 1],
                                    matrizProductos[IndiceFila, 2], matrizProductos[IndiceFila, 3]);

                                    lblErrorID.Visible = false;

                                    IndiceFila++;

                                    break;
                                }
                                else
                                {
                                    lblErrorID.Visible = true;
                                    break;
                                }
                            }
                            else
                            {
                                if(varNombre != matrizProductos[f, 0])
                                {

                                    while (i < 10)
                                    {
                                        if(matrizProductos[i, 1] != varID)
                                        {
                                            i++;
                                        }
                                        else
                                        {
                                            lblErrorID.Visible = true;
                                            varAux = -1;
                                            break;
                                        }
                                    }
                                    if(varAux != -1)
                                    {
                                        matrizProductos[IndiceFila, 0] = varNombre;
                                        matrizProductos[IndiceFila, 1] = varID;
                                        matrizProductos[IndiceFila, 2] = varCantidad;
                                        matrizProductos[IndiceFila, 3] = varFecha;

                                        Ventas.vectorProductos[IndiceFila] = varNombre;

                                        objetoMain.Listado.matrizProductos[IndiceFila, 0] = varNombre;
                                        objetoMain.Listado.matrizProductos[IndiceFila, 1] = varID;
                                        objetoMain.Listado.matrizProductos[IndiceFila, 2] = varCantidad;
                                        objetoMain.Listado.matrizProductos[IndiceFila, 3] = varFecha;

                                        lblErrorID.Visible = false;

                                        IndiceFila++;

                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }

                        }

                    }
                    else
                    {
                        lblErrorID.Visible = true;
                        nUDID.Value = 0;
                    }
                }
                else
                {
                    lblErrorNombre.Visible = true;
                }
            }
            else
            {
                lblErrorFecha.Visible = true;
            }
        }
    }
}
