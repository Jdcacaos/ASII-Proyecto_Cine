
namespace ProyectoAS2TaquillaCine.FormsCliente
{
    partial class CarteleraNueva
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.cbDireccion = new System.Windows.Forms.ComboBox();
            this.cbDepto = new System.Windows.Forms.ComboBox();
            this.btnQF = new System.Windows.Forms.Button();
            this.PeliculaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 102);
            this.label1.TabIndex = 1;
            this.label1.Text = "CINEHUB";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(721, 127);
            this.btn_filtrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(116, 36);
            this.btn_filtrar.TabIndex = 8;
            this.btn_filtrar.Text = "Buscar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click_1);
            // 
            // cbDireccion
            // 
            this.cbDireccion.FormattingEnabled = true;
            this.cbDireccion.Location = new System.Drawing.Point(551, 133);
            this.cbDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.cbDireccion.Name = "cbDireccion";
            this.cbDireccion.Size = new System.Drawing.Size(160, 24);
            this.cbDireccion.TabIndex = 7;
            // 
            // cbDepto
            // 
            this.cbDepto.FormattingEnabled = true;
            this.cbDepto.Location = new System.Drawing.Point(382, 133);
            this.cbDepto.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(160, 24);
            this.cbDepto.TabIndex = 6;
            // 
            // btnQF
            // 
            this.btnQF.Location = new System.Drawing.Point(845, 127);
            this.btnQF.Margin = new System.Windows.Forms.Padding(4);
            this.btnQF.Name = "btnQF";
            this.btnQF.Size = new System.Drawing.Size(116, 36);
            this.btnQF.TabIndex = 9;
            this.btnQF.Text = "Quitar filtro";
            this.btnQF.UseVisualStyleBackColor = true;
            this.btnQF.Click += new System.EventHandler(this.btnQF_Click_1);
            // 
            // PeliculaPanel
            // 
            this.PeliculaPanel.Location = new System.Drawing.Point(63, 181);
            this.PeliculaPanel.Name = "PeliculaPanel";
            this.PeliculaPanel.Size = new System.Drawing.Size(1740, 685);
            this.PeliculaPanel.TabIndex = 10;
            // 
            // CarteleraNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 907);
            this.Controls.Add(this.PeliculaPanel);
            this.Controls.Add(this.btnQF);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.cbDireccion);
            this.Controls.Add(this.cbDepto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarteleraNueva";
            this.Text = "Cartelera";
            this.Load += new System.EventHandler(this.CarteleraNueva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.ComboBox cbDireccion;
        private System.Windows.Forms.ComboBox cbDepto;
        private System.Windows.Forms.Button btnQF;
        private System.Windows.Forms.FlowLayoutPanel PeliculaPanel;
    }
}