using SISTEM_SUPER.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace SISTEM_SUPER
{
	public class CD_Compra
	{
		public int ObtenerCorrelativo()
		{
			int idCorrelativo = 0;
			ConnectionToSql conexion = new ConnectionToSql();
			SqlCommand comando = new SqlCommand();

			try
			{
				comando.Connection = conexion.AbrirConexion();

				comando.CommandText = ("SELECT count(*) + 1 FROM Compra");

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

		public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
		{
			bool Repuesta = false;
			Mensaje = string.Empty;
			ConnectionToSql conexion = new ConnectionToSql();

			try
			{
				SqlCommand comando = new SqlCommand("sp_RegistrarCompra", conexion.GetConnection());
				comando.Connection = conexion.AbrirConexion();
				comando.Parameters.AddWithValue("UserID", UserLoginCache.IdUser);
				comando.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor);
				comando.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
				comando.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
				comando.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
				comando.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
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
		//OBTENER DATOS PARA OBTERNER COMPRA

		public Compra ObtenerCompra(string numero)
		{
			Compra obj = new Compra();
			ConnectionToSql conexion = new ConnectionToSql();

			try
			{
				string query = "SELECT c.IdCompra, u.LoginName, pr.Documento, pr.RazonSocial, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, CONVERT(CHAR(10), c.FechaRegistro, 103) AS FechaRegistro " +
					"FROM COMPRA c " +
					"INNER JOIN Users u ON u.UserID = c.UserID " +
					"INNER JOIN Proveedor pr ON pr.IdProveedor = c.IdProveedor " +
					"WHERE c.NumeroDocumento = @numero";

				using (SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion()))
				{
					comando.Parameters.AddWithValue("@numero", numero);
					comando.CommandType = CommandType.Text; 

					using (SqlDataReader leer = comando.ExecuteReader())
					{
						while (leer.Read())
						{
							obj = new Compra()
							{
								IdCompra = Convert.ToInt32(leer["IdCompra"]),
								oUsuario = new UserModel() { loginName = leer["LoginName"].ToString() },
								oProveedor = new Proveedor() { Documento = leer["Documento"].ToString(), RazonSocial = leer["RazonSocial"].ToString() },
								TipoDocumento = leer["TipoDocumento"].ToString(),
								NumeroDocumento = leer["NumeroDocumento"].ToString(),
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
				obj = new Compra();
			}
			finally
			{
				conexion.CerrarConexion();
			}
			return obj;
		}


		//para la lista y obtener los detalles de la compra
		public List<Detalle_Compra> ObtenerDetalleCompra(int idcompra)
		{
			List<Detalle_Compra> oLista = new List<Detalle_Compra>();

			ConnectionToSql conexion = new ConnectionToSql();

			try
			{
				conexion.AbrirConexion();

				using (SqlCommand comando = new SqlCommand())
				{
					comando.Connection = conexion.AbrirConexion(); // Asegúrate de que tu método AbirConexion devuelva la conexión

					StringBuilder query = new StringBuilder();
					query.AppendLine("SELECT p.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal FROM Detalle_Compra dc");
					query.AppendLine("INNER JOIN Productos p ON p.Id = dc.IdProducto");
					query.AppendLine("WHERE dc.IdCompra = @idcompra");

					comando.CommandText = query.ToString();
					comando.Parameters.AddWithValue("@idcompra", idcompra);

					using (SqlDataReader leer = comando.ExecuteReader())
					{
						while (leer.Read())
						{
							Detalle_Compra detalleCompra = new Detalle_Compra()
							{
								Productos = new Productos() { Nombre = leer["Nombre"].ToString() },
								PrecioCompra = Convert.ToDecimal(leer["PrecioCompra"].ToString()),
								Cantidad = Convert.ToInt32(leer["Cantidad"].ToString()),
								MontoTotal = Convert.ToDecimal(leer["MontoTotal"].ToString()),
							};

							oLista.Add(detalleCompra);
						}
					}
				}
			}
			catch
			{
				oLista = new List<Detalle_Compra>();
			}
			finally
			{
				conexion.CerrarConexion();
			}

			return oLista;
		}



	}
}

