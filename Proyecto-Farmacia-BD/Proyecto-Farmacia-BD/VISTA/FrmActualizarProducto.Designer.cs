
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmActualizarProducto
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
            System.Windows.Forms.Label existenciasProductosLabel;
            System.Windows.Forms.Label nombreProductoLabel1;
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.existenciasProductosTextBox = new System.Windows.Forms.TextBox();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea_FK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio_FK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            existenciasProductosLabel = new System.Windows.Forms.Label();
            nombreProductoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // existenciasProductosLabel
            // 
            existenciasProductosLabel.AutoSize = true;
            existenciasProductosLabel.Location = new System.Drawing.Point(222, 107);
            existenciasProductosLabel.Name = "existenciasProductosLabel";
            existenciasProductosLabel.Size = new System.Drawing.Size(169, 20);
            existenciasProductosLabel.TabIndex = 2;
            existenciasProductosLabel.Text = "Existencias Productos:";
            // 
            // nombreProductoLabel1
            // 
            nombreProductoLabel1.AutoSize = true;
            nombreProductoLabel1.Location = new System.Drawing.Point(222, 54);
            nombreProductoLabel1.Name = "nombreProductoLabel1";
            nombreProductoLabel1.Size = new System.Drawing.Size(137, 20);
            nombreProductoLabel1.TabIndex = 7;
            nombreProductoLabel1.Text = "Nombre Producto:";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Producto);
            // 
            // existenciasProductosTextBox
            // 
            this.existenciasProductosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ExistenciasProductos", true));
            this.existenciasProductosTextBox.Location = new System.Drawing.Point(397, 104);
            this.existenciasProductosTextBox.Name = "existenciasProductosTextBox";
            this.existenciasProductosTextBox.Size = new System.Drawing.Size(129, 26);
            this.existenciasProductosTextBox.TabIndex = 3;
            this.existenciasProductosTextBox.TextChanged += new System.EventHandler(this.existenciasProductosTextBox_TextChanged);
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.Linea_FK,
            this.Laboratorio_FK,
            this.PrecioProducto});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(12, 188);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.RowHeadersWidth = 62;
            this.productoDataGridView.RowTemplate.Height = 28;
            this.productoDataGridView.Size = new System.Drawing.Size(776, 220);
            this.productoDataGridView.TabIndex = 4;
            this.productoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoDataGridView_CellClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(603, 104);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 43);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(700, 437);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "NombreProducto", true));
            this.nombreProductoTextBox.Location = new System.Drawing.Point(397, 51);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.Size = new System.Drawing.Size(129, 26);
            this.nombreProductoTextBox.TabIndex = 8;
            this.nombreProductoTextBox.Click += new System.EventHandler(this.nombreProductoTextBox_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Producto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreProducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ExistenciasProductos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Existencias";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Linea_FK
            // 
            this.Linea_FK.DataPropertyName = "Linea_FK";
            this.Linea_FK.HeaderText = "Linea_FK";
            this.Linea_FK.MinimumWidth = 8;
            this.Linea_FK.Name = "Linea_FK";
            this.Linea_FK.ReadOnly = true;
            this.Linea_FK.Visible = false;
            // 
            // Laboratorio_FK
            // 
            this.Laboratorio_FK.DataPropertyName = "Laboratorio_FK";
            this.Laboratorio_FK.HeaderText = "Laboratorio_FK";
            this.Laboratorio_FK.MinimumWidth = 8;
            this.Laboratorio_FK.Name = "Laboratorio_FK";
            this.Laboratorio_FK.ReadOnly = true;
            this.Laboratorio_FK.Visible = false;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.DataPropertyName = "PrecioProducto";
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.MinimumWidth = 8;
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            // 
            // FrmActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 502);
            this.Controls.Add(nombreProductoLabel1);
            this.Controls.Add(this.nombreProductoTextBox);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(existenciasProductosLabel);
            this.Controls.Add(this.existenciasProductosTextBox);
            this.Name = "FrmActualizarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActualizarProducto";
            this.Load += new System.EventHandler(this.FrmActualizarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox existenciasProductosTextBox;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea_FK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio_FK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
    }
}