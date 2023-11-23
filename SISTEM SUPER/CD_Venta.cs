using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows.Forms;
using SISTEM_SUPER.Modal;

namespace SISTEM_SUPER
{
	public class CD_Venta
	{
		public int ObtenerCorrelativo()
		{
			int idCorrelativo = 0;
			ConnectionToSql conexion = new ConnectionToSql();
			SqlCommand comando = new SqlCommand();

			try
			{
				comando.Connection = conexion.AbrirConexion();

				comando.CommandText = ("SELECT count(*) + 1 FROM Venta");

				comando.CommandType = CommandType.Text;

				idCorrelativo = Convert.ToInt32(comando.ExecuteScalar());

			}
			catch (Exception ex)
			{
				idCorrelativo = 0;
				_ = ex; // Descartar la variable ex para evitar la advertencia CS0168
						// Manejo de errores
						//MessageBox.Show("Error al obtener el correlativo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conexion.CerrarConexion();
				comando.Dispose();
			}
			return idCorrelativo;
		}


		//control de stock - cada vez que se le de agregar a la vewnta se disminuye
		public bool RestarStock(int idproducto, int cantidad)
		{
			bool respuesta = true;
			ConnectionToSql conexion = new ConnectionToSql();
			SqlCommand cmd = new SqlCommand();

			try
			{
				cmd.Connection = conexion.AbrirConexion();
				StringBuilder query = new StringBuilder();
				query.AppendLine("UPDATE Productos SET Stock = Stock - @cantidad WHERE Id = @idproducto");
				cmd.CommandText = query.ToString();
				cmd.Parameters.AddWithValue("@cantidad", cantidad);
				cmd.Parameters.AddWithValue("@idproducto", idproducto);
				cmd.CommandType = CommandType.Text;

				// nos devuelve la cantidad de la fila afectada
				respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
			}
			catch (Exception ex)
			{
				respuesta = false;
				// Manejo de errores si es necesario
				// MessageBox.Show("Error al restar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conexion.CerrarConexion();
				cmd.Dispose();
			}
			return respuesta;
		}

		public bool SumarStock(int idproducto, int cantidad)
		{
			bool respuesta = true;
			ConnectionToSql conexion = new ConnectionToSql();
			SqlCommand cmd = new SqlCommand();

			try
			{
				cmd.Connection = conexion.AbrirConexion();
				StringBuilder query = new StringBuilder();
				query.AppendLine("UPDATE Productos SET Stock = Stock + @cantidad WHERE Id = @idproducto");
				cmd.CommandText = query.ToString();
				cmd.Parameters.AddWithValue("@cantidad", cantidad);
				cmd.Parameters.AddWithValue("@idproducto", idproducto);
				cmd.CommandType = CommandType.Text;

				// nos devuelve la cantidad de la fila afectada
				respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
			}
			catch (Exception ex)
			{
				respuesta = false;
				// Manejo de errores si es necesario
				// MessageBox.Show("Error al restar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conexion.CerrarConexion();
				cmd.Dispose();
			}
			return respuesta;
		}

