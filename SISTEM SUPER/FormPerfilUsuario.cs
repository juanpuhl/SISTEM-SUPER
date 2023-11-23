using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
    public partial class FormPerfilUsuario : Form
    {
        public FormPerfilUsuario()
        {
            InitializeComponent();
        }

        private void FormPerfilUsuario_Load(object sender, EventArgs e)
        {
            loadUserData();
            IniciarPassEditarControl();

        }

        private void loadUserData() //metodo para cargar datos del usuario
        {
            //visibilidad
            lblNameUser.Text = UserLoginCache.loginName;
            lblNombre.Text = UserLoginCache.FirsName;
            lblApellido.Text = UserLoginCache.LastName;
            lblcorreo.Text = UserLoginCache.Email;
            lblPosicion.Text = UserLoginCache.Position;

            //Editar panel
            txtUser.Text = UserLoginCache.loginName;
            txtNombre.Text = UserLoginCache.FirsName;
            txtApellido.Text = UserLoginCache.LastName;
            txtEmail.Text = UserLoginCache.Email;
            txtPassw.Text = UserLoginCache.Password;
            txtConfirPass.Text = UserLoginCache.Password;
            txtActualPass.Text = "";
           

        }

        //para que pueda cambiar la contraseña
        private void IniciarPassEditarControl()
        {
            linkEditarPass.Text = "Edit";
            txtPassw.Enabled = false;
            txtPassw.UseSystemPasswordChar = true;
            txtConfirPass.Enabled = false;
            txtConfirPass.UseSystemPasswordChar = true;

        }

        //metodo para actualizar los datos en la interfaz grafica
        private void reset()
        {
            loadUserData();
            IniciarPassEditarControl();
        }

        private void linkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loadUserData();
           
        }

        private void linkEditarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkEditarPass.Text == "Edit")
            {
                linkEditarPass.Text = "Cancel";
                txtPassw.Enabled = true;
                txtPassw.Text = "";
                txtConfirPass.Enabled=true;
                txtConfirPass.Text = "";


            }
            else if (linkEditarPass.Text == "Cancel")
            {
               IniciarPassEditarControl();
                txtPassw.Text = UserLoginCache.Password;
                txtConfirPass.Text = UserLoginCache.Password;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e) //este es el boton GUARDAR    
        {
            if (txtPassw.Text.Length >= 5)
            {
                if (txtPassw.Text == txtConfirPass.Text)
                {
                    if (txtActualPass.Text == UserLoginCache.Password)
                    {
                        var userModel = new UserModel(
                            idUser: UserLoginCache.IdUser,
                            loginName: txtUser.Text,
                            password: txtPassw.Text,
                            firstName: txtNombre.Text,
                            lastName: txtApellido.Text,
                            position: null, //como el usuario no puede cambiuar su cargo, mandamos null
                            email: txtEmail.Text);
                        //invocamos metodo editar perfil usuario, y almacenamos en una variable el msj de retorno
                        var result = userModel.EditarPerfilUsuario();
                        MessageBox.Show(result);
                        reset(); //resetear datos
                        panel1.Visible = false;
                    }
                    else
                        MessageBox.Show("Contraseña Actual Incorrecta.");
                }
                else
                    MessageBox.Show("La Contraseña no coincide.");
            }
            else
                MessageBox.Show(" La contraseña debe tener minimo 5 caracteres");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            reset();
        }

        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
