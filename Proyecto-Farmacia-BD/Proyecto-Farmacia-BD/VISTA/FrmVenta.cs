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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        //public Cuenta cuenta = new Cuenta();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //CVenta cVenta = new CVenta();
            //Venta venta = new Venta();
            CDetalleVenta cDetalles = new CDetalleVenta();
            DetalleVenta detalles = new DetalleVenta();

            //ventaBindingSource.EndEdit();
            //venta = (Venta)ventaBindingSource.Current;

            detalleVentaBindingSource.EndEdit();
            detalles = (DetalleVenta)detalleVentaBindingSource.Current;

            //cVenta.IngresarVentas(venta);
            cDetalles.IngresarVenta(detalles);

            this.Close();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            ventaBindingSource.AddNew();
            detalleVentaBindingSource.AddNew();
            
        }
    }
}
