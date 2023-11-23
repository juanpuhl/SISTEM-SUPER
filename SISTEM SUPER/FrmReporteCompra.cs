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
	public partial class FrmReporteCompra : Form
	{
		public FrmReporteCompra()
		{
			InitializeComponent();
		}

		private void FrmReporteCompra_Load(object sender, EventArgs e)
		{
			// Agrega la opción "Todos" al ComboBox
			cmboProveedor.Items.Add("Todos");

			//luego agrega proveedores reales
			List<Proveedor> lista = new Proveedor().MostrarProv();

			foreach (Proveedor item in lista)
			{
				cmboProveedor.Items.Add(item);
			}
			cmboProveedor.DisplayMember = "RazonSocial"; // DisplayMember para indicar que propiedad mostrar

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

		private void btnBuscarProv_Click(object sender, EventArgs e)
		{
			if (cmboProveedor.SelectedItem != null)
			{
				// Verifica si se seleccionó la opción "Todos"
				if (cmboProveedor.SelectedItem.ToString() == "Todos")
				{
					// Realiza la búsqueda sin filtrar por proveedor
					List<ReporteCompra> lista = new Reporte().Compra(
						txtfechainicio.Value.ToString("yyyy/MM/dd"),
						txtfechafin.Value.ToString("yyyy/MM/dd"),
						0  // IdProveedor 0 para "Todos"
					);

					// Limpiar el DataGridView antes de completar
					dataGridView1.Rows.Clear();

					// Foreach para completar el DataGridView
					foreach (ReporteCompra rc in lista)
					{
					dataGridView1.Rows.Add(new object[] {
					rc.FechaRegistro,
					rc.TipoDocumento,
					rc.NumeroDocumento,
					rc.MontoTotal,
					rc.UsuarioRegistro,
					rc.DocumentoProveedor,
					rc.RazonSocial,
					rc.CodigoProducto,
					rc.NombreProducto,
					rc.PrecioCompra,
					rc.PrecioVenta,
					rc.Cantidad,
					rc.SubTotal
				});
					}
				}
				else if (cmboProveedor.SelectedItem is Proveedor selectedProveedor)
				{
					int idproveedor = Convert.ToInt32(selectedProveedor.IdProveedor);

					List<ReporteCompra> lista = new Reporte().Compra(
						txtfechainicio.Value.ToString("yyyy/MM/dd"),
						txtfechafin.Value.ToString("yyyy/MM/dd"),
						idproveedor
					);

					// Limpiar el DataGridView antes de completar
					dataGridView1.Rows.Clear();

					// Foreach para completar el DataGridView
					foreach (ReporteCompra rc in lista)
					{
						dataGridView1.Rows.Add(new object[] {
					rc.FechaRegistro,
					rc.TipoDocumento,
					rc.NumeroDocumento,
					rc.MontoTotal,
					rc.UsuarioRegistro,
					rc.DocumentoProveedor,
					rc.RazonSocial,
					rc.CodigoProducto,
					rc.NombreProducto,
					rc.PrecioCompra,
					rc.PrecioVenta,
					rc.Cantidad,
					rc.SubTotal
				});
					}
				
				}
				

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
	}
}



