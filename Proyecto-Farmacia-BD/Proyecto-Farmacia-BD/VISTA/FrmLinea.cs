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
    public partial class FrmLinea : Form
    {
        public FrmLinea()
        {
            InitializeComponent();
        }
        CLinea cLinea = new CLinea();

        private void FrmLinea_Load(object sender, EventArgs e)
        {
            //lineaBindingSource.DataSource = cLinea.Consultar();
            lineaBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CDetalleVenta cDetalles = new CDetalleVenta();
            Linea linea = new Linea();

            lineaBindingSource.EndEdit();
            //venta = (Venta)ventaBindingSource.Current;

            lineaBindingSource.EndEdit();
            linea = (Linea)lineaBindingSource.Current;

            //cVenta.IngresarVentas(venta);
            cLinea.IngresarLinea(linea);

            this.Close();
        }
    }
}
