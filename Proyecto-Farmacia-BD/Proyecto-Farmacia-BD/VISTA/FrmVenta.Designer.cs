
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmVenta
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
            System.Windows.Forms.Label venta_FKLabel;
            System.Windows.Forms.Label producto_FKLabel;
            System.Windows.Forms.Label cantidadVProductoLabel;
            System.Windows.Forms.Label totalVentaLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label fechaVentaLabel;
            this.venta_FKTextBox = new System.Windows.Forms.TextBox();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_FKTextBox = new System.Windows.Forms.TextBox();
            this.cantidadVProductoTextBox = new System.Windows.Forms.TextBox();
            this.totalVentaTextBox = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fechaVentaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            venta_FKLabel = new System.Windows.Forms.Label();
            producto_FKLabel = new System.Windows.Forms.Label();
            cantidadVProductoLabel = new System.Windows.Forms.Label();
            totalVentaLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            fechaVentaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // venta_FKLabel
            // 
            venta_FKLabel.AutoSize = true;
            venta_FKLabel.Location = new System.Drawing.Point(14, 43);
            venta_FKLabel.Name = "venta_FKLabel";
            venta_FKLabel.Size = new System.Drawing.Size(74, 13);
            venta_FKLabel.TabIndex = 1;
            venta_FKLabel.Text = "Codigo Venta:";
            // 
            // producto_FKLabel
            // 
            producto_FKLabel.AutoSize = true;
            producto_FKLabel.Location = new System.Drawing.Point(23, 58);
            producto_FKLabel.Name = "producto_FKLabel";
            producto_FKLabel.Size = new System.Drawing.Size(92, 13);
            producto_FKLabel.TabIndex = 2;
            producto_FKLabel.Text = "Codigo Producto :";
            // 
            // cantidadVProductoLabel
            // 
            cantidadVProductoLabel.AutoSize = true;
            cantidadVProductoLabel.Location = new System.Drawing.Point(374, 61);
            cantidadVProductoLabel.Name = "cantidadVProductoLabel";
            cantidadVProductoLabel.Size = new System.Drawing.Size(105, 13);
            cantidadVProductoLabel.TabIndex = 4;
            cantidadVProductoLabel.Text = "Cantidad VProducto:";
            // 
            // totalVentaLabel
            // 
            totalVentaLabel.AutoSize = true;
            totalVentaLabel.Location = new System.Drawing.Point(541, 145);
            totalVentaLabel.Name = "totalVentaLabel";
            totalVentaLabel.Size = new System.Drawing.Size(65, 13);
            totalVentaLabel.TabIndex = 6;
            totalVentaLabel.Text = "Total Venta:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(241, 43);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(42, 13);
            clienteLabel.TabIndex = 2;
            clienteLabel.Text = "Cliente:";
            // 
            // fechaVentaLabel
            // 
            fechaVentaLabel.AutoSize = true;
            fechaVentaLabel.Location = new System.Drawing.Point(442, 43);
            fechaVentaLabel.Name = "fechaVentaLabel";
            fechaVentaLabel.Size = new System.Drawing.Size(71, 13);
            fechaVentaLabel.TabIndex = 4;
            fechaVentaLabel.Text = "Fecha Venta:";
            // 
            // venta_FKTextBox
            // 
            this.venta_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Venta_FK", true));
            this.venta_FKTextBox.Location = new System.Drawing.Point(94, 40);
            this.venta_FKTextBox.Name = "venta_FKTextBox";
            this.venta_FKTextBox.Size = new System.Drawing.Size(100, 20);
            this.venta_FKTextBox.TabIndex = 2;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.DetalleVenta);
            // 
            // producto_FKTextBox
            // 
            this.producto_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "Producto_FK", true));
            this.producto_FKTextBox.Location = new System.Drawing.Point(121, 55);
            this.producto_FKTextBox.Name = "producto_FKTextBox";
            this.producto_FKTextBox.Size = new System.Drawing.Size(100, 20);
            this.producto_FKTextBox.TabIndex = 3;
            // 
            // cantidadVProductoTextBox
            // 
            this.cantidadVProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "CantidadVProducto", true));
            this.cantidadVProductoTextBox.Location = new System.Drawing.Point(485, 58);
            this.cantidadVProductoTextBox.Name = "cantidadVProductoTextBox";
            this.cantidadVProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadVProductoTextBox.TabIndex = 5;
            // 
            // totalVentaTextBox
            // 
            this.totalVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleVentaBindingSource, "TotalVenta", true));
            this.totalVentaTextBox.Location = new System.Drawing.Point(612, 142);
            this.totalVentaTextBox.Name = "totalVentaTextBox";
            this.totalVentaTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalVentaTextBox.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(289, 407);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(212, 57);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalVentaTextBox);
            this.groupBox1.Controls.Add(totalVentaLabel);
            this.groupBox1.Controls.Add(producto_FKLabel);
            this.groupBox1.Controls.Add(cantidadVProductoLabel);
            this.groupBox1.Controls.Add(this.producto_FKTextBox);
            this.groupBox1.Controls.Add(this.cantidadVProductoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Venta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(fechaVentaLabel);
            this.groupBox2.Controls.Add(this.fechaVentaDateTimePicker);
            this.groupBox2.Controls.Add(clienteLabel);
            this.groupBox2.Controls.Add(this.clienteTextBox);
            this.groupBox2.Controls.Add(this.venta_FKTextBox);
            this.groupBox2.Controls.Add(venta_FKLabel);
            this.groupBox2.Location = new System.Drawing.Point(23, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venta";
            // 
            // fechaVentaDateTimePicker
            // 
            this.fechaVentaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventaBindingSource, "FechaVenta", true));
            this.fechaVentaDateTimePicker.Enabled = false;
            this.fechaVentaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVentaDateTimePicker.Location = new System.Drawing.Point(519, 39);
            this.fechaVentaDateTimePicker.Name = "fechaVentaDateTimePicker";
            this.fechaVentaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaVentaDateTimePicker.TabIndex = 5;
            this.fechaVentaDateTimePicker.Value = new System.DateTime(2021, 6, 2, 0, 0, 0, 0);
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Venta);
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Cliente", true));
            this.clienteTextBox.Location = new System.Drawing.Point(289, 40);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(115, 20);
            this.clienteTextBox.TabIndex = 3;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private System.Windows.Forms.TextBox venta_FKTextBox;
        private System.Windows.Forms.TextBox producto_FKTextBox;
        private System.Windows.Forms.TextBox cantidadVProductoTextBox;
        private System.Windows.Forms.TextBox totalVentaTextBox;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.DateTimePicker fechaVentaDateTimePicker;
    }
}