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
        string varFecha, varNombre, varID;
        int IndiceFila, varAux;

        frmMain objetoMain = new frmMain();
        frmCargaVentas Ventas = new frmCargaVentas();
        string[,] matrizProductos = new string[10, 4];
        



        

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objetoMain.Listado.ShowDialog();
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
                
                lblErrorFecha.Visible = false;
                if (txtNombre.Text != "")
                {
                    varNombre = txtNombre.Text;
                    
                    varID = nUDID.Value.ToString();


                        for (int f = 0; f < 10; f++)
                        {
                            if(varNombre == matrizProductos[f, 0])
                            {
                                if(varID == matrizProductos[f, 1])
                                {
                                    matrizProductos[IndiceFila, 0] = varNombre;
                                    matrizProductos[IndiceFila, 1] = varID;
                                    matrizProductos[IndiceFila, 2] = varFecha;


                                    objetoMain.Listado.matrizProductos[IndiceFila, 0] = varNombre;
                                    objetoMain.Listado.matrizProductos[IndiceFila, 1] = varID;
                                    objetoMain.Listado.matrizProductos[IndiceFila, 2] = varFecha;

                                    dataGridViewConsultaProducto.Rows.Add(matrizProductos[IndiceFila, 0], matrizProductos[IndiceFila, 1],matrizProductos[IndiceFila, 2]);

                                    lblErrorID.Visible = false;
                                    lblErrorFecha.Visible = false;
                                    lblErrorNombre.Visible = false;
                                    MessageBox.Show("Producto cargado");
                                    txtNombre.Text = string.Empty;
                                
                                    nUDID.Value = 0;

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
                                        matrizProductos[IndiceFila, 2] = varFecha;


                                        objetoMain.Listado.matrizProductos[IndiceFila, 0] = varNombre;
                                        objetoMain.Listado.matrizProductos[IndiceFila, 1] = varID;
                                        objetoMain.Listado.matrizProductos[IndiceFila, 2] = varFecha;

                                        dataGridViewConsultaProducto.Rows.Add(matrizProductos[IndiceFila, 0], matrizProductos[IndiceFila, 1],matrizProductos[IndiceFila, 2]);
                                        lblErrorID.Visible = false;
                                        lblErrorFecha.Visible = false;
                                        lblErrorNombre.Visible = false;
                                        MessageBox.Show("Producto cargado");
                                        txtNombre.Text = string.Empty;
                                   
                                        nUDID.Value = 0;

                                        IndiceFila++;

                                        break;
                                    }
                                    else
                                    {
                                       
                                    }
                                }
                            }

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
