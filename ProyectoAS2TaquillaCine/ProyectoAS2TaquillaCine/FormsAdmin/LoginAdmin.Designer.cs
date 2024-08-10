
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class LoginAdmin
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
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lb_correo = new System.Windows.Forms.Label();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.chb_mostrarCont = new System.Windows.Forms.CheckBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.txtbx_user = new System.Windows.Forms.TextBox();
            this.txtbx_contrasena = new System.Windows.Forms.TextBox();
            this.picbx_imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(269, 545);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(300, 98);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_correo
            // 
            this.lb_correo.AutoSize = true;
            this.lb_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correo.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_correo.Location = new System.Drawing.Point(340, 118);
            this.lb_correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_correo.Name = "lb_correo";
            this.lb_correo.Size = new System.Drawing.Size(157, 52);
            this.lb_correo.TabIndex = 2;
            this.lb_correo.Text = "Correo";
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_contrasena.Location = new System.Drawing.Point(311, 325);
            this.lb_contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(248, 52);
            this.lb_contrasena.TabIndex = 4;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // chb_mostrarCont
            // 
            this.chb_mostrarCont.AutoSize = true;
            this.chb_mostrarCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_mostrarCont.ForeColor = System.Drawing.SystemColors.Window;
            this.chb_mostrarCont.Location = new System.Drawing.Point(320, 458);
            this.chb_mostrarCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chb_mostrarCont.Name = "chb_mostrarCont";
            this.chb_mostrarCont.Size = new System.Drawing.Size(202, 29);
            this.chb_mostrarCont.TabIndex = 3;
            this.chb_mostrarCont.Text = "Mostrar contraseña";
            this.chb_mostrarCont.UseVisualStyleBackColor = true;
            this.chb_mostrarCont.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_regresar
            // 
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_regresar.Location = new System.Drawing.Point(16, 15);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(163, 46);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbx_user
            // 
            this.txtbx_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtbx_user.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_user.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbx_user.Location = new System.Drawing.Point(164, 194);
            this.txtbx_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_user.Name = "txtbx_user";
            this.txtbx_user.Size = new System.Drawing.Size(507, 58);
            this.txtbx_user.TabIndex = 1;
            // 
            // txtbx_contrasena
            // 
            this.txtbx_contrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtbx_contrasena.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_contrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbx_contrasena.Location = new System.Drawing.Point(164, 389);
            this.txtbx_contrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_contrasena.Name = "txtbx_contrasena";
            this.txtbx_contrasena.PasswordChar = '*';
            this.txtbx_contrasena.Size = new System.Drawing.Size(507, 61);
            this.txtbx_contrasena.TabIndex = 2;
            // 
            // picbx_imagen
            // 
            this.picbx_imagen.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.telefono_gratuito_cinesur;
            this.picbx_imagen.Location = new System.Drawing.Point(835, -2);
            this.picbx_imagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbx_imagen.Name = "picbx_imagen";
            this.picbx_imagen.Size = new System.Drawing.Size(789, 944);
            this.picbx_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_imagen.TabIndex = 1;
            this.picbx_imagen.TabStop = false;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.txtbx_contrasena);
            this.Controls.Add(this.txtbx_user);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.chb_mostrarCont);
            this.Controls.Add(this.lb_contrasena);
            this.Controls.Add(this.lb_correo);
            this.Controls.Add(this.picbx_imagen);
            this.Controls.Add(this.btn_ingresar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAdmin";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.PictureBox picbx_imagen;
        private System.Windows.Forms.Label lb_correo;
        private System.Windows.Forms.Label lb_contrasena;
        private System.Windows.Forms.CheckBox chb_mostrarCont;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.TextBox txtbx_user;
        private System.Windows.Forms.TextBox txtbx_contrasena;
    }
}