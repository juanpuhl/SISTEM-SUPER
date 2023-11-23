using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace SISTEM_SUPER
{
    public class CD_Productos
    {
        private ConnectionToSql conexion = new ConnectionToSql(); // de manewra privada para encapsular la variable
        SqlDataReader leer; //para leer filas de la tabla producto
        DataTable tabla = new DataTable(); //para lamacenar las consultas
        SqlCommand comando = new SqlCommand(); //para ejecutar sql

        public DataTable Mostrar() //mostrar registros
        {
            //TRANSACT SQL
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select *from Productos"; // registros de la tabla 
            //comando.CommandText = "MostrarProductos"; con el procedimiento
            //comando.CommandType = CommandType.StoreProcedure; con el procedimiento
            leer = comando.ExecuteReader(); 
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;


            //PROCEDIMIENTO

            /*
             CREATE PROC MostrarProductos
             AS 
             SELECT *FROM Productos
             go
             */ 
            /// para crear el procedimiento en la base de datos

        }

        public void Insertar(long Codigo_Producto, string Nombre, string Descripcion,string Marca,
                                decimal Precio_Compra, decimal Precio_Venta, int Stock  )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Productos values ('"+Codigo_Producto+"','"+Nombre+"','"+Descripcion+"','"+Marca+"','"+Precio_Compra+"','"+Precio_Venta+"','"+Stock+"')";
            //comando.CommandText = "InsertarProductos";
            //comando.Commandtype = CommandType.StoredProcedure; //para el procedimiento
            //comando.Parameters.AddWithValue("@nombre") asi con cada uno
            comando.ExecuteNonQuery(); //ejecuta instruccion
            



            /*
             */
        }
        public void EditarP(int id, long Codigo_Producto, string Nombre, string Descripcion, string Marca,
                                decimal Precio_Compra, decimal Precio_Venta, int Stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id",id);
            comando.Parameters.AddWithValue("@Codigo_Producto",Codigo_Producto);
            comando.Parameters.AddWithValue("@Nombre",Nombre);
            comando.Parameters.AddWithValue("@Descripcion",Descripcion);
            comando.Parameters.AddWithValue("@Marca",Marca);
            comando.Parameters.AddWithValue("@Precio_Compra", Precio_Compra);
            comando.Parameters.AddWithValue("@Precio_Venta", Precio_Venta);
            comando.Parameters.AddWithValue("@Stock", Stock);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); // Limpia los parametros


        }
        public void EliminarProducto(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); // Limpia los parametros

        }

        // listar productos para generar el pdf
        public List<Productos> ObtenerProductosDesdeBD()
        {
            List<Productos> listaProductos = new List<Productos>();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Productos";
            leer = comando.ExecuteReader();

            while (leer.Read())
            {
                Productos producto = new Productos
                {
					Id = leer["Id"].ToString(),
					Codigo = leer["Codigo_Producto"].ToString(),
                    Nombre = leer["Nombre"].ToString(),
                    Descripcion = leer["Descripcion"].ToString(),
                    Marca = leer["Marca"].ToString(),
                    PrecioCompra = leer["Precio_Compra"].ToString(),
                    PrecioVenta = leer["Precio_Venta"].ToString(),
                    Stock = Convert.ToInt32(leer["Stock"])
                };

                listaProductos.Add(producto);
            }

            conexion.CerrarConexion();
            return listaProductos;
        }

    }
}
