using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM_SUPER
{
    public class Empleados
    {
        private CD_Empleados objetoCD = new CD_Empleados();

        //Mostrar Empleado
        public DataTable MostrarEmpleados()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEmpleados();
            return tabla;

        }
        // Insertar nuevo empleado
        public void InsertarEmpleado(string id, string legajo, string dni, string cuil, string nombre, string apellido, string correo, string telefono, string cargo, string direccion, string genero, string estadoCivil, string hijos, byte[] imagen)
        {

            objetoCD.InsertarEmpleado(Convert.ToInt32(id), Convert.ToInt32(legajo), dni, cuil, nombre, apellido, correo, telefono, cargo, direccion, genero, estadoCivil, Convert.ToInt32(hijos), imagen);

        }

        //Editar empleado
        public void EditarEmpleados(string id, string legajo, string dni, string cuil, string nombre, string apellido, string correo, string telefono, string cargo, string direccion, string genero, string estadoCivil, string hijos, byte[] imagen)
        {

            objetoCD.EditarEmpleados(Convert.ToInt32(id), Convert.ToInt32(legajo), dni, cuil, nombre, apellido, correo, telefono, cargo, direccion, genero, estadoCivil, Convert.ToInt32(hijos), imagen);

        }

        //eliminar empleado
        public void Eliminarempleado(string id)
        {
            objetoCD.EliminarEmpleado(Convert.ToInt32(id));
        }
        public void InsertarEmpleado()
        {

        }

       
    }
}

