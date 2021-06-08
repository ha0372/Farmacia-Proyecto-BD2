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
        Linea linea = new Linea();

        public FrmActualizarLinea(Linea linea = null)
        {
            this.linea = linea;

            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Linea actualizarLinea = new Linea();

            linea = (Linea)lineaBindingSource.Current;
            linea.Id_Linea = linea.Id_Linea;
            linea.NombreLinea = nombreLineaTextBox.Text;

            CLinea cLinea = new CLinea();
            cLinea.ActualizarLinea(linea);

            this.Close();
        }

        private void FrmActualizarLinea_Load(object sender, EventArgs e)
        {
            id_LineaTextBox.Text = linea.Id_Linea.ToString();
            nombreLineaTextBox.Text = linea.NombreLinea;

        }
    }
}
