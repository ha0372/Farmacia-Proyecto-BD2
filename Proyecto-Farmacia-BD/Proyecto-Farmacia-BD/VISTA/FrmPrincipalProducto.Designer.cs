
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmPrincipalProducto
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
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRegistrarNuevo = new System.Windows.Forms.Button();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(48, 398);
            this.productoDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.RowHeadersWidth = 62;
            this.productoDataGridView.Size = new System.Drawing.Size(1442, 438);
            this.productoDataGridView.TabIndex = 1;
            // 
            // btnRegistrarNuevo
            // 
            this.btnRegistrarNuevo.Location = new System.Drawing.Point(171, 114);
            this.btnRegistrarNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarNuevo.Name = "btnRegistrarNuevo";
            this.btnRegistrarNuevo.Size = new System.Drawing.Size(222, 92);
            this.btnRegistrarNuevo.TabIndex = 2;
            this.btnRegistrarNuevo.Text = "Registrar Nuevo Producto";
            this.btnRegistrarNuevo.UseVisualStyleBackColor = true;
            this.btnRegistrarNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.Location = new System.Drawing.Point(627, 114);
            this.btnEliminarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(294, 92);
            this.btnEliminarProductos.TabIndex = 3;
            this.btnEliminarProductos.Text = "Eliminar Productos";
            this.btnEliminarProductos.UseVisualStyleBackColor = true;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(1186, 235);
            this.btnActualizarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(237, 92);
            this.btnActualizarProducto.TabIndex = 4;
            this.btnActualizarProducto.Text = "Actualizar Producto";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Producto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Linea_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "Linea_FK";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Laboratorio_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "Laboratorio_FK";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreProducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "NombreProducto";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrecioProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "PrecioProducto";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ExistenciasProductos";
            this.dataGridViewTextBoxColumn6.HeaderText = "ExistenciasProductos";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Producto);
            // 
            // FrmPrincipalProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 855);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.btnEliminarProductos);
            this.Controls.Add(this.btnRegistrarNuevo);
            this.Controls.Add(this.productoDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipalProducto";
            this.Text = "FrmPrincipalProducto";
            this.Load += new System.EventHandler(this.FrmPrincipalProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnRegistrarNuevo;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnActualizarProducto;
    }
}