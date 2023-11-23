using SISTEM_SUPER.Modal;
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
	public partial class FrmAdminUsuarios : Form
	{

		AdministrarUsuarios objetoAdmUsuario = new  AdministrarUsuarios();
		private string idUsuario = null; //creo variable null para q no ocupe valor en memoria
		private bool EditarUser = false;
		public FrmAdminUsuarios()
		{
			InitializeComponent();
		}

		private void FrmAdminUsuarios_Load(object sender, EventArgs e)
		{
			MostrarUsuarios();

		}

		private void MostrarUsuarios()
		{
			AdministrarUsuarios objeto = new AdministrarUsuarios(); //para que se actualice
			dataGridView1.DataSource = objeto.MostrarUsuarios();

		}

		private void linkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel1.Visible = true;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			panel1.Visible = false;
			//reset();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{

			if (dataGridView1.SelectedRows.Count > 0)
			{
				EditarUser = true; // al cumplirse la condicion del if la variable editar pasa a verdadero
				txtLoginUser.Text = dataGridView1.CurrentRow.Cells["LoginName"].Value.ToString();
				txtPassword.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
				txtNombre.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
				txtApellido.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
				txtPosition.Text = dataGridView1.CurrentRow.Cells["Position"].Value.ToString();
				txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
				idUsuario = dataGridView1.CurrentRow.Cells["UserID"].Value.ToString();
			}
			else //al no cumplirse la condicion le decimos al usuario que elija la fila a editar
			{
				MessageBox.Show("Seleccione la fila a editar");
			}


		}

		private void LimpiarForm()
		{
			txtLoginUser.Clear();
			txtNombre.Clear();
			txtApellido.Clear();
			txtEmail.Clear();
			txtPosition.Clear();
			txtPassword.Clear();

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			//insertar productos
			if (EditarUser == false) //agrega el registro
			{
				try
				{

					objetoAdmUsuario.InsertarUsuario(txtLoginUser.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtPosition.Text, txtPassword.Text);
					MessageBox.Show("Se INSERTO Usuario correctamente");
					MostrarUsuarios();
					LimpiarForm();
				}
				catch (Exception ex)
				{
					MessageBox.Show("NO se pueden insertar los datos por: " + ex.Message);
				}
			}
			//editar productos
			if (EditarUser == true) // edita el regitro
			{
				try
				{
					objetoAdmUsuario.EditarUsuario(idUsuario, txtLoginUser.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtPosition.Text, txtPassword.Text);
					MessageBox.Show("Se EDITO Usuario correctamente");
					MostrarUsuarios();
					LimpiarForm();
					EditarUser = false; // cambia a falso para que el boton siga agregando registro

				}
				catch (Exception ex)
				{
					MessageBox.Show("NO se pueden EDITAR los datos por: " + ex.Message);
				}
			}

		}
	}
}

