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
	public partial class FrmProveedores : Form
	{

		Proveedor objetoProveedor = new Proveedor();
		private string IdProveedor = null; // para que no ocupe lugar en memoria
		private bool EditProveedor = false;

		public FrmProveedores()
		{
			InitializeComponent();
		}
		private void FrmProveedores_Load(object sender, EventArgs e)
		{
			MostrarProveedores();
		}

		private void MostrarProveedores()
		{
			Proveedor objetoP = new Proveedor();
			dataGridView1.DataSource = objetoP.MostrarProveedores();
		}
		private void LimpiarForm()
		{
			txtDocumento.Clear();
			txtRazonSocial.Clear();
			txtCorreo.Clear();
			txtTel.Clear();
		}
		private void btnGuardarCambioProveedor_Click(object sender, EventArgs e)
		{
			//INSERTAR	PROVEEDOR
			if (EditProveedor == false)
			{
				try
				{
					objetoProveedor.InsertarProveedor(IdProveedor, txtDocumento.Text, txtRazonSocial.Text, txtCorreo.Text, txtTel.Text);
					MessageBox.Show("Se INSERTO correctamente PROVEEDOR");
					MostrarProveedores();
					LimpiarForm();

				}
				catch (Exception ex)
				{
					MessageBox.Show("No se pudo INSERTAR PROVEEDOR por: " + ex.Message);

				}
			}

			//EDITAR proveedor
			if (EditProveedor == true)
			{
				try
				{
					objetoProveedor.EditarProveedor(IdProveedor, txtDocumento.Text, txtRazonSocial.Text, txtCorreo.Text, txtTel.Text);
					MessageBox.Show("Se EDITO correctamente PROVEEDOR");
					MostrarProveedores();
					LimpiarForm();
					EditProveedor = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show("No se pudo EDITAR  PROVEEDOR por: " + ex.Message);
				}

			}
		}

		private void btnEditarProveedor_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				EditProveedor = true;
				txtDocumento.Text = dataGridView1.CurrentRow.Cells["Documento"].Value.ToString();
				txtRazonSocial.Text = dataGridView1.CurrentRow.Cells["RazonSocial"].Value.ToString();
				txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();	
				txtTel.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
				IdProveedor = dataGridView1.CurrentRow.Cells["IdProveedor"].Value.ToString();
			}
			else
				MessageBox.Show("Seleccione la fila a editar");
		}

		private void btnBorrarProveedor_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este Proveedor?", "Confirmar Eliminación", MessageBoxButtons.OKCancel);
				if (resultado == DialogResult.OK)
				{
					IdProveedor = dataGridView1.CurrentRow.Cells["IdProveedor"].Value.ToString();
					objetoProveedor.EliminarProveedor(IdProveedor);
					MessageBox.Show("Proveedor ELIMINADO correctamente");
					MostrarProveedores();
				}


			}
			else
				MessageBox.Show("Seleccione la fila para ELIMINAR");
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
