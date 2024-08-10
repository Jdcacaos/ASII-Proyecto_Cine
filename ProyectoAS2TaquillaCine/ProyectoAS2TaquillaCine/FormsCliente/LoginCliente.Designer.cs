
namespace ProyectoAS2TaquillaCine.FormsCliente
{
    partial class LoginCliente
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
            this.chb_mostrarContra = new System.Windows.Forms.CheckBox();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.lb_correo = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.picbx_imagenCine = new System.Windows.Forms.PictureBox();
            this.txtbx_correoUsuario = new System.Windows.Forms.TextBox();
            this.txtbx_contrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagenCine)).BeginInit();
            this.SuspendLayout();
            // 
            // chb_mostrarContra
            // 
            this.chb_mostrarContra.AutoSize = true;
            this.chb_mostrarContra.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_mostrarContra.ForeColor = System.Drawing.SystemColors.Window;
            this.chb_mostrarContra.Location = new System.Drawing.Point(225, 358);
            this.chb_mostrarContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chb_mostrarContra.Name = "chb_mostrarContra";
            this.chb_mostrarContra.Size = new System.Drawing.Size(173, 28);
            this.chb_mostrarContra.TabIndex = 2;
            this.chb_mostrarContra.Text = "Mostrar contraseña";
            this.chb_mostrarContra.UseVisualStyleBackColor = true;
            this.chb_mostrarContra.CheckedChanged += new System.EventHandler(this.mostrarCon_CheckedChanged);
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_contrasena.Location = new System.Drawing.Point(216, 223);
            this.lb_contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(209, 52);
            this.lb_contrasena.TabIndex = 11;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // lb_correo
            // 
            this.lb_correo.AutoSize = true;
            this.lb_correo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correo.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_correo.Location = new System.Drawing.Point(236, 66);
            this.lb_correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_correo.Name = "lb_correo";
            this.lb_correo.Size = new System.Drawing.Size(133, 52);
            this.lb_correo.TabIndex = 9;
            this.lb_correo.Text = "Correo";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(135, 458);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(372, 92);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_regresar.Location = new System.Drawing.Point(1, 14);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(163, 46);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarse.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarse.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_registrarse.Location = new System.Drawing.Point(225, 588);
            this.btn_registrarse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(213, 43);
            this.btn_registrarse.TabIndex = 4;
            this.btn_registrarse.Text = "Registrarse";
            this.btn_registrarse.UseVisualStyleBackColor = true;
            this.btn_registrarse.Click += new System.EventHandler(this.button3_Click);
            // 
            // picbx_imagenCine
            // 
            this.picbx_imagenCine.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.cine;
            this.picbx_imagenCine.Location = new System.Drawing.Point(660, -102);
            this.picbx_imagenCine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbx_imagenCine.Name = "picbx_imagenCine";
            this.picbx_imagenCine.Size = new System.Drawing.Size(789, 944);
            this.picbx_imagenCine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_imagenCine.TabIndex = 8;
            this.picbx_imagenCine.TabStop = false;
            // 
            // txtbx_correoUsuario
            // 
            this.txtbx_correoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtbx_correoUsuario.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_correoUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbx_correoUsuario.Location = new System.Drawing.Point(91, 142);
            this.txtbx_correoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_correoUsuario.Name = "txtbx_correoUsuario";
            this.txtbx_correoUsuario.Size = new System.Drawing.Size(507, 58);
            this.txtbx_correoUsuario.TabIndex = 0;
            // 
            // txtbx_contrasena
            // 
            this.txtbx_contrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtbx_contrasena.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_contrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbx_contrasena.Location = new System.Drawing.Point(91, 289);
            this.txtbx_contrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_contrasena.Name = "txtbx_contrasena";
            this.txtbx_contrasena.PasswordChar = '*';
            this.txtbx_contrasena.Size = new System.Drawing.Size(507, 61);
            this.txtbx_contrasena.TabIndex = 1;
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1439, 740);
            this.Controls.Add(this.txtbx_contrasena);
            this.Controls.Add(this.txtbx_correoUsuario);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.chb_mostrarContra);
            this.Controls.Add(this.lb_contrasena);
            this.Controls.Add(this.lb_correo);
            this.Controls.Add(this.picbx_imagenCine);
            this.Controls.Add(this.btn_ingresar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCliente";
            this.Load += new System.EventHandler(this.LoginCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagenCine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_mostrarContra;
        private System.Windows.Forms.Label lb_contrasena;
        private System.Windows.Forms.Label lb_correo;
        private System.Windows.Forms.PictureBox picbx_imagenCine;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_registrarse;
        private System.Windows.Forms.TextBox txtbx_correoUsuario;
        private System.Windows.Forms.TextBox txtbx_contrasena;
    }
}