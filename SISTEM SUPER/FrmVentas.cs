using SISTEM_SUPER.Modal;
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
	public partial class FrmVentas : Form
	{

		//pasamos quien es el usuario actual
		UserDao userDao = new UserDao();
		string usuarioActual = UserLoginCache.loginName;
		public FrmVentas()
		{
			InitializeComponent();
			CargarTipoDoc();

		}

		private void CargarTipoDoc()
		{
			cmbTipoDoc.Items.Add("Fac A");
			cmbTipoDoc.Items.Add("Fac B");
			cmbTipoDoc.Items.Add("Fac C");
			cmbTipoDoc.Items.Add("Recibo");
			cmbTipoDoc.Items.Add("Boleta");
			cmbTipoDoc.SelectedIndex = 0;

		}

		private void FrmVentas_Load(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear(); //el dataGrid deberia iniciar limpio
			dataGridView1.AllowUserToAddRows = false; //evita la aparición de una fila adicional al final de las filas visibles del DataGridView.

			txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
			txtIdProducto.Text = "0";
			txtPagaCon.Text = "";
			txtCambio.Text = "";
			txtTotalPagar.Text = "0";

		}

		private void btnBuscarVenta_Click(object sender, EventArgs e)
		{
			using (var modal = new mdCliente())
			{
				var result = modal.ShowDialog();
				if (result == DialogResult.OK)
				{
					txtDocCliente.Text = modal._Cliente.Dni;
					txtNombreCliente.Text = modal._Cliente.Nombre;
					txtApellidoCliente.Text = modal._Cliente.Apellido;
					txtCondicionFiscal.Text = modal._Cliente.Condicion_Fiscal;
					txtCodProducto.Select(); //seleciona el txtCod Producto

				}
				else
				{
					txtDocCliente.Select();
				}
			}
		}

		private void btnBuscarProducto_Click(object sender, EventArgs e)
		{
			using (var modal = new mdProductos())
			{
				var result = modal.ShowDialog();
				if (result == DialogResult.OK)
				{
					txtCodProducto.Text = modal._producto.Codigo.ToString();
					txtIdProducto.Text = modal._producto.Id.ToString();
					txtNomProducto.Text = modal._producto.Nombre;
					txtPrecioProducto.Text = modal._producto.PrecioVenta.ToString();
					txtStock.Text = modal._producto.Stock.ToString();
					txtCantidad.Select();    // selecciona este txtbox
											 //txtPrecioCompra.Text = modal._producto.PrecioCompra;
											 //txtPrecioVenta.Text = modal._producto.PrecioVenta;
											 //txtStock.Text = modal._producto.Stock.ToString(); no tengo esto aun

				}
				else
				{
					txtCodProducto.Select(); //selecciona este txt
				}
			}

		}

		private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				CD_Productos oProducto = new CD_Productos();
				List<Productos> listaDeProductos = oProducto.ObtenerProductosDesdeBD();

				// Realizar la búsqueda en la lista de productos utilizando LINQ
				Productos productoEncontrado = listaDeProductos.FirstOrDefault(p => p.Codigo == txtCodProducto.Text);

				// Verifica si se encontró un producto con el código ingresado
				if (productoEncontrado != null)
				{

					// Realiza las acciones correspondientes con el producto encontrado
					txtCodProducto.BackColor = Color.LightBlue;
					txtIdProducto.Text = productoEncontrado.Id.ToString();
					txtNomProducto.Text = productoEncontrado.Nombre;
					txtCantidad.Select(); //selecciona el txt cantidad
				}
				else
				{
					txtCodProducto.BackColor = Color.Honeydew;
					txtIdProducto.Text = "0";
					txtNomProducto.Text = "";

				}

			}
		}

		private void btnAgregarProducto_Click(object sender, EventArgs e)
		{
			decimal precioVenta = 0;
			bool producto_existe = false;

			//para validar que selecciono un producto
			if (int.Parse(txtIdProducto.Text) == 0)
			{
				MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			//validar el formato de la moneda precio producto
			if (!decimal.TryParse(txtPrecioProducto.Text, out precioVenta))
			{
				MessageBox.Show("Precio: Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPrecioProducto.Select();
				return;
			}
			//validar cantidad de stock
			if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtCantidad.Value.ToString()))
			{
				MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPrecioProducto.Select();
				return;
			}
			//validar si existe el producto dentro del dataGrid
			foreach (DataGridViewRow fila in dataGridView1.Rows)
			{

				//verifica que Id, txtprofucto, no sean null
				if (fila.Cells["Id"].Value != null && txtIdProducto != null && fila.Cells["Id"].Value.ToString() == txtIdProducto.Text)
				//if (fila.Cells["Id"].Value.ToString() == txtIdProducto.Text)
				{
					producto_existe = true;
					break;
				}
			}
			if (!producto_existe)
			{
				bool respuesta = new Venta().RestarStock(
				Convert.ToInt32(txtIdProducto.Text),
				Convert.ToInt32(txtCantidad.Value.ToString())
				);
				if (respuesta)
				{
					dataGridView1.Rows.Add(new object[]
				{
					txtIdProducto.Text,
					txtNomProducto.Text,
					precioVenta.ToString("0.00"),
					//precioVenta.ToString("0.00"),
					txtCantidad.Value.ToString(),
					(txtCantidad.Value * precioVenta).ToString("0.00")

				});
				}


				limpiarProducto(); // limpia
				CalcularTotal(); // funcion para calcular el total

				txtCodProducto.Select();

			}

		}
		//para limpiar luego de agregar los datos al data
		private void limpiarProducto()
		{
			txtIdProducto.Text = "0";
			txtCodProducto.Text = "";
			txtCodProducto.BackColor = Color.White;
			txtNomProducto.Text = "";
			txtPrecioProducto.Text = "";
			txtStock.Text = "";
			txtCantidad.Value = 1;
		}

		// calcular el total de lo que esta en el data
		private void CalcularTotal()
		{
			decimal total = 0;
			if (dataGridView1.Rows.Count > 0) //valida que haya registro
			{
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if (row.Cells["SubTotal"].Value != null)
					{
						total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
					}


				}
			}
			txtTotalPagar.Text = total.ToString("0.00");
		}

		private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			if (e.ColumnIndex == 5)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);

				var w = Properties.Resources.deleteremove.Width;
				var h = Properties.Resources.deleteremove.Height;
				var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
				var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

				e.Graphics.DrawImage(Properties.Resources.deleteremove, new Rectangle(x, y, w, h));
				e.Handled = true;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView1.Columns[e.ColumnIndex].Name == "btneliminar")
			{
				int indice = e.RowIndex;

				if (indice >= 0)
				{
					bool respuesta = new Venta().SumarStock(
						Convert.ToInt32(dataGridView1.Rows[indice].Cells["Id"].Value.ToString()),
						Convert.ToInt32(dataGridView1.Rows[indice].Cells["Cantidad"].Value.ToString())
						);
					if (respuesta)
					{
						dataGridView1.Rows.RemoveAt(indice);
						CalcularTotal();
					}

				}

			}
		}

		private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
		{
			// si es un digito, no se activa
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;

			}
			else
			{   //si esta vacio no debe iniciar con un punto
				if (txtPrecioProducto.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
				{
					e.Handled = true;
				}
				else
				{  //si hay text puede usar borrar y poner punto
					if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
					{
						e.Handled = false;
					}
					else
					{
						e.Handled = true;
					}

				}
			}
		}

		private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
		{// si es un digito, no se activa
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;

			}
			else
			{   //si esta vacio no debe iniciar con un punto
				if (txtPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
				{
					e.Handled = true;
				}
				else
				{  //si hay text puede usar borrar y poner punto
					if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
					{
						e.Handled = false;
					}
					else
					{
						e.Handled = true;
					}

				}
			}

		}


		private void calcularCambio()
		{
			if (txtTotalPagar.Text.Trim() == "")
			{
				MessageBox.Show("No existen productos cargados en venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			decimal pagaCon;
			decimal total = Convert.ToDecimal(txtTotalPagar.Text);

			if (txtPagaCon.Text.Trim() == "")
			{
				txtPagaCon.Text = "0";
			}
			if (decimal.TryParse(txtPagaCon.Text.Trim(), out pagaCon))
			{
				if (pagaCon < total)
				{
					txtCambio.Text = "0.00";
				}
				else
				{
					decimal cambio = pagaCon - total;
					txtCambio.Text = cambio.ToString("0.00");
					txtCambio.ForeColor = System.Drawing.Color.White;
					txtCambio.BackColor = Color.DarkBlue;
				}
			}
		}




		private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				calcularCambio();
			}
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if (txtDocCliente.Text == "")
			{
				MessageBox.Show("Debe ingresar documento del Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (txtNombreCliente.Text == "")
			{
				MessageBox.Show("Debe ingresar Nombre del Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (txtApellidoCliente.Text == "")
			{
				MessageBox.Show("Debe ingresar Apellido del Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (dataGridView1.Rows.Count < 1)
			{
				MessageBox.Show("Debe ingresar productos a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			DataTable detalle_venta = new DataTable();
			detalle_venta.Columns.Add("IdProducto", typeof(int));
			detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
			detalle_venta.Columns.Add("Cantidad", typeof(int));
			detalle_venta.Columns.Add("SubTotal", typeof(decimal));

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				detalle_venta.Rows.Add(new object[] {
			row.Cells["Id"].Value,
			row.Cells["PrecioVenta"].Value,
			row.Cells["Cantidad"].Value,
			row.Cells["SubTotal"].Value
				});
			}

			//para obtener el numero correlativo
			int idcorrelativo = new Venta().ObtenerCorrelativo();
			string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

			//si el usuario no le da el enter con el cambio, para que se actulice.
			calcularCambio();

			//encabezados
			Venta oVenta = new Venta()
			{
				oUsuario = new UserModel() { idUser = UserLoginCache.IdUser },
				TipoDocumento = cmbTipoDoc.SelectedItem.ToString(),
				NumeroDocumento = numeroDocumento,
				DocumentoCliente = txtDocCliente.Text,
				NombreCliente = txtNombreCliente.Text,
				ApellidoCliente = txtApellidoCliente.Text,
				MontoPago = Convert.ToDecimal(txtPagaCon.Text),
				MontoCambio = Convert.ToDecimal(txtCambio.Text),
				MontoTotal = Convert.ToDecimal(txtTotalPagar.Text),
			};

			string mensaje = string.Empty;
			bool respuesta = new Venta().Registrar(oVenta, detalle_venta, out mensaje);
			//si la respuesta es correcta
			if (respuesta)
			{
				var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar?",
					"Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				// copia al portapapel
				if (result == DialogResult.Yes)
					Clipboard.SetText(numeroDocumento);
				txtDocCliente.Text = "0";
				txtNombreCliente.Text = "0";
				txtApellidoCliente.Text = "0";
				dataGridView1.Rows.Clear();
				CalcularTotal();
				txtPagaCon.Text = "0";
				txtCambio.Text = "0";
			}
			else
			{
				MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void label17_Click(object sender, EventArgs e)
		{

			this.Close();
		}
	}
}




	