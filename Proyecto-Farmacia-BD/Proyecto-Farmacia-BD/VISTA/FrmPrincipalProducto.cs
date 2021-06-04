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
    public partial class FrmPrincipalProducto : Form
    {
        public FrmPrincipalProducto()
        {
            InitializeComponent();
        }

        CProducto cProducto = new CProducto();


        private void button1_Click(object sender, EventArgs e)
        {
            FrmCrearProducto producto = new FrmCrearProducto();
            producto.ShowDialog();
            productoBindingSource.DataSource = null;
            productoBindingSource.DataSource = cProducto.Consultar();
        }

        private void FrmPrincipalProducto_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = cProducto.Consultar();
        }
    }
}
