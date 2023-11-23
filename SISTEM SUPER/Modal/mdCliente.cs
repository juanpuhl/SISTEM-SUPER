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
	public partial class mdCliente : Form
	{

		public Clientes _Cliente { get; set; } //_ para que indique q es una propiedad del formulario
		public mdCliente()
		{
			InitializeComponent();
		}

		private void mdCliente_Load(object sender, EventArgs e)
		{
			//cargamos el combobox con los datos de las columnas del dataGrid
			foreach (DataGridViewColumn columna in dgvdata.Columns)
			{
				if (columna.Visible == true)
				{
					cboBusqueda.Items.Add(columna.HeaderText); //agrega los encabezados de columas al comboBox
				}

				cboBusqueda.SelectedIndex = 0;
			}

			//completa el dataGrid con los datos de los clientes
			List<Clientes> lista = new Clientes().MostrarClie();
			foreach (Clientes item in lista)
			{
				dgvdata.Rows.Add(new object[] { item.Dni, item.Nombre, item.Apellido, item.Condicion_Fiscal });
			}
		}

		private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int iRow = e.RowIndex; //  fila
			int iCol = e.ColumnIndex; //  columna

			//para validar fila seleccionada
			if (iRow >= 0 && iCol > 0)
			{
				_Cliente = new Clientes()
				{
					//IdCliente = dgvdata.Rows[iRow].Cells["Id"].Value.ToString(),
					Dni = dgvdata.Rows[iRow].Cells["Dni"].Value.ToString(),
					Nombre = dgvdata.Rows[iRow].Cells["Nombre"].Value.ToString(),
					Apellido = dgvdata.Rows[iRow].Cells["Apellido"].Value.ToString(),
					Condicion_Fiscal = dgvdata.Rows[iRow].Cells["Condicion_Fiscal"].Value.ToString(),
				};
			};
				this.DialogResult = DialogResult.OK;
				this.Close();
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
