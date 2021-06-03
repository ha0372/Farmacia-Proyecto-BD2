using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Farmacia_BD.ENTIDADES
{
    public class DetalleCompra
    {
        public int Id_DetalleCompra { get; set; }
        public int? Compra_FK { get; set; }
        public int? Producto_FK { get; set; }
        public int? CantidadCProducto { get; set; }
        public decimal? TotalCompra { get; set; }
    }
}
