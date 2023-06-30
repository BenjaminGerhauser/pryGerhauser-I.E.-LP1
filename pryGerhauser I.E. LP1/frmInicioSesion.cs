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
    public partial class frmInicioSesion : Form
    {
        string[,] Usuarios = new string[10,2];
        


        public frmInicioSesion()
        {
            InitializeComponent();
            Usuarios[0, 0] = "Benja";
            Usuarios[0, 1] = "1234";
            Usuarios[1, 0] = "Admin";
            Usuarios[1, 1] = "Admin";

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (Usuarios[i, 0] != null)
                {
                    if (txtUsuario.Text == Usuarios[i, 0]) 
                    {
                        if(txtContraseña.Text == Usuarios[i, 1])
                        {
                            frmMain Inicio = new frmMain();
                            this.Hide();
                            Inicio.lblBienvenida.Text = Usuarios[i, 0];
                            Inicio.ShowDialog();
                            
                        }    
                    }

                }
                
            }
        }

       

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;

            }
        }
    }
}
