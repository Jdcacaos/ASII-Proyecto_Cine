
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
            this.lb_tiempoSys = new System.Windows.Forms.Label();
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.panel_panel2.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.tmr_timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel1.Name = "panel1";
            this.panel_panel1.Size = new System.Drawing.Size(1061, 28);
            this.panel_panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.lb_tiempoSys);
            this.panel_panel2.Controls.Add(this.lb_estadoEmp);
            this.panel_panel2.Controls.Add(this.cb_estadoEmp);
            this.panel_panel2.Controls.Add(this.txtbx_confContra);
            this.panel_panel2.Controls.Add(this.lb_confContra);
            this.panel_panel2.Controls.Add(this.lb_cargo);
            this.panel_panel2.Controls.Add(this.cb_cargo);
            this.panel_panel2.Controls.Add(this.txtbx_contrasena);
            this.panel_panel2.Controls.Add(this.lb_contrasena);
            this.panel_panel2.Controls.Add(this.txtbx_telefono);
            this.panel_panel2.Controls.Add(this.lb_telefono);
            this.panel_panel2.Controls.Add(this.txtbx_email);
            this.panel_panel2.Controls.Add(this.lb_email);
            this.panel_panel2.Controls.Add(this.txtbx_apellido);
            this.panel_panel2.Controls.Add(this.lb_apellido);
            this.panel_panel2.Controls.Add(this.txtbx_nombre);
            this.panel_panel2.Controls.Add(this.lb_nombre);
            this.panel_panel2.Controls.Add(this.lb_mantenimientoEmpl);
            this.panel_panel2.Controls.Add(this.btn_guardar);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(693, 28);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel2.Name = "panel2";
            this.panel_panel2.Size = new System.Drawing.Size(368, 683);
            this.panel_panel2.TabIndex = 35;
            this.panel_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Tiempo
            // 
            this.lb_tiempoSys.AutoSize = true;
            this.lb_tiempoSys.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_tiempoSys.Location = new System.Drawing.Point(226, 62);
            this.lb_tiempoSys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tiempoSys.Name = "Tiempo";
            this.lb_tiempoSys.Size = new System.Drawing.Size(35, 13);
            this.lb_tiempoSys.TabIndex = 70;
            this.lb_tiempoSys.Text = "label7";
            // 
            // label6
            // 
            this.lb_estadoEmp.AutoSize = true;
            this.lb_estadoEmp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estadoEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_estadoEmp.Location = new System.Drawing.Point(26, 520);
            this.lb_estadoEmp.Name = "label6";
            this.lb_estadoEmp.Size = new System.Drawing.Size(151, 22);
            this.lb_estadoEmp.TabIndex = 69;
            this.lb_estadoEmp.Text = "Estado Empleado";
            // 
            // cbEstado
            // 
            this.cb_estadoEmp.FormattingEnabled = true;
            this.cb_estadoEmp.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estadoEmp.Location = new System.Drawing.Point(184, 520);
            this.cb_estadoEmp.Margin = new System.Windows.Forms.Padding(2);
            this.cb_estadoEmp.Name = "cbEstado";
            this.cb_estadoEmp.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoEmp.TabIndex = 7;
            // 
            // txtContrasenaVer
            // 
            this.txtbx_confContra.Location = new System.Drawing.Point(184, 439);
            this.txtbx_confContra.Name = "txtContrasenaVer";
            this.txtbx_confContra.PasswordChar = '*';
            this.txtbx_confContra.Size = new System.Drawing.Size(121, 20);
            this.txtbx_confContra.TabIndex = 5;
            // 
            // label3
            // 
            this.lb_confContra.AutoSize = true;
            this.lb_confContra.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confContra.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_confContra.Location = new System.Drawing.Point(26, 440);
            this.lb_confContra.Name = "label3";
            this.lb_confContra.Size = new System.Drawing.Size(161, 19);
            this.lb_confContra.TabIndex = 66;
            this.lb_confContra.Text = "Confirmar contraseña";
            // 
            // label11
            // 
            this.lb_cargo.AutoSize = true;
            this.lb_cargo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cargo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_cargo.Location = new System.Drawing.Point(26, 323);
            this.lb_cargo.Name = "label11";
            this.lb_cargo.Size = new System.Drawing.Size(59, 22);
            this.lb_cargo.TabIndex = 65;
            this.lb_cargo.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Location = new System.Drawing.Point(184, 325);
            this.cb_cargo.Name = "cbCargo";
            this.cb_cargo.Size = new System.Drawing.Size(121, 21);
            this.cb_cargo.TabIndex = 2;
            // 
            // txtContrasena
            // 
            this.txtbx_contrasena.Location = new System.Drawing.Point(184, 401);
            this.txtbx_contrasena.Name = "txtContrasena";
            this.txtbx_contrasena.PasswordChar = '*';
            this.txtbx_contrasena.Size = new System.Drawing.Size(121, 20);
            this.txtbx_contrasena.TabIndex = 4;
            // 
            // label9
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_contrasena.Location = new System.Drawing.Point(26, 400);
            this.lb_contrasena.Name = "label9";
            this.lb_contrasena.Size = new System.Drawing.Size(101, 22);
            this.lb_contrasena.TabIndex = 62;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // txtTelefono
            // 
            this.txtbx_telefono.Location = new System.Drawing.Point(184, 480);
            this.txtbx_telefono.Name = "txtTelefono";
            this.txtbx_telefono.Size = new System.Drawing.Size(121, 20);
            this.txtbx_telefono.TabIndex = 6;
            // 
            // label8
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_telefono.Location = new System.Drawing.Point(26, 479);
            this.lb_telefono.Name = "label8";
            this.lb_telefono.Size = new System.Drawing.Size(81, 22);
            this.lb_telefono.TabIndex = 60;
            this.lb_telefono.Text = "Teléfono";
            // 
            // txtEmail
            // 
            this.txtbx_email.Location = new System.Drawing.Point(184, 367);
            this.txtbx_email.Name = "txtEmail";
            this.txtbx_email.Size = new System.Drawing.Size(121, 20);
            this.txtbx_email.TabIndex = 3;
            // 
            // label4
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_email.Location = new System.Drawing.Point(28, 366);
            this.lb_email.Name = "label4";
            this.lb_email.Size = new System.Drawing.Size(54, 22);
            this.lb_email.TabIndex = 58;
            this.lb_email.Text = "Email";
            // 
            // txtApellido
            // 
            this.txtbx_apellido.Location = new System.Drawing.Point(184, 286);
            this.txtbx_apellido.Name = "txtApellido";
            this.txtbx_apellido.Size = new System.Drawing.Size(121, 20);
            this.txtbx_apellido.TabIndex = 1;
            // 
            // label5
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_apellido.Location = new System.Drawing.Point(26, 284);
            this.lb_apellido.Name = "label5";
            this.lb_apellido.Size = new System.Drawing.Size(79, 22);
            this.lb_apellido.TabIndex = 56;
            this.lb_apellido.Text = "Apellido";
            // 
            // txtnombre
            // 
            this.txtbx_nombre.Location = new System.Drawing.Point(184, 241);
            this.txtbx_nombre.Name = "txtnombre";
            this.txtbx_nombre.Size = new System.Drawing.Size(121, 20);
            this.txtbx_nombre.TabIndex = 0;
            // 
            // label7
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_nombre.Location = new System.Drawing.Point(26, 240);
            this.lb_nombre.Name = "label7";
            this.lb_nombre.Size = new System.Drawing.Size(78, 22);
            this.lb_nombre.TabIndex = 54;
            this.lb_nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.lb_mantenimientoEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantenimientoEmpl.AutoSize = true;
            this.lb_mantenimientoEmpl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantenimientoEmpl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantenimientoEmpl.Location = new System.Drawing.Point(93, 133);
            this.lb_mantenimientoEmpl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mantenimientoEmpl.Name = "label2";
            this.lb_mantenimientoEmpl.Size = new System.Drawing.Size(229, 19);
            this.lb_mantenimientoEmpl.TabIndex = 53;
            this.lb_mantenimientoEmpl.Text = "Mantenimiento de Empleado";
            // 
            // button5
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Location = new System.Drawing.Point(60, 566);
            this.btn_guardar.Name = "button5";
            this.btn_guardar.Size = new System.Drawing.Size(237, 41);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(237, 6);
            this.btn_regresar.Name = "button4";
            this.btn_regresar.Size = new System.Drawing.Size(91, 33);
            this.btn_regresar.TabIndex = 37;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.dgv_empleados);
            this.panel_panel3.Controls.Add(this.btn_editar);
            this.panel_panel3.Controls.Add(this.btn_eliminar);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 28);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel3.Name = "panel3";
            this.panel_panel3.Size = new System.Drawing.Size(693, 683);
            this.panel_panel3.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dgv_empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(10, 208);
            this.dgv_empleados.Name = "dataGridView1";
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.Size = new System.Drawing.Size(661, 349);
            this.dgv_empleados.TabIndex = 179;
            this.dgv_empleados.Tag = "";
            this.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button3
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Location = new System.Drawing.Point(31, 584);
            this.btn_editar.Name = "button3";
            this.btn_editar.Size = new System.Drawing.Size(119, 39);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Location = new System.Drawing.Point(171, 584);
            this.btn_eliminar.Name = "button2";
            this.btn_eliminar.Size = new System.Drawing.Size(111, 39);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(221, 40);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "label1";
            this.lb_cinehub.Size = new System.Drawing.Size(282, 85);
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
            this.panel_panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr_timer1;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Label lb_mantenimientoEmpl;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lb_cinehub;
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
        private System.Windows.Forms.Label lb_tiempoSys;
    }
}