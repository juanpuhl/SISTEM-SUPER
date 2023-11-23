using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISTEM_SUPER.Modal;

namespace SISTEM_SUPER
{
	public class Compra
	{
		private CD_Compra objcd_compra = new CD_Compra();

		public UserModel oUsuario { get; set; } = new UserModel();
		public Proveedor oProveedor { get; set; } = new Proveedor();
		public string TipoDocumento { get; set; }
		public string NumeroDocumento { get; set; }
		public decimal MontoTotal { get; set; }
		public int IdCompra { get; set; }
		public string FechaRegistro { get; set; }
		public List<Detalle_Compra> oDetalleCompra { get; set; }

		public int ObtenerCorrelativo()
		{
			return objcd_compra.ObtenerCorrelativo();
		}

		public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
		{
			return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);
		}

		public List<Detalle_Compra> ObtenerDetalleCompra(int idcompra)
		{
			List<Detalle_Compra> oLista = new List<Detalle_Compra>();
			ConnectionToSql conexion = new ConnectionToSql();


			try
			{
				conexion.AbrirConexion();

				SqlCommand comando = new SqlCommand();


				StringBuilder query = new StringBuilder();
				query.AppendLine("SELECT p.Nombre,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal");
				query.AppendLine("FROM Detalle_Compra dc");
				query.AppendLine("INNER JOIN Productos p ON p.Id = dc.IdProducto");
				query.AppendLine("WHERE dc.IdCompra = @idcompra");

				comando.CommandText = query.ToString(); // Asigna el texto de la consulta al comando
				comando.Parameters.AddWithValue("@idcompra", idcompra); // Asigna el parámetro
				comando.CommandType = CommandType.Text;

				using (SqlDataReader leer = comando.ExecuteReader())
				{
					while (leer.Read())
					{
						oLista.Add(new Detalle_Compra()
						{
							Productos= new Productos() { Nombre = leer["Nombre"].ToString() },
							PrecioCompra = Convert.ToDecimal(leer["PrecioCompra"].ToString()),
							Cantidad = Convert.ToInt32(leer["Cantidad"].ToString()),
							MontoTotal = Convert.ToDecimal(leer["MontoTotal"].ToString()),
						});
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

		// ObtenerCompra
		public Compra ObtenerCompra(string numero)
		{
			Compra oCompra = objcd_compra.ObtenerCompra(numero); //recibe numero de compra
			if (oCompra.IdCompra != 0)
			{
				List<Detalle_Compra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra);
				oCompra.oDetalleCompra = oDetalleCompra;


			}
			return oCompra;

		}


	}
}