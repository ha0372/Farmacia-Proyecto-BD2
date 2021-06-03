
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label estadoCompraLabel;
            System.Windows.Forms.Label fechaCompraLabel;
            System.Windows.Forms.Label id_CompraLabel;
            System.Windows.Forms.Label cantidadCProductoLabel;
            System.Windows.Forms.Label compra_FKLabel;
            System.Windows.Forms.Label id_DetalleCompraLabel;
            System.Windows.Forms.Label producto_FKLabel;
            System.Windows.Forms.Label totalCompraLabel;
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoCompraTextBox = new System.Windows.Forms.TextBox();
            this.fechaCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_CompraTextBox = new System.Windows.Forms.TextBox();
            this.detalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadCProductoTextBox = new System.Windows.Forms.TextBox();
            this.compra_FKTextBox = new System.Windows.Forms.TextBox();
            this.id_DetalleCompraTextBox = new System.Windows.Forms.TextBox();
            this.producto_FKTextBox = new System.Windows.Forms.TextBox();
            this.totalCompraTextBox = new System.Windows.Forms.TextBox();
            this.detalleCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estadoCompraLabel = new System.Windows.Forms.Label();
            fechaCompraLabel = new System.Windows.Forms.Label();
            id_CompraLabel = new System.Windows.Forms.Label();
            cantidadCProductoLabel = new System.Windows.Forms.Label();
            compra_FKLabel = new System.Windows.Forms.Label();
            id_DetalleCompraLabel = new System.Windows.Forms.Label();
            producto_FKLabel = new System.Windows.Forms.Label();
            totalCompraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Compra);
            // 
            // estadoCompraLabel
            // 
            estadoCompraLabel.AutoSize = true;
            estadoCompraLabel.Location = new System.Drawing.Point(575, 61);
            estadoCompraLabel.Name = "estadoCompraLabel";
            estadoCompraLabel.Size = new System.Drawing.Size(82, 13);
            estadoCompraLabel.TabIndex = 1;
            estadoCompraLabel.Text = "Estado Compra:";
            // 
            // estadoCompraTextBox
            // 
            this.estadoCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "EstadoCompra", true));
            this.estadoCompraTextBox.Location = new System.Drawing.Point(663, 59);
            this.estadoCompraTextBox.Name = "estadoCompraTextBox";
            this.estadoCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoCompraTextBox.TabIndex = 2;
            // 
            // fechaCompraLabel
            // 
            fechaCompraLabel.AutoSize = true;
            fechaCompraLabel.Location = new System.Drawing.Point(95, 59);
            fechaCompraLabel.Name = "fechaCompraLabel";
            fechaCompraLabel.Size = new System.Drawing.Size(79, 13);
            fechaCompraLabel.TabIndex = 3;
            fechaCompraLabel.Text = "Fecha Compra:";
            // 
            // fechaCompraDateTimePicker
            // 
            this.fechaCompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraBindingSource, "FechaCompra", true));
            this.fechaCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCompraDateTimePicker.Location = new System.Drawing.Point(180, 55);
            this.fechaCompraDateTimePicker.Name = "fechaCompraDateTimePicker";
            this.fechaCompraDateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.fechaCompraDateTimePicker.TabIndex = 4;
            // 
            // id_CompraLabel
            // 
            id_CompraLabel.AutoSize = true;
            id_CompraLabel.Location = new System.Drawing.Point(84, 15);
            id_CompraLabel.Name = "id_CompraLabel";
            id_CompraLabel.Size = new System.Drawing.Size(58, 13);
            id_CompraLabel.TabIndex = 5;
            id_CompraLabel.Text = "Id Compra:";
            // 
            // id_CompraTextBox
            // 
            this.id_CompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "Id_Compra", true));
            this.id_CompraTextBox.Location = new System.Drawing.Point(148, 12);
            this.id_CompraTextBox.Name = "id_CompraTextBox";
            this.id_CompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_CompraTextBox.TabIndex = 6;
            // 
            // detalleCompraBindingSource
            // 
            this.detalleCompraBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.DetalleCompra);
            // 
            // cantidadCProductoLabel
            // 
            cantidadCProductoLabel.AutoSize = true;
            cantidadCProductoLabel.Location = new System.Drawing.Point(82, 179);
            cantidadCProductoLabel.Name = "cantidadCProductoLabel";
            cantidadCProductoLabel.Size = new System.Drawing.Size(105, 13);
            cantidadCProductoLabel.TabIndex = 7;
            cantidadCProductoLabel.Text = "Cantidad CProducto:";
            // 
            // cantidadCProductoTextBox
            // 
            this.cantidadCProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "CantidadCProducto", true));
            this.cantidadCProductoTextBox.Location = new System.Drawing.Point(193, 176);
            this.cantidadCProductoTextBox.Name = "cantidadCProductoTextBox";
            this.cantidadCProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadCProductoTextBox.TabIndex = 8;
            // 
            // compra_FKLabel
            // 
            compra_FKLabel.AutoSize = true;
            compra_FKLabel.Location = new System.Drawing.Point(6, 122);
            compra_FKLabel.Name = "compra_FKLabel";
            compra_FKLabel.Size = new System.Drawing.Size(62, 13);
            compra_FKLabel.TabIndex = 9;
            compra_FKLabel.Text = "Compra FK:";
            // 
            // compra_FKTextBox
            // 
            this.compra_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Compra_FK", true));
            this.compra_FKTextBox.Location = new System.Drawing.Point(74, 119);
            this.compra_FKTextBox.Name = "compra_FKTextBox";
            this.compra_FKTextBox.Size = new System.Drawing.Size(100, 20);
            this.compra_FKTextBox.TabIndex = 10;
            // 
            // id_DetalleCompraLabel
            // 
            id_DetalleCompraLabel.AutoSize = true;
            id_DetalleCompraLabel.Location = new System.Drawing.Point(329, 11);
            id_DetalleCompraLabel.Name = "id_DetalleCompraLabel";
            id_DetalleCompraLabel.Size = new System.Drawing.Size(94, 13);
            id_DetalleCompraLabel.TabIndex = 11;
            id_DetalleCompraLabel.Text = "Id Detalle Compra:";
            // 
            // id_DetalleCompraTextBox
            // 
            this.id_DetalleCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Id_DetalleCompra", true));
            this.id_DetalleCompraTextBox.Location = new System.Drawing.Point(429, 8);
            this.id_DetalleCompraTextBox.Name = "id_DetalleCompraTextBox";
            this.id_DetalleCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DetalleCompraTextBox.TabIndex = 12;
            // 
            // producto_FKLabel
            // 
            producto_FKLabel.AutoSize = true;
            producto_FKLabel.Location = new System.Drawing.Point(397, 121);
            producto_FKLabel.Name = "producto_FKLabel";
            producto_FKLabel.Size = new System.Drawing.Size(69, 13);
            producto_FKLabel.TabIndex = 13;
            producto_FKLabel.Text = "Producto FK:";
            // 
            // producto_FKTextBox
            // 
            this.producto_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "Producto_FK", true));
            this.producto_FKTextBox.Location = new System.Drawing.Point(472, 118);
            this.producto_FKTextBox.Name = "producto_FKTextBox";
            this.producto_FKTextBox.Size = new System.Drawing.Size(100, 20);
            this.producto_FKTextBox.TabIndex = 14;
            // 
            // totalCompraLabel
            // 
            totalCompraLabel.AutoSize = true;
            totalCompraLabel.Location = new System.Drawing.Point(478, 175);
            totalCompraLabel.Name = "totalCompraLabel";
            totalCompraLabel.Size = new System.Drawing.Size(73, 13);
            totalCompraLabel.TabIndex = 15;
            totalCompraLabel.Text = "Total Compra:";
            // 
            // totalCompraTextBox
            // 
            this.totalCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleCompraBindingSource, "TotalCompra", true));
            this.totalCompraTextBox.Location = new System.Drawing.Point(557, 172);
            this.totalCompraTextBox.Name = "totalCompraTextBox";
            this.totalCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalCompraTextBox.TabIndex = 16;
            // 
            // detalleCompraDataGridView
            // 
            this.detalleCompraDataGridView.AutoGenerateColumns = false;
            this.detalleCompraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detalleCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.detalleCompraDataGridView.DataSource = this.detalleCompraBindingSource;
            this.detalleCompraDataGridView.Location = new System.Drawing.Point(12, 241);
            this.detalleCompraDataGridView.Name = "detalleCompraDataGridView";
            this.detalleCompraDataGridView.Size = new System.Drawing.Size(854, 257);
            this.detalleCompraDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_DetalleCompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_DetalleCompra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Compra_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Compra_FK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Producto_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "Producto_FK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CantidadCProducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "CantidadCProducto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "TotalCompra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 510);
            this.Controls.Add(this.detalleCompraDataGridView);
            this.Controls.Add(totalCompraLabel);
            this.Controls.Add(this.totalCompraTextBox);
            this.Controls.Add(producto_FKLabel);
            this.Controls.Add(this.producto_FKTextBox);
            this.Controls.Add(id_DetalleCompraLabel);
            this.Controls.Add(this.id_DetalleCompraTextBox);
            this.Controls.Add(compra_FKLabel);
            this.Controls.Add(this.compra_FKTextBox);
            this.Controls.Add(cantidadCProductoLabel);
            this.Controls.Add(this.cantidadCProductoTextBox);
            this.Controls.Add(id_CompraLabel);
            this.Controls.Add(this.id_CompraTextBox);
            this.Controls.Add(fechaCompraLabel);
            this.Controls.Add(this.fechaCompraDateTimePicker);
            this.Controls.Add(estadoCompraLabel);
            this.Controls.Add(this.estadoCompraTextBox);
            this.Name = "FrmCompra";
            this.Text = "FrmCompra";
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.TextBox estadoCompraTextBox;
        private System.Windows.Forms.DateTimePicker fechaCompraDateTimePicker;
        private System.Windows.Forms.TextBox id_CompraTextBox;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource;
        private System.Windows.Forms.TextBox cantidadCProductoTextBox;
        private System.Windows.Forms.TextBox compra_FKTextBox;
        private System.Windows.Forms.TextBox id_DetalleCompraTextBox;
        private System.Windows.Forms.TextBox producto_FKTextBox;
        private System.Windows.Forms.TextBox totalCompraTextBox;
        private System.Windows.Forms.DataGridView detalleCompraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}