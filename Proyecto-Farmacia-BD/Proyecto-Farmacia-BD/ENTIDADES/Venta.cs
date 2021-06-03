using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Farmacia_BD.ENTIDADES
{
    public class Venta
    {
        public int Id_Venta { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
