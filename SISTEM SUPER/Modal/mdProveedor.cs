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
	public partial class mdProveedor : Form
	{

        public Proveedor _Proveedor { get; set; } //_ para que indique q es una propiedad del formulario

        public mdProveedor()
		{
			InitializeComponent();
		}

		private void mdProveedor_Load(object sender, EventArgs e)
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

			List<Proveedor> lista = new Proveedor().MostrarProv();
			foreach(Proveedor item in lista)
			{
				dgvdata.Rows.Add(new object[] {item.IdProveedor, item.Documento,item.RazonSocial});
			}


		}

		//doble click al data para que ponga los datos al otro form
		private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int iRow = e.RowIndex; //  fila
			int iCol = e.ColumnIndex; //  columna
			
			//para validar fila seleccionada
			if(iRow >= 0 && iCol > 0)
			{
				_Proveedor = new Proveedor()
				{
					IdProveedor = dgvdata.Rows[iRow].Cells["Id"].Value.ToString(),
					Documento = dgvdata.Rows[iRow].Cells["Documento"].Value.ToString(),
					RazonSocial = dgvdata.Rows[iRow].Cells["RazonSocial"].Value.ToString(),
				};
				this.DialogResult = DialogResult.OK;
				this.Close();
			}

		}

		//boton buscar 
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			/*string columnaFiltro =((OpcionCombo)cboBusqueda.SelectedItem).ToString();
			
			if(dgvdata.Rows.Count > 0 )
			{ 
				foreach (DataGridViewRow row in dgvdata.Rows)
				{
					if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
						row.Visible = true;
					else 
						row.Visible = false;

				}

			}*/

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
		//boton limpiar
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtBusqueda.Text = "";
			foreach(DataGridViewRow row in dgvdata.Rows)
			{
				row.Visible = true;
			}
		}
	}
}
