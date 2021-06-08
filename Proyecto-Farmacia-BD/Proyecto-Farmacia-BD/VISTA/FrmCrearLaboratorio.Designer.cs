
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmCrearLaboratorio
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
            System.Windows.Forms.Label nombreLaboratorioLabel;
            this.nombreLaboratorioTextBox = new System.Windows.Forms.TextBox();
            this.laboratorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRegistrar = new System.Windows.Forms.Button();
            nombreLaboratorioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLaboratorioLabel
            // 
            nombreLaboratorioLabel.AutoSize = true;
            nombreLaboratorioLabel.Location = new System.Drawing.Point(44, 103);
            nombreLaboratorioLabel.Name = "nombreLaboratorioLabel";
            nombreLaboratorioLabel.Size = new System.Drawing.Size(103, 13);
            nombreLaboratorioLabel.TabIndex = 1;
            nombreLaboratorioLabel.Text = "Nombre Laboratorio:";
            // 
            // nombreLaboratorioTextBox
            // 
            this.nombreLaboratorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratorioBindingSource, "NombreLaboratorio", true));
            this.nombreLaboratorioTextBox.Location = new System.Drawing.Point(153, 100);
            this.nombreLaboratorioTextBox.Name = "nombreLaboratorioTextBox";
            this.nombreLaboratorioTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreLaboratorioTextBox.TabIndex = 2;
            // 
            // laboratorioBindingSource
            // 
            this.laboratorioBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Laboratorio);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(117, 206);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 34);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmCrearLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(nombreLaboratorioLabel);
            this.Controls.Add(this.nombreLaboratorioTextBox);
            this.Name = "FrmCrearLaboratorio";
            this.Text = "FrmCrearLaboratorio";
            this.Load += new System.EventHandler(this.FrmCrearLaboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laboratorioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource laboratorioBindingSource;
        private System.Windows.Forms.TextBox nombreLaboratorioTextBox;
        private System.Windows.Forms.Button btnRegistrar;
    }
}