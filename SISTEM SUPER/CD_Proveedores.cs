using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM_SUPER
{
	public  class CD_Proveedores
	{

		private ConnectionToSql conexion = new ConnectionToSql(); // de manewra privada para encapsular la variable
		SqlDataReader leer; //para leer filas de la tabla PROVEEDORES
		DataTable tabla = new DataTable(); //para almacenar las consultas
		SqlCommand comando = new SqlCommand(); //para ejecutar sql

		public DataTable Mostrar() //mostrar registros
		{

			//procedimiento
			comando.Connection = conexion.AbrirConexion();
			comando.CommandText = "MostrarProveedores"; // MostrarProveedores es un procedimiento / registros de la tabla
			comando.CommandType = CommandType.StoredProcedure; //indica que es tipo procedimiento
			leer = comando.ExecuteReader();
			tabla.Load(leer);
			conexion.CerrarConexion();
			return tabla;
		}

		public void InsertarProveedor(int id, string documento, string razonsocial, string correo, string telefono)
		{
			SqlCommand comando = new SqlCommand();
			comando.Connection = conexion.AbrirConexion();
			comando.CommandText = "INSERT INTO Proveedor (Documento, RazonSocial, Correo, Telefono, FechaRegistro) " +
			"VALUES ('" + documento + "', '" + razonsocial + "', '" + correo + "', '" + telefono + "', GETDATE())";
			comando.CommandType = CommandType.Text; //aca volvemos asignar que es tipo text para ejecutar sql
			comando.ExecuteNonQuery(); // ejecutar
			comando.Parameters.Clear(); // Limpia los parametros

		}

		public void EditarProveedor(int id, string documento, string razonsocial, string correo, string telefono)
		{ //aca con procedimiento EditarProveedor
			SqlCommand comando = new SqlCommand();
			comando.Connection = conexion.AbrirConexion();
			comando.CommandText = "EditarProveedor";
			comando.CommandType = CommandType.StoredProcedure;
			comando.Parameters.AddWithValue("@Documento", documento);
			comando.Parameters.AddWithValue("@RazonSocial", razonsocial);
			comando.Parameters.AddWithValue("@Correo", correo);
			comando.Parameters.AddWithValue("@telefono", telefono);
			comando.Parameters.AddWithValue("@IdProveedor", id);
			comando.ExecuteNonQuery();
			comando.Parameters.Clear(); // Limpia los parametros


		}

		public void EliminarProveedor(int id)
		{
			comando.Connection = conexion.AbrirConexion();
			comando.CommandText = "EliminarProveedor";
			comando.CommandType = CommandType.StoredProcedure;
			comando.Parameters.AddWithValue("@IdProveedor", id);
			comando.ExecuteNonQuery();
			comando.Parameters.Clear();

		}
	}
}
