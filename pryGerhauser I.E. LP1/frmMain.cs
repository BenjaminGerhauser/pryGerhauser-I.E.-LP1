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
    public partial class frmMain : Form
    {
        public string[,] matrizProductos = new string[10, 4];
        //public string[,] matrizVentas = new string[10,4];
        //public string[,] matrizCantidadProducto = new string[10,2];

        int i;



        public frmMain()
        {
            InitializeComponent();
            
        }

        

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmCargaProducto CargarProducto = new frmCargaProducto();

            this.Hide();

            CargarProducto.ShowDialog();    
            if(btnProducto.Text == "Productos")
            {
                mrcProductos.Visible = true;
                mrcProductos.Location = new Point(120, 48);
                btnProducto.Text = "Productos  ";
            }
            else if(btnProducto.Text == "Productos  ")
            {
                mrcProductos.Visible = false;
                btnProducto.Text = "Productos";
            }
            mrcListado.Visible = false;
            mrcVentas.Visible = false;
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargaVentas Ventas = new frmCargaVentas();

            Ventas.ShowDialog();
            if (btnVentas.Text == "Ventas")
            {
                mrcVentas.Visible = true;
                mrcVentas.Location = new Point(120, 92);
                btnVentas.Text = "Ventas  ";
            }
            else if (btnVentas.Text == "Ventas  ")
            {
                mrcVentas.Visible = false;
                btnVentas.Text = "Ventas";
            }
            
            mrcProductos.Visible =false;
            mrcListado.Visible =false;

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            if (btnListado.Text == "Listado")
            {
                mrcListado.Visible = true;
                mrcListado.Location = new Point(120, 130);
                btnListado.Text = "Listado  ";
            }
            else if (btnListado.Text == "Listado  ")
            {
                mrcListado.Visible = false;
                btnListado.Text = "Listado";
            }
            
            mrcProductos.Visible = false;
            mrcVentas.Visible = false;
        }

        
        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(btnMenu.Text == "   ")
            {
                mrcMenuDesplegable.Visible = true;
                btnMenu.Text = " ";
            }
            else if(btnMenu.Text == " ")
            {
                mrcVentas.Visible=false;
                mrcListado.Visible=false;
                mrcProductos.Visible=false;
                mrcMenuDesplegable.Visible = false;
                btnMenu.Text = "   ";
            }
        }
    }
}
