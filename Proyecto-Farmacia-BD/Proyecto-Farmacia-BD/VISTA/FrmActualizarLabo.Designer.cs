
namespace Proyecto_Farmacia_BD
{
    partial class FrmActualizarLabo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLaboratorioLabel;
            this.laboratorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratorioDataGridView = new System.Windows.Forms.DataGridView();
            this.nombreLaboratorioTextBox = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreLaboratorioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // laboratorioBindingSource
            // 
            this.laboratorioBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Laboratorio);
            // 
            // laboratorioDataGridView
            // 
            this.laboratorioDataGridView.AllowUserToAddRows = false;
            this.laboratorioDataGridView.AllowUserToDeleteRows = false;
            this.laboratorioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laboratorioDataGridView.AutoGenerateColumns = false;
            this.laboratorioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.laboratorioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laboratorioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.laboratorioDataGridView.DataSource = this.laboratorioBindingSource;
            this.laboratorioDataGridView.Location = new System.Drawing.Point(12, 181);
            this.laboratorioDataGridView.Name = "laboratorioDataGridView";
            this.laboratorioDataGridView.ReadOnly = true;
            this.laboratorioDataGridView.Size = new System.Drawing.Size(608, 246);
            this.laboratorioDataGridView.TabIndex = 1;
            // 
            // nombreLaboratorioLabel
            // 
            nombreLaboratorioLabel.AutoSize = true;
            nombreLaboratorioLabel.Location = new System.Drawing.Point(104, 100);
            nombreLaboratorioLabel.Name = "nombreLaboratorioLabel";
            nombreLaboratorioLabel.Size = new System.Drawing.Size(103, 13);
            nombreLaboratorioLabel.TabIndex = 1;
            nombreLaboratorioLabel.Text = "Nombre Laboratorio:";
            // 
            // nombreLaboratorioTextBox
            // 
            this.nombreLaboratorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratorioBindingSource, "NombreLaboratorio", true));
            this.nombreLaboratorioTextBox.Location = new System.Drawing.Point(213, 97);
            this.nombreLaboratorioTextBox.Name = "nombreLaboratorioTextBox";
            this.nombreLaboratorioTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreLaboratorioTextBox.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(433, 97);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Laboratorio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Laboratorio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreLaboratorio";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreLaboratorio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmActualizarLabo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 439);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(nombreLaboratorioLabel);
            this.Controls.Add(this.nombreLaboratorioTextBox);
            this.Controls.Add(this.laboratorioDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmActualizarLabo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmActualizarLabo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource laboratorioBindingSource;
        private System.Windows.Forms.DataGridView laboratorioDataGridView;
        private System.Windows.Forms.TextBox nombreLaboratorioTextBox;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

