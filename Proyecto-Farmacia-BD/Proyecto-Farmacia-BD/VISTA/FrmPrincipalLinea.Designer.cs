﻿
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
            System.Windows.Forms.Label nombreLineaLabel;
            this.lineaDataGridView = new System.Windows.Forms.DataGridView();
            this.btnIngresarLinea = new System.Windows.Forms.Button();
            this.btnEliminarLinea = new System.Windows.Forms.Button();
            this.btnActualizarLinea = new System.Windows.Forms.Button();
            this.nombreLineaTextBox = new System.Windows.Forms.TextBox();
            this.lineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreLineaLabel = new System.Windows.Forms.Label();
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
            // btnIngresarLinea
            // 
            this.btnIngresarLinea.Location = new System.Drawing.Point(28, 82);
            this.btnIngresarLinea.Name = "btnIngresarLinea";
            this.btnIngresarLinea.Size = new System.Drawing.Size(121, 51);
            this.btnIngresarLinea.TabIndex = 2;
            this.btnIngresarLinea.Text = "Ingresar Linea";
            this.btnIngresarLinea.UseVisualStyleBackColor = true;
            this.btnIngresarLinea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarLinea
            // 
            this.btnEliminarLinea.Location = new System.Drawing.Point(295, 82);
            this.btnEliminarLinea.Name = "btnEliminarLinea";
            this.btnEliminarLinea.Size = new System.Drawing.Size(121, 51);
            this.btnEliminarLinea.TabIndex = 3;
            this.btnEliminarLinea.Text = "Eliminar Linea";
            this.btnEliminarLinea.UseVisualStyleBackColor = true;
            this.btnEliminarLinea.Click += new System.EventHandler(this.btnEliminarLinea_Click);
            // 
            // btnActualizarLinea
            // 
            this.btnActualizarLinea.Location = new System.Drawing.Point(578, 151);
            this.btnActualizarLinea.Name = "btnActualizarLinea";
            this.btnActualizarLinea.Size = new System.Drawing.Size(121, 51);
            this.btnActualizarLinea.TabIndex = 4;
            this.btnActualizarLinea.Text = "ActualizarLinea";
            this.btnActualizarLinea.UseVisualStyleBackColor = true;
            this.btnActualizarLinea.Click += new System.EventHandler(this.btnActualizarLinea_Click);
            // 
            // nombreLineaLabel
            // 
            nombreLineaLabel.AutoSize = true;
            nombreLineaLabel.Location = new System.Drawing.Point(551, 101);
            nombreLineaLabel.Name = "nombreLineaLabel";
            nombreLineaLabel.Size = new System.Drawing.Size(76, 13);
            nombreLineaLabel.TabIndex = 4;
            nombreLineaLabel.Text = "Nombre Linea:";
            // 
            // nombreLineaTextBox
            // 
            this.nombreLineaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineaBindingSource, "NombreLinea", true));
            this.nombreLineaTextBox.Location = new System.Drawing.Point(633, 98);
            this.nombreLineaTextBox.Name = "nombreLineaTextBox";
            this.nombreLineaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreLineaTextBox.TabIndex = 5;
            // 
            // lineaBindingSource
            // 
            this.lineaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Linea);
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
            // FrmPrincipalLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(nombreLineaLabel);
            this.Controls.Add(this.nombreLineaTextBox);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lineaBindingSource;
        private System.Windows.Forms.DataGridView lineaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnIngresarLinea;
        private System.Windows.Forms.Button btnEliminarLinea;
        private System.Windows.Forms.Button btnActualizarLinea;
        private System.Windows.Forms.TextBox nombreLineaTextBox;
    }
}