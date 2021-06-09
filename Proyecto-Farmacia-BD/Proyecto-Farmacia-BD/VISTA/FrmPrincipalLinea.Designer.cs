
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmPrincipalLinea
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
            this.lineaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIngresarLinea = new System.Windows.Forms.Button();
            this.btnEliminarLinea = new System.Windows.Forms.Button();
            this.btnActualizarLinea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lineaDataGridView
            // 
            this.lineaDataGridView.AllowUserToAddRows = false;
            this.lineaDataGridView.AllowUserToDeleteRows = false;
            this.lineaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineaDataGridView.AutoGenerateColumns = false;
            this.lineaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lineaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lineaDataGridView.DataSource = this.lineaBindingSource;
            this.lineaDataGridView.Location = new System.Drawing.Point(28, 238);
            this.lineaDataGridView.Name = "lineaDataGridView";
            this.lineaDataGridView.ReadOnly = true;
            this.lineaDataGridView.Size = new System.Drawing.Size(750, 220);
            this.lineaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Linea";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Linea";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreLinea";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreLinea";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lineaBindingSource
            // 
            this.lineaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Linea);
            // 
            // btnIngresarLinea
            // 
            this.btnIngresarLinea.Location = new System.Drawing.Point(41, 39);
            this.btnIngresarLinea.Name = "btnIngresarLinea";
            this.btnIngresarLinea.Size = new System.Drawing.Size(121, 66);
            this.btnIngresarLinea.TabIndex = 2;
            this.btnIngresarLinea.Text = "Ingresar Linea";
            this.btnIngresarLinea.UseVisualStyleBackColor = true;
            this.btnIngresarLinea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarLinea
            // 
            this.btnEliminarLinea.Location = new System.Drawing.Point(657, 166);
            this.btnEliminarLinea.Name = "btnEliminarLinea";
            this.btnEliminarLinea.Size = new System.Drawing.Size(121, 51);
            this.btnEliminarLinea.TabIndex = 3;
            this.btnEliminarLinea.Text = "Eliminar Linea";
            this.btnEliminarLinea.UseVisualStyleBackColor = true;
            this.btnEliminarLinea.Click += new System.EventHandler(this.btnEliminarLinea_Click);
            // 
            // btnActualizarLinea
            // 
            this.btnActualizarLinea.Location = new System.Drawing.Point(188, 39);
            this.btnActualizarLinea.Name = "btnActualizarLinea";
            this.btnActualizarLinea.Size = new System.Drawing.Size(121, 66);
            this.btnActualizarLinea.TabIndex = 4;
            this.btnActualizarLinea.Text = "ActualizarLinea";
            this.btnActualizarLinea.UseVisualStyleBackColor = true;
            this.btnActualizarLinea.Click += new System.EventHandler(this.btnActualizarLinea_Click);
            // 
            // FrmPrincipalLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnActualizarLinea);
            this.Controls.Add(this.btnEliminarLinea);
            this.Controls.Add(this.btnIngresarLinea);
            this.Controls.Add(this.lineaDataGridView);
            this.Name = "FrmPrincipalLinea";
            this.Text = "FrmPrincipalLinea";
            this.Load += new System.EventHandler(this.FrmPrincipalLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource lineaBindingSource;
        private System.Windows.Forms.DataGridView lineaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnIngresarLinea;
        private System.Windows.Forms.Button btnEliminarLinea;
        private System.Windows.Forms.Button btnActualizarLinea;
    }
}