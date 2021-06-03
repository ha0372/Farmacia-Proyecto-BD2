
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmLinea
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
            this.nombreLineaTextBox = new System.Windows.Forms.TextBox();
            this.lineaDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nombreLineaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLineaLabel
            // 
            nombreLineaLabel.AutoSize = true;
            nombreLineaLabel.Location = new System.Drawing.Point(14, 94);
            nombreLineaLabel.Name = "nombreLineaLabel";
            nombreLineaLabel.Size = new System.Drawing.Size(76, 13);
            nombreLineaLabel.TabIndex = 3;
            nombreLineaLabel.Text = "Nombre Linea:";
            // 
            // nombreLineaTextBox
            // 
            this.nombreLineaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineaBindingSource, "NombreLinea", true));
            this.nombreLineaTextBox.Location = new System.Drawing.Point(96, 91);
            this.nombreLineaTextBox.Name = "nombreLineaTextBox";
            this.nombreLineaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreLineaTextBox.TabIndex = 4;
            // 
            // lineaDataGridView
            // 
            this.lineaDataGridView.AutoGenerateColumns = false;
            this.lineaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lineaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lineaDataGridView.DataSource = this.lineaBindingSource;
            this.lineaDataGridView.Location = new System.Drawing.Point(12, 218);
            this.lineaDataGridView.Name = "lineaDataGridView";
            this.lineaDataGridView.Size = new System.Drawing.Size(300, 220);
            this.lineaDataGridView.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Linea";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Linea";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreLinea";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreLinea";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // lineaBindingSource
            // 
            this.lineaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Linea);
            // 
            // FrmLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineaDataGridView);
            this.Controls.Add(nombreLineaLabel);
            this.Controls.Add(this.nombreLineaTextBox);
            this.Name = "FrmLinea";
            this.Text = "FrmLinea";
            this.Load += new System.EventHandler(this.FrmLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lineaBindingSource;
        private System.Windows.Forms.TextBox nombreLineaTextBox;
        private System.Windows.Forms.DataGridView lineaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}