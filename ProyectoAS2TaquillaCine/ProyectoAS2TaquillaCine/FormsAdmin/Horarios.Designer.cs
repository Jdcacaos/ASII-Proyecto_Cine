
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class Horarios
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
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.txtbx_3ra = new System.Windows.Forms.TextBox();
            this.txtbx_adulto = new System.Windows.Forms.TextBox();
            this.txtbx_nino = new System.Windows.Forms.TextBox();
            this.lb_precio3ra = new System.Windows.Forms.Label();
            this.lb_precioAdulto = new System.Windows.Forms.Label();
            this.lb_precioNino = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lb_mantHorario = new System.Windows.Forms.Label();
            this.dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.lb_hora = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_sala = new System.Windows.Forms.Label();
            this.lb_pelicula = new System.Windows.Forms.Label();
            this.cb_Pelicula = new System.Windows.Forms.ComboBox();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.cb_id_Sala = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.gbbuscar = new System.Windows.Forms.GroupBox();
            this.txtbxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_horario = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.panel_panel1 = new System.Windows.Forms.Panel();
            this.tmr_timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_panel2.SuspendLayout();
            this.gbIngresar.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            this.gbbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_boton4
            // 
            this.btn_boton4.Location = new System.Drawing.Point(12, 12);
            this.btn_boton4.Name = "btn_boton4";
            this.btn_boton4.Size = new System.Drawing.Size(91, 33);
            this.btn_boton4.TabIndex = 40;
            this.btn_boton4.Text = "Regresar";
            this.btn_boton4.UseVisualStyleBackColor = true;
            this.btn_boton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_fechaSys
            // 
            this.lb_fechaSys.AutoSize = true;
            this.lb_fechaSys.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fechaSys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_fechaSys.Location = new System.Drawing.Point(189, 56);
            this.lb_fechaSys.Name = "lb_fechaSys";
            this.lb_fechaSys.Size = new System.Drawing.Size(53, 19);
            this.lb_fechaSys.TabIndex = 35;
            this.lb_fechaSys.Text = "Fecha";
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.gbIngresar);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Controls.Add(this.lb_fechaSys);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(672, 28);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(368, 612);
            this.panel_panel2.TabIndex = 55;
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.txtbx_3ra);
            this.gbIngresar.Controls.Add(this.txtbx_adulto);
            this.gbIngresar.Controls.Add(this.txtbx_nino);
            this.gbIngresar.Controls.Add(this.lb_precio3ra);
            this.gbIngresar.Controls.Add(this.lb_precioAdulto);
            this.gbIngresar.Controls.Add(this.lb_precioNino);
            this.gbIngresar.Controls.Add(this.btn_guardar);
            this.gbIngresar.Controls.Add(this.lb_mantHorario);
            this.gbIngresar.Controls.Add(this.dtp_hora);
            this.gbIngresar.Controls.Add(this.lb_hora);
            this.gbIngresar.Controls.Add(this.lb_estado);
            this.gbIngresar.Controls.Add(this.lb_fecha);
            this.gbIngresar.Controls.Add(this.lb_sala);
            this.gbIngresar.Controls.Add(this.lb_pelicula);
            this.gbIngresar.Controls.Add(this.cb_Pelicula);
            this.gbIngresar.Controls.Add(this.cb_Estado);
            this.gbIngresar.Controls.Add(this.cb_id_Sala);
            this.gbIngresar.Controls.Add(this.dtp_fecha);
            this.gbIngresar.Location = new System.Drawing.Point(0, 126);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(368, 540);
            this.gbIngresar.TabIndex = 37;
            this.gbIngresar.TabStop = false;
            // 
            // txtbx_3ra
            // 
            this.txtbx_3ra.Location = new System.Drawing.Point(195, 340);
            this.txtbx_3ra.Name = "txtbx_3ra";
            this.txtbx_3ra.Size = new System.Drawing.Size(121, 20);
            this.txtbx_3ra.TabIndex = 65;
            // 
            // txtbx_adulto
            // 
            this.txtbx_adulto.Location = new System.Drawing.Point(195, 305);
            this.txtbx_adulto.Name = "txtbx_adulto";
            this.txtbx_adulto.Size = new System.Drawing.Size(121, 20);
            this.txtbx_adulto.TabIndex = 64;
            // 
            // txtbx_nino
            // 
            this.txtbx_nino.Location = new System.Drawing.Point(195, 266);
            this.txtbx_nino.Name = "txtbx_nino";
            this.txtbx_nino.Size = new System.Drawing.Size(121, 20);
            this.txtbx_nino.TabIndex = 63;
            // 
            // lb_precio3ra
            // 
            this.lb_precio3ra.AutoSize = true;
            this.lb_precio3ra.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precio3ra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_precio3ra.Location = new System.Drawing.Point(53, 339);
            this.lb_precio3ra.Name = "lb_precio3ra";
            this.lb_precio3ra.Size = new System.Drawing.Size(126, 19);
            this.lb_precio3ra.TabIndex = 75;
            this.lb_precio3ra.Text = "Precio 3ra Edad";
            // 
            // lb_precioAdulto
            // 
            this.lb_precioAdulto.AutoSize = true;
            this.lb_precioAdulto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precioAdulto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_precioAdulto.Location = new System.Drawing.Point(53, 304);
            this.lb_precioAdulto.Name = "lb_precioAdulto";
            this.lb_precioAdulto.Size = new System.Drawing.Size(111, 19);
            this.lb_precioAdulto.TabIndex = 74;
            this.lb_precioAdulto.Text = "Precio Adulto";
            // 
            // lb_precioNino
            // 
            this.lb_precioNino.AutoSize = true;
            this.lb_precioNino.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precioNino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_precioNino.Location = new System.Drawing.Point(53, 265);
            this.lb_precioNino.Name = "lb_precioNino";
            this.lb_precioNino.Size = new System.Drawing.Size(97, 19);
            this.lb_precioNino.TabIndex = 73;
            this.lb_precioNino.Text = "Precio Niño";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.diskette_save_saveas_1514;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(133, 411);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(134, 63);
            this.btn_guardar.TabIndex = 66;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lb_mantHorario
            // 
            this.lb_mantHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantHorario.AutoSize = true;
            this.lb_mantHorario.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantHorario.Location = new System.Drawing.Point(80, 17);
            this.lb_mantHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mantHorario.Name = "lb_mantHorario";
            this.lb_mantHorario.Size = new System.Drawing.Size(210, 19);
            this.lb_mantHorario.TabIndex = 72;
            this.lb_mantHorario.Text = "Mantenimiento de Horario";
            // 
            // dtp_hora
            // 
            this.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora.Location = new System.Drawing.Point(193, 182);
            this.dtp_hora.Name = "dtp_hora";
            this.dtp_hora.ShowUpDown = true;
            this.dtp_hora.Size = new System.Drawing.Size(121, 20);
            this.dtp_hora.TabIndex = 61;
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_hora.Location = new System.Drawing.Point(53, 182);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(46, 19);
            this.lb_hora.TabIndex = 71;
            this.lb_hora.Text = "Hora";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_estado.Location = new System.Drawing.Point(53, 221);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(60, 19);
            this.lb_estado.TabIndex = 70;
            this.lb_estado.Text = "Estado";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_fecha.Location = new System.Drawing.Point(53, 143);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(53, 19);
            this.lb_fecha.TabIndex = 69;
            this.lb_fecha.Text = "Fecha";
            // 
            // lb_sala
            // 
            this.lb_sala.AutoSize = true;
            this.lb_sala.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_sala.Location = new System.Drawing.Point(53, 104);
            this.lb_sala.Name = "lb_sala";
            this.lb_sala.Size = new System.Drawing.Size(40, 19);
            this.lb_sala.TabIndex = 68;
            this.lb_sala.Text = "Sala";
            // 
            // lb_pelicula
            // 
            this.lb_pelicula.AutoSize = true;
            this.lb_pelicula.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_pelicula.Location = new System.Drawing.Point(53, 64);
            this.lb_pelicula.Name = "lb_pelicula";
            this.lb_pelicula.Size = new System.Drawing.Size(67, 19);
            this.lb_pelicula.TabIndex = 67;
            this.lb_pelicula.Text = "Pelicula";
            // 
            // cb_Pelicula
            // 
            this.cb_Pelicula.FormattingEnabled = true;
            this.cb_Pelicula.Location = new System.Drawing.Point(193, 64);
            this.cb_Pelicula.Name = "cb_Pelicula";
            this.cb_Pelicula.Size = new System.Drawing.Size(121, 21);
            this.cb_Pelicula.TabIndex = 58;
            // 
            // cb_Estado
            // 
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Location = new System.Drawing.Point(193, 219);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(121, 21);
            this.cb_Estado.TabIndex = 62;
            // 
            // cb_id_Sala
            // 
            this.cb_id_Sala.FormattingEnabled = true;
            this.cb_id_Sala.Location = new System.Drawing.Point(193, 104);
            this.cb_id_Sala.Name = "cb_id_Sala";
            this.cb_id_Sala.Size = new System.Drawing.Size(121, 21);
            this.cb_id_Sala.TabIndex = 59;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy/MM/dd";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(193, 143);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fecha.Size = new System.Drawing.Size(121, 20);
            this.dtp_fecha.TabIndex = 60;
            this.dtp_fecha.Value = new System.DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(225, 11);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(91, 33);
            this.btn_regresar.TabIndex = 13;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.gbbuscar);
            this.panel_panel3.Controls.Add(this.label1);
            this.panel_panel3.Controls.Add(this.dgv_horario);
            this.panel_panel3.Controls.Add(this.btn_editar);
            this.panel_panel3.Controls.Add(this.btn_eliminar);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 28);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(672, 612);
            this.panel_panel3.TabIndex = 56;
            // 
            // gbbuscar
            // 
            this.gbbuscar.Controls.Add(this.txtbxBuscar);
            this.gbbuscar.Controls.Add(this.label2);
            this.gbbuscar.Location = new System.Drawing.Point(3, 0);
            this.gbbuscar.Name = "gbbuscar";
            this.gbbuscar.Size = new System.Drawing.Size(683, 53);
            this.gbbuscar.TabIndex = 184;
            this.gbbuscar.TabStop = false;
            // 
            // txtbxBuscar
            // 
            this.txtbxBuscar.Location = new System.Drawing.Point(71, 13);
            this.txtbxBuscar.Multiline = true;
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(591, 31);
            this.txtbxBuscar.TabIndex = 182;
            this.txtbxBuscar.TextChanged += new System.EventHandler(this.txtbxBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 181;
            this.label2.Text = "Buscar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(229, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Registros Horario";
            // 
            // dgv_horario
            // 
            this.dgv_horario.AllowUserToAddRows = false;
            this.dgv_horario.AllowUserToDeleteRows = false;
            this.dgv_horario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horario.Location = new System.Drawing.Point(12, 193);
            this.dgv_horario.Name = "dgv_horario";
            this.dgv_horario.ReadOnly = true;
            this.dgv_horario.RowHeadersWidth = 51;
            this.dgv_horario.Size = new System.Drawing.Size(638, 278);
            this.dgv_horario.TabIndex = 179;
            this.dgv_horario.Tag = "";
            this.dgv_horario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.editsquare_120033;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(31, 513);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(94, 39);
            this.btn_editar.TabIndex = 9;
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
            this.btn_eliminar.Location = new System.Drawing.Point(180, 513);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(104, 39);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button7_Click);
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(132, 67);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(341, 85);
            this.lb_cinehub.TabIndex = 32;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(1040, 28);
            this.panel_panel1.TabIndex = 54;
            this.panel_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tmr_timer1
            // 
            this.tmr_timer1.Tick += new System.EventHandler(this.tmr_timer1_Tick);
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.Controls.Add(this.btn_boton4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Horarios";
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.Horarios_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            this.panel_panel3.ResumeLayout(false);
            this.panel_panel3.PerformLayout();
            this.gbbuscar.ResumeLayout(false);
            this.gbbuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_boton4;
        private System.Windows.Forms.Label lb_fechaSys;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.DataGridView dgv_horario;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbbuscar;
        private System.Windows.Forms.TextBox txtbxBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmr_timer1;
        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.TextBox txtbx_3ra;
        private System.Windows.Forms.TextBox txtbx_adulto;
        private System.Windows.Forms.TextBox txtbx_nino;
        private System.Windows.Forms.Label lb_precio3ra;
        private System.Windows.Forms.Label lb_precioAdulto;
        private System.Windows.Forms.Label lb_precioNino;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lb_mantHorario;
        private System.Windows.Forms.DateTimePicker dtp_hora;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Label lb_sala;
        private System.Windows.Forms.Label lb_pelicula;
        private System.Windows.Forms.ComboBox cb_Pelicula;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.ComboBox cb_id_Sala;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
    }
}