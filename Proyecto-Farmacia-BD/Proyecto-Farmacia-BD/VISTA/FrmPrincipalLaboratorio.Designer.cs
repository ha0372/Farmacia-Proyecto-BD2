
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmPrincipalLaboratorio
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
            this.btnIngresarNLaboratorio = new System.Windows.Forms.Button();
            this.laboratorioDataGridView = new System.Windows.Forms.DataGridView();
            this.laboratorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminarLaboratorio = new System.Windows.Forms.Button();
            this.btnActualizarLaboratorio = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarNLaboratorio
            // 
            this.btnIngresarNLaboratorio.Location = new System.Drawing.Point(30, 45);
            this.btnIngresarNLaboratorio.Name = "btnIngresarNLaboratorio";
            this.btnIngresarNLaboratorio.Size = new System.Drawing.Size(164, 78);
            this.btnIngresarNLaboratorio.TabIndex = 0;
            this.btnIngresarNLaboratorio.Text = "Ingresar Nuevo Laboratorio";
            this.btnIngresarNLaboratorio.UseVisualStyleBackColor = true;
            this.btnIngresarNLaboratorio.Click += new System.EventHandler(this.btnIngresarNLaboratorio_Click);
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
            this.laboratorioDataGridView.Location = new System.Drawing.Point(30, 218);
            this.laboratorioDataGridView.Name = "laboratorioDataGridView";
            this.laboratorioDataGridView.ReadOnly = true;
            this.laboratorioDataGridView.Size = new System.Drawing.Size(789, 354);
            this.laboratorioDataGridView.TabIndex = 2;
            // 
            // laboratorioBindingSource
            // 
            this.laboratorioBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Laboratorio);
            // 
            // btnEliminarLaboratorio
            // 
            this.btnEliminarLaboratorio.Location = new System.Drawing.Point(629, 121);
            this.btnEliminarLaboratorio.Name = "btnEliminarLaboratorio";
            this.btnEliminarLaboratorio.Size = new System.Drawing.Size(167, 78);
            this.btnEliminarLaboratorio.TabIndex = 3;
            this.btnEliminarLaboratorio.Text = "Eliminar Laboratorio";
            this.btnEliminarLaboratorio.UseVisualStyleBackColor = true;
            this.btnEliminarLaboratorio.Click += new System.EventHandler(this.btnEliminarLaboratorio_Click);
            // 
            // btnActualizarLaboratorio
            // 
            this.btnActualizarLaboratorio.Location = new System.Drawing.Point(295, 45);
            this.btnActualizarLaboratorio.Name = "btnActualizarLaboratorio";
            this.btnActualizarLaboratorio.Size = new System.Drawing.Size(167, 78);
            this.btnActualizarLaboratorio.TabIndex = 4;
            this.btnActualizarLaboratorio.Text = "Actualizar Laboratorio";
            this.btnActualizarLaboratorio.UseVisualStyleBackColor = true;
            this.btnActualizarLaboratorio.Click += new System.EventHandler(this.btnActualizarLaboratorio_Click);
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
            // FrmPrincipalLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 602);
            this.Controls.Add(this.btnActualizarLaboratorio);
            this.Controls.Add(this.btnEliminarLaboratorio);
            this.Controls.Add(this.laboratorioDataGridView);
            this.Controls.Add(this.btnIngresarNLaboratorio);
            this.Name = "FrmPrincipalLaboratorio";
            this.Text = "FrmPrincipalLaboratorio";
            this.Load += new System.EventHandler(this.FrmPrincipalLaboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarNLaboratorio;
        private System.Windows.Forms.BindingSource laboratorioBindingSource;
        private System.Windows.Forms.DataGridView laboratorioDataGridView;
        private System.Windows.Forms.Button btnEliminarLaboratorio;
        private System.Windows.Forms.Button btnActualizarLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}