using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISTEM_SUPER
{
    public class Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;

        }

		// otra manera de mostrar porductos, la uso para los modal y realizar busqueda.

		public List<Productos> MostrarProductos()
		{
			DataTable tabla = objetoCD.Mostrar();
			List<Productos> listaProductos = new List<Productos>();

			foreach (DataRow fila in tabla.Rows)
			{
                Productos productos = new Productos
                {
                    // Asigna los valores del DataTable a un objeto Proveedor
                    Id = fila["Id"].ToString(),
                    Codigo = fila["Codigo_Producto"].ToString(),
                    Nombre = fila["Nombre"].ToString(),
                    Descripcion = fila["Descripcion"].ToString(),
                    Marca = fila["Marca"].ToString(),
                    PrecioCompra = fila["Precio_Compra"].ToString(),
					PrecioVenta = fila["Precio_Venta"].ToString(),
					Stock = Convert.ToInt32(fila["Stock"].ToString())
					// Asegúrate de ajustar los nombres de las columnas según la estructura de tu DataTable
				};

				listaProductos.Add(productos);
			}

			return listaProductos;
		}
		public void InsertarProductos(string Codigo_Producto, string Nombre, string Descripcion, string Marca,
                                string Precio_Compra, string Precio_Venta, string Stock)
            {
            objetoCD.Insertar(Convert.ToInt64(Codigo_Producto), Nombre, Descripcion, Marca, Convert.ToDecimal(Precio_Compra), Convert.ToDecimal(Precio_Venta), Convert.ToInt32(Stock));
            }

        public void EditarProductos(string id, string Codigo_Producto, string Nombre, string Descripcion, string Marca,
                                string Precio_Compra, string Precio_Venta, string Stock)
        
        {
            objetoCD.EditarP(Convert.ToInt32(id), Convert.ToInt64(Codigo_Producto), Nombre, Descripcion, Marca, Convert.ToDecimal(Precio_Compra), Convert.ToDecimal(Precio_Venta), Convert.ToInt32(Stock));
        }

       public void ElimarProducto(string id)
        {
            objetoCD.EliminarProducto(Convert.ToInt32(id));
        }

        //para crear el registro pdf
        public List<Productos> ObtenerProductos()
        {
           List<Productos > listaProductos = objetoCD.ObtenerProductosDesdeBD();
            
            return listaProductos;
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string PrecioCompra { get; set; }
        public string PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string Id { get; set; }



    }
}
