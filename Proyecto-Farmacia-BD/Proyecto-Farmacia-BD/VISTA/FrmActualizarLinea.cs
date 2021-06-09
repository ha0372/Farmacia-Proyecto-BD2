using Proyecto_Farmacia_BD.CONTROLADORES;
using Proyecto_Farmacia_BD.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Farmacia_BD.VISTA
{
    public partial class FrmActualizarLinea : Form
    {
        CLinea cLinea = new CLinea();

        public FrmActualizarLinea()
        {          

            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Linea actualizarLinea = new Linea();
            //linea = (Linea)lineaBindingSource.Current;
            //linea.Id_Linea = linea.Id_Linea;
            //linea.NombreLinea = nombreLineaTextBox.Text;
            //CLinea cLinea = new CLinea();
            //cLinea.ActualizarLinea(linea);

            Linea linea = new Linea();

            lineaBindingSource.EndEdit();

            lineaBindingSource.EndEdit();
            linea = (Linea)lineaBindingSource.Current;

            cLinea.ActualizarLinea(linea);

            lineaBindingSource.DataSource = cLinea.Consultar();

            this.Close();
        }

        private void FrmActualizarLinea_Load(object sender, EventArgs e)
        {
            lineaBindingSource.DataSource = cLinea.Consultar();

        }
    }
}
