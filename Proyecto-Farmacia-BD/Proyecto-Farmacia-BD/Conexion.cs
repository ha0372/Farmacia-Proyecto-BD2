using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace Proyecto_Farmacia_BD
{
    public static class Conexion
    {


        public static IDbConnection conectar()
        {
            IDbConnection connection;
            var cadena = ConfigurationManager.ConnectionStrings["FarmaciaDBEntities"].ConnectionString;
            connection = new SqlConnection(cadena);
            return connection;
        }



    }
}