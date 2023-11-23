using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace SISTEM_SUPER
{
    public class UserDao : ConnectionToSql
    {

        public void EditarPerfil(int id, string userName, string password, string nombre, string apellido, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Users set LoginName=@userName, Password=@pass, FirstName=@name, LastName=@LastName, Email=@mail where UserID=@id";
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", nombre);
                    command.Parameters.AddWithValue("@LastName", apellido);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery(); //ejecutamos el comando


                }
            }
        }

        public bool Login(string user, string pass)
        {
            // metodo using se desacha cuando finaliza
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    // command.CommandText = "select *from Users where"; // esta es una forma
                    command.CommandText = "select *from Users where LoginName=@user and Password=@pass"; // otra forma de validad los datos 
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@id", UserLoginCache.IdUser); //esto para mas adelante se puede usar para editar datos del usuario
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    //para saber si la consulta fue exitosa
                    if (reader.HasRows)
                    {
                        while (reader.Read()) //mientras el lector lee fila agregamos los campos a la clase estqatica
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.loginName = reader.GetString(1);
                            UserLoginCache.Password = reader.GetString(2);
                            UserLoginCache.FirsName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                            //estos valores permanecen en memoria pasar usarlos en cualquier momento
                        }
                        return true;
                    }
                    else
                        return false;

                }
            }
        }
        //codigo pendiente ......
        public void AnyMetHod()
        {
            if (UserLoginCache.Position == CargosUsers.Administrador)
            {

            }
            if (UserLoginCache.Position == CargosUsers.Cajero)
            {

            }
            if (UserLoginCache.Position == CargosUsers.Contadora)
            {

            }
        }

        //para recuperar contraseña
        public string recuperarContraseña(string requerimientoUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", requerimientoUsuario);
                    command.Parameters.AddWithValue("@mail", requerimientoUsuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();  //lector de datos sql y ejecutamois el lector

                    if (reader.Read() == true) //si existe el user
                    {
                        //obtenemos los datos del usuario
                        string UserName = reader.GetString(3) + ", " + reader.GetString(4); //nombre del usuario y apellido
                        string userMail = reader.GetString(6); //correo del user
                        string accountPass = reader.GetString(2); // pass del user

                        //instanciamos la clase soporte de sistema
                        var mailService = new SystemSupportMail();
                        //invocamos el metodo de enviar correo de soporte de sistema
                        mailService.sendMail(
                            asunto: "Sistema: Recuperacion de contraseña.",
                            cuerpo: "Hola, " + UserName + "\n solicito recuperacion de contraseña. \n " +
                            "Tu contraseña es: " + accountPass +
                            "\nDebe cambiar su contraseña luego de ingresar al sistema. " +
							"\nQue tenga buen dia.",
                            destinatario: new List<string> { userMail } //en este caso solo instanciamos y ponemos el correo del solicitante
                            //pero podria ser una lista completa de correos, en ese caso se cargan con un forech
                            );
                        //le retornamos al usuario un msj
                        return "Hola, " + UserName + "\n Solicitaste recuperacion de contraseña: \n  \n" +
                            "VERIFICA tu correo electronico: " + userMail +
							"\n "+
							"\n Debe cambiar su contraseña luego de ingresar al sistema. \n";

                    }
                    else
                        return "No tiene cuenta con ese nombre de usuario \n o correo Electronico.";
                }
            }
        }
		//fin codigo  recuperar contraseña


		//guardar tiempo sesion
		public void GuardarTiempoSesion(int id, string nombreUsuario, DateTime fecha, string tiempoSesion)
		{
			using (var connection = GetConnection())
			{
				connection.Open();

				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "INSERT INTO TiempoSesion (IdUser, Nombre, Fecha, Tiempo) " +
				"VALUES (@id, @nombreUsuario, @fecha, @tiempoSesion)";
					command.Parameters.AddWithValue("@id", id);
					command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
					command.Parameters.AddWithValue("@fecha", fecha);
					command.Parameters.AddWithValue("@tiempoSesion", tiempoSesion);
					command.CommandType = CommandType.Text;
					command.ExecuteNonQuery();
				}
			}
		}



	}
}
