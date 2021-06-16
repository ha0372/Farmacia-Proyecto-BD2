using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Proyecto_Farmacia_BD.ENTIDADES;
using System.Data.SqlClient;

namespace Proyecto_Farmacia_BD.MODELOS
{
    public class MVenta
    {
        IDbConnection cn = Conexion.conectar();

        public string UltimaVenta()
        {

            cn.Open();
            string consulta = "SELECT distinct TOP 1 Id_Venta FROM  Venta ORDER BY Id_Venta DESC";
            SqlCommand venta = new SqlCommand(consulta, (SqlConnection)cn);
            SqlDataReader r = venta.ExecuteReader();
            //ventas = cn.Query<Venta>(consulta, commandType: CommandType.StoredProcedure).ToList();

            if (r.Read())
            {
                return r["Id_Venta"].ToString();
            }
            else
            {
                return "Null";
            }

           
            cn.Close();
        }


        public List<Venta> ConsultarVenta()
        {

            List<Venta> ventas = new List<Venta>();
            string consulta = "sp_ConsultarVenta";
            cn.Open();
            ventas = cn.Query<Venta>(consulta, commandType: CommandType.StoredProcedure).ToList();

            cn.Close();
            return ventas;

        }


        public void insertarVenta(Venta venta)
        {
            string consulta = "Insert into Venta values(@Cliente,@FechaVenta)";

            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Cliente", venta.Cliente, DbType.String);
            parametros.Add("@FechaVenta", venta.FechaVenta, DbType.DateTime2);


            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }
    }
}
