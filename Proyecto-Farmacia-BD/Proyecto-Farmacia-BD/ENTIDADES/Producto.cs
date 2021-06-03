using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Farmacia_BD.ENTIDADES
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public int? Linea_FK { get; set; }
        public int? Laboratorio_FK { get; set; }
        public string NombreProducto { get; set; }
        public decimal? PrecioProducto { get; set; }
        public int? ExistenciasProductos { get; set; }
    }
}
