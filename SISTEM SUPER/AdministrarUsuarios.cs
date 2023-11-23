using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM_SUPER
{
	public class AdministrarUsuarios
	{

		private CD_AdministrarUsuarios objetoCD = new CD_AdministrarUsuarios();

		public DataTable MostrarUsuarios()
		{
			DataTable tabla = new DataTable();
			tabla = objetoCD.Mostrar();
			return tabla;

		}

		public void InsertarUsuario(string LoginName, string Password, string FirstName, string LastName,
							 string position, string email)
		{
			objetoCD.Insertar(LoginName,  Password, FirstName, LastName,
							  position,   email);
		}

		public void EditarUsuario(string id, string LoginName, string Password, string FirstName, string LastName,
							 string position, string email)

		{
			objetoCD.EditarUsers(Convert.ToInt32(id),  LoginName,  Password,  FirstName,  LastName,
							  position,  email);
		}

		public void ElimarUsuario(string id)
		{
			objetoCD.EliminarUsers(Convert.ToInt32(id));
		}

	}
}
