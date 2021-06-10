using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Farmacia_BD.MODELOS;
using Proyecto_Farmacia_BD.ENTIDADES;

namespace Proyecto_Farmacia_BD.CONTROLADORES
{
    public class CProducto
    {
        MProducto mProducto = new MProducto();

        public List<Producto> Consultar()
        {
            return mProducto.Consultar();
        }
        public void IngresarProducto(Producto producto)
        {
            mProducto.insertar(producto);
        }
        public void EliminarProducto(Producto productos)
        {
            mProducto.eliminarProducto(productos);
        }
        public void ActualizarProducto(Producto producto)
        {
            mProducto.actualizarProducto(producto);
        }
    }
}
