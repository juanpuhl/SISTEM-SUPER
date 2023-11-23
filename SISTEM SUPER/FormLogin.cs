using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // para poder arrastrar formulario

namespace SISTEM_SUPER
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        //esto es para poder mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd , int wmsg, int wparam, int lParam);
        // fin codigo de mover formulario

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text== "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar= true; //para que se oculte la contraseña

            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false; //para que se vea la palabra contraseña

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        // esto tambien va para poder mover el formulario
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //para el panel donde esta el logo
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Form panelcontrol = new PanelControl();
            //panelcontrol.Show();
            //verificar si esta vacio, pero usamos marca de agua
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        PanelControl mainMenu = new PanelControl();
						//MessageBox.Show("Bienvenido " + UserLoginCache.FirsName + ", " + UserLoginCache.LastName);
						MessageBox.Show(
	                    "Bienvenido " + UserLoginCache.FirsName + ", " + UserLoginCache.LastName,
	                    "Welcome",
	                    MessageBoxButtons.OK,
	                    MessageBoxIcon.Information);
						mainMenu.Show();
                        mainMenu.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrectos. \n        Por favor, volver a intentar ");
                        txtPass.Clear();
                        txtUsuario.Focus();

                    }
                }
                else msgError("Por favor Ingrese Contraseña");

            }
            else msgError("Por favor Ingrese Usuario"); 
               
        }
       private void msgError( string msg)
        {
            lblErrorMessage.Text = "       " + msg;
            lblErrorMessage.Visible = true;
        }
        private void CerrarSesion(object sender, FormClosedEventArgs e) // para cerrar sesion
        {
            txtPass.Clear();
            txtUsuario.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperacionDeContraseña = new  FormRecuperarContraseña();
            recuperacionDeContraseña.ShowDialog();
        }
        // para ingresar con un enter
		private void txtPass_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin.PerformClick(); // Simula el clic en el botón de inicio de sesión
			}

		}
	}
   
}
