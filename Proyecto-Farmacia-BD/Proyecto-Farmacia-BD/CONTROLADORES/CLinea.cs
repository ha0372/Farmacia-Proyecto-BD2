using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Farmacia_BD.MODELOS;
using Proyecto_Farmacia_BD.ENTIDADES;

namespace Proyecto_Farmacia_BD.CONTROLADORES
{
    public class CLinea
    {
        MLinea mLinea = new MLinea();

        public List<Linea> Consultar()
        {
            return mLinea.Consultar();
        }
        public void IngresarLinea(Linea linea)
        {
            mLinea.insertar(linea);
        }
    }
}
