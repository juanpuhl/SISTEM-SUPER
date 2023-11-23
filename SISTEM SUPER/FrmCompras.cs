using Microsoft.Extensions.Options;
using Patagames.Pdf;
using SISTEM_SUPER;
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
    public partial class FrmCompras : Form
    {
		//pasamos quien es el usuario actual
		UserDao userDao = new UserDao();
		string usuarioActual = UserLoginCache.loginName;

		public FrmCompras()
        {
			InitializeComponent();
			CargarTipoDoc();

			
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		// carga los tipos de Facturas...
		private void CargarTipoDoc()
		{
			cmbTipoDoc.Items.Add("Fac A");
			cmbTipoDoc.Items.Add("Fac B");
			cmbTipoDoc.Items.Add("Fac C");
			cmbTipoDoc.Items.Add("Recibo");
			cmbTipoDoc.Items.Add("Boleta");
			cmbTipoDoc.SelectedIndex = 0;

		}
		private void FrmCompras_Load(object sender, EventArgs e)
		{
			
			dataGridView1.Rows.Clear(); //el dataGrid deberia iniciar limpio
			dataGridView1.AllowUserToAddRows = false; //evita la aparición de una fila adicional al final de las filas visibles del DataGridView.
			txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

			txtIdProducto.Text = "0";
			txtIdProveedor.Text = "0";


		}

		private void btnBuscarProve_Click(object sender, EventArgs e)
		{
			using (var modal = new mdProveedor())
			{
				var result = modal.ShowDialog();
				if (result == DialogResult.OK)
				{
					txtIdProveedor.Text = modal._Proveedor.IdProveedor;
					txtDocProveedor.Text = modal._Proveedor.Documento;
					txtNombreProveedor.Text = modal._Proveedor.RazonSocial;

				}
				else
				{
					txtDocProveedor.Select();
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
					txtPrecioCompra.Select(); // selecciona este txtbox
					

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
					txtPrecioCompra.Select(); //selecciona el txt precio de compra
				}
				else
				{
					txtCodProducto.BackColor = Color.MistyRose;
					txtIdProducto.Text = "0";
					txtNomProducto.Text = "";
					
				}

			}
		}

		private void btnAgregarProducto_Click(object sender, EventArgs e)
		{
			decimal precioCompra = 0;
			decimal precioVenta = 0;
			bool producto_existe = false;

			//para validar que selecciono un producto
			if (int.Parse (txtIdProducto.Text) == 0)
			{
				MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			//validar el formato de la moneda precio compra
			if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
			{
				MessageBox.Show("Precio Compra: Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPrecioCompra.Select();
				return;
			}
			//validar el formato de la moneda precio venta
			if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
			{
				MessageBox.Show("Precio Venta: Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPrecioVenta.Select();
				return;
			}
			//validar si existe el producto dentro del dataGrid
			foreach(DataGridViewRow fila in  dataGridView1.Rows)
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
				dataGridView1.Rows.Add(new object[]
				{
					txtIdProducto.Text,
					txtNomProducto.Text,
					precioCompra.ToString("0.00"),
					precioVenta.ToString("0.00"),
					txtCantidad.Value.ToString(),
					(txtCantidad.Value * precioCompra).ToString("0.00")

				});

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
			txtPrecioCompra.Text = "";
			txtPrecioVenta.Text = "";
			txtCantidad.Value = 1;
		}

		// calcular el total de lo que esta en el data
		private void CalcularTotal()
		{
			decimal total = 0;
			if(dataGridView1.Rows.Count > 0) //valida que haya registro
			{
				foreach(DataGridViewRow row in dataGridView1.Rows)
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
			if (e.ColumnIndex == 6)
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
					dataGridView1.Rows.RemoveAt(indice);
					CalcularTotal();
				}

			}
		}

		// validar los datos del txt precio compra y luego txt precio venta
		private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
		{
			// si es un digito, no se activa
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;

			}
			else
			{   //si esta vacio no debe iniciar con un punto
				if(txtPrecioCompra.Text.Trim().Length == 0  && e.KeyChar.ToString() == ".")
				{
					e.Handled = true;
				}
				else  
				{  //si hay text puede usar borrar y poner punto
					if(Char.IsControl(e.KeyChar)  || e.KeyChar.ToString() == ".")
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

		private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
		{
			// si es un digito, no se activa
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;

			}
			else
			{   //si esta vacio no debe iniciar con un punto
				if (txtPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(txtIdProveedor.Text) ==0 )
			{
				MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (dataGridView1.Rows.Count  < 1 )
			{
				MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			DataTable detalle_compra = new DataTable();
			detalle_compra.Columns.Add("Id", typeof(int));
			detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
			detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
			detalle_compra.Columns.Add("Cantidad", typeof(string));
			detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				detalle_compra.Rows.Add(
					new object[]
					{
						Convert.ToInt32(row.Cells["Id"].Value.ToString()),
						row.Cells["PrecioCompra"].Value.ToString(),
						row.Cells["PrecioVenta"].Value.ToString(),
						row.Cells["Cantidad"].Value.ToString(),
						row.Cells["SubTotal"].Value.ToString()

					});
			}
			int idcorrelativo = new Compra().ObtenerCorrelativo();
			string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

			Compra oCompra = new Compra()
			{
				oUsuario = new UserModel() { idUser = UserLoginCache.IdUser },
				oProveedor = new Proveedor() { IdProveedor = txtIdProveedor.Text},
				TipoDocumento = cmbTipoDoc.SelectedItem.ToString(),
				NumeroDocumento  = numeroDocumento,
				MontoTotal = Convert.ToDecimal(txtTotalPagar.Text)
			};

			string mensaje = string.Empty;
			bool respuesta = new Compra().Registrar(oCompra, detalle_compra, out mensaje);

			if (respuesta)
			{
				var result = MessageBox.Show("Numero de compra generada:\n" + numeroDocumento + "\n\n¿Desea copiar?",
					"Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (result == DialogResult.Yes)
					Clipboard.SetText(numeroDocumento);
				txtIdProveedor.Text = "0";
				txtNombreProveedor.Text = "";
				dataGridView1.Rows.Clear();
				CalcularTotal();
			}
			else
			{
				MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}
	}
}


/*
para el Color.
    HoneyDew: Miel de rocío
    Cyan: Cian
    LightBlue: Azul claro
    Azure: Azul celeste
    Lavender: Lavanda
    Aquamarine: Aguamarina
    LightGreen: Verde claro
    LightYellow: Amarillo claro
    LightCoral: Coral claro
    LightPink: Rosa claro
    LightGray: Gris claro
    DarkBlue: Azul oscuro
    DarkGreen: Verde oscuro
    DarkRed: Rojo oscuro
    DarkOrange: Naranja oscuro
    DarkViolet: Violeta oscuro
	HoneyDew :Miel de rocío
	MistyRose:Rosa brumosa
*/