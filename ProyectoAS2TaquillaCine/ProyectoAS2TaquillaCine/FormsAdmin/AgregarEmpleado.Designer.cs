﻿
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class AgregarEmpleado
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
            this.tmr_timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_panel1 = new System.Windows.Forms.Panel();
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lb_estadoEmp = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.cb_estadoEmp = new System.Windows.Forms.ComboBox();
            this.txtbx_confContra = new System.Windows.Forms.TextBox();
            this.lb_confContra = new System.Windows.Forms.Label();
            this.lb_cargo = new System.Windows.Forms.Label();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.txtbx_contrasena = new System.Windows.Forms.TextBox();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.txtbx_telefono = new System.Windows.Forms.TextBox();
            this.lb_telefono = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.txtbx_apellido = new System.Windows.Forms.TextBox();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.txtbx_nombre = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_mantenimientoEmpl = new System.Windows.Forms.Label();
            this.lb_tiempoSys = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.lb_texto = new System.Windows.Forms.Label();
            this.gpb_buscar = new System.Windows.Forms.GroupBox();
            this.txtbx_buscar = new System.Windows.Forms.TextBox();
            this.lb_buscar = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.panel_panel2.SuspendLayout();
            this.gbIngresar.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            this.gpb_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_timer1
            // 
            this.tmr_timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(1387, 44);
            this.panel_panel1.TabIndex = 34;
            this.panel_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_panel1_Paint);
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.gbIngresar);
            this.panel_panel2.Controls.Add(this.lb_tiempoSys);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(896, 44);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(491, 744);
            this.panel_panel2.TabIndex = 35;
            this.panel_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.btn_eliminar);
            this.gbIngresar.Controls.Add(this.btn_guardar);
            this.gbIngresar.Controls.Add(this.lb_estadoEmp);
            this.gbIngresar.Controls.Add(this.btn_editar);
            this.gbIngresar.Controls.Add(this.cb_estadoEmp);
            this.gbIngresar.Controls.Add(this.txtbx_confContra);
            this.gbIngresar.Controls.Add(this.lb_confContra);
            this.gbIngresar.Controls.Add(this.lb_cargo);
            this.gbIngresar.Controls.Add(this.cb_cargo);
            this.gbIngresar.Controls.Add(this.txtbx_contrasena);
            this.gbIngresar.Controls.Add(this.lb_contrasena);
            this.gbIngresar.Controls.Add(this.txtbx_telefono);
            this.gbIngresar.Controls.Add(this.lb_telefono);
            this.gbIngresar.Controls.Add(this.txtbx_email);
            this.gbIngresar.Controls.Add(this.lb_email);
            this.gbIngresar.Controls.Add(this.txtbx_apellido);
            this.gbIngresar.Controls.Add(this.lb_apellido);
            this.gbIngresar.Controls.Add(this.txtbx_nombre);
            this.gbIngresar.Controls.Add(this.lb_nombre);
            this.gbIngresar.Controls.Add(this.lb_mantenimientoEmpl);
            this.gbIngresar.Location = new System.Drawing.Point(4, 128);
            this.gbIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Padding = new System.Windows.Forms.Padding(4);
            this.gbIngresar.Size = new System.Drawing.Size(487, 709);
            this.gbIngresar.TabIndex = 71;
            this.gbIngresar.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.delete_button_6303088;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(26, 568);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(136, 48);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.diskette_save_saveas_1514;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(170, 584);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(173, 52);
            this.btn_guardar.TabIndex = 78;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lb_estadoEmp
            // 
            this.lb_estadoEmp.AutoSize = true;
            this.lb_estadoEmp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estadoEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_estadoEmp.Location = new System.Drawing.Point(41, 505);
            this.lb_estadoEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_estadoEmp.Name = "lb_estadoEmp";
            this.lb_estadoEmp.Size = new System.Drawing.Size(185, 27);
            this.lb_estadoEmp.TabIndex = 87;
            this.lb_estadoEmp.Text = "Estado Empleado";
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.editsquare_120033;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(351, 568);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(123, 48);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_estadoEmp
            // 
            this.cb_estadoEmp.FormattingEnabled = true;
            this.cb_estadoEmp.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estadoEmp.Location = new System.Drawing.Point(252, 505);
            this.cb_estadoEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_estadoEmp.Name = "cb_estadoEmp";
            this.cb_estadoEmp.Size = new System.Drawing.Size(160, 24);
            this.cb_estadoEmp.TabIndex = 77;
            // 
            // txtbx_confContra
            // 
            this.txtbx_confContra.Location = new System.Drawing.Point(252, 405);
            this.txtbx_confContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_confContra.Name = "txtbx_confContra";
            this.txtbx_confContra.PasswordChar = '*';
            this.txtbx_confContra.Size = new System.Drawing.Size(160, 22);
            this.txtbx_confContra.TabIndex = 75;
            // 
            // lb_confContra
            // 
            this.lb_confContra.AutoSize = true;
            this.lb_confContra.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confContra.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_confContra.Location = new System.Drawing.Point(41, 406);
            this.lb_confContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_confContra.Name = "lb_confContra";
            this.lb_confContra.Size = new System.Drawing.Size(195, 24);
            this.lb_confContra.TabIndex = 86;
            this.lb_confContra.Text = "Confirmar contraseña";
            // 
            // lb_cargo
            // 
            this.lb_cargo.AutoSize = true;
            this.lb_cargo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cargo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_cargo.Location = new System.Drawing.Point(41, 262);
            this.lb_cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cargo.Name = "lb_cargo";
            this.lb_cargo.Size = new System.Drawing.Size(71, 27);
            this.lb_cargo.TabIndex = 85;
            this.lb_cargo.Text = "Cargo";
            // 
            // cb_cargo
            // 
            this.cb_cargo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Location = new System.Drawing.Point(252, 265);
            this.cb_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(160, 24);
            this.cb_cargo.TabIndex = 72;
            this.cb_cargo.Text = "Seleccione un cargo ...";
            // 
            // txtbx_contrasena
            // 
            this.txtbx_contrasena.Location = new System.Drawing.Point(252, 358);
            this.txtbx_contrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_contrasena.Name = "txtbx_contrasena";
            this.txtbx_contrasena.PasswordChar = '*';
            this.txtbx_contrasena.Size = new System.Drawing.Size(160, 22);
            this.txtbx_contrasena.TabIndex = 74;
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_contrasena.Location = new System.Drawing.Point(41, 357);
            this.lb_contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(126, 27);
            this.lb_contrasena.TabIndex = 84;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // txtbx_telefono
            // 
            this.txtbx_telefono.Location = new System.Drawing.Point(252, 455);
            this.txtbx_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_telefono.Name = "txtbx_telefono";
            this.txtbx_telefono.Size = new System.Drawing.Size(160, 22);
            this.txtbx_telefono.TabIndex = 76;
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_telefono.Location = new System.Drawing.Point(41, 454);
            this.lb_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(102, 27);
            this.lb_telefono.TabIndex = 83;
            this.lb_telefono.Text = "Teléfono";
            // 
            // txtbx_email
            // 
            this.txtbx_email.Location = new System.Drawing.Point(252, 316);
            this.txtbx_email.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(160, 22);
            this.txtbx_email.TabIndex = 73;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_email.Location = new System.Drawing.Point(44, 315);
            this.lb_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(67, 27);
            this.lb_email.TabIndex = 82;
            this.lb_email.Text = "Email";
            // 
            // txtbx_apellido
            // 
            this.txtbx_apellido.Location = new System.Drawing.Point(252, 217);
            this.txtbx_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_apellido.Name = "txtbx_apellido";
            this.txtbx_apellido.Size = new System.Drawing.Size(160, 22);
            this.txtbx_apellido.TabIndex = 71;
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_apellido.Location = new System.Drawing.Point(41, 214);
            this.lb_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(96, 27);
            this.lb_apellido.TabIndex = 81;
            this.lb_apellido.Text = "Apellido";
            // 
            // txtbx_nombre
            // 
            this.txtbx_nombre.Location = new System.Drawing.Point(252, 161);
            this.txtbx_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_nombre.Name = "txtbx_nombre";
            this.txtbx_nombre.Size = new System.Drawing.Size(160, 22);
            this.txtbx_nombre.TabIndex = 70;
            this.txtbx_nombre.TextChanged += new System.EventHandler(this.txtbx_nombre_TextChanged);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_nombre.Location = new System.Drawing.Point(41, 160);
            this.lb_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(95, 27);
            this.lb_nombre.TabIndex = 80;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_mantenimientoEmpl
            // 
            this.lb_mantenimientoEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantenimientoEmpl.AutoSize = true;
            this.lb_mantenimientoEmpl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantenimientoEmpl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantenimientoEmpl.Location = new System.Drawing.Point(139, 97);
            this.lb_mantenimientoEmpl.Name = "lb_mantenimientoEmpl";
            this.lb_mantenimientoEmpl.Size = new System.Drawing.Size(292, 26);
            this.lb_mantenimientoEmpl.TabIndex = 79;
            this.lb_mantenimientoEmpl.Text = "Mantenimiento de Empleado";
            // 
            // lb_tiempoSys
            // 
            this.lb_tiempoSys.AutoSize = true;
            this.lb_tiempoSys.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_tiempoSys.Location = new System.Drawing.Point(301, 76);
            this.lb_tiempoSys.Name = "lb_tiempoSys";
            this.lb_tiempoSys.Size = new System.Drawing.Size(46, 17);
            this.lb_tiempoSys.TabIndex = 70;
            this.lb_tiempoSys.Text = "label7";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(316, 7);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(121, 41);
            this.btn_regresar.TabIndex = 37;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.lb_texto);
            this.panel_panel3.Controls.Add(this.gpb_buscar);
            this.panel_panel3.Controls.Add(this.dgv_empleados);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 44);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(896, 744);
            this.panel_panel3.TabIndex = 36;
            this.panel_panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_panel3_Paint);
            // 
            // lb_texto
            // 
            this.lb_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_texto.Location = new System.Drawing.Point(292, 201);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(203, 26);
            this.lb_texto.TabIndex = 71;
            this.lb_texto.Text = "Registros Empleado";
            // 
            // gpb_buscar
            // 
            this.gpb_buscar.Controls.Add(this.txtbx_buscar);
            this.gpb_buscar.Controls.Add(this.lb_buscar);
            this.gpb_buscar.Location = new System.Drawing.Point(0, 0);
            this.gpb_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_buscar.Name = "gpb_buscar";
            this.gpb_buscar.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_buscar.Size = new System.Drawing.Size(924, 65);
            this.gpb_buscar.TabIndex = 180;
            this.gpb_buscar.TabStop = false;
            // 
            // txtbx_buscar
            // 
            this.txtbx_buscar.Location = new System.Drawing.Point(95, 16);
            this.txtbx_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_buscar.Multiline = true;
            this.txtbx_buscar.Name = "txtbx_buscar";
            this.txtbx_buscar.Size = new System.Drawing.Size(799, 37);
            this.txtbx_buscar.TabIndex = 182;
            this.txtbx_buscar.TextChanged += new System.EventHandler(this.txtbxBuscar_TextChanged);
            // 
            // lb_buscar
            // 
            this.lb_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_buscar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_buscar.Location = new System.Drawing.Point(3, 20);
            this.lb_buscar.Name = "lb_buscar";
            this.lb_buscar.Size = new System.Drawing.Size(103, 32);
            this.lb_buscar.TabIndex = 181;
            this.lb_buscar.Text = "Buscar";
            this.lb_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(13, 256);
            this.dgv_empleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.Size = new System.Drawing.Size(853, 333);
            this.dgv_empleados.TabIndex = 179;
            this.dgv_empleados.Tag = "";
            this.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(196, 82);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(427, 105);
            this.lb_cinehub.TabIndex = 32;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            this.panel_panel3.ResumeLayout(false);
            this.panel_panel3.PerformLayout();
            this.gpb_buscar.ResumeLayout(false);
            this.gpb_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr_timer1;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Label lb_tiempoSys;
        private System.Windows.Forms.GroupBox gpb_buscar;
        private System.Windows.Forms.TextBox txtbx_buscar;
        private System.Windows.Forms.Label lb_buscar;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.Label lb_estadoEmp;
        private System.Windows.Forms.ComboBox cb_estadoEmp;
        private System.Windows.Forms.TextBox txtbx_confContra;
        private System.Windows.Forms.Label lb_confContra;
        private System.Windows.Forms.Label lb_cargo;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.TextBox txtbx_contrasena;
        private System.Windows.Forms.Label lb_contrasena;
        private System.Windows.Forms.TextBox txtbx_telefono;
        private System.Windows.Forms.Label lb_telefono;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txtbx_apellido;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.TextBox txtbx_nombre;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_mantenimientoEmpl;
        private System.Windows.Forms.Button btn_guardar;
    }
}