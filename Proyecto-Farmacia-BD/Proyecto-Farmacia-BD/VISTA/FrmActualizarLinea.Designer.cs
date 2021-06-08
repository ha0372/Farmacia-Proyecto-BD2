
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
            System.Windows.Forms.Label id_LineaLabel;
            System.Windows.Forms.Label nombreLineaLabel;
            this.id_LineaTextBox = new System.Windows.Forms.TextBox();
            this.nombreLineaTextBox = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            id_LineaLabel = new System.Windows.Forms.Label();
            nombreLineaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_LineaLabel
            // 
            id_LineaLabel.AutoSize = true;
            id_LineaLabel.Location = new System.Drawing.Point(39, 34);
            id_LineaLabel.Name = "id_LineaLabel";
            id_LineaLabel.Size = new System.Drawing.Size(48, 13);
            id_LineaLabel.TabIndex = 1;
            id_LineaLabel.Text = "Id Linea:";
            id_LineaLabel.Visible = false;
            // 
            // nombreLineaLabel
            // 
            nombreLineaLabel.AutoSize = true;
            nombreLineaLabel.Location = new System.Drawing.Point(105, 99);
            nombreLineaLabel.Name = "nombreLineaLabel";
            nombreLineaLabel.Size = new System.Drawing.Size(76, 13);
            nombreLineaLabel.TabIndex = 3;
            nombreLineaLabel.Text = "Nombre Linea:";
            // 
            // id_LineaTextBox
            // 
            this.id_LineaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineaBindingSource, "Id_Linea", true));
            this.id_LineaTextBox.Location = new System.Drawing.Point(93, 31);
            this.id_LineaTextBox.Name = "id_LineaTextBox";
            this.id_LineaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_LineaTextBox.TabIndex = 2;
            this.id_LineaTextBox.Visible = false;
            // 
            // nombreLineaTextBox
            // 
            this.nombreLineaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lineaBindingSource, "NombreLinea", true));
            this.nombreLineaTextBox.Location = new System.Drawing.Point(187, 96);
            this.nombreLineaTextBox.Name = "nombreLineaTextBox";
            this.nombreLineaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreLineaTextBox.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(168, 174);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 34);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lineaBindingSource
            // 
            this.lineaBindingSource.DataSource = typeof(Proyecto_Farmacia_BD.ENTIDADES.Linea);
            // 
            // FrmActualizarLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 244);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(nombreLineaLabel);
            this.Controls.Add(this.nombreLineaTextBox);
            this.Controls.Add(id_LineaLabel);
            this.Controls.Add(this.id_LineaTextBox);
            this.Name = "FrmActualizarLinea";
            this.Text = "FrmActualizarLinea";
            this.Load += new System.EventHandler(this.FrmActualizarLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lineaBindingSource;
        private System.Windows.Forms.TextBox id_LineaTextBox;
        private System.Windows.Forms.TextBox nombreLineaTextBox;
        private System.Windows.Forms.Button btnActualizar;
    }
}