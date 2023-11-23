using ClosedXML.Excel;
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
	public partial class FrmReporteVentas : Form
	{
		public FrmReporteVentas()
		{
			InitializeComponent();
		}

		private void FrmReporteVentas_Load(object sender, EventArgs e)
		{
			//llena el combo box con los datos que tiene el datagrid para realizar filtro
			foreach (DataGridViewColumn columna in dataGridView1.Columns)
			{
				if (columna.Visible == true)
				{
					cboBusqueda.Items.Add(columna.HeaderText); //agrega los encabezados de columas al comboBox
				}

				cboBusqueda.SelectedIndex = 0;
			}

		}

		private void btnBuscarVentas_Click(object sender, EventArgs e)
		{
			try
			{
				List<ReporteVenta> lista = new Reporte().venta(
					txtfechainicio.Value.ToString("yyyy/MM/dd"),
					txtfechafin.Value.ToString("yyyy/MM/dd")
					);

				dataGridView1.Rows.Clear();

				foreach (ReporteVenta rv in lista)
				{
					dataGridView1.Rows.Add(new object[] {
					rv.FechaRegistro,
					rv.TipoDocumento,
					rv.NumeroDocumento,
					rv.MontoTotal,
					rv.UsuarioRegistro,
					rv.DocumentoCliente,
					rv.NombreCliente,
					rv.ApellidoCliente,
					rv.CodigoProducto,
					rv.NombreProducto,
					//rv.PrecioCompra,
					rv.PrecioVenta,
					rv.Cantidad,
					rv.SubTotal
				});
				}
				dataGridView1.Refresh();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error en btnBuscarVentas_Click: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnBuscarPorColum_Click(object sender, EventArgs e)
		{
			try
			{
				string columnaFiltro = cboBusqueda.SelectedItem?.ToString();

				if (!string.IsNullOrEmpty(columnaFiltro))
				{
					// Buscar la columna por el nombre visible
					DataGridViewColumn columna = dataGridView1.Columns.Cast<DataGridViewColumn>()
						.FirstOrDefault(c => c.HeaderText == columnaFiltro);

					if (columna != null)
					{
						foreach (DataGridViewRow row in dataGridView1.Rows)
						{
							if (row.Cells[columna.Index].Value != null &&
								row.Cells[columna.Index].Value.ToString().Trim().ToLower().Contains(txtBusqueda.Text.Trim().ToLower()))
							{
								row.Visible = true;
							}
							else
							{
								row.Visible = false;
							}
						}
					}
				}
				// Restaurar la visibilidad de las filas que no coinciden con el criterio de búsqueda
				else
				{
					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						row.Visible = true;
					}
				}
			}
			catch (Exception ex)
			{
				//MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBusqueda.Text = "";
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				row.Visible = true;
			}
		}
		private void btnReporteExcel_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count < 1)
			{
				MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				DataTable dt = new DataTable();

				foreach (DataGridViewColumn columna in dataGridView1.Columns)
				{
					dt.Columns.Add(columna.HeaderText, typeof(string));
				}

				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if (row.Visible)
					{
						object[] rowData = new object[dataGridView1.Columns.Count];

						for (int i = 0; i < dataGridView1.Columns.Count; i++)
						{
							// Verificar si la celda no es null antes de acceder a su valor
							if (row.Cells[i].Value != null)
							{
								rowData[i] = row.Cells[i].Value.ToString();
							}
							else
							{
								// Puedes asignar un valor predeterminado o manejar la situación según sea necesario
								rowData[i] = string.Empty;
							}
						}

						dt.Rows.Add(rowData);
					}
				}

				SaveFileDialog savefile = new SaveFileDialog();
				savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
				savefile.Filter = "Excel Files | *.xlsx";

				if (savefile.ShowDialog() == DialogResult.OK)
				{
					try
					{
						XLWorkbook wb = new XLWorkbook();
						var hoja = wb.Worksheets.Add(dt, "Informe");
						if (hoja != null)
						{
							hoja.ColumnsUsed().AdjustToContents();
							wb.SaveAs(savefile.FileName);
							MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Error al generar reporte: hoja es null", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
					catch
					{
						MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
		}




	}
}


	


