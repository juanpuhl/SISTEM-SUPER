using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
	public class CD_Negocio
	{
		private ConnectionToSql conexion = new ConnectionToSql();
		private SqlCommand comando = new SqlCommand();

		public Negocio DatosNegocio()
		{
			Negocio obj = new Negocio();
			try
			{
				using (SqlConnection conn = conexion.AbrirConexion())
				{
					string query = "Select IdNegocio, Nombre, Cuit, Direccion, Telefono from DatosNegocio where IdNegocio = 1";

					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								obj.IdNegocio = Convert.ToInt32(reader["IdNegocio"]);
								obj.Nombre = reader["Nombre"].ToString();
								obj.Cuit = reader["Cuit"].ToString();
								obj.Direccion = reader["Direccion"].ToString();
								obj.Telefono = reader["Telefono"].ToString();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return obj;
		}

		public bool GuardarDatos(Negocio objeto, out string mensaje)
		{
			mensaje = string.Empty;
			bool respuesta = true;
			try
			{
				using (SqlConnection conn = conexion.AbrirConexion())
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "update DatosNegocio set Nombre = @nombre, Cuit = @cuit, Direccion = @direccion, Telefono = @telefono where IdNegocio = 1;";
					cmd.Parameters.AddWithValue("@nombre", objeto.Nombre);
					cmd.Parameters.AddWithValue("@cuit", objeto.Cuit);
					cmd.Parameters.AddWithValue("@direccion", objeto.Direccion);
					cmd.Parameters.AddWithValue("@telefono", objeto.Telefono);

					cmd.CommandType = CommandType.Text;
					if (cmd.ExecuteNonQuery() < 1)
					{
						mensaje = "No se guardaron los datos";
						respuesta = false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return respuesta;
		}

		public byte[] Logo(out bool obtenido)
		{
			obtenido = true;
			byte[] LogoBytes = new byte[0];
			try
			{
				using (SqlConnection conn = conexion.AbrirConexion())
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "Select Logo from DatosNegocio where IdNegocio = 1";
					cmd.CommandType = CommandType.Text;

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							LogoBytes = (byte[])reader["Logo"];
						}
					}
				}
			}
			catch (Exception ex)
			{
				obtenido = false;
				LogoBytes = new byte[0];
				MessageBox.Show($"Error en Logo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return LogoBytes;
		}

		public bool ActualizarLogo(byte[] image, out string mensaje)
		{
			mensaje = string.Empty;
			bool respuesta = true;
			try
			{
				using (SqlConnection conn = conexion.AbrirConexion())
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "update DatosNegocio set Logo = @imagen where IdNegocio = 1;";
					cmd.Parameters.AddWithValue("@imagen", image);
					cmd.CommandType = CommandType.Text;

					if (cmd.ExecuteNonQuery() < 1)
					{
						mensaje = "No se pudo actualizar el logo";
						respuesta = false;
					}
					else
					{
						mensaje = "Se actualizó el logo correctamente";
						// Muestra un MessageBox indicando que la imagen se actualizó correctamente
						MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return respuesta;
		}
	}

}





