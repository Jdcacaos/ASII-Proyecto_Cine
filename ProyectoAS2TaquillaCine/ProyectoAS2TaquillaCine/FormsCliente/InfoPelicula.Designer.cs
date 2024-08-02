
namespace ProyectoAS2TaquillaCine.FormsCliente
{
    partial class InfoPelicula
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
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_sinopsis = new System.Windows.Forms.Label();
            this.byn_back = new System.Windows.Forms.Button();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.btnTrailer = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(731, 51);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(46, 17);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "label1";
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.Location = new System.Drawing.Point(731, 97);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(46, 17);
            this.lbl_duracion.TabIndex = 2;
            this.lbl_duracion.Text = "label2";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Location = new System.Drawing.Point(731, 147);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(46, 17);
            this.lbl_genero.TabIndex = 3;
            this.lbl_genero.Text = "label3";
            // 
            // lbl_sinopsis
            // 
            this.lbl_sinopsis.AutoSize = true;
            this.lbl_sinopsis.Location = new System.Drawing.Point(731, 195);
            this.lbl_sinopsis.Name = "lbl_sinopsis";
            this.lbl_sinopsis.Size = new System.Drawing.Size(46, 17);
            this.lbl_sinopsis.TabIndex = 4;
            this.lbl_sinopsis.Text = "label4";
            // 
            // byn_back
            // 
            this.byn_back.Location = new System.Drawing.Point(12, 12);
            this.byn_back.Name = "byn_back";
            this.byn_back.Size = new System.Drawing.Size(116, 39);
            this.byn_back.TabIndex = 5;
            this.byn_back.Text = "Regresar";
            this.byn_back.UseVisualStyleBackColor = true;
            this.byn_back.Click += new System.EventHandler(this.byn_back_Click_1);
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(339, 24);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(371, 263);
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            // 
            // btnTrailer
            // 
            this.btnTrailer.Location = new System.Drawing.Point(426, 330);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(200, 47);
            this.btnTrailer.TabIndex = 6;
            this.btnTrailer.Text = "Ver trailer";
            this.btnTrailer.UseVisualStyleBackColor = true;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(12, 57);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(116, 39);
            this.btnReserva.TabIndex = 7;
            this.btnReserva.Text = "Reservar";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // InfoPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 432);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.btnTrailer);
            this.Controls.Add(this.byn_back);
            this.Controls.Add(this.lbl_sinopsis);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_duracion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.picbox1);
            this.Name = "InfoPelicula";
            this.Text = "InfoPelicula";
            this.Load += new System.EventHandler(this.InfoPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_sinopsis;
        private System.Windows.Forms.Button byn_back;
        private System.Windows.Forms.Button btnTrailer;
        private System.Windows.Forms.Button btnReserva;
    }
}