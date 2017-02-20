using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data;
using utils;

namespace ordery
{
    public partial class PLogin : Form
    {
        public PLogin()
        {
            InitializeComponent();
        }

        private void ntextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.txtusername.Text = string.Empty;
            this.txtpassword.Text = string.Empty;
            this.txtusername.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Username = this.txtusername.Text.Trim();
            usuario.Password = this.txtpassword.Text.Trim();
            if(usuario.authenticateUsuario(usuario))
            {
                mdiPrincipal doform = new mdiPrincipal();
                doform.Show();
                this.Hide();
            }
            else
            {
                messages.errorMessage("Error de Usuario o Contraseña");
            }
        }
    }
}
