
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
            this.txtbx_user = new System.Windows.Forms.TextBox();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.chb_mostrarCont = new System.Windows.Forms.CheckBox();
            this.picbx_imagen = new System.Windows.Forms.PictureBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.txtbx_contrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(200, 542);
            this.btn_ingresar.Name = "btnIngresar";
            this.btn_ingresar.Size = new System.Drawing.Size(225, 80);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.lb_correo.AutoSize = true;
            this.lb_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correo.Location = new System.Drawing.Point(255, 96);
            this.lb_correo.Name = "label1";
            this.lb_correo.Size = new System.Drawing.Size(123, 39);
            this.lb_correo.TabIndex = 2;
            this.lb_correo.Text = "Correo";
            // 
            // txtuser
            // 
            this.txtbx_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_user.Location = new System.Drawing.Point(123, 154);
            this.txtbx_user.Name = "txtuser";
            this.txtbx_user.Size = new System.Drawing.Size(394, 47);
            this.txtbx_user.TabIndex = 0;
            this.txtbx_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.Location = new System.Drawing.Point(233, 264);
            this.lb_contrasena.Name = "label2";
            this.lb_contrasena.Size = new System.Drawing.Size(196, 39);
            this.lb_contrasena.TabIndex = 4;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // checkBox1
            // 
            this.chb_mostrarCont.AutoSize = true;
            this.chb_mostrarCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_mostrarCont.Location = new System.Drawing.Point(240, 372);
            this.chb_mostrarCont.Name = "checkBox1";
            this.chb_mostrarCont.Size = new System.Drawing.Size(166, 24);
            this.chb_mostrarCont.TabIndex = 2;
            this.chb_mostrarCont.Text = "Mostrar contraseña";
            this.chb_mostrarCont.UseVisualStyleBackColor = true;
            this.chb_mostrarCont.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.picbx_imagen.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.telefono_gratuito_cinesur;
            this.picbx_imagen.Location = new System.Drawing.Point(626, -2);
            this.picbx_imagen.Name = "pictureBox1";
            this.picbx_imagen.Size = new System.Drawing.Size(592, 767);
            this.picbx_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_imagen.TabIndex = 1;
            this.picbx_imagen.TabStop = false;
            // 
            // button2
            // 
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "button2";
            this.btn_regresar.Size = new System.Drawing.Size(122, 37);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtContra
            // 
            this.txtbx_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_contrasena.Location = new System.Drawing.Point(123, 306);
            this.txtbx_contrasena.Name = "txtContra";
            this.txtbx_contrasena.PasswordChar = '*';
            this.txtbx_contrasena.Size = new System.Drawing.Size(394, 47);
            this.txtbx_contrasena.TabIndex = 1;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.txtbx_contrasena);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.chb_mostrarCont);
            this.Controls.Add(this.lb_contrasena);
            this.Controls.Add(this.txtbx_user);
            this.Controls.Add(this.lb_correo);
            this.Controls.Add(this.picbx_imagen);
            this.Controls.Add(this.btn_ingresar);
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.picbx_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.PictureBox picbx_imagen;
        private System.Windows.Forms.Label lb_correo;
        private System.Windows.Forms.TextBox txtbx_user;
        private System.Windows.Forms.Label lb_contrasena;
        private System.Windows.Forms.CheckBox chb_mostrarCont;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.TextBox txtbx_contrasena;
    }
}