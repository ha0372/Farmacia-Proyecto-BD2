
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmPrincilaVenta
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
            this.ventaDataGridView = new System.Windows.Forms.DataGridView();
            this.detalleVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.btnIngresarVenta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ventaDataGridView
            // 
            this.ventaDataGridView.AllowUserToAddRows = false;
            this.ventaDataGridView.AllowUserToDeleteRows = false;
            this.ventaDataGridView.AutoGenerateColumns = false;
            this.ventaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ventaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ventaDataGridView.DataSource = this.ventaBindingSource;
            this.ventaDataGridView.Location = new System.Drawing.Point(1, 249);
            this.ventaDataGridView.Name = "ventaDataGridView";
            this.ventaDataGridView.ReadOnly = true;
            this.ventaDataGridView.Size = new System.Drawing.Size(393, 220);
            this.ventaDataGridView.TabIndex = 1;
            // 
            // detalleVentaDataGridView
            // 
            this.detalleVentaDataGridView.AutoGenerateColumns = false;
            this.detalleVentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.detalleVentaDataGridView.DataSource = this.detalleVentaBindingSource;
            this.detalleVentaDataGridView.Location = new System.Drawing.Point(400, 249);
            this.detalleVentaDataGridView.Name = "detalleVentaDataGridView";
            this.detalleVentaDataGridView.Size = new System.Drawing.Size(582, 220);
            this.detalleVentaDataGridView.TabIndex = 1;
            // 
            // btnIngresarVenta
            // 
            this.btnIngresarVenta.Location = new System.Drawing.Point(52, 46);
            this.btnIngresarVenta.Name = "btnIngresarVenta";
            this.btnIngresarVenta.Size = new System.Drawing.Size(189, 71);
            this.btnIngresarVenta.TabIndex = 2;
            this.btnIngresarVenta.Text = "Ingresar Venta";
            this.btnIngresarVenta.UseVisualStyleBackColor = true;
            this.btnIngresarVenta.Click += new System.EventHandler(this.btnIngresarVenta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 71);
            this.button2.TabIndex = 3;
            this.button2.Text = "Actualizar Venta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(729, 46);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(189, 71);
            this.btnEliminarVenta.TabIndex = 4;
            this.btnEliminarVenta.Text = "Eliminar Venta";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id_DetalleVenta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id_DetalleVenta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Venta_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "Venta_FK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Producto_FK";
            this.dataGridViewTextBoxColumn6.HeaderText = "Producto_FK";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CantidadVProducto";
            this.dataGridViewTextBoxColumn7.HeaderText = "CantidadVProducto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TotalVenta";
            this.dataGridViewTextBoxColumn8.HeaderText = "TotalVenta";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.DetalleVenta);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Venta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaVenta";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaVenta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Venta);
            // 
            // FrmPrincilaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 481);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIngresarVenta);
            this.Controls.Add(this.detalleVentaDataGridView);
            this.Controls.Add(this.ventaDataGridView);
            this.Name = "FrmPrincilaVenta";
            this.Text = "FrmPrincilaVenta";
            this.Load += new System.EventHandler(this.FrmPrincilaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.DataGridView ventaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private System.Windows.Forms.DataGridView detalleVentaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnIngresarVenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminarVenta;
    }
}