		//Registrar venta
		public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
		{
			bool Repuesta = false;
			Mensaje = string.Empty;
			ConnectionToSql conexion = new ConnectionToSql();

			try
			{
				SqlCommand comando = new SqlCommand("usp_RegistrarVenta", conexion.GetConnection());
				comando.Connection = conexion.AbrirConexion();
				comando.Parameters.AddWithValue("UserID", UserLoginCache.IdUser);
				comando.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
				comando.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
				comando.Parameters.AddWithValue("Dni", obj.DocumentoCliente);
				comando.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
				comando.Parameters.AddWithValue("ApellidoCliente", obj.ApellidoCliente);
				comando.Parameters.AddWithValue("MontoPago", obj.MontoTotal);
				comando.Parameters.AddWithValue("MontoCambio", obj.MontoTotal);
				comando.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
				comando.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
				//parametros de salida
				comando.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
				comando.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
				comando.CommandType = CommandType.StoredProcedure;

				comando.ExecuteNonQuery();

				Repuesta = Convert.ToBoolean(comando.Parameters["Resultado"].Value);
				Mensaje = comando.Parameters["Mensaje"].Value.ToString();
				//idCorrelativo = Convert.ToInt32(comando.ExecuteScalar());

			}
			catch (Exception ex)
			{
				Repuesta = false;
				Mensaje = ex.Message;
			}
			finally
			{
				conexion.CerrarConexion();
			}
			return Repuesta;
		}
		/// obtener Venta
		public Venta ObtenerVenta(string numero)
		{
			Venta obj = new Venta();
			ConnectionToSql conexion = new ConnectionToSql();
			
			try
			{
				string query = "SELECT v.IdVenta, u.LoginName," +
				"v.DocumentoCliente, v.NombreCliente, v.ApellidoCliente," +
				"v.TipoDocumento, v.NumeroDocumento, v.MontoPago, v.MontoCambio, v.MontoTotal, " +
				"CONVERT(CHAR(10), v.FechaRegistro, 103) AS FechaRegistro " +
				"FROM Venta v " +
				"INNER JOIN Users u ON u.UserID = v.UserID " +
				"WHERE v.NumeroDocumento = @numero";


				using (SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion()))
				{
					comando.Parameters.AddWithValue("@numero", numero);
					comando.CommandType = CommandType.Text;

					using (SqlDataReader leer = comando.ExecuteReader())
					{
						while (leer.Read())
						{
							obj = new Venta()
							{
								IdVenta = int.Parse(leer["IdVenta"].ToString()),
								oUsuario = new UserModel() { loginName = leer["LoginName"].ToString() },
								DocumentoCliente = leer["DocumentoCliente"].ToString(),
								NombreCliente = leer["NombreCliente"].ToString(),
								ApellidoCliente = leer["ApellidoCliente"].ToString(),
								TipoDocumento = leer["TipoDocumento"].ToString(),
								NumeroDocumento = leer["NumeroDocumento"].ToString(),					
								MontoPago = Convert.ToDecimal(leer["MontoPago"].ToString()),
								MontoCambio = Convert.ToDecimal(leer["MontoCambio"].ToString()),
								MontoTotal = Convert.ToDecimal(leer["MontoTotal"].ToString()),
								FechaRegistro = leer["FechaRegistro"].ToString()

							};


						}
					}
				}
			}
			catch (Exception ex)
			{
				// Agrega un mensaje de depuración para identificar el problema.
				MessageBox.Show($"Error en la consulta SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//en caso de que haya error envia objeto vacio
				obj = new Venta();
			}
			finally
			{
				conexion.CerrarConexion();
			}

			return obj;
		}

		/// falta realizar este 
		//para la lista y obtener los detalles de la Venta
		public List<Detalle_Venta> ObtenerDetalleVenta(int idventa)
		{
			List<Detalle_Venta> oLista = new List<Detalle_Venta>();

			ConnectionToSql conexion = new ConnectionToSql();

			try
			{
				conexion.AbrirConexion();

				using (SqlCommand comando = new SqlCommand())
				{
					comando.Connection = conexion.AbrirConexion(); // Asegúrate de que tu método AbirConexion devuelva la conexión

					StringBuilder query = new StringBuilder();

					query.AppendLine("SELECT p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal FROM Detalle_Venta dv");
					query.AppendLine("INNER JOIN Productos p ON p.Id = dv.IdProducto");
					query.AppendLine("WHERE dv.IdVenta = @idventa");


					comando.CommandText = query.ToString();
					comando.Parameters.AddWithValue("@idventa", idventa);

					using (SqlDataReader leer = comando.ExecuteReader())
					{
						while (leer.Read())
						{
							Detalle_Venta detalleVenta = new Detalle_Venta()
							{
								Productos = new Productos() { Nombre = leer["Nombre"].ToString() },
								PrecioVenta = Convert.ToDecimal(leer["PrecioVenta"].ToString()),
								Cantidad = Convert.ToInt32(leer["Cantidad"].ToString()),
								SubTotal = Convert.ToDecimal(leer["SubTotal"].ToString()),
							};

							oLista.Add(detalleVenta);
						}
					}
				}
			}
			catch
			{
				oLista = new List<Detalle_Venta>();
			}
			finally
			{
				conexion.CerrarConexion();
			}

			return oLista;
		}

	}
}
