
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
            this.btn_boton4 = new System.Windows.Forms.Button();
            this.lb_horaSys = new System.Windows.Forms.Label();
            this.lb_fechaSys = new System.Windows.Forms.Label();
            this.cb_Pelicula = new System.Windows.Forms.ComboBox();
            this.cb_id_Sala = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.lb_pelicula = new System.Windows.Forms.Label();
            this.lb_sala = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.txtbx_3ra = new System.Windows.Forms.TextBox();
            this.txtbx_adulto = new System.Windows.Forms.TextBox();
            this.txtbx_nino = new System.Windows.Forms.TextBox();
            this.lb_precio3ra = new System.Windows.Forms.Label();
            this.lb_precioAdulto = new System.Windows.Forms.Label();
            this.lb_precioNino = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lb_mantHorario = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.dgv_horario = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.panel_panel1 = new System.Windows.Forms.Panel();
            this.panel_panel2.SuspendLayout();
            this.panel_panel3.SuspendLayout();
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
            // lb_horaSys
            // 
            this.lb_horaSys.AutoSize = true;
            this.lb_horaSys.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horaSys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_horaSys.Location = new System.Drawing.Point(208, 62);
            this.lb_horaSys.Name = "lb_horaSys";
            this.lb_horaSys.Size = new System.Drawing.Size(46, 19);
            this.lb_horaSys.TabIndex = 36;
            this.lb_horaSys.Text = "Hora";
            // 
            // lb_fechaSys
            // 
            this.lb_fechaSys.AutoSize = true;
            this.lb_fechaSys.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fechaSys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_fechaSys.Location = new System.Drawing.Point(278, 62);
            this.lb_fechaSys.Name = "lb_fechaSys";
            this.lb_fechaSys.Size = new System.Drawing.Size(53, 19);
            this.lb_fechaSys.TabIndex = 35;
            this.lb_fechaSys.Text = "Fecha";
            // 
            // cb_Pelicula
            // 
            this.cb_Pelicula.FormattingEnabled = true;
            this.cb_Pelicula.Location = new System.Drawing.Point(205, 211);
            this.cb_Pelicula.Name = "cb_Pelicula";
            this.cb_Pelicula.Size = new System.Drawing.Size(121, 21);
            this.cb_Pelicula.TabIndex = 0;
            // 
            // cb_id_Sala
            // 
            this.cb_id_Sala.FormattingEnabled = true;
            this.cb_id_Sala.Location = new System.Drawing.Point(205, 251);
            this.cb_id_Sala.Name = "cb_id_Sala";
            this.cb_id_Sala.Size = new System.Drawing.Size(121, 21);
            this.cb_id_Sala.TabIndex = 1;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy/MM/dd";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(205, 290);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fecha.Size = new System.Drawing.Size(121, 20);
            this.dtp_fecha.TabIndex = 2;
            this.dtp_fecha.Value = new System.DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // cb_Estado
            // 
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Location = new System.Drawing.Point(205, 366);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(121, 21);
            this.cb_Estado.TabIndex = 4;
            // 
            // lb_pelicula
            // 
            this.lb_pelicula.AutoSize = true;
            this.lb_pelicula.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_pelicula.Location = new System.Drawing.Point(65, 211);
            this.lb_pelicula.Name = "lb_pelicula";
            this.lb_pelicula.Size = new System.Drawing.Size(67, 19);
            this.lb_pelicula.TabIndex = 47;
            this.lb_pelicula.Text = "Pelicula";
            // 
            // lb_sala
            // 
            this.lb_sala.AutoSize = true;
            this.lb_sala.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_sala.Location = new System.Drawing.Point(65, 251);
            this.lb_sala.Name = "lb_sala";
            this.lb_sala.Size = new System.Drawing.Size(40, 19);
            this.lb_sala.TabIndex = 48;
            this.lb_sala.Text = "Sala";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_fecha.Location = new System.Drawing.Point(65, 290);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(53, 19);
            this.lb_fecha.TabIndex = 49;
            this.lb_fecha.Text = "Fecha";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_estado.Location = new System.Drawing.Point(65, 368);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(60, 19);
            this.lb_estado.TabIndex = 50;
            this.lb_estado.Text = "Estado";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_hora.Location = new System.Drawing.Point(65, 329);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(46, 19);
            this.lb_hora.TabIndex = 51;
            this.lb_hora.Text = "Hora";
            this.lb_hora.Click += new System.EventHandler(this.label9_Click);
            // 
            // dtp_hora
            // 
            this.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora.Location = new System.Drawing.Point(205, 329);
            this.dtp_hora.Name = "dtp_hora";
            this.dtp_hora.ShowUpDown = true;
            this.dtp_hora.Size = new System.Drawing.Size(121, 20);
            this.dtp_hora.TabIndex = 3;
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.txtbx_3ra);
            this.panel_panel2.Controls.Add(this.txtbx_adulto);
            this.panel_panel2.Controls.Add(this.txtbx_nino);
            this.panel_panel2.Controls.Add(this.lb_precio3ra);
            this.panel_panel2.Controls.Add(this.lb_precioAdulto);
            this.panel_panel2.Controls.Add(this.lb_precioNino);
            this.panel_panel2.Controls.Add(this.btn_guardar);
            this.panel_panel2.Controls.Add(this.lb_mantHorario);
            this.panel_panel2.Controls.Add(this.dtp_hora);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Controls.Add(this.lb_hora);
            this.panel_panel2.Controls.Add(this.lb_fechaSys);
            this.panel_panel2.Controls.Add(this.lb_estado);
            this.panel_panel2.Controls.Add(this.lb_horaSys);
            this.panel_panel2.Controls.Add(this.lb_fecha);
            this.panel_panel2.Controls.Add(this.lb_sala);
            this.panel_panel2.Controls.Add(this.lb_pelicula);
            this.panel_panel2.Controls.Add(this.cb_Pelicula);
            this.panel_panel2.Controls.Add(this.cb_Estado);
            this.panel_panel2.Controls.Add(this.cb_id_Sala);
            this.panel_panel2.Controls.Add(this.dtp_fecha);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(686, 28);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(368, 669);
            this.panel_panel2.TabIndex = 55;
            // 
            // txtbx_3ra
            // 
            this.txtbx_3ra.Location = new System.Drawing.Point(207, 487);
            this.txtbx_3ra.Name = "txtbx_3ra";
            this.txtbx_3ra.Size = new System.Drawing.Size(121, 20);
            this.txtbx_3ra.TabIndex = 7;
            this.txtbx_3ra.TextChanged += new System.EventHandler(this.txt3ra_TextChanged);
            // 
            // txtbx_adulto
            // 
            this.txtbx_adulto.Location = new System.Drawing.Point(207, 452);
            this.txtbx_adulto.Name = "txtbx_adulto";
            this.txtbx_adulto.Size = new System.Drawing.Size(121, 20);
            this.txtbx_adulto.TabIndex = 6;
            this.txtbx_adulto.TextChanged += new System.EventHandler(this.txtAdulto_TextChanged);
            // 
            // txtbx_nino
            // 
            this.txtbx_nino.Location = new System.Drawing.Point(207, 413);
            this.txtbx_nino.Name = "txtbx_nino";
            this.txtbx_nino.Size = new System.Drawing.Size(121, 20);
            this.txtbx_nino.TabIndex = 5;
            this.txtbx_nino.TextChanged += new System.EventHandler(this.txtNino_TextChanged);
            // 
            // lb_precio3ra
            // 
            this.lb_precio3ra.AutoSize = true;
            this.lb_precio3ra.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precio3ra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_precio3ra.Location = new System.Drawing.Point(65, 486);
            this.lb_precio3ra.Name = "lb_precio3ra";
            this.lb_precio3ra.Size = new System.Drawing.Size(126, 19);
            this.lb_precio3ra.TabIndex = 57;
            this.lb_precio3ra.Text = "Precio 3ra Edad";
            this.lb_precio3ra.Click += new System.EventHandler(this.label12_Click);
            // 
            // lb_precioAdulto
            // 
            this.lb_precioAdulto.AutoSize = true;
            this.lb_precioAdulto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precioAdulto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_precioAdulto.Location = new System.Drawing.Point(65, 451);
            this.lb_precioAdulto.Name = "lb_precioAdulto";
            this.lb_precioAdulto.Size = new System.Drawing.Size(111, 19);
            this.lb_precioAdulto.TabIndex = 56;
            this.lb_precioAdulto.Text = "Precio Adulto";
            this.lb_precioAdulto.Click += new System.EventHandler(this.label11_Click);
            // 
            // lb_precioNino
            // 
            this.lb_precioNino.AutoSize = true;
            this.lb_precioNino.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precioNino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_precioNino.Location = new System.Drawing.Point(65, 412);
            this.lb_precioNino.Name = "lb_precioNino";
            this.lb_precioNino.Size = new System.Drawing.Size(97, 19);
            this.lb_precioNino.TabIndex = 55;
            this.lb_precioNino.Text = "Precio Niño";
            this.lb_precioNino.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Location = new System.Drawing.Point(78, 568);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(237, 41);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.button8_Click);
            // 
            // lb_mantHorario
            // 
            this.lb_mantHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantHorario.AutoSize = true;
            this.lb_mantHorario.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantHorario.Location = new System.Drawing.Point(93, 133);
            this.lb_mantHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mantHorario.Name = "lb_mantHorario";
            this.lb_mantHorario.Size = new System.Drawing.Size(210, 19);
            this.lb_mantHorario.TabIndex = 53;
            this.lb_mantHorario.Text = "Mantenimiento de Horario";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(237, 6);
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
            this.panel_panel3.Controls.Add(this.dgv_horario);
            this.panel_panel3.Controls.Add(this.btn_editar);
            this.panel_panel3.Controls.Add(this.btn_eliminar);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 28);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(686, 669);
            this.panel_panel3.TabIndex = 56;
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
            this.dgv_horario.Size = new System.Drawing.Size(653, 335);
            this.dgv_horario.TabIndex = 179;
            this.dgv_horario.Tag = "";
            this.dgv_horario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Location = new System.Drawing.Point(31, 570);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(119, 39);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Location = new System.Drawing.Point(171, 570);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(111, 39);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button7_Click);
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(218, 40);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(282, 85);
            this.lb_cinehub.TabIndex = 32;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(1054, 28);
            this.panel_panel1.TabIndex = 54;
            this.panel_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 697);
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
            this.panel_panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_boton4;
        private System.Windows.Forms.Label lb_horaSys;
        private System.Windows.Forms.Label lb_fechaSys;
        private System.Windows.Forms.ComboBox cb_Pelicula;
        private System.Windows.Forms.ComboBox cb_id_Sala;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.Label lb_pelicula;
        private System.Windows.Forms.Label lb_sala;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.DateTimePicker dtp_hora;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Label lb_mantHorario;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.DataGridView dgv_horario;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.TextBox txtbx_3ra;
        private System.Windows.Forms.TextBox txtbx_adulto;
        private System.Windows.Forms.TextBox txtbx_nino;
        private System.Windows.Forms.Label lb_precio3ra;
        private System.Windows.Forms.Label lb_precioAdulto;
        private System.Windows.Forms.Label lb_precioNino;
    }
}