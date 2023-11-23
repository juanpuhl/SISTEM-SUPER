using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using SISTEM_SUPER.Modal;
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
	public partial class FrmDetalleVenta : Form
	{
		public FrmDetalleVenta()
		{
			InitializeComponent();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				// Crear una instancia de la clase Compra y obtener los datos de la compra
				Venta oVenta = new Venta().ObtenerVenta(txtBusqueda.Text);

				// Verificar si se obtuvieron datos válidos
				if (oVenta.IdVenta != 0)
				{
					// Mostrar los datos en los TextBox
					txtNumeroDocumento.Text = oVenta.NumeroDocumento;

					txtFecha.Text = oVenta.FechaRegistro;
					txtTipoDoc.Text = oVenta.TipoDocumento;
					txtUsuario.Text = oVenta.oUsuario.loginName;

					txtDniCliente.Text = oVenta.DocumentoCliente;
					txtNombreCliente.Text = oVenta.NombreCliente;
					txtApellidoCliente.Text = oVenta.ApellidoCliente;


					// Limpiar las filas existentes en el DataGridView
					dataGridView1.Rows.Clear();

					if (oVenta.oDetalleVenta != null && oVenta.oDetalleVenta.Count > 0)
					{
						// Llenar el DataGridView con los detalles de la compra
						foreach (Detalle_Venta dv in oVenta.oDetalleVenta)
						{
							try
							{
								if (dv.Productos != null)
								{
									dataGridView1.Rows.Add(new object[] { dv.Productos.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
								}
								dataGridView1.AllowUserToAddRows = false;

							}
							catch (Exception ex)
							{
								MessageBox.Show($"Error al agregar fila al DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}

						// Mostrar los montos  en el TextBox
						txtMontoPago.Text = oVenta.MontoPago.ToString("0.00");
						txtMontoCambio.Text = oVenta.MontoCambio.ToString("0.00");
						txtMontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
					}
					else
					{
						// Limpiar el DataGridView si no hay detalles de compra
						dataGridView1.Rows.Clear();

						// alerta al no encontrar detalles de compra
						MessageBox.Show("No hay detalles de venta para mostrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

						// También puedes mostrar el mensaje en la consola para depuración
						Console.WriteLine("No hay detalles de venta para mostrar.");
					}
				}
				else
				{
					// alerta al no encontrar la compra
					MessageBox.Show("La venta no fue encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				// Manejar cualquier excepción y mostrar un mensaje de error
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDescargarPDf_Click(object sender, EventArgs e)
		{
			if (txtTipoDoc.Text == "")
			{
				MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
			Negocio oDatos = new CD_Negocio().DatosNegocio();

			// reemplaza los datos @.... por los datos del negocio
			//DATOS DEL NEGOCIO
			Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatos.Nombre.ToUpper());
			Texto_Html = Texto_Html.Replace("@docnegocio", oDatos.Cuit.ToUpper());
			Texto_Html = Texto_Html.Replace("@dirnegocio", oDatos.Direccion.ToUpper());
			Texto_Html = Texto_Html.Replace("@telnegocio", oDatos.Telefono.ToUpper());
			//DATOS DERECHA
			Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDoc.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@numerodocumento", txtNumeroDocumento.Text.ToUpper());

			//DATOS DEL PROVEEDOR
			Texto_Html = Texto_Html.Replace("@docCliente", txtDniCliente.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@nombreCliente", txtNombreCliente.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@apellidoCliente", txtApellidoCliente.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@fecharegistro", txtFecha.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuario.Text.ToUpper());

			//DATOS DE LA TABLAS
			string filas = string.Empty;
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				filas += "<tr>";
				filas += "<td>" + row.Cells["Productos"].Value.ToString() + "</td>";
				filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
				filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
				filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
				filas += "</tr>";
			}

			//reemplaza el @filas del html por los datos obtenidos con el foreach
			Texto_Html = Texto_Html.Replace("@filas", filas);
			//monto total

			Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotal.Text);


			//Ventana dialogo, donde guardar el documento.
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.FileName = string.Format("Venta_{0}-{1}.pdf", txtNumeroDocumento.Text, txtApellidoCliente.Text);
			saveFile.Filter = "Pdf Files|*.pdf";

			// para poner los datos en el pdf
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
				{
					Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
					PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
					pdfDoc.Open();
					//poner el logo
					bool obtenido = true;
					byte[] byteImage = new Negocio().Logo(out obtenido);
					if (obtenido)
					{
						iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
						img.ScaleToFit(60, 60);
						img.Alignment = iTextSharp.text.Image.UNDERLYING;
						img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
						pdfDoc.Add(img);
					}
					//poner los demas datos
					using (StringReader sr = new StringReader(Texto_Html))
					{
						XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
					}
					// Agregar imagen QR al final del PDF
					string rutaImagenQR = @"C:\Users\juanp\source\repos\EJERCICIOS\tp metodo constructor\SISTEM SUPER\SISTEM SUPER\Resources\QR sitio los dos chinos.png";  // Reemplaza con la ruta de tu imagen QR
					AgregarImagenQR(pdfDoc, rutaImagenQR);

					pdfDoc.Close();
					stream.Close();
					MessageBox.Show("Se genero documento PDF", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


				}
			}
		}
		private void AgregarImagenQR(Document pdfDoc, string rutaImagenQR)
		{
			try
			{
				// Crear instancia de Image y agregarla al documento PDF
				iTextSharp.text.Image imgQR = iTextSharp.text.Image.GetInstance(rutaImagenQR);
				imgQR.ScaleToFit(100, 100); // Ajusta el tamaño de la imagen QR según tus necesidades

				// Posiciona la imagen QR en el centro y alineada al final del PDF
				imgQR.SetAbsolutePosition((pdfDoc.PageSize.Width - imgQR.ScaledWidth) / 2, pdfDoc.Bottom);

				pdfDoc.Add(imgQR);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al agregar la imagen QR al PDF: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}

		