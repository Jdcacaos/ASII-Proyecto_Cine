
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class AgregarPeliculas
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
            this.btn_boton4 = new System.Windows.Forms.Button();
            this.lb_fechaSys = new System.Windows.Forms.Label();
            this.panel_panel1 = new System.Windows.Forms.Panel();
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.gpb_ingresar = new System.Windows.Forms.GroupBox();
            this.txtbx_trailer = new System.Windows.Forms.TextBox();
            this.lb_trailer = new System.Windows.Forms.Label();
            this.lb_mantPelicula = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txtbx_imagen = new System.Windows.Forms.TextBox();
            this.txtbx_duracion = new System.Windows.Forms.TextBox();
            this.picbx_imagenPelicula = new System.Windows.Forms.PictureBox();
            this.btn_imagen = new System.Windows.Forms.Button();
            this.txtbx_titulo = new System.Windows.Forms.TextBox();
            this.txtbx_genero = new System.Windows.Forms.TextBox();
            this.lb_imagen = new System.Windows.Forms.Label();
            this.cb_clasificacion = new System.Windows.Forms.ComboBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_genero = new System.Windows.Forms.Label();
            this.cb_productor = new System.Windows.Forms.ComboBox();
            this.lb_duracion = new System.Windows.Forms.Label();
            this.lb_productor = new System.Windows.Forms.Label();
            this.lb_clasificacion = new System.Windows.Forms.Label();
            this.txtbx_sinopsis = new System.Windows.Forms.TextBox();
            this.lb_sinopsis = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.gpb_buscar = new System.Windows.Forms.GroupBox();
            this.txbx_buscar = new System.Windows.Forms.TextBox();
            this.lb_buscar = new System.Windows.Forms.Label();
            this.lb_texto = new System.Windows.Forms.Label();
            this.dgv_peliculas = new System.Windows.Forms.DataGridView();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.tmr_timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_panel2.SuspendLayout();
            this.gpb_ingresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagenPelicula)).BeginInit();
            this.panel_panel3.SuspendLayout();
            this.gpb_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_boton4
            // 
            this.btn_boton4.Location = new System.Drawing.Point(45, 64);
            this.btn_boton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_boton4.Name = "btn_boton4";
            this.btn_boton4.Size = new System.Drawing.Size(121, 41);
            this.btn_boton4.TabIndex = 50;
            this.btn_boton4.Text = "Regresar";
            this.btn_boton4.UseVisualStyleBackColor = true;
            this.btn_boton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_fechaSys
            // 
            this.lb_fechaSys.AutoSize = true;
            this.lb_fechaSys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_fechaSys.Location = new System.Drawing.Point(312, 89);
            this.lb_fechaSys.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaSys.Name = "lb_fechaSys";
            this.lb_fechaSys.Size = new System.Drawing.Size(47, 17);
            this.lb_fechaSys.TabIndex = 45;
            this.lb_fechaSys.Text = "Fecha";
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(1313, 34);
            this.panel_panel1.TabIndex = 74;
            this.panel_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.gpb_ingresar);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Controls.Add(this.lb_fechaSys);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(822, 34);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(491, 754);
            this.panel_panel2.TabIndex = 75;
            // 
            // gpb_ingresar
            // 
            this.gpb_ingresar.Controls.Add(this.txtbx_trailer);
            this.gpb_ingresar.Controls.Add(this.lb_trailer);
            this.gpb_ingresar.Controls.Add(this.lb_mantPelicula);
            this.gpb_ingresar.Controls.Add(this.btn_guardar);
            this.gpb_ingresar.Controls.Add(this.btn_editar);
            this.gpb_ingresar.Controls.Add(this.txtbx_imagen);
            this.gpb_ingresar.Controls.Add(this.btn_eliminar);
            this.gpb_ingresar.Controls.Add(this.txtbx_duracion);
            this.gpb_ingresar.Controls.Add(this.picbx_imagenPelicula);
            this.gpb_ingresar.Controls.Add(this.btn_imagen);
            this.gpb_ingresar.Controls.Add(this.txtbx_titulo);
            this.gpb_ingresar.Controls.Add(this.txtbx_genero);
            this.gpb_ingresar.Controls.Add(this.lb_imagen);
            this.gpb_ingresar.Controls.Add(this.cb_clasificacion);
            this.gpb_ingresar.Controls.Add(this.cb_estado);
            this.gpb_ingresar.Controls.Add(this.lb_titulo);
            this.gpb_ingresar.Controls.Add(this.lb_estado);
            this.gpb_ingresar.Controls.Add(this.lb_genero);
            this.gpb_ingresar.Controls.Add(this.cb_productor);
            this.gpb_ingresar.Controls.Add(this.lb_duracion);
            this.gpb_ingresar.Controls.Add(this.lb_productor);
            this.gpb_ingresar.Controls.Add(this.lb_clasificacion);
            this.gpb_ingresar.Controls.Add(this.txtbx_sinopsis);
            this.gpb_ingresar.Controls.Add(this.lb_sinopsis);
            this.gpb_ingresar.Location = new System.Drawing.Point(4, 126);
            this.gpb_ingresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpb_ingresar.Name = "gpb_ingresar";
            this.gpb_ingresar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpb_ingresar.Size = new System.Drawing.Size(483, 624);
            this.gpb_ingresar.TabIndex = 47;
            this.gpb_ingresar.TabStop = false;
            // 
            // txtbx_trailer
            // 
            this.txtbx_trailer.Location = new System.Drawing.Point(235, 297);
            this.txtbx_trailer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_trailer.Name = "txtbx_trailer";
            this.txtbx_trailer.Size = new System.Drawing.Size(216, 22);
            this.txtbx_trailer.TabIndex = 82;
            // 
            // lb_trailer
            // 
            this.lb_trailer.AutoSize = true;
            this.lb_trailer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trailer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_trailer.Location = new System.Drawing.Point(31, 294);
            this.lb_trailer.Name = "lb_trailer";
            this.lb_trailer.Size = new System.Drawing.Size(118, 26);
            this.lb_trailer.TabIndex = 96;
            this.lb_trailer.Text = "Trailer URL";
            // 
            // lb_mantPelicula
            // 
            this.lb_mantPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantPelicula.AutoSize = true;
            this.lb_mantPelicula.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantPelicula.Location = new System.Drawing.Point(128, 20);
            this.lb_mantPelicula.Name = "lb_mantPelicula";
            this.lb_mantPelicula.Size = new System.Drawing.Size(270, 26);
            this.lb_mantPelicula.TabIndex = 85;
            this.lb_mantPelicula.Text = "Mantenimiento de Pelicula";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.diskette_save_saveas_1514;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(161, 569);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(161, 59);
            this.btn_guardar.TabIndex = 84;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txtbx_imagen
            // 
            this.txtbx_imagen.Location = new System.Drawing.Point(220, 468);
            this.txtbx_imagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_imagen.Name = "txtbx_imagen";
            this.txtbx_imagen.Size = new System.Drawing.Size(208, 22);
            this.txtbx_imagen.TabIndex = 95;
            // 
            // txtbx_duracion
            // 
            this.txtbx_duracion.Location = new System.Drawing.Point(235, 139);
            this.txtbx_duracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_duracion.Name = "txtbx_duracion";
            this.txtbx_duracion.Size = new System.Drawing.Size(216, 22);
            this.txtbx_duracion.TabIndex = 77;
            // 
            // picbx_imagenPelicula
            // 
            this.picbx_imagenPelicula.Location = new System.Drawing.Point(220, 354);
            this.picbx_imagenPelicula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbx_imagenPelicula.Name = "picbx_imagenPelicula";
            this.picbx_imagenPelicula.Size = new System.Drawing.Size(209, 111);
            this.picbx_imagenPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_imagenPelicula.TabIndex = 94;
            this.picbx_imagenPelicula.TabStop = false;
            // 
            // btn_imagen
            // 
            this.btn_imagen.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_imagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_imagen.Location = new System.Drawing.Point(103, 425);
            this.btn_imagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(105, 42);
            this.btn_imagen.TabIndex = 83;
            this.btn_imagen.Text = "Agregar Imagen";
            this.btn_imagen.UseVisualStyleBackColor = false;
            this.btn_imagen.Click += new System.EventHandler(this.btn_imagen_Click);
            // 
            // txtbx_titulo
            // 
            this.txtbx_titulo.Location = new System.Drawing.Point(235, 80);
            this.txtbx_titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_titulo.Name = "txtbx_titulo";
            this.txtbx_titulo.Size = new System.Drawing.Size(216, 22);
            this.txtbx_titulo.TabIndex = 75;
            // 
            // txtbx_genero
            // 
            this.txtbx_genero.Location = new System.Drawing.Point(235, 110);
            this.txtbx_genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_genero.Name = "txtbx_genero";
            this.txtbx_genero.Size = new System.Drawing.Size(216, 22);
            this.txtbx_genero.TabIndex = 76;
            // 
            // lb_imagen
            // 
            this.lb_imagen.AutoSize = true;
            this.lb_imagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_imagen.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_imagen.Location = new System.Drawing.Point(40, 354);
            this.lb_imagen.Name = "lb_imagen";
            this.lb_imagen.Size = new System.Drawing.Size(84, 26);
            this.lb_imagen.TabIndex = 93;
            this.lb_imagen.Text = "Imagen";
            // 
            // cb_clasificacion
            // 
            this.cb_clasificacion.FormattingEnabled = true;
            this.cb_clasificacion.Location = new System.Drawing.Point(235, 171);
            this.cb_clasificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_clasificacion.Name = "cb_clasificacion";
            this.cb_clasificacion.Size = new System.Drawing.Size(216, 24);
            this.cb_clasificacion.TabIndex = 78;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(235, 262);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(216, 24);
            this.cb_estado.TabIndex = 81;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_titulo.Location = new System.Drawing.Point(31, 76);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(68, 26);
            this.lb_titulo.TabIndex = 86;
            this.lb_titulo.Text = "Titulo";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_estado.Location = new System.Drawing.Point(31, 262);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(76, 26);
            this.lb_estado.TabIndex = 92;
            this.lb_estado.Text = "Estado";
            // 
            // lb_genero
            // 
            this.lb_genero.AutoSize = true;
            this.lb_genero.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_genero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_genero.Location = new System.Drawing.Point(31, 110);
            this.lb_genero.Name = "lb_genero";
            this.lb_genero.Size = new System.Drawing.Size(81, 26);
            this.lb_genero.TabIndex = 87;
            this.lb_genero.Text = "Género";
            // 
            // cb_productor
            // 
            this.cb_productor.FormattingEnabled = true;
            this.cb_productor.Location = new System.Drawing.Point(235, 231);
            this.cb_productor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_productor.Name = "cb_productor";
            this.cb_productor.Size = new System.Drawing.Size(216, 24);
            this.cb_productor.TabIndex = 80;
            // 
            // lb_duracion
            // 
            this.lb_duracion.AutoSize = true;
            this.lb_duracion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_duracion.Location = new System.Drawing.Point(31, 139);
            this.lb_duracion.Name = "lb_duracion";
            this.lb_duracion.Size = new System.Drawing.Size(196, 26);
            this.lb_duracion.TabIndex = 88;
            this.lb_duracion.Text = "Duración (minutos)";
            // 
            // lb_productor
            // 
            this.lb_productor.AutoSize = true;
            this.lb_productor.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_productor.Location = new System.Drawing.Point(31, 231);
            this.lb_productor.Name = "lb_productor";
            this.lb_productor.Size = new System.Drawing.Size(107, 26);
            this.lb_productor.TabIndex = 91;
            this.lb_productor.Text = "Productor";
            // 
            // lb_clasificacion
            // 
            this.lb_clasificacion.AutoSize = true;
            this.lb_clasificacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clasificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_clasificacion.Location = new System.Drawing.Point(31, 171);
            this.lb_clasificacion.Name = "lb_clasificacion";
            this.lb_clasificacion.Size = new System.Drawing.Size(132, 26);
            this.lb_clasificacion.TabIndex = 89;
            this.lb_clasificacion.Text = "Clasificación";
            // 
            // txtbx_sinopsis
            // 
            this.txtbx_sinopsis.Location = new System.Drawing.Point(235, 202);
            this.txtbx_sinopsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_sinopsis.Name = "txtbx_sinopsis";
            this.txtbx_sinopsis.Size = new System.Drawing.Size(216, 22);
            this.txtbx_sinopsis.TabIndex = 79;
            // 
            // lb_sinopsis
            // 
            this.lb_sinopsis.AutoSize = true;
            this.lb_sinopsis.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sinopsis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_sinopsis.Location = new System.Drawing.Point(31, 201);
            this.lb_sinopsis.Name = "lb_sinopsis";
            this.lb_sinopsis.Size = new System.Drawing.Size(90, 26);
            this.lb_sinopsis.TabIndex = 90;
            this.lb_sinopsis.Text = "Sinopsis";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(312, 25);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(121, 41);
            this.btn_regresar.TabIndex = 12;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.gpb_buscar);
            this.panel_panel3.Controls.Add(this.lb_texto);
            this.panel_panel3.Controls.Add(this.dgv_peliculas);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 34);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(822, 754);
            this.panel_panel3.TabIndex = 76;
            // 
            // gpb_buscar
            // 
            this.gpb_buscar.Controls.Add(this.txbx_buscar);
            this.gpb_buscar.Controls.Add(this.lb_buscar);
            this.gpb_buscar.Location = new System.Drawing.Point(0, 0);
            this.gpb_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpb_buscar.Name = "gpb_buscar";
            this.gpb_buscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpb_buscar.Size = new System.Drawing.Size(812, 65);
            this.gpb_buscar.TabIndex = 181;
            this.gpb_buscar.TabStop = false;
            // 
            // txbx_buscar
            // 
            this.txbx_buscar.Location = new System.Drawing.Point(95, 16);
            this.txbx_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbx_buscar.Multiline = true;
            this.txbx_buscar.Name = "txbx_buscar";
            this.txbx_buscar.Size = new System.Drawing.Size(708, 37);
            this.txbx_buscar.TabIndex = 182;
            this.txbx_buscar.TextChanged += new System.EventHandler(this.txtbxBuscar_TextChanged);
            // 
            // lb_buscar
            // 
            this.lb_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_buscar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_buscar.Location = new System.Drawing.Point(-5, 20);
            this.lb_buscar.Name = "lb_buscar";
            this.lb_buscar.Size = new System.Drawing.Size(103, 32);
            this.lb_buscar.TabIndex = 181;
            this.lb_buscar.Text = "Buscar";
            this.lb_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_buscar.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lb_texto
            // 
            this.lb_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_texto.Location = new System.Drawing.Point(239, 178);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(270, 26);
            this.lb_texto.TabIndex = 75;
            this.lb_texto.Text = "Mantenimiento de Pelicula";
            // 
            // dgv_peliculas
            // 
            this.dgv_peliculas.AllowUserToAddRows = false;
            this.dgv_peliculas.AllowUserToDeleteRows = false;
            this.dgv_peliculas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_peliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_peliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peliculas.Location = new System.Drawing.Point(16, 241);
            this.dgv_peliculas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_peliculas.Name = "dgv_peliculas";
            this.dgv_peliculas.ReadOnly = true;
            this.dgv_peliculas.RowHeadersWidth = 51;
            this.dgv_peliculas.RowTemplate.Height = 50;
            this.dgv_peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_peliculas.Size = new System.Drawing.Size(795, 407);
            this.dgv_peliculas.TabIndex = 183;
            this.dgv_peliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_peliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(124, 74);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(512, 105);
            this.lb_cinehub.TabIndex = 182;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.editsquare_120033;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(17, 567);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(125, 48);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.delete_button_6303088;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(330, 567);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(131, 48);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button6_Click);
            // 
            // tmr_timer1
            // 
            this.tmr_timer1.Tick += new System.EventHandler(this.tmr_timer1_Tick);
            // 
            // AgregarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 788);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.Controls.Add(this.btn_boton4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarPeliculas";
            this.Text = "AgregarPelicuals";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.gpb_ingresar.ResumeLayout(false);
            this.gpb_ingresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagenPelicula)).EndInit();
            this.panel_panel3.ResumeLayout(false);
            this.panel_panel3.PerformLayout();
            this.gpb_buscar.ResumeLayout(false);
            this.gpb_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_boton4;
        private System.Windows.Forms.Label lb_fechaSys;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dgv_peliculas;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.GroupBox gpb_buscar;
        private System.Windows.Forms.TextBox txbx_buscar;
        private System.Windows.Forms.Label lb_buscar;
        private System.Windows.Forms.GroupBox gpb_ingresar;
        private System.Windows.Forms.TextBox txtbx_trailer;
        private System.Windows.Forms.Label lb_trailer;
        private System.Windows.Forms.Label lb_mantPelicula;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txtbx_imagen;
        private System.Windows.Forms.TextBox txtbx_duracion;
        private System.Windows.Forms.PictureBox picbx_imagenPelicula;
        private System.Windows.Forms.Button btn_imagen;
        private System.Windows.Forms.TextBox txtbx_titulo;
        private System.Windows.Forms.TextBox txtbx_genero;
        private System.Windows.Forms.Label lb_imagen;
        private System.Windows.Forms.ComboBox cb_clasificacion;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_genero;
        private System.Windows.Forms.ComboBox cb_productor;
        private System.Windows.Forms.Label lb_duracion;
        private System.Windows.Forms.Label lb_productor;
        private System.Windows.Forms.Label lb_clasificacion;
        private System.Windows.Forms.TextBox txtbx_sinopsis;
        private System.Windows.Forms.Label lb_sinopsis;
        private System.Windows.Forms.Timer tmr_timer1;
    }
}