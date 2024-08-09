
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
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_duracion = new System.Windows.Forms.Label();
            this.lb_genero = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_reserva = new System.Windows.Forms.Button();
            this.btn_trailer = new System.Windows.Forms.Button();
            this.picbx_imagenPelicula = new System.Windows.Forms.PictureBox();
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.lb_sinopsis = new System.Windows.Forms.Label();
            this.txtbx_sinopsis = new System.Windows.Forms.TextBox();
            this.panel_panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagenPelicula)).BeginInit();
            this.panel_panel2.SuspendLayout();
            this.panel_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nombre.Location = new System.Drawing.Point(14, 9);
            this.lb_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(54, 19);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "label1";
            // 
            // lb_duracion
            // 
            this.lb_duracion.AutoSize = true;
            this.lb_duracion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duracion.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_duracion.Location = new System.Drawing.Point(14, 41);
            this.lb_duracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_duracion.Name = "lb_duracion";
            this.lb_duracion.Size = new System.Drawing.Size(54, 19);
            this.lb_duracion.TabIndex = 2;
            this.lb_duracion.Text = "label2";
            // 
            // lb_genero
            // 
            this.lb_genero.AutoSize = true;
            this.lb_genero.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_genero.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_genero.Location = new System.Drawing.Point(14, 73);
            this.lb_genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_genero.Name = "lb_genero";
            this.lb_genero.Size = new System.Drawing.Size(54, 19);
            this.lb_genero.TabIndex = 3;
            this.lb_genero.Text = "label3";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regresar.Location = new System.Drawing.Point(-3, 10);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(127, 43);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.byn_back_Click_1);
            // 
            // btn_reserva
            // 
            this.btn_reserva.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_reserva.BackgroundImage = global::ProyectoAS2TaquillaCine.Properties.Resources.reserva__2_;
            this.btn_reserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_reserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserva.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_reserva.Location = new System.Drawing.Point(266, 307);
            this.btn_reserva.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reserva.Name = "btn_reserva";
            this.btn_reserva.Size = new System.Drawing.Size(149, 55);
            this.btn_reserva.TabIndex = 1;
            this.btn_reserva.Text = "Reservar";
            this.btn_reserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reserva.UseVisualStyleBackColor = false;
            this.btn_reserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btn_trailer
            // 
            this.btn_trailer.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_trailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trailer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trailer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_trailer.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.remolque;
            this.btn_trailer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_trailer.Location = new System.Drawing.Point(475, 305);
            this.btn_trailer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_trailer.Name = "btn_trailer";
            this.btn_trailer.Size = new System.Drawing.Size(115, 57);
            this.btn_trailer.TabIndex = 2;
            this.btn_trailer.Text = "Ver trailer";
            this.btn_trailer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_trailer.UseVisualStyleBackColor = false;
            this.btn_trailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // picbx_imagenPelicula
            // 
            this.picbx_imagenPelicula.Location = new System.Drawing.Point(26, 32);
            this.picbx_imagenPelicula.Margin = new System.Windows.Forms.Padding(2);
            this.picbx_imagenPelicula.Name = "picbx_imagenPelicula";
            this.picbx_imagenPelicula.Size = new System.Drawing.Size(278, 214);
            this.picbx_imagenPelicula.TabIndex = 0;
            this.picbx_imagenPelicula.TabStop = false;
            this.picbx_imagenPelicula.Click += new System.EventHandler(this.picbox1_Click);
            // 
            // panel_panel2
            // 
            this.panel_panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_panel2.Controls.Add(this.lb_sinopsis);
            this.panel_panel2.Controls.Add(this.txtbx_sinopsis);
            this.panel_panel2.Controls.Add(this.lb_nombre);
            this.panel_panel2.Controls.Add(this.lb_duracion);
            this.panel_panel2.Controls.Add(this.lb_genero);
            this.panel_panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel_panel2.Location = new System.Drawing.Point(322, 2);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(317, 277);
            this.panel_panel2.TabIndex = 161;
            // 
            // lb_sinopsis
            // 
            this.lb_sinopsis.AutoSize = true;
            this.lb_sinopsis.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sinopsis.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_sinopsis.Location = new System.Drawing.Point(17, 116);
            this.lb_sinopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sinopsis.Name = "lb_sinopsis";
            this.lb_sinopsis.Size = new System.Drawing.Size(70, 19);
            this.lb_sinopsis.TabIndex = 8;
            this.lb_sinopsis.Text = "Sinopsis";
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
            // panel_panel1
            // 
            this.panel_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_panel1.Controls.Add(this.panel_panel2);
            this.panel_panel1.Controls.Add(this.picbx_imagenPelicula);
            this.panel_panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel_panel1.Location = new System.Drawing.Point(124, 10);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(643, 277);
            this.panel_panel1.TabIndex = 162;
            // 
            // InfoPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(896, 395);
            this.Controls.Add(this.panel_panel1);
            this.Controls.Add(this.btn_trailer);
            this.Controls.Add(this.btn_reserva);
            this.Controls.Add(this.btn_regresar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InfoPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPelicula";
            this.Load += new System.EventHandler(this.InfoPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagenPelicula)).EndInit();
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.panel_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_imagenPelicula;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_duracion;
        private System.Windows.Forms.Label lb_genero;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_trailer;
        private System.Windows.Forms.Button btn_reserva;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.TextBox txtbx_sinopsis;
        private System.Windows.Forms.Label lb_sinopsis;
    }
}