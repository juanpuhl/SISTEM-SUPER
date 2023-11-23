using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER.Modal
{
	public partial class mdProductos : Form
	{
        public Productos _producto { get; set; } //propiedad
        public mdProductos()
		{
			InitializeComponent();
		}

		private void mdProductos_Load(object sender, EventArgs e)
		{


			foreach (DataGridViewColumn columna in dgvdata.Columns)
			{
				if (columna.Visible == true)
				{
					cboBusqueda.Items.Add(columna.HeaderText); //agrega los encabezados de columas al comboBox
				}

				
			}
			if (cboBusqueda.Items.Count > 0)
			{
				cboBusqueda.SelectedIndex = 0; // establece el índice seleccionado si hay elementos en el ComboBox
			}

			List<Productos> lista = new Productos().MostrarProductos();
			foreach (Productos item in lista)
			{
				dgvdata.Rows.Add(new object[] {item.Id, item.Codigo, item.Nombre, item.Descripcion, item.Marca, item.PrecioCompra, item.PrecioCompra, item.Stock });
			}

		}

		private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int iRow = e.RowIndex; //  fila
			int iCol = e.ColumnIndex; //  columna

			//para validar fila seleccionada
			if (iRow >= 0 && iCol > 0)
			{
				_producto = new Productos()
				{
					Id = dgvdata.Rows[iRow].Cells["Id"].Value.ToString(),
					Codigo = dgvdata.Rows[iRow].Cells["Codigo_Producto"].Value.ToString(),
					Nombre = dgvdata.Rows[iRow].Cells["Nombre"].Value.ToString(),
					Descripcion = dgvdata.Rows[iRow].Cells["Descripcion"].Value.ToString(),
					Marca = dgvdata.Rows[iRow].Cells["Marca"].Value.ToString(),
					PrecioCompra = dgvdata.Rows[iRow].Cells["Precio_Compra"].Value.ToString(),
					PrecioVenta = dgvdata.Rows[iRow].Cells["Precio_Venta"].Value.ToString(),
					Stock = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Stock"].Value.ToString()),
				};
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (cboBusqueda.SelectedItem != null && dgvdata.Rows.Count > 0)
			{
				string columnaFiltro = cboBusqueda.SelectedItem.ToString();

				foreach (DataGridViewRow row in dgvdata.Rows)
				{
					if (row.Cells[columnaFiltro].Value != null &&
						row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
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

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBusqueda.Text = "";
			foreach (DataGridViewRow row in dgvdata.Rows)
			{
				row.Visible = true;
			}
		}
	}
}
