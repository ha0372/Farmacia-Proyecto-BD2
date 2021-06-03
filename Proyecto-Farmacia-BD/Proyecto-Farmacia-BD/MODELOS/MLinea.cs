using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Proyecto_Farmacia_BD.ENTIDADES;

namespace Proyecto_Farmacia_BD.MODELOS
{
    public class MLinea
    {
        IDbConnection cn = Conexion.conectar();

        public List<Linea> Consultar()
        {

            List<Linea> linea = new List<Linea>();
            string consulta = "sp_ConsultarLinea";
            cn.Open();
            linea = cn.Query<Linea>(consulta, commandType: CommandType.StoredProcedure).ToList();

            cn.Close();
            return linea;

        }


        public void insertar(Linea linea)
        {
            string consulta = "Insert into Linea values(@NombreLinea)";

            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreLinea", linea.NombreLinea, DbType.String);


            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }
    }
}
