using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM_SUPER
{
	public class Proveedor
	{
		private CD_Proveedores objetoCD = new CD_Proveedores();

		public string IdProveedor { get; set; }
		public string Documento { get; set; }
		public string RazonSocial { get; set; }
		public string Correo { get; set; }
		public string Telefono { get; set; }

		public DataTable MostrarProveedores()
		{
			DataTable tabla = new DataTable();
			tabla = objetoCD.Mostrar();
			return tabla;

		}

		public List<Proveedor> MostrarProv()
		{
			DataTable tabla = objetoCD.Mostrar();
			List<Proveedor> listaProveedores = new List<Proveedor>();

			foreach (DataRow fila in tabla.Rows)
			{
				Proveedor proveedor = new Proveedor
				{
					// Asigna los valores del DataTable a un objeto Proveedor
					IdProveedor = fila["IdProveedor"].ToString(),
					Documento = fila["Documento"].ToString(),
					RazonSocial = fila["RazonSocial"].ToString(),
					Correo = fila["Correo"].ToString(),
					Telefono = fila["Telefono"].ToString()
					// Asegúrate de ajustar los nombres de las columnas según la estructura de tu DataTable
				};

				listaProveedores.Add(proveedor);
			}

			return listaProveedores;
		}


		public void InsertarProveedor(string id, string documento, string razonsocial, string correo, string telefono)
		{

			objetoCD.InsertarProveedor(Convert.ToInt32(id), documento, razonsocial, correo, telefono);


		}

		public void EditarProveedor(string id, string documento, string razonsocial, string correo, string telefono)
		{
			objetoCD.EditarProveedor(Convert.ToInt32(id), documento, razonsocial, correo, telefono);
		}

		public void EliminarProveedor(String id)
		{
			objetoCD.EliminarProveedor(Convert.ToInt32(id));
		}


	}
}
