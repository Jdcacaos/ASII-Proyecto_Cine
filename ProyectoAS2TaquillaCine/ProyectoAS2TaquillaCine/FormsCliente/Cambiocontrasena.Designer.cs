
namespace ProyectoAS2TaquillaCine.FormsCliente
{
    partial class Cambiocontrasena
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_cambiocontrasena = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_nuevacontrasena = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(236, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(182, 17);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "CAMBIO DE CONTRASENA";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(197, 93);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(68, 17);
            this.lbl_correo.TabIndex = 1;
            this.lbl_correo.Text = "CORREO";
            // 
            // lbl_cambiocontrasena
            // 
            this.lbl_cambiocontrasena.AutoSize = true;
            this.lbl_cambiocontrasena.Location = new System.Drawing.Point(111, 142);
            this.lbl_cambiocontrasena.Name = "lbl_cambiocontrasena";
            this.lbl_cambiocontrasena.Size = new System.Drawing.Size(154, 17);
            this.lbl_cambiocontrasena.TabIndex = 2;
            this.lbl_cambiocontrasena.Text = "CONTRASEÑA NUEVA";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(302, 87);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(182, 22);
            this.txt_correo.TabIndex = 3;
            // 
            // txt_nuevacontrasena
            // 
            this.txt_nuevacontrasena.Location = new System.Drawing.Point(302, 139);
            this.txt_nuevacontrasena.Name = "txt_nuevacontrasena";
            this.txt_nuevacontrasena.Size = new System.Drawing.Size(182, 22);
            this.txt_nuevacontrasena.TabIndex = 4;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(290, 210);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(146, 63);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.Text = "Actualizar Contraseña";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Cambiocontrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 353);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_nuevacontrasena);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_cambiocontrasena);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Cambiocontrasena";
            this.Text = "Cambiocontrasena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_cambiocontrasena;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_nuevacontrasena;
        private System.Windows.Forms.Button btn_actualizar;
    }
}