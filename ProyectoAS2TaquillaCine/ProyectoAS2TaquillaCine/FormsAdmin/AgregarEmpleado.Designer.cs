
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
            this.lb_estadoEmp = new System.Windows.Forms.Label();
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lb_tiempoSys = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gbbuscar = new System.Windows.Forms.GroupBox();
            this.txtbxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.panel_panel2.SuspendLayout();
            this.gbIngresar.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            this.gbbuscar.SuspendLayout();
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
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(1061, 28);
            this.panel_panel1.TabIndex = 34;
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.gbIngresar);
            this.panel_panel2.Controls.Add(this.lb_tiempoSys);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(693, 28);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(368, 683);
            this.panel_panel2.TabIndex = 35;
            this.panel_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.lb_estadoEmp);
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
            this.gbIngresar.Controls.Add(this.btn_guardar);
            this.gbIngresar.Location = new System.Drawing.Point(3, 104);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(365, 576);
            this.gbIngresar.TabIndex = 71;
            this.gbIngresar.TabStop = false;
            // 
            // lb_estadoEmp
            // 
            this.lb_estadoEmp.AutoSize = true;
            this.lb_estadoEmp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estadoEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_estadoEmp.Location = new System.Drawing.Point(31, 410);
            this.lb_estadoEmp.Name = "lb_estadoEmp";
            this.lb_estadoEmp.Size = new System.Drawing.Size(151, 22);
            this.lb_estadoEmp.TabIndex = 87;
            this.lb_estadoEmp.Text = "Estado Empleado";
            // 
            // cb_estadoEmp
            // 
            this.cb_estadoEmp.FormattingEnabled = true;
            this.cb_estadoEmp.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estadoEmp.Location = new System.Drawing.Point(189, 410);
            this.cb_estadoEmp.Margin = new System.Windows.Forms.Padding(2);
            this.cb_estadoEmp.Name = "cb_estadoEmp";
            this.cb_estadoEmp.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoEmp.TabIndex = 77;
            // 
            // txtbx_confContra
            // 
            this.txtbx_confContra.Location = new System.Drawing.Point(189, 329);
            this.txtbx_confContra.Name = "txtbx_confContra";
            this.txtbx_confContra.PasswordChar = '*';
            this.txtbx_confContra.Size = new System.Drawing.Size(121, 20);
            this.txtbx_confContra.TabIndex = 75;
            // 
            // lb_confContra
            // 
            this.lb_confContra.AutoSize = true;
            this.lb_confContra.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confContra.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_confContra.Location = new System.Drawing.Point(31, 330);
            this.lb_confContra.Name = "lb_confContra";
            this.lb_confContra.Size = new System.Drawing.Size(161, 19);
            this.lb_confContra.TabIndex = 86;
            this.lb_confContra.Text = "Confirmar contraseña";
            // 
            // lb_cargo
            // 
            this.lb_cargo.AutoSize = true;
            this.lb_cargo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cargo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_cargo.Location = new System.Drawing.Point(31, 213);
            this.lb_cargo.Name = "lb_cargo";
            this.lb_cargo.Size = new System.Drawing.Size(59, 22);
            this.lb_cargo.TabIndex = 85;
            this.lb_cargo.Text = "Cargo";
            // 
            // cb_cargo
            // 
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Location = new System.Drawing.Point(189, 215);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(121, 21);
            this.cb_cargo.TabIndex = 72;
            // 
            // txtbx_contrasena
            // 
            this.txtbx_contrasena.Location = new System.Drawing.Point(189, 291);
            this.txtbx_contrasena.Name = "txtbx_contrasena";
            this.txtbx_contrasena.PasswordChar = '*';
            this.txtbx_contrasena.Size = new System.Drawing.Size(121, 20);
            this.txtbx_contrasena.TabIndex = 74;
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_contrasena.Location = new System.Drawing.Point(31, 290);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(101, 22);
            this.lb_contrasena.TabIndex = 84;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // txtbx_telefono
            // 
            this.txtbx_telefono.Location = new System.Drawing.Point(189, 370);
            this.txtbx_telefono.Name = "txtbx_telefono";
            this.txtbx_telefono.Size = new System.Drawing.Size(121, 20);
            this.txtbx_telefono.TabIndex = 76;
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_telefono.Location = new System.Drawing.Point(31, 369);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(81, 22);
            this.lb_telefono.TabIndex = 83;
            this.lb_telefono.Text = "Teléfono";
            // 
            // txtbx_email
            // 
            this.txtbx_email.Location = new System.Drawing.Point(189, 257);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(121, 20);
            this.txtbx_email.TabIndex = 73;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_email.Location = new System.Drawing.Point(33, 256);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 22);
            this.lb_email.TabIndex = 82;
            this.lb_email.Text = "Email";
            // 
            // txtbx_apellido
            // 
            this.txtbx_apellido.Location = new System.Drawing.Point(189, 176);
            this.txtbx_apellido.Name = "txtbx_apellido";
            this.txtbx_apellido.Size = new System.Drawing.Size(121, 20);
            this.txtbx_apellido.TabIndex = 71;
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_apellido.Location = new System.Drawing.Point(31, 174);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(79, 22);
            this.lb_apellido.TabIndex = 81;
            this.lb_apellido.Text = "Apellido";
            // 
            // txtbx_nombre
            // 
            this.txtbx_nombre.Location = new System.Drawing.Point(189, 131);
            this.txtbx_nombre.Name = "txtbx_nombre";
            this.txtbx_nombre.Size = new System.Drawing.Size(121, 20);
            this.txtbx_nombre.TabIndex = 70;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_nombre.Location = new System.Drawing.Point(31, 130);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(78, 22);
            this.lb_nombre.TabIndex = 80;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_mantenimientoEmpl
            // 
            this.lb_mantenimientoEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantenimientoEmpl.AutoSize = true;
            this.lb_mantenimientoEmpl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantenimientoEmpl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantenimientoEmpl.Location = new System.Drawing.Point(104, 79);
            this.lb_mantenimientoEmpl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mantenimientoEmpl.Name = "lb_mantenimientoEmpl";
            this.lb_mantenimientoEmpl.Size = new System.Drawing.Size(229, 19);
            this.lb_mantenimientoEmpl.TabIndex = 79;
            this.lb_mantenimientoEmpl.Text = "Mantenimiento de Empleado";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Location = new System.Drawing.Point(65, 456);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(237, 41);
            this.btn_guardar.TabIndex = 78;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // lb_tiempoSys
            // 
            this.lb_tiempoSys.AutoSize = true;
            this.lb_tiempoSys.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_tiempoSys.Location = new System.Drawing.Point(226, 62);
            this.lb_tiempoSys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tiempoSys.Name = "lb_tiempoSys";
            this.lb_tiempoSys.Size = new System.Drawing.Size(35, 13);
            this.lb_tiempoSys.TabIndex = 70;
            this.lb_tiempoSys.Text = "label7";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(237, 6);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(91, 33);
            this.btn_regresar.TabIndex = 37;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.label2);
            this.panel_panel3.Controls.Add(this.gbbuscar);
            this.panel_panel3.Controls.Add(this.dgv_empleados);
            this.panel_panel3.Controls.Add(this.btn_editar);
            this.panel_panel3.Controls.Add(this.btn_eliminar);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 28);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(693, 683);
            this.panel_panel3.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(229, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 71;
            this.label2.Text = "Registros Empleado";
            // 
            // gbbuscar
            // 
            this.gbbuscar.Controls.Add(this.txtbxBuscar);
            this.gbbuscar.Controls.Add(this.label1);
            this.gbbuscar.Location = new System.Drawing.Point(0, 0);
            this.gbbuscar.Name = "gbbuscar";
            this.gbbuscar.Size = new System.Drawing.Size(693, 53);
            this.gbbuscar.TabIndex = 180;
            this.gbbuscar.TabStop = false;
            // 
            // txtbxBuscar
            // 
            this.txtbxBuscar.Location = new System.Drawing.Point(71, 13);
            this.txtbxBuscar.Multiline = true;
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(600, 31);
            this.txtbxBuscar.TabIndex = 182;
            this.txtbxBuscar.TextChanged += new System.EventHandler(this.txtbxBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 181;
            this.label1.Text = "Buscar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(10, 208);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.Size = new System.Drawing.Size(661, 349);
            this.dgv_empleados.TabIndex = 179;
            this.dgv_empleados.Tag = "";
            this.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Location = new System.Drawing.Point(31, 584);
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
            this.btn_eliminar.Location = new System.Drawing.Point(171, 584);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(111, 39);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(157, 67);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(320, 85);
            this.lb_cinehub.TabIndex = 32;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 711);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            this.panel_panel3.ResumeLayout(false);
            this.panel_panel3.PerformLayout();
            this.gbbuscar.ResumeLayout(false);
            this.gbbuscar.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbbuscar;
        private System.Windows.Forms.TextBox txtbxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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