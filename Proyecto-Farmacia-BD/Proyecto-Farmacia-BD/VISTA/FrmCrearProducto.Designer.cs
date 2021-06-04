
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmCrearProducto
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
            System.Windows.Forms.Label linea_FKLabel;
            System.Windows.Forms.Label laboratorio_FKLabel;
            System.Windows.Forms.Label nombreProductoLabel;
            System.Windows.Forms.Label precioProductoLabel;
            System.Windows.Forms.Label existenciasProductosLabel;
            this.linea_FKTextBox = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratorio_FKTextBox = new System.Windows.Forms.TextBox();
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.precioProductoTextBox = new System.Windows.Forms.TextBox();
            this.existenciasProductosTextBox = new System.Windows.Forms.TextBox();
            this.btnIngresarProducto = new System.Windows.Forms.Button();
            linea_FKLabel = new System.Windows.Forms.Label();
            laboratorio_FKLabel = new System.Windows.Forms.Label();
            nombreProductoLabel = new System.Windows.Forms.Label();
            precioProductoLabel = new System.Windows.Forms.Label();
            existenciasProductosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // linea_FKLabel
            // 
            linea_FKLabel.AutoSize = true;
            linea_FKLabel.Location = new System.Drawing.Point(96, 89);
            linea_FKLabel.Name = "linea_FKLabel";
            linea_FKLabel.Size = new System.Drawing.Size(52, 13);
            linea_FKLabel.TabIndex = 1;
            linea_FKLabel.Text = "Linea FK:";
            // 
            // laboratorio_FKLabel
            // 
            laboratorio_FKLabel.AutoSize = true;
            laboratorio_FKLabel.Location = new System.Drawing.Point(432, 92);
            laboratorio_FKLabel.Name = "laboratorio_FKLabel";
            laboratorio_FKLabel.Size = new System.Drawing.Size(79, 13);
            laboratorio_FKLabel.TabIndex = 2;
            laboratorio_FKLabel.Text = "Laboratorio FK:";
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Location = new System.Drawing.Point(55, 200);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new System.Drawing.Size(93, 13);
            nombreProductoLabel.TabIndex = 4;
            nombreProductoLabel.Text = "Nombre Producto:";
            // 
            // precioProductoLabel
            // 
            precioProductoLabel.AutoSize = true;
            precioProductoLabel.Location = new System.Drawing.Point(295, 200);
            precioProductoLabel.Name = "precioProductoLabel";
            precioProductoLabel.Size = new System.Drawing.Size(86, 13);
            precioProductoLabel.TabIndex = 6;
            precioProductoLabel.Text = "Precio Producto:";
            // 
            // existenciasProductosLabel
            // 
            existenciasProductosLabel.AutoSize = true;
            existenciasProductosLabel.Location = new System.Drawing.Point(514, 203);
            existenciasProductosLabel.Name = "existenciasProductosLabel";
            existenciasProductosLabel.Size = new System.Drawing.Size(114, 13);
            existenciasProductosLabel.TabIndex = 8;
            existenciasProductosLabel.Text = "Existencias Productos:";
            // 
            // linea_FKTextBox
            // 
            this.linea_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Linea_FK", true));
            this.linea_FKTextBox.Location = new System.Drawing.Point(154, 86);
            this.linea_FKTextBox.Name = "linea_FKTextBox";
            this.linea_FKTextBox.Size = new System.Drawing.Size(100, 20);
            this.linea_FKTextBox.TabIndex = 2;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Producto);
            // 
            // laboratorio_FKTextBox
            // 
            this.laboratorio_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Laboratorio_FK", true));
            this.laboratorio_FKTextBox.Location = new System.Drawing.Point(517, 89);
            this.laboratorio_FKTextBox.Name = "laboratorio_FKTextBox";
            this.laboratorio_FKTextBox.Size = new System.Drawing.Size(100, 20);
            this.laboratorio_FKTextBox.TabIndex = 3;
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "NombreProducto", true));
            this.nombreProductoTextBox.Location = new System.Drawing.Point(154, 197);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreProductoTextBox.TabIndex = 5;
            // 
            // precioProductoTextBox
            // 
            this.precioProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "PrecioProducto", true));
            this.precioProductoTextBox.Location = new System.Drawing.Point(387, 197);
            this.precioProductoTextBox.Name = "precioProductoTextBox";
            this.precioProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioProductoTextBox.TabIndex = 7;
            // 
            // existenciasProductosTextBox
            // 
            this.existenciasProductosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ExistenciasProductos", true));
            this.existenciasProductosTextBox.Location = new System.Drawing.Point(634, 200);
            this.existenciasProductosTextBox.Name = "existenciasProductosTextBox";
            this.existenciasProductosTextBox.Size = new System.Drawing.Size(100, 20);
            this.existenciasProductosTextBox.TabIndex = 9;
            this.existenciasProductosTextBox.Text = "1000";
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.Location = new System.Drawing.Point(355, 336);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarProducto.TabIndex = 10;
            this.btnIngresarProducto.Text = "Ingresar";
            this.btnIngresarProducto.UseVisualStyleBackColor = true;
            this.btnIngresarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresarProducto);
            this.Controls.Add(existenciasProductosLabel);
            this.Controls.Add(this.existenciasProductosTextBox);
            this.Controls.Add(precioProductoLabel);
            this.Controls.Add(this.precioProductoTextBox);
            this.Controls.Add(nombreProductoLabel);
            this.Controls.Add(this.nombreProductoTextBox);
            this.Controls.Add(laboratorio_FKLabel);
            this.Controls.Add(this.laboratorio_FKTextBox);
            this.Controls.Add(linea_FKLabel);
            this.Controls.Add(this.linea_FKTextBox);
            this.Name = "FrmCrearProducto";
            this.Text = "FrmCrearProducto";
            this.Load += new System.EventHandler(this.FrmCrearProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox linea_FKTextBox;
        private System.Windows.Forms.TextBox laboratorio_FKTextBox;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.TextBox precioProductoTextBox;
        private System.Windows.Forms.TextBox existenciasProductosTextBox;
        private System.Windows.Forms.Button btnIngresarProducto;
    }
}