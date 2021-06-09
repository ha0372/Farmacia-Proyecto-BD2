
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmActualizarLinea
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
            this.lineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreLineaTextBox = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lineaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreLineaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLineaLabel
            // 
            nombreLineaLabel.AutoSize = true;
            nombreLineaLabel.Location = new System.Drawing.Point(49, 82);
            nombreLineaLabel.Name = "nombreLineaLabel";
            nombreLineaLabel.Size = new System.Drawing.Size(76, 13);
            nombreLineaLabel.TabIndex = 3;
            nombreLineaLabel.Text = "Nombre Linea:";
            // 
            // lineaBindingSource
            // 
            this.lineaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Linea);
            // 
            // nombreLineaTextBox
            // 
            this.nombreLineaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineaBindingSource, "NombreLinea", true));
            this.nombreLineaTextBox.Location = new System.Drawing.Point(146, 82);
            this.nombreLineaTextBox.Name = "nombreLineaTextBox";
            this.nombreLineaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreLineaTextBox.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(346, 74);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 34);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lineaDataGridView
            // 
            this.lineaDataGridView.AllowUserToAddRows = false;
            this.lineaDataGridView.AllowUserToDeleteRows = false;
            this.lineaDataGridView.AutoGenerateColumns = false;
            this.lineaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lineaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lineaDataGridView.DataSource = this.lineaBindingSource;
            this.lineaDataGridView.Location = new System.Drawing.Point(66, 141);
            this.lineaDataGridView.Name = "lineaDataGridView";
            this.lineaDataGridView.ReadOnly = true;
            this.lineaDataGridView.Size = new System.Drawing.Size(432, 220);
            this.lineaDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Linea";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Linea";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreLinea";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreLinea";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmActualizarLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 425);
            this.Controls.Add(this.lineaDataGridView);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(nombreLineaLabel);
            this.Controls.Add(this.nombreLineaTextBox);
            this.Name = "FrmActualizarLinea";
            this.Text = "FrmActualizarLinea";
            this.Load += new System.EventHandler(this.FrmActualizarLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lineaBindingSource;
        private System.Windows.Forms.TextBox nombreLineaTextBox;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView lineaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}