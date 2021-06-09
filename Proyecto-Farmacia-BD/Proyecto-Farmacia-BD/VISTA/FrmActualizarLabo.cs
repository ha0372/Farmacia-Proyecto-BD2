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

namespace Proyecto_Farmacia_BD
{
    public partial class FrmActualizarLabo : Form
    {
        public FrmActualizarLabo()
        {
            InitializeComponent();
        }

        CLaboratorio cLaboratorio = new CLaboratorio();

        private void FrmActualizarLabo_Load(object sender, EventArgs e)
        {
            laboratorioBindingSource.DataSource = cLaboratorio.Consultar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Laboratorio laboratorio = new Laboratorio();

            laboratorioBindingSource.EndEdit();

            laboratorioBindingSource.EndEdit();
            laboratorio = (Laboratorio)laboratorioBindingSource.Current;

            cLaboratorio.ActualizarLaboratorio(laboratorio);

            laboratorioBindingSource.DataSource = cLaboratorio.Consultar();

            this.Close();
        }
    }
}
