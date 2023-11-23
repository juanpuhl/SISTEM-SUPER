using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM_SUPER
{
	public class CD_AdministrarUsuarios
	{

		private ConnectionToSql conexion = new ConnectionToSql(); // de manewra privada para encapsular la variable
		SqlDataReader leer; //para leer filas de la tabla producto
		DataTable tabla = new DataTable(); //para lamacenar las consultas
		SqlCommand comando = new SqlCommand(); //para ejecutar sql

		public DataTable Mostrar() //mostrar registros
		{
			//TRANSACT SQL

			comando.Connection = conexion.AbrirConexion();
			comando.CommandText = "Select *from Users"; // registros de la tabla 
															//comando.CommandText = "MostrarProductos"; con el procedimiento
															//comando.CommandType = CommandType.StoreProcedure; con el procedimiento
			leer = comando.ExecuteReader();
			tabla.Load(leer);
			conexion.CerrarConexion();
			return tabla;

		}

		public void Insertar(string  LoginName, string Password, string FirstName, string LastName,
							 string position, string  email)
		{
			comando.Connection = conexion.AbrirConexion();
			comando.CommandText = "insert into Users values ('" + LoginName + "','" + Password + "','" + FirstName + "','" + LastName + "','" + position + "','" + email + "')";
			
			comando.ExecuteNonQuery(); //ejecuta instruccion

		}

		public void EditarUsers(int id, string LoginName, string Password, string FirstName, string LastName,
							 string position, string email)
		{
			comando.Connection = conexion.AbrirConexion();
			comando.CommandText = "EditarUsers";
			comando.CommandType = CommandType.StoredProcedure;
			comando.Parameters.AddWithValue("@userid", id);
			comando.Parameters.AddWithValue("@LoginName", LoginName);
			comando.Parameters.AddWithValue("@Password", Password);
			comando.Parameters.AddWithValue("@FirstName", FirstName);
			comando.Parameters.AddWithValue("@LastName", LastName);
			comando.Parameters.AddWithValue("@Position", position);
			comando.Parameters.AddWithValue("@Email", email);
			comando.ExecuteNonQuery();
			comando.Parameters.Clear(); // Limpia los parametros


		}

		public void EliminarUsers(int id)
		{
			comando.Connection = conexion.AbrirConexion();
			comando.CommandText = "EliminarUsers";
			comando.CommandType = CommandType.StoredProcedure;

			comando.Parameters.AddWithValue("@userid", id);

			comando.ExecuteNonQuery();
			comando.Parameters.Clear(); // Limpia los parametros

		}




	}
}
