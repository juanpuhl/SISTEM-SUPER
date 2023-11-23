using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SISTEM_SUPER
{
    
    public  class ConnectionToSql
    {
        private  readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Server = .\\SQLDEVELOPER2022; DataBase = ChinoDB; integrated security = true";

        }

        private SqlConnection Conexion = new SqlConnection("Server = .\\SQLDEVELOPER2022; DataBase = ChinoDB; integrated security = true");
        public SqlConnection AbrirConexion()
        {
            if(Conexion.State == ConnectionState.Closed)
             Conexion.Open();
            return Conexion;    
            
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }

        //metodo protegido metodo coneccion
        public SqlConnection GetConnection()
        {
            
            return new SqlConnection(connectionString);
        }

    }
}
