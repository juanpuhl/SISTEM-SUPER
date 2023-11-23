using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace SISTEM_SUPER
{
	public partial class FrmImprimirPrecios : Form
	{
		Productos objetoProd = new Productos();
		private int contadorImagenes = 1;

		public FrmImprimirPrecios()
		{
			InitializeComponent();
		}

		private void MostrarProductos()
		{
			Productos objeto = new Productos();
			dataGridView1.DataSource = objeto.MostrarProd();
		}

		private string ObtenerContenidoCodigoBarras()
		{
			// Obtener solo el código del producto seleccionado
			string codigo = dataGridView1.SelectedRows[0].Cells["Codigo_Producto"].Value.ToString();
			return codigo;
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				string contenidoCodigoBarras = ObtenerContenidoCodigoBarras();

				// Obtener la fila seleccionada del DataGridView
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

				// Obtener los datos del producto
				string codigo = selectedRow.Cells["Codigo_Producto"].Value.ToString();
				string nombre = selectedRow.Cells["Nombre"].Value.ToString();
				string descripcion = selectedRow.Cells["Descripcion"].Value.ToString();
				string marca = selectedRow.Cells["Marca"].Value.ToString();
				string precioVenta = selectedRow.Cells["Precio_Venta"].Value.ToString();
				string stock = selectedRow.Cells["stock"].Value.ToString();

				// Generar el código de barras
				BarcodeWriter barcodeWriter = new BarcodeWriter();
				barcodeWriter.Format = BarcodeFormat.CODE_128;
				Bitmap barcodeBitmap = barcodeWriter.Write(contenidoCodigoBarras);

				// Crear una imagen que contenga el código de barras y los datos del producto con fondo blanco
				int combinedWidth = barcodeBitmap.Width + 200; // Ajusta el ancho según tus necesidades
				int combinedHeight = Math.Max(barcodeBitmap.Height, 200); // Ajusta el alto según tus necesidades

				Bitmap combinedBitmap = new Bitmap(combinedWidth, combinedHeight);

				using (Graphics g = Graphics.FromImage(combinedBitmap))
				{
					// Establecer el fondo blanco
					g.Clear(Color.White);

					// Dibujar el código de barras
					g.DrawImage(barcodeBitmap, 0, 0);

					// Dibujar los datos del producto al lado del código de barras
					Font font = new Font(FontFamily.GenericSansSerif, 10);
					SolidBrush brush = new SolidBrush(Color.Black);
					PointF dataPosition = new PointF(barcodeBitmap.Width + 10, 0);
					g.DrawString($"Código: {codigo}\n" +
								 $"Nombre: {nombre}\n" +
								 $"Descripción: {descripcion}\n" +
								 $"Marca: {marca}\n" +
								 $"Precio de venta: {precioVenta}\n" +
								 $"Stock: {stock}", font, brush, dataPosition);
				}

				// Mostrar la imagen combinada en el PictureBox
				picCodigoBarras.Image = combinedBitmap;

				// Guardar la imagen combinada en un archivo JPG con un nombre único
				GuardarCodigoBarrasYDatosEnImagen(combinedBitmap);
			}
			else
			{
				MessageBox.Show("Seleccione un producto antes de generar el código de barras.");
			}
		}

		private void GuardarCodigoBarrasYDatosEnImagen(Bitmap combinedBitmap)
		{
			// Mostrar el cuadro de diálogo para seleccionar la carpeta
			DialogResult result = folderBrowserDialog1.ShowDialog();

			if (result == DialogResult.OK)
			{
				// Generar un nombre de archivo único con un número al final
				string fileName = $"codigo_barras_y_datos_{contadorImagenes}.jpg";

				// Guardar la imagen en la carpeta seleccionada con el nombre único
				string imagePath = Path.Combine(folderBrowserDialog1.SelectedPath, fileName);
				combinedBitmap.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

				MessageBox.Show($"La imagen del código de barras y datos se ha guardado en {imagePath}", "Éxito");

				// Incrementar el contador de imágenes para el próximo nombre único
				contadorImagenes++;
			}
		}

		private void FrmImprimirPrecios_Load(object sender, EventArgs e)
		{
			MostrarProductos();
		}
	}
}
