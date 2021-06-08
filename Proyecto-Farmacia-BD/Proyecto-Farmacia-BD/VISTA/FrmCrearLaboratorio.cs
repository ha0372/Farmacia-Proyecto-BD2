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
    public partial class FrmCrearLaboratorio : Form
    {
        public FrmCrearLaboratorio()
        {
            InitializeComponent();
        }
        CLaboratorio cLaboratorio = new CLaboratorio();

        private void FrmCrearLaboratorio_Load(object sender, EventArgs e)
        {
            laboratorioBindingSource.AddNew();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Laboratorio laboratorio = new Laboratorio();

            laboratorioBindingSource.EndEdit();

            laboratorioBindingSource.EndEdit();
            laboratorio = (Laboratorio)laboratorioBindingSource.Current;

            cLaboratorio.IngresarLinea(laboratorio);

            this.Close();
        }
    }
}
