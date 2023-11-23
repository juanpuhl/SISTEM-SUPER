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
    public partial class PanelControl : Form
    {
        public PanelControl()
        {
            InitializeComponent();

            LoadUserData(); //cargar datos del usuario
			PermisoUsuarios(); 


        }
        //esto es para poder mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lParam);
		// fin codigo de mover formulario


		private DateTime tiempoInicioSesion; //inicio sesion
        private TimeSpan tiempoTranscurrido; //tiempo que paso
		private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PermisoUsuarios()
        {
            //Permisos de usuarios
            if (UserLoginCache.Position == CargosUsers.Cajero)
            {
                btnContabilidad.Enabled = false;
                btnProveedores.Enabled = false;
                btnAdminUser.Enabled = false;
            }
            if (UserLoginCache.Position == CargosUsers.Contadora)
            {
                btnVentas.Enabled = false;
                btnAdminUser.Enabled = false;
            }
        }
        private void btnslide_Click(object sender, EventArgs e)
        {
            // consulta si el menu principal tiene una longitud de 250
            // si es asi la imagen cambia a 70
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
            // esta condicion se intercalan al presionar el boton
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;



        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show(" Si - Cierra Sesion \n No - Cierra Programa ", "ALERTA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

			if (result == DialogResult.Yes) // Si selecciona "Sí", cerrar sesión y guardar el tiempo de inicio
			{
				string resultado = userModel.GuardarTiempoSesion(tiempoTranscurrido);
				this.Close();
				// Cierra la ventana actual o realiza otras tareas necesarias para cerrar sesión
			}
			else if (result == DialogResult.No) // Si selecciona "No", cerrar la aplicación
			{
				string resultado = userModel.GuardarTiempoSesion(tiempoTranscurrido);
				Application.Exit();
			}
			// Si selecciona "Cancelar", no hacer nada y mantener la sesión activa

		}

		private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;

        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        //esta funcion es para abrir los formularios en el Formulario Panel Control (el principal)
        private void AbrirformInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new FrmVentas());

        }

        private void LoadUserData() //cargar datos del usuario
        {
            lblName.Text = UserLoginCache.FirsName + ", " + UserLoginCache.LastName;
            lblPosition.Text = UserLoginCache.Position;
            lblCorreo.Text = UserLoginCache.Email;
            //para el tiempo de sesion transcurrido
            tiempoInicioSesion = DateTime.Now;
			tiempoTranscurrido = TimeSpan.Zero;
			lblTimeSesion.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");



		}
		UserModel userModel = new UserModel();
		private void bntCerrarSesion_Click(object sender, EventArgs e)
        {
			string resultado = userModel.GuardarTiempoSesion(tiempoTranscurrido);

			if (MessageBox.Show("Esta seguro de cerrar sesion?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new StockRegistro());
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
    
        }

        //form editar perfil del usuario
        private void linkeditPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirformInPanel(new FormPerfilUsuario());
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new FormClientes());
        }

        private void btnAdminUser_Click(object sender, EventArgs e)
        {
			var FrmAdminUsuarios = new FrmAdminUsuarios();
			FrmAdminUsuarios.ShowDialog();
		}

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new FrmContabilidad());
        }

		private void PanelControl_Load(object sender, EventArgs e)
		{
            // cronometro tiempo de sesion
            cronoSesion.Start();
			cronoSesion.Tick += (s, args) =>
			{
				tiempoTranscurrido = DateTime.Now - tiempoInicioSesion;
				lblTimeSesion.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");
			};

            //fin codigo - crono time sesion
		}

		private void btnProveedores_Click(object sender, EventArgs e)
		{
			AbrirformInPanel(new FrmProveedores());
		}

		private void btnSeguridad_Click(object sender, EventArgs e)
		{
			var FrmCamarasSeguridad = new FrmCamarasSeguridad();
			FrmCamarasSeguridad.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var FrmImprimirPrecios = new FrmImprimirPrecios();
			FrmImprimirPrecios.ShowDialog();
		}
	}
}

