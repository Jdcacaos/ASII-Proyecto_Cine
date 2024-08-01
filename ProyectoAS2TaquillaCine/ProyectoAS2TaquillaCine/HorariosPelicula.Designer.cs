
namespace ProyectoAS2TaquillaCine
{
    partial class HorariosPelicula
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_sinopsis = new System.Windows.Forms.Label();
            this.byn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(438, 30);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(35, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "label1";
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.Location = new System.Drawing.Point(438, 52);
            this.lbl_duracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(35, 13);
            this.lbl_duracion.TabIndex = 1;
            this.lbl_duracion.Text = "label2";
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(171, 11);
            this.picbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(263, 187);
            this.picbox1.TabIndex = 2;
            this.picbox1.TabStop = false;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Location = new System.Drawing.Point(438, 74);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(35, 13);
            this.lbl_genero.TabIndex = 3;
            this.lbl_genero.Text = "label1";
            // 
            // lbl_sinopsis
            // 
            this.lbl_sinopsis.AutoSize = true;
            this.lbl_sinopsis.Location = new System.Drawing.Point(438, 96);
            this.lbl_sinopsis.Name = "lbl_sinopsis";
            this.lbl_sinopsis.Size = new System.Drawing.Size(35, 13);
            this.lbl_sinopsis.TabIndex = 4;
            this.lbl_sinopsis.Text = "label1";
            // 
            // byn_back
            // 
            this.byn_back.Location = new System.Drawing.Point(13, 11);
            this.byn_back.Name = "byn_back";
            this.byn_back.Size = new System.Drawing.Size(75, 23);
            this.byn_back.TabIndex = 5;
            this.byn_back.Text = "Regresar";
            this.byn_back.UseVisualStyleBackColor = true;
            this.byn_back.Click += new System.EventHandler(this.byn_back_Click);
            // 
            // HorariosPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 608);
            this.Controls.Add(this.byn_back);
            this.Controls.Add(this.lbl_sinopsis);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.lbl_duracion);
            this.Controls.Add(this.lbl_nombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HorariosPelicula";
            this.Text = "HorariosPelicula";
            this.Load += new System.EventHandler(this.HorariosPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_sinopsis;
        private System.Windows.Forms.Button byn_back;
    }
}