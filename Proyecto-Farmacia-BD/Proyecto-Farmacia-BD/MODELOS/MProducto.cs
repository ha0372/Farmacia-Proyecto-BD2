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
    public class MProducto
    {
        IDbConnection cn = Conexion.conectar();

        public List<Producto> Consultar()
        {

            List<Producto> producto = new List<Producto>();
            string consulta = "sp_ConsultarProducto";
            cn.Open();
            producto = cn.Query<Producto>(consulta, commandType: CommandType.StoredProcedure).ToList();

            cn.Close();
            return producto;

        }


        public void insertar(Producto productoI)
        {
            string consulta = "Insert into Producto values(@Linea_FK,@Laboratorio_FK,@NombreProducto,@PrecioProducto,@ExistenciasProductos)";

            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Linea_FK", productoI.Linea_FK, DbType.Int32);
            parametros.Add("@Laboratorio_FK", productoI.Laboratorio_FK, DbType.Int32);
            parametros.Add("@NombreProducto", productoI.NombreProducto, DbType.String);
            parametros.Add("@PrecioProducto", productoI.PrecioProducto, DbType.Decimal);
            parametros.Add("@ExistenciasProductos", productoI.ExistenciasProductos, DbType.Int32);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public void eliminarProducto(Producto producto)
        {

            string consulta = "Delete from Producto where Id_Producto=" + producto.Id_Producto;

            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }
        public void actualizarProducto(Producto producto)
        {

            string consulta = "Update Producto set NombreProducto=" + producto.NombreProducto + "where ExistenciasProductos=" + producto.ExistenciasProductos;

            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }
    }
}
