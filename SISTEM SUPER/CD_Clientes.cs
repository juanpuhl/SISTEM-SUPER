using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SISTEM_SUPER
{
    public class CD_Clientes
    {
        private ConnectionToSql conexion = new ConnectionToSql(); // de manewra privada para encapsular la variable
        SqlDataReader leer; //para leer filas de la tabla Cliente
        DataTable tabla = new DataTable(); //para lamacenar las consultas
        SqlCommand comando = new SqlCommand(); //para ejecutar sql

        public DataTable Mostrar() //mostrar registros
        {

            //procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes"; // MostrarClientes es un procedimiento / registros de la tabla
            comando.CommandType = CommandType.StoredProcedure; //indica que es tipo procedimiento
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarCliente(int id, string dni, string cuil, string nombre, string apellido, string condicionFiscal, string telefono, string direccion, string ciudad)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Clientes VALUES ('" + dni + "','" + cuil + "','" + nombre + "','" + apellido + "','" + condicionFiscal + "','" + telefono + "','" + direccion + "','" + ciudad + "')";
            comando.CommandType = CommandType.Text; //aca volvemos asignar que es tipo text para ejecutar sql
            comando.ExecuteNonQuery(); // ejecutar
            comando.Parameters.Clear(); // Limpia los parametros

        }

        public void EditarCliente(int id, string dni, string cuil, string nombre, string apellido, string condicionFiscal, string telefono, string direccion, string ciudad)
        { //aca con procedimiento EditarCliente
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@cuil", cuil);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@condicionFiscal", condicionFiscal);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); // Limpia los parametros


        }

        public void EliminarCliente(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idcliente",id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

    }
}

