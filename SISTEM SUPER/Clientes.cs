using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace SISTEM_SUPER
{
    public class Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

		public string IdCliente { get; set; }
		public string Dni { get; set; }
		public string Cuil { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Condicion_Fiscal { get; set; }
		public string Telefono { get; set; }
		public string Direccion { get; set; }
		public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

        public void InsertarCliente(string id, string dni, string cuil, string nombre, string apellido, string condicionFiscal, string telefono, string direccion, string ciudad)
        {
            
                objetoCD.InsertarCliente(Convert.ToInt32(id),dni, cuil, nombre, apellido, condicionFiscal, telefono, direccion, ciudad);         


        }

        public  void EditarCliente(string id, string dni, string cuil, string nombre, string apellido, string condicionFiscal, string telefono, string direccion, string ciudad)
        {
            objetoCD.EditarCliente(Convert.ToInt32(id), dni, cuil, nombre, apellido, condicionFiscal, telefono, direccion, ciudad);
        }

        public void EliminarCliente(String id)
        {
            objetoCD.EliminarCliente(Convert.ToInt32(id));
        }


		public List<Clientes> MostrarClie()
		{
			DataTable tabla = objetoCD.Mostrar();
			List<Clientes> listaClientes = new List<Clientes>();

			foreach (DataRow fila in tabla.Rows)
			{
				Clientes cliente = new Clientes
				{
					// Asigna los valores del DataTable a un objeto Proveedor
					IdCliente = fila["Id"].ToString(),
					Dni = fila["Dni"].ToString(),
					Cuil = fila["Cuil"].ToString(),
					Nombre = fila["Nombre"].ToString(),
					Apellido = fila["Apellido"].ToString(),
					Condicion_Fiscal = fila["Condicion_Fiscal"].ToString(),
					Telefono = fila["Telefono"].ToString(),
					Direccion = fila["Direccion"].ToString(),
					// Asegúrate de ajustar los nombres de las columnas según la estructura de tu DataTable
				};

				listaClientes.Add(cliente);
			}

			return listaClientes;
		}

	}
}
