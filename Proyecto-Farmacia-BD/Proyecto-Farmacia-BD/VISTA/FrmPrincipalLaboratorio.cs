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

namespace Proyecto_Farmacia_BD.VISTA
{
    public partial class FrmPrincipalLaboratorio : Form
    {
        public FrmPrincipalLaboratorio()
        {
            InitializeComponent();
        }
        FrmCrearLaboratorio cLaboratorio = new FrmCrearLaboratorio();

        private void btnIngresarNLaboratorio_Click(object sender, EventArgs e)
        {
            laboratorioBindingSource.DataSource = cLaboratorio.();
        }

        private void FrmPrincipalLaboratorio_Load(object sender, EventArgs e)
        {
            FrmLinea linea = new FrmLinea();
            linea.ShowDialog();
            lineaBindingSource.DataSource = null;
            lineaBindingSource.DataSource = cLinea.Consultar();
        }
    }
}
