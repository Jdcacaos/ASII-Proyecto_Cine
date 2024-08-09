
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
            this.byn_back = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnTrailer = new System.Windows.Forms.Button();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbx_sinopsis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_nombre.Location = new System.Drawing.Point(14, 9);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 19);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "label1";
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duracion.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_duracion.Location = new System.Drawing.Point(14, 41);
            this.lbl_duracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(54, 19);
            this.lbl_duracion.TabIndex = 2;
            this.lbl_duracion.Text = "label2";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_genero.Location = new System.Drawing.Point(14, 73);
            this.lbl_genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(54, 19);
            this.lbl_genero.TabIndex = 3;
            this.lbl_genero.Text = "label3";
            // 
            // byn_back
            // 
            this.byn_back.BackColor = System.Drawing.Color.Red;
            this.byn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byn_back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.byn_back.Location = new System.Drawing.Point(-3, 10);
            this.byn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.byn_back.Name = "byn_back";
            this.byn_back.Size = new System.Drawing.Size(127, 43);
            this.byn_back.TabIndex = 5;
            this.byn_back.Text = "Regresar";
            this.byn_back.UseVisualStyleBackColor = false;
            this.byn_back.Click += new System.EventHandler(this.byn_back_Click_1);
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReserva.BackgroundImage = global::ProyectoAS2TaquillaCine.Properties.Resources.reserva__2_;
            this.btnReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReserva.Location = new System.Drawing.Point(266, 307);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(149, 55);
            this.btnReserva.TabIndex = 7;
            this.btnReserva.Text = "Reservar";
            this.btnReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnTrailer
            // 
            this.btnTrailer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTrailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrailer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrailer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnTrailer.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.remolque;
            this.btnTrailer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrailer.Location = new System.Drawing.Point(475, 305);
            this.btnTrailer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(115, 57);
            this.btnTrailer.TabIndex = 6;
            this.btnTrailer.Text = "Ver trailer";
            this.btnTrailer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrailer.UseVisualStyleBackColor = false;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(26, 32);
            this.picbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(278, 214);
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            this.picbox1.Click += new System.EventHandler(this.picbox1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtbx_sinopsis);
            this.panel2.Controls.Add(this.lbl_nombre);
            this.panel2.Controls.Add(this.lbl_duracion);
            this.panel2.Controls.Add(this.lbl_genero);
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(322, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 277);
            this.panel2.TabIndex = 161;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picbox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(124, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 277);
            this.panel1.TabIndex = 162;
            // 
            // txtbx_sinopsis
            // 
            this.txtbx_sinopsis.BackColor = System.Drawing.Color.SteelBlue;
            this.txtbx_sinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_sinopsis.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtbx_sinopsis.Location = new System.Drawing.Point(18, 138);
            this.txtbx_sinopsis.Multiline = true;
            this.txtbx_sinopsis.Name = "txtbx_sinopsis";
            this.txtbx_sinopsis.Size = new System.Drawing.Size(278, 105);
            this.txtbx_sinopsis.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(17, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sinopsis";
            // 
            // InfoPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(896, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTrailer);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.byn_back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPelicula";
            this.Load += new System.EventHandler(this.InfoPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Button byn_back;
        private System.Windows.Forms.Button btnTrailer;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbx_sinopsis;
        private System.Windows.Forms.Label label1;
    }
}