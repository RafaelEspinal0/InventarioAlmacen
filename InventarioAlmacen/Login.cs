using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioAlmacen
{
    public partial class Login : Form
    {
        AlmacenEntities db = new AlmacenEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {
                if (txtPass.Text != "Contraseña")
                {
                    doLogin();
                }
                else
                {
                    mensajeError("Por favor ingrese su contraseña");
                }
            }
            else
            {
                mensajeError("Por favor ingrese su usuario");
            }
        }

        void doLogin()
        {
            var user = db.usuario.FirstOrDefault(x => x.username == txtUsuario.Text && x.password== txtPass.Text);
            if (user == null)
            {
                mensajeError("Credenciales invalidas");
                txtPass.Text = "Contraseña";
                return;
            }

            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += logOut;
            dashboard.Show();

            this.Hide();
        }

        void mensajeError(string msg)
        {
            lblError.Text = "       " + msg;
            lblError.Visible = true;
        }

        void logOut(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Text = "Usuario";
            txtPass.Text = "Contraseña";
            txtPass.UseSystemPasswordChar = false;
            lblError.Visible = false;
            txtUsuario.Focus();
            this.Show();
        }

    }
}
