using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
	public partial class FrmCamarasSeguridad : Form
	{


		public string Path = @"C:\Users\juanp\source\repos\EJERCICIOS\tp metodo constructor\SISTEM SUPER\SISTEM SUPER\Path";

		private bool HayDispositivos;

		private FilterInfoCollection MisDispositivos;
		private VideoCaptureDevice MiWebCam;
		public FrmCamarasSeguridad()
		{
			InitializeComponent();
		}

		private void FrmCamarasSeguridad_Load(object sender, EventArgs e)
		{
			CargaDispositivos();
			pictureBox1.DoubleClick += pictureBox1_DoubleClick;

		}

		public void CargaDispositivos()
		{
			MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (MisDispositivos.Count > 0)
			{
				HayDispositivos = true;
				for (int i = 0; i < MisDispositivos.Count; i++)
				{
					comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
					comboBox1.Text = MisDispositivos[i].Name.ToString();
				}
			}
			else
			{
				HayDispositivos = false;
			}

		}

		private void CerrarWebCam()
		{
			if (MiWebCam != null && MiWebCam.IsRunning)
			{
				MiWebCam.SignalToStop();
				MiWebCam = null;
			}
		}
		private void btnGrabar_Click(object sender, EventArgs e)
		{
			CerrarWebCam();
			int i = comboBox1.SelectedIndex;
			string NombreVideo = MisDispositivos[i].MonikerString;
			MiWebCam = new VideoCaptureDevice(NombreVideo);
			MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
			MiWebCam.Start();

		}

		private void Capturando(object sender, NewFrameEventArgs eventArgs)
		{
			Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
			pictureBox1.Image = Imagen;

		}

		private void FrmCamarasSeguridad_FormClosed(object sender, FormClosedEventArgs e)
		{
			CerrarWebCam();
		}

		private int contadorCapturas = 0; // Agrega un contador para hacer cada nombre único
		private void btnCapturar_Click(object sender, EventArgs e)
		{
			if (MiWebCam != null && MiWebCam.IsRunning)
			{
				// Crear una copia del último fotograma capturado
				Bitmap captura = (Bitmap)pictureBox1.Image.Clone();

				// Asignar la copia a pictureBox2.Image
				pictureBox2.Image = captura;

				// Construir el nombre del archivo con el contador
				string nombreArchivo = $"capturaCamSuper{contadorCapturas}.jpg";

				// Guardar la copia en la ruta completa con el nombre único
				if (captura != null)
				{
					captura.Save(System.IO.Path.Combine(Path, nombreArchivo), ImageFormat.Jpeg);

					// Incrementar el contador para la siguiente captura
					contadorCapturas++;
				}
				else
				{
					MessageBox.Show("La imagen capturada es null. No se puede guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void pictureBox1_DoubleClick(object sender, EventArgs e)
		{
			if (FormBorderStyle == FormBorderStyle.None)
			{
				// Si ya está en modo pantalla completa, restaurar
				FormBorderStyle = FormBorderStyle.Sizable;
				WindowState = FormWindowState.Normal;
				TopMost = false;
			}
			else
			{
				// Si no está en modo pantalla completa, agrandar a toda la pantalla
				FormBorderStyle = FormBorderStyle.None;
				WindowState = FormWindowState.Maximized;
				TopMost = true; // Mantener la ventana por encima de otras ventanas
			}
		}
	}
}
