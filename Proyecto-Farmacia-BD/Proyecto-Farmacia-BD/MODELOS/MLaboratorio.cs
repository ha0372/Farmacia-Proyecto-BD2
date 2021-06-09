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
    public class MLaboratorio
    {
        IDbConnection cn = Conexion.conectar();

        public List<Laboratorio> Consultar()
        {

            List<Laboratorio> laboratorio = new List<Laboratorio>();
            string consulta = "sp_ConsultarLaboratorio";
            cn.Open();
            laboratorio = cn.Query<Laboratorio>(consulta, commandType: CommandType.StoredProcedure).ToList();

            cn.Close();
            return laboratorio;

        }


        public void insertar(Laboratorio laboratorio)
        {
            string consulta = "Insert into Laboratorio values(@NombreLaboratorio)";

            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreLaboratorio", laboratorio.NombreLaboratorio, DbType.String);


            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public void Actualizar(Laboratorio laboratorio)
        {
            string consulta = "Update Laboratorio set NombreLaboratorio='" + laboratorio.NombreLaboratorio + "'where Id_Laboratorio=" + laboratorio.Id_Laboratorio;

            cn.Open();
            cn.Execute(consulta);
            cn.Close();

        }

        public void Eliminar(Laboratorio laboratorio)
        {
            string consulta = "Delete from Laboratorio where Id_Laboratorio=" + laboratorio.Id_Laboratorio;

            cn.Open();
            cn.Execute(consulta);
            cn.Close();

        }
    }
}
