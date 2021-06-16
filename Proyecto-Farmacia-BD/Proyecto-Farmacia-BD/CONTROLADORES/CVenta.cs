using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Farmacia_BD.MODELOS;
using Proyecto_Farmacia_BD.ENTIDADES;

namespace Proyecto_Farmacia_BD.CONTROLADORES
{
    public class CVenta
    {
        MVenta mVenta = new MVenta();

        public List<Venta> ConsultarV()
        {
            return mVenta.ConsultarVenta();
        }
        public void IngresarVentas(Venta venta)
        {
            mVenta.insertarVenta(venta);
        }

        //public String UltimaVenta()
        //{
        //    return mVenta.UltimaVenta();
        //}

        public void EliminarDetalle(Venta venta)
        {
            mVenta.eliminarDetalle(venta);
        }

    }
}
