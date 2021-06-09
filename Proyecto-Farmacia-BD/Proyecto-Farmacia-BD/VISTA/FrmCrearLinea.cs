using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Farmacia_BD.CONTROLADORES;
using Proyecto_Farmacia_BD.ENTIDADES;

namespace Proyecto_Farmacia_BD.VISTA
{
    public partial class FrmCrearLinea : Form
    {
        public FrmCrearLinea()
        {
            InitializeComponent();
        }
        CLinea cLinea = new CLinea();

        private void FrmLinea_Load(object sender, EventArgs e)
        {
            lineaBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Linea linea = new Linea();

            lineaBindingSource.EndEdit();

            lineaBindingSource.EndEdit();
            linea = (Linea)lineaBindingSource.Current;

            cLinea.IngresarLinea(linea);

            this.Close();
        }
    }
}
