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
    public partial class FrmCrearProducto : Form
    {
        public FrmCrearProducto()
        {
            InitializeComponent();
        }

        CProducto cProducto = new CProducto();

        private void FrmCrearProducto_Load(object sender, EventArgs e)
        {
            productoBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Producto producto = new Producto();         

            productoBindingSource.EndEdit();
            producto = (Producto)productoBindingSource.Current;

            
           cProducto.IngresarProducto(producto);

            this.Close();
        }
    }
}
