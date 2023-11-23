using SISTEM_SUPER.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SISTEM_SUPER
{
	public class Venta
	{
		private CD_Venta objcd_venta = new CD_Venta();
		public string NumeroDocumento { get; set; }
		public decimal MontoTotal { get; set; }
		public  decimal MontoPago { get; set; }
		public decimal MontoCambio { get; set; }
		public UserModel oUsuario { get; set; } = new UserModel();
		public Proveedor oProveedor { get; set; } = new Proveedor();
		public string TipoDocumento { get; set; }
		public string DocumentoCliente { get; set; }
		public string ApellidoCliente { get; set; }
		public string NombreCliente { get; set; }
		public int IdVenta { get; set; }
		public string FechaRegistro { get; set; }

		public List<Detalle_Venta> oDetalleVenta { get; set; }

		public bool RestarStock(int idproducto, int cantidad)
		{
			return objcd_venta.RestarStock(idproducto, cantidad);
		}

		public bool SumarStock(int idproducto, int cantidad)
		{
			return objcd_venta.SumarStock(idproducto, cantidad);
		}

		public int ObtenerCorrelativo()
		{
			return objcd_venta.ObtenerCorrelativo();
		}

		public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
		{
			return objcd_venta.Registrar(obj, DetalleVenta, out Mensaje);
		}


		//obtener venta 

		public Venta ObtenerVenta(string numero)
		{
			Venta oVenta = objcd_venta.ObtenerVenta(numero); //recibe numero de compra
			if (oVenta.IdVenta != 0)
			{
				List<Detalle_Venta> oDetalleVenta = objcd_venta.ObtenerDetalleVenta(oVenta.IdVenta);
				oVenta.oDetalleVenta = oDetalleVenta;


			}
			return oVenta;

		}

		// obtener detalle venta

		public List<Detalle_Venta> ObtenerDetalleVenta(int idventa)
		{
			List<Detalle_Venta> oLista = new List<Detalle_Venta>();
			ConnectionToSql conexion = new ConnectionToSql();


			try
			{
				conexion.AbrirConexion();

				SqlCommand comando = new SqlCommand();


				StringBuilder query = new StringBuilder();

				query.AppendLine("SELECT p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal");
				query.AppendLine("FROM Detalle_Venta dv");
				query.AppendLine("INNER JOIN Productos p ON p.Id = dv.IdProducto");
				query.AppendLine("WHERE dv.IdVenta = @idventa");

				comando.CommandText = query.ToString(); // Asigna el texto de la consulta al comando
				comando.Parameters.AddWithValue("@idventa", idventa); // Asigna el parámetro
				comando.CommandType = CommandType.Text;

				using (SqlDataReader leer = comando.ExecuteReader())
				{
					while (leer.Read())
					{
						oLista.Add(new Detalle_Venta()
						{
							Productos = new Productos() { Nombre = leer["Nombre"].ToString() },
							PrecioVenta = Convert.ToDecimal(leer["PrecioVenta"].ToString()),  
							Cantidad = Convert.ToInt32(leer["Cantidad"].ToString()),
							SubTotal = Convert.ToDecimal(leer["SubTotal"].ToString()),
						});
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