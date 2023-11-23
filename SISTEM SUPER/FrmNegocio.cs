using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
	public partial class FrmNegocio : Form
	{
		public FrmNegocio()
		{
			InitializeComponent();
		}

		public Image ByteToImage(byte[] imageBytes)
		{ 
			MemoryStream ms = new MemoryStream();
			ms.Write(imageBytes,0,imageBytes.Length);
			Image image = new Bitmap(ms);

			return image;
		}
		private void FrmNegocio_Load(object sender, EventArgs e)
		{
			bool obtenido = true;
			byte[] byteimage = new CD_Negocio().Logo(out obtenido);
			if (obtenido)
			{
				picLogo.Image = ByteToImage(byteimage);
			}

			Negocio datos = new CD_Negocio().DatosNegocio();

			txtNombreNegocio.Text = datos.Nombre;
			txtCuit.Text = datos.Cuit;
			txtDireccion.Text = datos.Direccion;
			txtTelefono.Text = datos.Telefono;

		}

		private void btnExaminar_Click(object sender, EventArgs e)
		{
			string mensaje = string.Empty;

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.FileName = "Files |*.jpg;*.jpeg; *.png";

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				byte[] byteimage = File.ReadAllBytes(openFileDialog.FileName);
				bool respuesta = new Negocio().ActulizarLogo(byteimage, out mensaje);

				if (respuesta)
				{
					picLogo.Image= ByteToImage(byteimage);
				}
				else
				{
					MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string mensaje = string.Empty;
			Negocio obj = new Negocio()
			{
				Nombre = txtNombreNegocio.Text,
				Cuit = txtCuit.Text,
				Direccion = txtDireccion.Text,
				Telefono = txtTelefono.Text,
			};

			bool respuesta = new Negocio().GuardarDatos(obj, out mensaje);
			
			if (respuesta)
			{
				MessageBox.Show("Se actualizaron los datos con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(mensaje, "Error al actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
	}

/////////////////
///OTRA FORMA DE MOSTRAR LOS ERRORES 
///// Imprime el mensaje actual en la ventana de salida de Visual Studio
/*System.Diagnostics.Debug.WriteLine($"Mensaje actual: {mensaje}");

if (respuesta)
{
	MessageBox.Show("Se actualizó los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
else
{
	MessageBox.Show($"No se pudo actualizar datos. Motivo: {mensaje}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}*/

