using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using ZXing;

namespace SISTEM_SUPER
{
	public partial class FrmLeerCodigoQR : Form
	{
		private Mat Frame;
		private VideoCapture Camara;
		private BarcodeReader Reader;

		public FrmLeerCodigoQR()
		{
			InitializeComponent();
			
		}

		private void rdbEncender_Click(object sender, EventArgs e)
		{
			if (!Camara.IsOpened)
			{
				Camara.Start();
				timer1.Start();
			}
		}

		private void rdbApagar_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbApagar.Checked)
			{
				timer1.Stop();
				Camara.Stop();
				pictureBox1.Image = null;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (Camara.IsOpened)
				{
					Camara.Read(Frame);
					pictureBox1.Image = Frame.ToBitmap();
				}
			}
			catch (Emgu.CV.Util.CvException ex)
			{
				//  excepción, por ejemplo, mostrando un mensaje en la consola o en una ventana emergente
				Console.WriteLine("Error de captura de video: " + ex.Message);
				// MessageBox.Show("Error de captura de video: " + ex.Message); // Ventana emergente

				
			}
		}


		private void btnIngresar_Click(object sender, EventArgs e)
		{
			Result resultado;
			if (pictureBox1.Image != null)
			{
				resultado = Reader.Decode((Bitmap)pictureBox1.Image);
				if (resultado != null)
				{
					textBox1.Text = resultado.Text;
				}
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			textBox1.Text = string.Empty;
		}

		private void FrmLeerCodigoQR_Load(object sender, EventArgs e)
		{
			Frame = new Mat();
			Camara = new VideoCapture();
			Reader = new BarcodeReader();
			timer1.Interval = 40;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

			rdbApagar.Checked = true;

			Frame = new Mat();
			Camara = new VideoCapture();
			Reader = new BarcodeReader();
			timer1.Interval = 40;

			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

			rdbApagar.Checked = true;
		}

		private void rdbEncender_CheckedChanged(object sender, EventArgs e)
		{
			Camara.Start();
			if (!timer1.Enabled) timer1.Enabled = true;
			timer1.Start();
		}

		private void rdbApagar_CheckedChanged_1(object sender, EventArgs e)
		{
			timer1.Stop();

			timer1.Enabled = false;
			Camara.Start();
			pictureBox1.Image = null;
			timer1.Enabled = false;
		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			if (Camara.IsOpened)
			{
				Camara.Read(Frame);
				pictureBox1.Image = Frame.ToBitmap();
			}
		}

		private void btnIngresar_Click_1(object sender, EventArgs e)
		{
			Result resultado;
			if (pictureBox1.Image != null)
			{
				resultado = Reader.Decode((Bitmap)pictureBox1.Image);
				if (resultado != null)
				{
					textBox1.Text = resultado.Text;

				}
			}
		}

		private void btnLimpiar_Click_1(object sender, EventArgs e)
		{
			textBox1.Text = string.Empty;
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{

			this.Close();
		}
	}
}
