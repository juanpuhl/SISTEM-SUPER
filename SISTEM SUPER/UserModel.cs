using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SISTEM_SUPER
{
    public class UserModel
    {
        UserDao UserDao = new UserDao();

        public string recuperacionContraseña(string requerimientoUsuario)
        {
            return UserDao.recuperarContraseña(requerimientoUsuario);
        }

        // attributos del usuario
        public int idUser;
        public string loginName;
        private string password;
        private string firstName;
        private string lastName;
        private string Position;
        private string email;

        public UserModel(int idUser, string loginName, string password, string firstName, string lastName, string position, string email)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.Position = position;
            this.email = email;
        }

        public UserModel()
        {

        }

        // editar perfil
        public string EditarPerfilUsuario()
        {


            // try
            //{
            UserDao.EditarPerfil(idUser, loginName, password, firstName, lastName, email); //no pongo cargo porque esto es para contador rrhh o admin
            LoginUser(loginName, password);
            return "Tu perfil se actualizo correctamente.";

            //} catch (Exception ex) 
            //{
            //    return "El nombre de Usuario ya esta registrado, intente con otro." + ex;
            //}
        }



        public bool LoginUser(string user, string pass)
        {
            return UserDao.Login(user, pass);
        }

        public bool editarContraseña(int user, string pass)
        {
            if (user == UserLoginCache.IdUser)
            {


            }
            return true;
        }

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


		//tiempo de sesion
		public TimeSpan TiempoTranscurrido { get; set; }
		// Guardar tiempo de sesión
		public string GuardarTiempoSesion(TimeSpan tiempoTranscurrido)
		{
			UserDao userDao = new UserDao(); 

			try
			{
                // Llama al método en UserDao para guardar el tiempo de sesión
                userDao.GuardarTiempoSesion(
                    UserLoginCache.IdUser,
                    UserLoginCache.loginName,
                    DateTime.Now,
                    tiempoTranscurrido.ToString(@"hh\:mm\:ss"));
				return "";

			}
			catch (Exception ex)
			{
				Console.WriteLine("Error de SQL: " + ex.Message);
				return "no se guardo " + ex;
			}
		}
    }
}
