
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class Salas
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
            this.lb_fechaSys = new System.Windows.Forms.Label();
            this.panel_panel1 = new System.Windows.Forms.Panel();
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.gpb_ingresar = new System.Windows.Forms.GroupBox();
            this.lb_mantSala = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lb_estadoSala = new System.Windows.Forms.Label();
            this.lb_ubicacion = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.lb_tipoSala = new System.Windows.Forms.Label();
            this.txtbx_noSala = new System.Windows.Forms.TextBox();
            this.lb_capacidad = new System.Windows.Forms.Label();
            this.txtbx_capacidad = new System.Windows.Forms.TextBox();
            this.lb_noSala = new System.Windows.Forms.Label();
            this.cb_tipoSala = new System.Windows.Forms.ComboBox();
            this.cb_ubicacion = new System.Windows.Forms.ComboBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.gpb_buscar = new System.Windows.Forms.GroupBox();
            this.txtbx_Buscar = new System.Windows.Forms.TextBox();
            this.lb_buscar = new System.Windows.Forms.Label();
            this.lb_texto = new System.Windows.Forms.Label();
            this.dgv_sala = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.tmr_timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_panel2.SuspendLayout();
            this.gpb_ingresar.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            this.gpb_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sala)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fechaSys
            // 
            this.lb_fechaSys.AutoSize = true;
            this.lb_fechaSys.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaSys.Location = new System.Drawing.Point(240, 59);
            this.lb_fechaSys.Name = "lb_fechaSys";
            this.lb_fechaSys.Size = new System.Drawing.Size(37, 13);
            this.lb_fechaSys.TabIndex = 26;
            this.lb_fechaSys.Text = "Fecha";
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(986, 28);
            this.panel_panel1.TabIndex = 43;
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.gpb_ingresar);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Controls.Add(this.lb_fechaSys);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(618, 28);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(368, 612);
            this.panel_panel2.TabIndex = 44;
            // 
            // gbIngresar
            // 
            this.gpb_ingresar.Controls.Add(this.lb_mantSala);
            this.gpb_ingresar.Controls.Add(this.btn_guardar);
            this.gpb_ingresar.Controls.Add(this.lb_estadoSala);
            this.gpb_ingresar.Controls.Add(this.lb_ubicacion);
            this.gpb_ingresar.Controls.Add(this.cb_estado);
            this.gpb_ingresar.Controls.Add(this.lb_tipoSala);
            this.gpb_ingresar.Controls.Add(this.txtbx_noSala);
            this.gpb_ingresar.Controls.Add(this.lb_capacidad);
            this.gpb_ingresar.Controls.Add(this.txtbx_capacidad);
            this.gpb_ingresar.Controls.Add(this.lb_noSala);
            this.gpb_ingresar.Controls.Add(this.cb_tipoSala);
            this.gpb_ingresar.Controls.Add(this.cb_ubicacion);
            this.gpb_ingresar.Location = new System.Drawing.Point(5, 131);
            this.gpb_ingresar.Name = "gbIngresar";
            this.gpb_ingresar.Size = new System.Drawing.Size(363, 481);
            this.gpb_ingresar.TabIndex = 28;
            this.gpb_ingresar.TabStop = false;
            // 
            // lb_mantSala
            // 
            this.lb_mantSala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantSala.AutoSize = true;
            this.lb_mantSala.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantSala.Location = new System.Drawing.Point(97, 47);
            this.lb_mantSala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mantSala.Name = "lb_mantSala";
            this.lb_mantSala.Size = new System.Drawing.Size(184, 19);
            this.lb_mantSala.TabIndex = 65;
            this.lb_mantSala.Text = "Mantenimiento de Sala";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.diskette_save_saveas_1514;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(151, 382);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(135, 62);
            this.btn_guardar.TabIndex = 59;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lb_estadoSala
            // 
            this.lb_estadoSala.AutoSize = true;
            this.lb_estadoSala.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estadoSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_estadoSala.Location = new System.Drawing.Point(29, 310);
            this.lb_estadoSala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_estadoSala.Name = "lb_estadoSala";
            this.lb_estadoSala.Size = new System.Drawing.Size(93, 19);
            this.lb_estadoSala.TabIndex = 64;
            this.lb_estadoSala.Text = "Estado sala";
            // 
            // lb_ubicacion
            // 
            this.lb_ubicacion.AutoSize = true;
            this.lb_ubicacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ubicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ubicacion.Location = new System.Drawing.Point(29, 275);
            this.lb_ubicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ubicacion.Name = "lb_ubicacion";
            this.lb_ubicacion.Size = new System.Drawing.Size(84, 19);
            this.lb_ubicacion.TabIndex = 63;
            this.lb_ubicacion.Text = "Ubicación";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estado.Location = new System.Drawing.Point(176, 310);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(157, 21);
            this.cb_estado.TabIndex = 58;
            // 
            // lb_tipoSala
            // 
            this.lb_tipoSala.AutoSize = true;
            this.lb_tipoSala.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipoSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_tipoSala.Location = new System.Drawing.Point(29, 235);
            this.lb_tipoSala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tipoSala.Name = "lb_tipoSala";
            this.lb_tipoSala.Size = new System.Drawing.Size(75, 19);
            this.lb_tipoSala.TabIndex = 62;
            this.lb_tipoSala.Text = "Tipo sala";
            // 
            // txtbx_noSala
            // 
            this.txtbx_noSala.Location = new System.Drawing.Point(176, 168);
            this.txtbx_noSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_noSala.Name = "txtbx_noSala";
            this.txtbx_noSala.Size = new System.Drawing.Size(157, 20);
            this.txtbx_noSala.TabIndex = 54;
            // 
            // lb_capacidad
            // 
            this.lb_capacidad.AutoSize = true;
            this.lb_capacidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_capacidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_capacidad.Location = new System.Drawing.Point(29, 199);
            this.lb_capacidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_capacidad.Name = "lb_capacidad";
            this.lb_capacidad.Size = new System.Drawing.Size(88, 19);
            this.lb_capacidad.TabIndex = 61;
            this.lb_capacidad.Text = "Capacidad";
            // 
            // txtbx_capacidad
            // 
            this.txtbx_capacidad.Location = new System.Drawing.Point(176, 199);
            this.txtbx_capacidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_capacidad.Name = "txtbx_capacidad";
            this.txtbx_capacidad.Size = new System.Drawing.Size(157, 20);
            this.txtbx_capacidad.TabIndex = 55;
            // 
            // lb_noSala
            // 
            this.lb_noSala.AutoSize = true;
            this.lb_noSala.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_noSala.Location = new System.Drawing.Point(29, 162);
            this.lb_noSala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_noSala.Name = "lb_noSala";
            this.lb_noSala.Size = new System.Drawing.Size(128, 19);
            this.lb_noSala.TabIndex = 60;
            this.lb_noSala.Text = "Numero de sala";
            // 
            // cb_tipoSala
            // 
            this.cb_tipoSala.FormattingEnabled = true;
            this.cb_tipoSala.Location = new System.Drawing.Point(176, 235);
            this.cb_tipoSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_tipoSala.Name = "cb_tipoSala";
            this.cb_tipoSala.Size = new System.Drawing.Size(157, 21);
            this.cb_tipoSala.TabIndex = 56;
            // 
            // cb_ubicacion
            // 
            this.cb_ubicacion.FormattingEnabled = true;
            this.cb_ubicacion.Location = new System.Drawing.Point(176, 275);
            this.cb_ubicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_ubicacion.Name = "cb_ubicacion";
            this.cb_ubicacion.Size = new System.Drawing.Size(157, 21);
            this.cb_ubicacion.TabIndex = 57;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(237, 6);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(91, 33);
            this.btn_regresar.TabIndex = 8;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.gpb_buscar);
            this.panel_panel3.Controls.Add(this.lb_texto);
            this.panel_panel3.Controls.Add(this.dgv_sala);
            this.panel_panel3.Controls.Add(this.btn_editar);
            this.panel_panel3.Controls.Add(this.btn_eliminar);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 28);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(618, 612);
            this.panel_panel3.TabIndex = 45;
            // 
            // gbbuscar
            // 
            this.gpb_buscar.Controls.Add(this.txtbx_Buscar);
            this.gpb_buscar.Controls.Add(this.lb_buscar);
            this.gpb_buscar.Location = new System.Drawing.Point(0, 3);
            this.gpb_buscar.Name = "gbbuscar";
            this.gpb_buscar.Size = new System.Drawing.Size(618, 53);
            this.gpb_buscar.TabIndex = 183;
            this.gpb_buscar.TabStop = false;
            // 
            // txtbxBuscar
            // 
            this.txtbx_Buscar.Location = new System.Drawing.Point(71, 13);
            this.txtbx_Buscar.Multiline = true;
            this.txtbx_Buscar.Name = "txtbxBuscar";
            this.txtbx_Buscar.Size = new System.Drawing.Size(532, 31);
            this.txtbx_Buscar.TabIndex = 182;
            this.txtbx_Buscar.TextChanged += new System.EventHandler(this.txtbxBuscar_TextChanged);
            // 
            // label2
            // 
            this.lb_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_buscar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_buscar.Location = new System.Drawing.Point(1, 16);
            this.lb_buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_buscar.Name = "label2";
            this.lb_buscar.Size = new System.Drawing.Size(77, 26);
            this.lb_buscar.TabIndex = 181;
            this.lb_buscar.Text = "Buscar";
            this.lb_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.lb_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_texto.Location = new System.Drawing.Point(220, 166);
            this.lb_texto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_texto.Name = "label1";
            this.lb_texto.Size = new System.Drawing.Size(143, 19);
            this.lb_texto.TabIndex = 54;
            this.lb_texto.Text = "Registros de Salas";
            // 
            // dgv_sala
            // 
            this.dgv_sala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sala.Location = new System.Drawing.Point(10, 208);
            this.dgv_sala.Name = "dgv_sala";
            this.dgv_sala.RowHeadersWidth = 51;
            this.dgv_sala.Size = new System.Drawing.Size(586, 277);
            this.dgv_sala.TabIndex = 179;
            this.dgv_sala.Tag = "";
            this.dgv_sala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.editsquare_120033;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(31, 512);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(94, 39);
            this.btn_editar.TabIndex = 6;
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
            this.btn_eliminar.Location = new System.Drawing.Point(171, 512);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(103, 39);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button6_Click);
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(135, 82);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(318, 85);
            this.lb_cinehub.TabIndex = 32;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmr_timer1
            // 
            this.tmr_timer1.Tick += new System.EventHandler(this.tmr_timer1_Tick);
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salas";
            this.Text = "Salas";
            this.Load += new System.EventHandler(this.Salas_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.gpb_ingresar.ResumeLayout(false);
            this.gpb_ingresar.PerformLayout();
            this.panel_panel3.ResumeLayout(false);
            this.panel_panel3.PerformLayout();
            this.gpb_buscar.ResumeLayout(false);
            this.gpb_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_fechaSys;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.DataGridView dgv_sala;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.GroupBox gpb_buscar;
        private System.Windows.Forms.TextBox txtbx_Buscar;
        private System.Windows.Forms.Label lb_buscar;
        private System.Windows.Forms.GroupBox gpb_ingresar;
        private System.Windows.Forms.Label lb_mantSala;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lb_estadoSala;
        private System.Windows.Forms.Label lb_ubicacion;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label lb_tipoSala;
        private System.Windows.Forms.TextBox txtbx_noSala;
        private System.Windows.Forms.Label lb_capacidad;
        private System.Windows.Forms.TextBox txtbx_capacidad;
        private System.Windows.Forms.Label lb_noSala;
        private System.Windows.Forms.ComboBox cb_tipoSala;
        private System.Windows.Forms.ComboBox cb_ubicacion;
        private System.Windows.Forms.Timer tmr_timer1;
    }
}