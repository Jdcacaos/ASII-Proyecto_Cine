
namespace ProyectoAS2TaquillaCine.FormsCliente
{
    partial class RegistroCliente
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
            this.txtbx_nombre = new System.Windows.Forms.TextBox();
            this.txtbx_apellido = new System.Windows.Forms.TextBox();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.txtbx_contrasena = new System.Windows.Forms.TextBox();
            this.txtbx_verifContrasena = new System.Windows.Forms.TextBox();
            this.txtbx_telefono = new System.Windows.Forms.TextBox();
            this.txtbx_nit = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.lb_confContra = new System.Windows.Forms.Label();
            this.lb_telefono = new System.Windows.Forms.Label();
            this.lb_nit = new System.Windows.Forms.Label();
            this.lb_fechaNac = new System.Windows.Forms.Label();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_nombre
            // 
            this.txtbx_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_nombre.Location = new System.Drawing.Point(113, 151);
            this.txtbx_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_nombre.Multiline = true;
            this.txtbx_nombre.Name = "txtbx_nombre";
            this.txtbx_nombre.Size = new System.Drawing.Size(281, 37);
            this.txtbx_nombre.TabIndex = 0;
            this.txtbx_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbx_apellido
            // 
            this.txtbx_apellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_apellido.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_apellido.Location = new System.Drawing.Point(469, 151);
            this.txtbx_apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_apellido.Multiline = true;
            this.txtbx_apellido.Name = "txtbx_apellido";
            this.txtbx_apellido.Size = new System.Drawing.Size(281, 37);
            this.txtbx_apellido.TabIndex = 1;
            this.txtbx_apellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtbx_email
            // 
            this.txtbx_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_email.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_email.Location = new System.Drawing.Point(113, 261);
            this.txtbx_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_email.Multiline = true;
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(637, 47);
            this.txtbx_email.TabIndex = 2;
            this.txtbx_email.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtbx_contrasena
            // 
            this.txtbx_contrasena.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_contrasena.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_contrasena.Location = new System.Drawing.Point(113, 405);
            this.txtbx_contrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_contrasena.Multiline = true;
            this.txtbx_contrasena.Name = "txtbx_contrasena";
            this.txtbx_contrasena.PasswordChar = '*';
            this.txtbx_contrasena.Size = new System.Drawing.Size(281, 46);
            this.txtbx_contrasena.TabIndex = 3;
            this.txtbx_contrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // txtbx_verifContrasena
            // 
            this.txtbx_verifContrasena.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_verifContrasena.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_verifContrasena.Location = new System.Drawing.Point(469, 405);
            this.txtbx_verifContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_verifContrasena.Multiline = true;
            this.txtbx_verifContrasena.Name = "txtbx_verifContrasena";
            this.txtbx_verifContrasena.PasswordChar = '*';
            this.txtbx_verifContrasena.Size = new System.Drawing.Size(281, 46);
            this.txtbx_verifContrasena.TabIndex = 4;
            this.txtbx_verifContrasena.TextChanged += new System.EventHandler(this.txtContrasenaVer_TextChanged);
            // 
            // txtbx_telefono
            // 
            this.txtbx_telefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_telefono.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_telefono.Location = new System.Drawing.Point(113, 518);
            this.txtbx_telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_telefono.Multiline = true;
            this.txtbx_telefono.Name = "txtbx_telefono";
            this.txtbx_telefono.Size = new System.Drawing.Size(281, 42);
            this.txtbx_telefono.TabIndex = 5;
            this.txtbx_telefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtbx_nit
            // 
            this.txtbx_nit.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_nit.Location = new System.Drawing.Point(469, 518);
            this.txtbx_nit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_nit.Multiline = true;
            this.txtbx_nit.Name = "txtbx_nit";
            this.txtbx_nit.Size = new System.Drawing.Size(281, 42);
            this.txtbx_nit.TabIndex = 6;
            this.txtbx_nit.TextChanged += new System.EventHandler(this.txtNit_TextChanged);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nombre.Location = new System.Drawing.Point(107, 97);
            this.lb_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(114, 31);
            this.lb_nombre.TabIndex = 9;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_apellido.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_apellido.Location = new System.Drawing.Point(463, 97);
            this.lb_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(115, 31);
            this.lb_apellido.TabIndex = 10;
            this.lb_apellido.Text = "Apellido";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_email.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_email.Location = new System.Drawing.Point(107, 226);
            this.lb_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(80, 31);
            this.lb_email.TabIndex = 11;
            this.lb_email.Text = "Email";
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_contrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_contrasena.Location = new System.Drawing.Point(107, 350);
            this.lb_contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(152, 31);
            this.lb_contrasena.TabIndex = 12;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // lb_confContra
            // 
            this.lb_confContra.AutoSize = true;
            this.lb_confContra.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_confContra.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_confContra.Location = new System.Drawing.Point(463, 350);
            this.lb_confContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_confContra.Name = "lb_confContra";
            this.lb_confContra.Size = new System.Drawing.Size(278, 31);
            this.lb_confContra.TabIndex = 13;
            this.lb_confContra.Text = "Confirmar contraseña";
            // 
            // lb_telefono
            // 
            this.lb_telefono.AutoSize = true;
            this.lb_telefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_telefono.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_telefono.Location = new System.Drawing.Point(107, 474);
            this.lb_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_telefono.Name = "lb_telefono";
            this.lb_telefono.Size = new System.Drawing.Size(122, 31);
            this.lb_telefono.TabIndex = 14;
            this.lb_telefono.Text = "Telefono";
            this.lb_telefono.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_nit
            // 
            this.lb_nit.AutoSize = true;
            this.lb_nit.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_nit.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nit.Location = new System.Drawing.Point(463, 474);
            this.lb_nit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nit.Name = "lb_nit";
            this.lb_nit.Size = new System.Drawing.Size(57, 31);
            this.lb_nit.TabIndex = 15;
            this.lb_nit.Text = "NIT";
            // 
            // lb_fechaNac
            // 
            this.lb_fechaNac.AutoSize = true;
            this.lb_fechaNac.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_fechaNac.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_fechaNac.Location = new System.Drawing.Point(107, 594);
            this.lb_fechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaNac.Name = "lb_fechaNac";
            this.lb_fechaNac.Size = new System.Drawing.Size(263, 31);
            this.lb_fechaNac.TabIndex = 16;
            this.lb_fechaNac.Text = "Fecha de nacimiento";
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_registrarse.Location = new System.Drawing.Point(326, 643);
            this.btn_registrarse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(181, 42);
            this.btn_registrarse.TabIndex = 8;
            this.btn_registrarse.Text = "Registrarse";
            this.btn_registrarse.UseVisualStyleBackColor = true;
            this.btn_registrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(432, 603);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(265, 22);
            this.dtp_fecha.TabIndex = 7;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(147, 39);
            this.btn_regresar.TabIndex = 9;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(893, 750);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.lb_fechaNac);
            this.Controls.Add(this.lb_nit);
            this.Controls.Add(this.lb_telefono);
            this.Controls.Add(this.lb_confContra);
            this.Controls.Add(this.lb_contrasena);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_apellido);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.txtbx_nit);
            this.Controls.Add(this.txtbx_telefono);
            this.Controls.Add(this.txtbx_verifContrasena);
            this.Controls.Add(this.txtbx_contrasena);
            this.Controls.Add(this.txtbx_email);
            this.Controls.Add(this.txtbx_apellido);
            this.Controls.Add(this.txtbx_nombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroCliente";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_nombre;
        private System.Windows.Forms.TextBox txtbx_apellido;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.TextBox txtbx_contrasena;
        private System.Windows.Forms.TextBox txtbx_verifContrasena;
        private System.Windows.Forms.TextBox txtbx_telefono;
        private System.Windows.Forms.TextBox txtbx_nit;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_contrasena;
        private System.Windows.Forms.Label lb_confContra;
        private System.Windows.Forms.Label lb_telefono;
        private System.Windows.Forms.Label lb_nit;
        private System.Windows.Forms.Label lb_fechaNac;
        private System.Windows.Forms.Button btn_registrarse;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_regresar;
    }
}