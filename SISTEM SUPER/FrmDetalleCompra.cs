
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Diagnostics;


namespace SISTEM_SUPER
{
	public partial class FrmDetalleCompra : Form
	{

		
		public FrmDetalleCompra()
		{
			InitializeComponent();
			
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				// Crear una instancia de la clase Compra y obtener los datos de la compra
				Compra oCompra = new Compra().ObtenerCompra(txtBusqueda.Text);

				// Verificar si se obtuvieron datos válidos
				if (oCompra.IdCompra != 0)
				{
					// Mostrar los datos en los TextBox
					txtNumeroDocumento.Text = oCompra.NumeroDocumento;
					txtFecha.Text = oCompra.FechaRegistro;
					txtTipoDoc.Text = oCompra.TipoDocumento;
					txtUsuario.Text = oCompra.oUsuario.loginName;
					txtDocProveedor.Text = oCompra.oProveedor?.Documento;
					txtNombreProv.Text = oCompra.oProveedor?.RazonSocial;

					// Limpiar las filas existentes en el DataGridView
					dataGridView1.Rows.Clear();

					if (oCompra.oDetalleCompra != null && oCompra.oDetalleCompra.Count > 0)
					{
						// Llenar el DataGridView con los detalles de la compra
						foreach (Detalle_Compra dc in oCompra.oDetalleCompra)
						{
							try
							{
								if (dc.Productos != null)
								{
									dataGridView1.Rows.Add(new object[] { dc.Productos.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
								}
								dataGridView1.AllowUserToAddRows = false;

							}
							catch (Exception ex)
							{
								MessageBox.Show($"Error al agregar fila al DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}

						// Mostrar el monto total en el TextBox
						txtMontoTotal.Text = oCompra.MontoTotal.ToString("0.00");
					}
					else
					{
						// Limpiar el DataGridView si no hay detalles de compra
						dataGridView1.Rows.Clear();

						// alerta al no encontrar detalles de compra
						MessageBox.Show("No hay detalles de compra para mostrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

						// También puedes mostrar el mensaje en la consola para depuración
						Console.WriteLine("No hay detalles de compra para mostrar.");
					}
				}
				else
				{
					// alerta al no encontrar la compra
					MessageBox.Show("La compra no fue encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

			string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
			Negocio oDatos = new CD_Negocio().DatosNegocio();

			// reemplaza los datos @.... por los datos del negocio
			//DATOS DEL NEGOCIO
			Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatos.Nombre.ToUpper());
			Texto_Html = Texto_Html.Replace("@docnegocio", oDatos.Cuit.ToUpper());
			Texto_Html = Texto_Html.Replace("@dirnegocio", oDatos.Direccion.ToUpper());
			//Texto_Html = Texto_Html.Replace("@telnegocio", oDatos.Telefono.ToUpper());
			//DATOS DERECHA
			Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDoc.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@numerodocumento", txtNumeroDocumento.Text.ToUpper());

			//DATOS DEL PROVEEDOR
			Texto_Html = Texto_Html.Replace("@docproveedor", txtDocProveedor.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@nombreproveedor", txtNombreProv.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@fecharegistro", txtFecha.Text.ToUpper());
			Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuario.Text.ToUpper());

			//DATOS DE LA TABLAS
			string filas = string.Empty;
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				filas += "<tr>";
				filas += "<td>" + row.Cells["Productos"].Value.ToString() + "</td>";
				filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
				filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
				filas += "<td>" + row.Cells["SubTotal"].Value.ToString()+ "</td>";
				filas += "</tr>";
			}

			//reemplaza el @filas del html por los datos obtenidos con el foreach
			Texto_Html = Texto_Html.Replace("@filas", filas);
			//monto total
			
			Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotal.Text);
			

			//Ventana dialogo, donde guardar el documento.
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.FileName = string.Format("Compra_{0}-{1}.pdf", txtNumeroDocumento.Text, txtNombreProv.Text);
			saveFile.Filter = "Pdf Files|*.pdf";

			// para poner los datos en el pdf
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
				{
					Document pdfDoc = new Document (PageSize.A4,25,25,25,25);
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
					using (StringReader sr= new StringReader(Texto_Html))
					{
						XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfDoc, sr);
					}

					pdfDoc.Close();
					stream.Close();
					MessageBox.Show("Se genero documento PDF", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


				}
			}

		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtFecha.Text = "";
			txtNumeroDocumento.Text = "";
			txtTipoDoc.Text = "";
			txtUsuario.Text = "";
			txtDocProveedor.Text = "";
			txtNombreProv.Text = "";
			dataGridView1.Rows.Clear();
			txtMontoTotal.Text = "0.00";
		}
	}

	}

