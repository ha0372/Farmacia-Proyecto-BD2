
namespace Proyecto_Farmacia_BD.VISTA
{
    partial class FrmCrearLinea
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
            this.lineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            nombreLineaLabel = new System.Windows.Forms.Label();
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
            // lineaBindingSource
            // 
            this.lineaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Linea);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(nombreLineaLabel);
            this.Controls.Add(this.nombreLineaTextBox);
            this.Name = "FrmLinea";
            this.Text = "FrmLinea";
            this.Load += new System.EventHandler(this.FrmLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lineaBindingSource;
        private System.Windows.Forms.TextBox nombreLineaTextBox;
        private System.Windows.Forms.Button button1;
    }
}