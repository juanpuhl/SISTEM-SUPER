using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;
using System.IO; // para los archivos en memoria 
using System.Drawing.Imaging; //Clase imagen
using System.Windows.Forms;

namespace SISTEM_SUPER
{
    public  class CD_Empleados
    {


        private ConnectionToSql conexion = new ConnectionToSql(); // de manera privada para encapsular la variable
        SqlDataReader leer; //para leer filas de la tabla Empleados
        DataTable tabla = new DataTable(); //para lamacenar las consultas
        SqlCommand comando = new SqlCommand(); //para ejecutar sql

        public DataTable MostrarEmpleados() //mostrar registros
        {

            //procedimiento
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEmpleados"; // MostrarEmpleados es un procedimiento / registros de la tabla
            comando.CommandType = CommandType.StoredProcedure; //indica que es tipo procedimiento
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarEmpleado(int id, int legajo, string dni, string cuil, string nombre, string apellido, string correo, string telefono, string cargo,string direccion, string genero, string estadoCivil, int hijos, byte[] imagen)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            //comando.CommandText = "insert into Empleados VALUES (' " + legajo + " ' , ' " + dni + " ' , ' " + cuil + " ' , ' " + nombre + " ' , ' " + apellido + " ' , ' " + correo + " '  , ' " + telefono + "','" + cargo + " ','" + direccion + "','" + genero + "','"+estadoCivil + "',' " + hijos + " ' , ' "+imagen+ " ')";
            comando.CommandText = "INSERT INTO Empleados (Legajo, Dni, Cuil, Nombre, Apellido, Correo, Telefono, Cargo, Direccion, Genero, EstadoCivil, Hijos, FotoImagen) " +
                          "VALUES (@Legajo, @Dni, @Cuil, @Nombre, @Apellido, @Correo, @Telefono, @Cargo, @Direccion, @Genero, @EstadoCivil, @Hijos, @FotoImagen)";
            comando.Parameters.AddWithValue("@Legajo", legajo);
            comando.Parameters.AddWithValue("@Dni", dni);
            comando.Parameters.AddWithValue("@Cuil", cuil);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Cargo", cargo);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Genero", genero);
            comando.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
            comando.Parameters.AddWithValue("@Hijos", hijos);
            comando.Parameters.AddWithValue("@FotoImagen", imagen);

            comando.CommandType = CommandType.Text; //aca volvemos asignar que es tipo text para ejecutar sql
            comando.ExecuteNonQuery(); // ejecutar
            comando.Parameters.Clear(); // Limpia los parametros

        }

        public void EditarEmpleados(int id, int legajo, string dni, string cuil, string nombre, string apellido, string correo, string telefono, string cargo, string direccion, string genero, string estadoCivil, int hijos,  byte [] imagen)
        { //aca EditarEmpleados
          SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@legajo", legajo);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@cuil", cuil);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@estadocivil", estadoCivil);
            comando.Parameters.AddWithValue("@hijos", hijos);
            comando.Parameters.AddWithValue("@fotoimagen", imagen);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); // Limpia los parametros

           
        }

       
        public void EliminarEmpleado(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmp", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        // no uso este al final
       /*   public byte [] ObtenerImagenEmpleado(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT FotoImagen FROM Empleados WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            try
            {
                return (byte[])comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Manejar excepción
                Console.WriteLine(ex.Message);
                return null;
            }
        }*/


       

    }
}
