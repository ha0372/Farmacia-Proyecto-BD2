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

        CVenta cVenta = new CVenta();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            Venta venta = new Venta();
            CDetalleVenta cDetalles = new CDetalleVenta();
            DetalleVenta detalles = new DetalleVenta();

            ventaBindingSource.EndEdit();
            venta = (Venta)ventaBindingSource.Current;

            detalleVentaBindingSource.EndEdit();
            detalles = (DetalleVenta)detalleVentaBindingSource.Current;

            cVenta.IngresarVentas(venta);
            cDetalles.IngresarVenta(detalles);

            this.Close();
        }
        int Id_Venta;
        int prueba;

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            ventaBindingSource.AddNew();

            detalleVentaBindingSource.AddNew();
            Id_Venta = Convert.ToInt32( cVenta.UltimaVenta());
            prueba = Id_Venta +1;
            venta_FKTextBox.Text = prueba.ToString();



        }
    }
}
