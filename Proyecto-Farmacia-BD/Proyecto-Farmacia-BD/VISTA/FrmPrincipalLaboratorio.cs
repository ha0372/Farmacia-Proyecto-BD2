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
    public partial class FrmPrincipalLaboratorio : Form
    {
        public FrmPrincipalLaboratorio()
        {
            InitializeComponent();
        }

        CLaboratorio cLaboratorio = new CLaboratorio();

        private void btnIngresarNLaboratorio_Click(object sender, EventArgs e)
        {
            FrmCrearLaboratorio laboratorio = new FrmCrearLaboratorio();
            laboratorio.ShowDialog();
            laboratorioBindingSource.DataSource = null;
            laboratorioBindingSource.DataSource = cLaboratorio.Consultar();
        }

        private void FrmPrincipalLaboratorio_Load(object sender, EventArgs e)
        {
            
            laboratorioBindingSource.DataSource = cLaboratorio.Consultar();
        }

        private void btnActualizarLaboratorio_Click(object sender, EventArgs e)
        {
            FrmActualizarLabo laboratorio = new FrmActualizarLabo();
            laboratorio.ShowDialog();
            laboratorioBindingSource.DataSource = null;
            laboratorioBindingSource.DataSource = cLaboratorio.Consultar();
        }

        private void btnEliminarLaboratorio_Click(object sender, EventArgs e)
        {
            Laboratorio laboratorio = new Laboratorio();

            //laboratorioBindingSource.EndEdit();

            laboratorioBindingSource.EndEdit();
            laboratorio = (Laboratorio)laboratorioBindingSource.Current;

            cLaboratorio.EliminarLaboratorio(laboratorio);

            laboratorioBindingSource.DataSource = cLaboratorio.Consultar();
        }
    }
}
