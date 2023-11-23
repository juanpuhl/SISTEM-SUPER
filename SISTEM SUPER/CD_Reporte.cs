using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
	public class CD_Reporte
	{

		//consultas para las compras y ventas

		public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
		{
			List<ReporteCompra> lista = new List<ReporteCompra>();
			ConnectionToSql conexion = new ConnectionToSql();

			try
			{
				string query = "sp_ReporteCompras";  // Nombre del procedimiento almacenado

				using (SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion()))
				{
					comando.CommandType = CommandType.StoredProcedure;
					comando.Parameters.AddWithValue("@fechainicio", fechainicio);
					comando.Parameters.AddWithValue("@fechafin", fechafin);
					comando.Parameters.AddWithValue("@idproveedor", idproveedor);

					using (SqlDataReader leer = comando.ExecuteReader())
					{
						while (leer.Read())
						{
							lista.Add(new ReporteCompra()
							{
								FechaRegistro = leer["FechaRegistro"].ToString(),
								TipoDocumento = leer["TipoDocumento"].ToString(),
								NumeroDocumento = leer["NumeroDocumento"].ToString(),
								MontoTotal = leer["MontoTotal"].ToString(),
								UsuarioRegistro = leer["usuarioRegistro"].ToString(),
								DocumentoProveedor = leer["DocumentoProveedor"].ToString(),
								RazonSocial = leer["RazonSocial"].ToString(),
								CodigoProducto = leer["CodigoProducto"].ToString(),
								NombreProducto = leer["NombreProducto"].ToString(),
								PrecioCompra = leer["PrecioCompra"].ToString(),
								PrecioVenta = leer["PrecioVenta"].ToString(),
								Cantidad = leer["Cantidad"].ToString(),
								SubTotal = leer["SubTotal"].ToString(),
							});
						}
					}
				}
			}
			catch (Exception ex)
			{
				// Manejo de excepciones, por ejemplo, puedes registrar el error
				Console.WriteLine($"Error en CD_Reporte.Compra: {ex.Message}");
			}
			finally
			{
				conexion.CerrarConexion();
			}

			return lista;
		}



		public List<ReporteVenta> Venta(string fechainicio, string fechafin)
		{
			List<ReporteVenta> lista = new List<ReporteVenta>();
			ConnectionToSql conexion = new ConnectionToSql();

			try
			{
				string query = "sp_ReporteVentas";  // Nombre del procedimiento almacenado

				using (SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion()))
				{
					comando.CommandType = CommandType.StoredProcedure;
					comando.Parameters.AddWithValue("@fechainicio", fechainicio);
					comando.Parameters.AddWithValue("@fechafin", fechafin);

					using (SqlDataReader leer = comando.ExecuteReader())
					{
						while (leer.Read())
						{
							lista.Add(new ReporteVenta()
							{
								FechaRegistro = leer["FechaRegistro"].ToString(),
								TipoDocumento = leer["TipoDocumento"].ToString(),
								NumeroDocumento = leer["NumeroDocumento"].ToString(),
								MontoTotal = leer["MontoTotal"].ToString(),
								UsuarioRegistro = leer["usuarioRegistro"].ToString(),
								DocumentoCliente = leer["DocumentoCliente"].ToString(),
								NombreCliente = leer["NombreCliente"].ToString(),
								ApellidoCliente = leer["ApellidoCliente"].ToString(),
								CodigoProducto = leer["CodigoProducto"].ToString(),
								NombreProducto = leer["NombreProducto"].ToString(),
								PrecioVenta = leer["PrecioVenta"].ToString(),
								Cantidad = leer["Cantidad"].ToString(),
								SubTotal = leer["SubTotal"].ToString(),
							});
						}
					}
				}
			}
			catch (Exception ex)
			{
				// Manejo de excepciones, por ejemplo, puedes registrar el error
				Console.WriteLine($"Error en CD_Reporte.Venta: {ex.Message}");
				MessageBox.Show($"Error en CD_Reporte.Venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conexion.CerrarConexion();
			}

			return lista;
		}






	}

}