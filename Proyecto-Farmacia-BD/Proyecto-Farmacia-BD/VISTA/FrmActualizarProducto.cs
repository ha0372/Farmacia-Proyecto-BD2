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
    public partial class FrmActualizarProducto : Form
    {
        CProducto cProducto = new CProducto();

        public FrmActualizarProducto()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto productos = new Producto();

            productoBindingSource.EndEdit();
            productos = (Producto)productoBindingSource.Current;

            cProducto.ActualizarProducto(productos);

            productoBindingSource.DataSource = cProducto.Consultar();

            MessageBox.Show("Producto Actualizado");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmActualizarProducto_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = cProducto.Consultar();
        }

        private void nombreProductoTextBox_Click(object sender, EventArgs e)
        {
            nombreProductoTextBox.Text = "";
        }

        private void existenciasProductosTextBox_TextChanged(object sender, EventArgs e)
        {
            existenciasProductosTextBox.Text = "";
        }

        private void productoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreProducto = productoDataGridView.CurrentRow.Cells[1].Value.ToString();
            string Existencia = productoDataGridView.CurrentRow.Cells[2].Value.ToString();

            nombreProductoTextBox.Text = nombreProducto;
            existenciasProductosTextBox.Text = Existencia;
        }
    }
}
