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
    public partial class FrmPrincilaVenta : Form
    {
        public FrmPrincilaVenta()
        {
            InitializeComponent();
        }

        CVenta cVenta = new CVenta();
        CDetalleVenta cDetalleVenta = new CDetalleVenta();
        private void btnIngresarVenta_Click(object sender, EventArgs e)
        {
            FrmVenta venta = new FrmVenta();
            venta.ShowDialog();
            ventaBindingSource.DataSource = null;
            ventaBindingSource.DataSource = cVenta.ConsultarV();
        }

        private void FrmPrincilaVenta_Load(object sender, EventArgs e)
        {
               ventaBindingSource.DataSource = cVenta.ConsultarV();
            detalleVentaBindingSource.DataSource = cDetalleVenta.Consultar();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
