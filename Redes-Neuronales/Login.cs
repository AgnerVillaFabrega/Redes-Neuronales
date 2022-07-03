using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redes_Neuronales
{
    public partial class Login : Form
    {
        FrmPrincipal frmPrincipal = new FrmPrincipal();
        public int cont { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Usuario"))
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(""))
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.FromArgb(64, 71, 89);
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("Contraseña"))
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(""))
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.FromArgb(64, 71, 89);
                txtPass.UseSystemPasswordChar = false;
            }
        }
        public void IniciarSesion()
        {
            
            if (cont < 3)
            {
                if (txtUser.Text.Equals("admi") && txtPass.Text.Equals("1234"))
                {
                    cont = 0;
                    this.Hide();
                    frmPrincipal.Show();
                }
                else
                {
                    cont += 1;
                    MessageBox.Show("Usuario o contraseña incorrecto", "¿Olvidaste tu contraseña?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Si tienes problemas con el inicio de sesion comunicate con los desarrolladores", "¿Problemas al iniciar sesion?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void BtmLogin_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}
