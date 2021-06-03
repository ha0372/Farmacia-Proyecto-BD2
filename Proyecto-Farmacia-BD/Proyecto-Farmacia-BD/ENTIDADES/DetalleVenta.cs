using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Farmacia_BD.ENTIDADES
{
    public class DetalleVenta
    {
        public int Id_DetalleVenta { get; set; }
        public int? Venta_FK { get; set; }
        public int? Producto_FK { get; set; }
        public int? CantidadVProducto { get; set; }
        public decimal? TotalVenta { get; set; }
    }
}
