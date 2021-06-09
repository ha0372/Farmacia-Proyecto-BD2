using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Farmacia_BD.MODELOS;
using Proyecto_Farmacia_BD.ENTIDADES;

namespace Proyecto_Farmacia_BD.CONTROLADORES
{
    public class CLaboratorio
    {
        MLaboratorio mLaboratorio = new MLaboratorio();

        public List<Laboratorio> Consultar()
        {
            return mLaboratorio.Consultar();
        }
        public void IngresarLinea(Laboratorio laboratorio)
        {
            mLaboratorio.insertar(laboratorio);
        }
        public void ActualizarLaboratorio(Laboratorio laboratorio)
        {
            mLaboratorio.Actualizar(laboratorio);
        }
        public void EliminarLaboratorio(Laboratorio laboratorio)
        {
            mLaboratorio.Eliminar(laboratorio);
        }
    }
}
