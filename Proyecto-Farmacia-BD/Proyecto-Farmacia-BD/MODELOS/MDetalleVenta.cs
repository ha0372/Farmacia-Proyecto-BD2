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
    public class MDetalleVenta
    {
        IDbConnection cn = Conexion.conectar();

        public List<DetalleVenta> Consultar()
        {

            List<DetalleVenta> detalleVentas = new List<DetalleVenta>();
            string consulta = "sp_ConsultarDetalleVenta";
            cn.Open();
            detalleVentas = cn.Query<DetalleVenta>(consulta, commandType: CommandType.StoredProcedure).ToList();

            cn.Close();
            return detalleVentas;

        }


        public void insertar(DetalleVenta dventa)
        {
            string consulta = "Insert into DetalleVenta values(@Venta_FK,@Producto_FK,@CantidadVProducto,@TotalVenta)";

            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Venta_FK", dventa.Venta_FK, DbType.Int32);
            parametros.Add("@Producto_FK", dventa.Producto_FK, DbType.Int32);
            parametros.Add("@CantidadVProducto", dventa.CantidadVProducto, DbType.Int32);
            parametros.Add("@TotalVenta", dventa.TotalVenta, DbType.Decimal);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }
    }
}

