using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Farmacia_BD.MODELOS;
using Proyecto_Farmacia_BD.ENTIDADES;

namespace Proyecto_Farmacia_BD.CONTROLADORES
{
    public class CDetalleVenta
    {
        MDetalleVenta mDetalleV = new MDetalleVenta();       

        public List<DetalleVenta> Consultar()
        {
            return mDetalleV.Consultar();
        }
        public void IngresarVenta(DetalleVenta detalleVenta)
        {
            mDetalleV.insertar(detalleVenta);
        }

        public void EliminarDetalle(DetalleVenta venta)
        {
            mDetalleV.eliminarDetalle(venta);
        }

    }
}
