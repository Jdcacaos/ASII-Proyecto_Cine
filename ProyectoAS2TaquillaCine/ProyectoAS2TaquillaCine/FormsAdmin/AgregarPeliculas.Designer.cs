
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.dgv_peliculas = new System.Windows.Forms.DataGridView();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbbuscar = new System.Windows.Forms.GroupBox();
            this.txtbxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.txtbx_trailer = new System.Windows.Forms.TextBox();
            this.lb_trailer = new System.Windows.Forms.Label();
            this.lb_mantPelicula = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txtbx_imagen = new System.Windows.Forms.TextBox();
            this.txtbx_duracion = new System.Windows.Forms.TextBox();
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
            this.tmr_timer1 = new System.Windows.Forms.Timer(this.components);
            this.picbx_imagenPelicula = new System.Windows.Forms.PictureBox();
            this.panel_panel2.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).BeginInit();
            this.gbbuscar.SuspendLayout();
            this.gbIngresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagenPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_boton4
            // 
            this.btn_boton4.Location = new System.Drawing.Point(34, 52);
            this.btn_boton4.Name = "btn_boton4";
            this.btn_boton4.Size = new System.Drawing.Size(91, 33);
            this.btn_boton4.TabIndex = 50;
            this.btn_boton4.Text = "Regresar";
            this.btn_boton4.UseVisualStyleBackColor = true;
            this.btn_boton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_fechaSys
            // 
            this.lb_fechaSys.AutoSize = true;
            this.lb_fechaSys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_fechaSys.Location = new System.Drawing.Point(234, 72);
            this.lb_fechaSys.Name = "lb_fechaSys";
            this.lb_fechaSys.Size = new System.Drawing.Size(37, 13);
            this.lb_fechaSys.TabIndex = 45;
            this.lb_fechaSys.Text = "Fecha";
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(985, 28);
            this.panel_panel1.TabIndex = 74;
            this.panel_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.gbIngresar);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Controls.Add(this.lb_fechaSys);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(617, 28);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(368, 612);
            this.panel_panel2.TabIndex = 75;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(234, 20);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(91, 33);
            this.btn_regresar.TabIndex = 12;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.gbbuscar);
            this.panel_panel3.Controls.Add(this.label1);
            this.panel_panel3.Controls.Add(this.dgv_peliculas);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Controls.Add(this.btn_editar);
            this.panel_panel3.Controls.Add(this.btn_eliminar);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 28);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(617, 612);
            this.panel_panel3.TabIndex = 76;
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
            this.dgv_peliculas.Location = new System.Drawing.Point(12, 196);
            this.dgv_peliculas.Name = "dgv_peliculas";
            this.dgv_peliculas.ReadOnly = true;
            this.dgv_peliculas.RowHeadersWidth = 51;
            this.dgv_peliculas.RowTemplate.Height = 50;
            this.dgv_peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_peliculas.Size = new System.Drawing.Size(597, 331);
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
            this.lb_cinehub.Location = new System.Drawing.Point(93, 60);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(384, 85);
            this.lb_cinehub.TabIndex = 182;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Location = new System.Drawing.Point(12, 547);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(119, 39);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Location = new System.Drawing.Point(147, 547);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(111, 39);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(179, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "Mantenimiento de Pelicula";
            // 
            // gbbuscar
            // 
            this.gbbuscar.Controls.Add(this.txtbxBuscar);
            this.gbbuscar.Controls.Add(this.label2);
            this.gbbuscar.Location = new System.Drawing.Point(0, 0);
            this.gbbuscar.Name = "gbbuscar";
            this.gbbuscar.Size = new System.Drawing.Size(609, 53);
            this.gbbuscar.TabIndex = 181;
            this.gbbuscar.TabStop = false;
            // 
            // txtbxBuscar
            // 
            this.txtbxBuscar.Location = new System.Drawing.Point(71, 13);
            this.txtbxBuscar.Multiline = true;
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(532, 31);
            this.txtbxBuscar.TabIndex = 182;
            this.txtbxBuscar.TextChanged += new System.EventHandler(this.txtbxBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(-4, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 181;
            this.label2.Text = "Buscar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.txtbx_trailer);
            this.gbIngresar.Controls.Add(this.lb_trailer);
            this.gbIngresar.Controls.Add(this.lb_mantPelicula);
            this.gbIngresar.Controls.Add(this.btn_guardar);
            this.gbIngresar.Controls.Add(this.txtbx_imagen);
            this.gbIngresar.Controls.Add(this.txtbx_duracion);
            this.gbIngresar.Controls.Add(this.picbx_imagenPelicula);
            this.gbIngresar.Controls.Add(this.btn_imagen);
            this.gbIngresar.Controls.Add(this.txtbx_titulo);
            this.gbIngresar.Controls.Add(this.txtbx_genero);
            this.gbIngresar.Controls.Add(this.lb_imagen);
            this.gbIngresar.Controls.Add(this.cb_clasificacion);
            this.gbIngresar.Controls.Add(this.cb_estado);
            this.gbIngresar.Controls.Add(this.lb_titulo);
            this.gbIngresar.Controls.Add(this.lb_estado);
            this.gbIngresar.Controls.Add(this.lb_genero);
            this.gbIngresar.Controls.Add(this.cb_productor);
            this.gbIngresar.Controls.Add(this.lb_duracion);
            this.gbIngresar.Controls.Add(this.lb_productor);
            this.gbIngresar.Controls.Add(this.lb_clasificacion);
            this.gbIngresar.Controls.Add(this.txtbx_sinopsis);
            this.gbIngresar.Controls.Add(this.lb_sinopsis);
            this.gbIngresar.Location = new System.Drawing.Point(3, 102);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(362, 507);
            this.gbIngresar.TabIndex = 47;
            this.gbIngresar.TabStop = false;
            // 
            // txtbx_trailer
            // 
            this.txtbx_trailer.Location = new System.Drawing.Point(176, 241);
            this.txtbx_trailer.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_trailer.Name = "txtbx_trailer";
            this.txtbx_trailer.Size = new System.Drawing.Size(163, 20);
            this.txtbx_trailer.TabIndex = 82;
            // 
            // lb_trailer
            // 
            this.lb_trailer.AutoSize = true;
            this.lb_trailer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trailer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_trailer.Location = new System.Drawing.Point(23, 239);
            this.lb_trailer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_trailer.Name = "lb_trailer";
            this.lb_trailer.Size = new System.Drawing.Size(90, 19);
            this.lb_trailer.TabIndex = 96;
            this.lb_trailer.Text = "Trailer URL";
            // 
            // lb_mantPelicula
            // 
            this.lb_mantPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantPelicula.AutoSize = true;
            this.lb_mantPelicula.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantPelicula.Location = new System.Drawing.Point(96, 16);
            this.lb_mantPelicula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mantPelicula.Name = "lb_mantPelicula";
            this.lb_mantPelicula.Size = new System.Drawing.Size(211, 19);
            this.lb_mantPelicula.TabIndex = 85;
            this.lb_mantPelicula.Text = "Mantenimiento de Pelicula";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Location = new System.Drawing.Point(63, 449);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(237, 41);
            this.btn_guardar.TabIndex = 84;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // txtbx_imagen
            // 
            this.txtbx_imagen.Location = new System.Drawing.Point(165, 380);
            this.txtbx_imagen.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_imagen.Name = "txtbx_imagen";
            this.txtbx_imagen.Size = new System.Drawing.Size(157, 20);
            this.txtbx_imagen.TabIndex = 95;
            // 
            // txtbx_duracion
            // 
            this.txtbx_duracion.Location = new System.Drawing.Point(176, 113);
            this.txtbx_duracion.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_duracion.Name = "txtbx_duracion";
            this.txtbx_duracion.Size = new System.Drawing.Size(163, 20);
            this.txtbx_duracion.TabIndex = 77;
            // 
            // btn_imagen
            // 
            this.btn_imagen.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_imagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_imagen.Location = new System.Drawing.Point(77, 345);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(79, 34);
            this.btn_imagen.TabIndex = 83;
            this.btn_imagen.Text = "Agregar Imagen";
            this.btn_imagen.UseVisualStyleBackColor = false;
            // 
            // txtbx_titulo
            // 
            this.txtbx_titulo.Location = new System.Drawing.Point(176, 65);
            this.txtbx_titulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_titulo.Name = "txtbx_titulo";
            this.txtbx_titulo.Size = new System.Drawing.Size(163, 20);
            this.txtbx_titulo.TabIndex = 75;
            // 
            // txtbx_genero
            // 
            this.txtbx_genero.Location = new System.Drawing.Point(176, 89);
            this.txtbx_genero.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_genero.Name = "txtbx_genero";
            this.txtbx_genero.Size = new System.Drawing.Size(163, 20);
            this.txtbx_genero.TabIndex = 76;
            // 
            // lb_imagen
            // 
            this.lb_imagen.AutoSize = true;
            this.lb_imagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_imagen.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_imagen.Location = new System.Drawing.Point(30, 288);
            this.lb_imagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_imagen.Name = "lb_imagen";
            this.lb_imagen.Size = new System.Drawing.Size(67, 19);
            this.lb_imagen.TabIndex = 93;
            this.lb_imagen.Text = "Imagen";
            // 
            // cb_clasificacion
            // 
            this.cb_clasificacion.FormattingEnabled = true;
            this.cb_clasificacion.Location = new System.Drawing.Point(176, 139);
            this.cb_clasificacion.Margin = new System.Windows.Forms.Padding(2);
            this.cb_clasificacion.Name = "cb_clasificacion";
            this.cb_clasificacion.Size = new System.Drawing.Size(163, 21);
            this.cb_clasificacion.TabIndex = 78;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(176, 213);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(163, 21);
            this.cb_estado.TabIndex = 81;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_titulo.Location = new System.Drawing.Point(23, 62);
            this.lb_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(52, 19);
            this.lb_titulo.TabIndex = 86;
            this.lb_titulo.Text = "Titulo";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_estado.Location = new System.Drawing.Point(23, 213);
            this.lb_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(60, 19);
            this.lb_estado.TabIndex = 92;
            this.lb_estado.Text = "Estado";
            // 
            // lb_genero
            // 
            this.lb_genero.AutoSize = true;
            this.lb_genero.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_genero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_genero.Location = new System.Drawing.Point(23, 89);
            this.lb_genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_genero.Name = "lb_genero";
            this.lb_genero.Size = new System.Drawing.Size(64, 19);
            this.lb_genero.TabIndex = 87;
            this.lb_genero.Text = "Género";
            // 
            // cb_productor
            // 
            this.cb_productor.FormattingEnabled = true;
            this.cb_productor.Location = new System.Drawing.Point(176, 188);
            this.cb_productor.Margin = new System.Windows.Forms.Padding(2);
            this.cb_productor.Name = "cb_productor";
            this.cb_productor.Size = new System.Drawing.Size(163, 21);
            this.cb_productor.TabIndex = 80;
            // 
            // lb_duracion
            // 
            this.lb_duracion.AutoSize = true;
            this.lb_duracion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_duracion.Location = new System.Drawing.Point(23, 113);
            this.lb_duracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_duracion.Name = "lb_duracion";
            this.lb_duracion.Size = new System.Drawing.Size(156, 19);
            this.lb_duracion.TabIndex = 88;
            this.lb_duracion.Text = "Duración (minutos)";
            // 
            // lb_productor
            // 
            this.lb_productor.AutoSize = true;
            this.lb_productor.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_productor.Location = new System.Drawing.Point(23, 188);
            this.lb_productor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_productor.Name = "lb_productor";
            this.lb_productor.Size = new System.Drawing.Size(85, 19);
            this.lb_productor.TabIndex = 91;
            this.lb_productor.Text = "Productor";
            // 
            // lb_clasificacion
            // 
            this.lb_clasificacion.AutoSize = true;
            this.lb_clasificacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clasificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_clasificacion.Location = new System.Drawing.Point(23, 139);
            this.lb_clasificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_clasificacion.Name = "lb_clasificacion";
            this.lb_clasificacion.Size = new System.Drawing.Size(102, 19);
            this.lb_clasificacion.TabIndex = 89;
            this.lb_clasificacion.Text = "Clasificación";
            // 
            // txtbx_sinopsis
            // 
            this.txtbx_sinopsis.Location = new System.Drawing.Point(176, 164);
            this.txtbx_sinopsis.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_sinopsis.Name = "txtbx_sinopsis";
            this.txtbx_sinopsis.Size = new System.Drawing.Size(163, 20);
            this.txtbx_sinopsis.TabIndex = 79;
            // 
            // lb_sinopsis
            // 
            this.lb_sinopsis.AutoSize = true;
            this.lb_sinopsis.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sinopsis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_sinopsis.Location = new System.Drawing.Point(23, 163);
            this.lb_sinopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sinopsis.Name = "lb_sinopsis";
            this.lb_sinopsis.Size = new System.Drawing.Size(70, 19);
            this.lb_sinopsis.TabIndex = 90;
            this.lb_sinopsis.Text = "Sinopsis";
            // 
            // tmr_timer1
            // 
            this.tmr_timer1.Tick += new System.EventHandler(this.tmr_timer1_Tick);
            // 
            // picbx_imagenPelicula
            // 
            this.picbx_imagenPelicula.Location = new System.Drawing.Point(165, 288);
            this.picbx_imagenPelicula.Name = "picbx_imagenPelicula";
            this.picbx_imagenPelicula.Size = new System.Drawing.Size(157, 90);
            this.picbx_imagenPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_imagenPelicula.TabIndex = 94;
            this.picbx_imagenPelicula.TabStop = false;
            // 
            // AgregarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 640);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.Controls.Add(this.btn_boton4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPeliculas";
            this.Text = "AgregarPelicuals";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.panel_panel3.ResumeLayout(false);
            this.panel_panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).EndInit();
            this.gbbuscar.ResumeLayout(false);
            this.gbbuscar.PerformLayout();
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagenPelicula)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbbuscar;
        private System.Windows.Forms.TextBox txtbxBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbIngresar;
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