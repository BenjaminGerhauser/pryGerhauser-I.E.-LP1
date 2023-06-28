﻿using System;
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
        string[,] matrizProductos = new string[10, 4];


        frmMain objetoMain = new frmMain();
        frmCargaVentas Ventas = new frmCargaVentas();


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrizProductos.GetLength(0); i++)
            {
                if (matrizProductos[i, 0] != null)
                {
                    if (Ventas.cmbProducto.Items.Contains(matrizProductos[i, 0]) == false)
                    {
                        Ventas.cmbProducto.Items.Add(matrizProductos[i, 0]);
                    }
                }
            }
            //this.Hide();
            //Ventas.ShowDialog();
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
            for (int i = 0; i < matrizProductos.GetLength(0); i++)
            {
                if (matrizProductos[i, 0] != null)
                {
                    if (Ventas.cmbProducto.Items.Contains(matrizProductos[i, 0]) == false)
                    {   
                        Ventas.cmbProducto.Items.Add(matrizProductos[i, 0]);
                    }
                }
            }
            this.Hide();
            objetoMain.ShowDialog();
        }

        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //lblErrorFecha.Visible  = false;
            //lblErrorID.Visible = false; 
            //lblErrorNombre.Visible = false; 


            if (dtpFecha.Value >= DateTime.Today) 
            {
                varFecha = dtpFecha.Value.ToString();
                varCantidad = nUDCantidad.Value.ToString();
                if(txtNombre.Text != "")
                {
                    varNombre = txtNombre.Text.ToLower();
                    if(nUDID.Value < 9999)
                    {
                        varID = nUDID.Value.ToString();
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
            for (int f = 0; f < matrizProductos.GetLength(0); f++)
            {
                if (varNombre == matrizProductos[f, 0])
                {
                    if(varID == matrizProductos[f, 1])
                    {

                        //Ventas.matrizProductos[IndiceFila, 0] = varNombre;
                        //Ventas.matrizProductos[IndiceFila, 1] = varID;
                        //Ventas.matrizProductos[IndiceFila, 2] = varFecha;
                        //Ventas.matrizProductos[IndiceFila, 3] = varCantidad;

                        matrizProductos[IndiceFila, 0] = varNombre;
                        matrizProductos[IndiceFila, 1] = varID;
                        matrizProductos[IndiceFila, 2] = varFecha;
                        matrizProductos[IndiceFila, 3] = varCantidad;
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
                    if (varNombre != matrizProductos[f, 0] && varID != matrizProductos[f, 1])
                    {
                        //Ventas.matrizProductos[IndiceFila, 0] = varNombre;
                        //Ventas.matrizProductos[IndiceFila, 1] = varID;
                        //Ventas.matrizProductos[IndiceFila, 2] = varFecha;
                        //Ventas.matrizProductos[IndiceFila, 3] = varCantidad;

                        matrizProductos[IndiceFila, 0] = varNombre;
                        matrizProductos[IndiceFila, 1] = varID;
                        matrizProductos[IndiceFila, 2] = varFecha;
                        matrizProductos[IndiceFila, 3] = varCantidad;
                        break;
                    }
                    else
                    {
                        lblErrorID.Visible = true;
                        break;
                    }
                }
            }
            IndiceFila++;
           
            //for (int f = 0; f < objetoMain.matrizCantidadProducto.GetLength(0); f++)
            //{
            //    if (objetoMain.matrizCantidadProducto[f, 0] == varNombre )
            //    {
            //        varAux = (Convert.ToInt32(objetoMain.matrizCantidadProducto[f, 1]) + Convert.ToInt32(varCantidad));
            //        objetoMain.matrizCantidadProducto[f, 1] = varAux.ToString();
            //        break;
            //    }
            //    else
            //    {
            //        objetoMain.matrizCantidadProducto[f, 0] = varNombre;
            //        objetoMain.matrizCantidadProducto[f, 1] = varCantidad;
            //        break;
            //    }
            //}

        }
        
        

    }
}
