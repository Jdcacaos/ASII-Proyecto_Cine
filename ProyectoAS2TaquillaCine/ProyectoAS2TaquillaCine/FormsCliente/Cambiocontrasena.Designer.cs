
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
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(339, 28);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(238, 24);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "CAMBIO DE CONTRASENA";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_correo.Location = new System.Drawing.Point(271, 139);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(83, 24);
            this.lbl_correo.TabIndex = 1;
            this.lbl_correo.Text = "CORREO";
            // 
            // lbl_cambiocontrasena
            // 
            this.lbl_cambiocontrasena.AutoSize = true;
            this.lbl_cambiocontrasena.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambiocontrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cambiocontrasena.Location = new System.Drawing.Point(152, 213);
            this.lbl_cambiocontrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cambiocontrasena.Name = "lbl_cambiocontrasena";
            this.lbl_cambiocontrasena.Size = new System.Drawing.Size(199, 24);
            this.lbl_cambiocontrasena.TabIndex = 2;
            this.lbl_cambiocontrasena.Text = "CONTRASEÑA NUEVA";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(415, 131);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(249, 30);
            this.txt_correo.TabIndex = 3;
            // 
            // txt_nuevacontrasena
            // 
            this.txt_nuevacontrasena.Location = new System.Drawing.Point(415, 208);
            this.txt_nuevacontrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nuevacontrasena.Name = "txt_nuevacontrasena";
            this.txt_nuevacontrasena.Size = new System.Drawing.Size(249, 30);
            this.txt_nuevacontrasena.TabIndex = 4;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_actualizar.Location = new System.Drawing.Point(399, 315);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(201, 94);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.Text = "Actualizar Contraseña";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // Cambiocontrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(855, 460);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_nuevacontrasena);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_cambiocontrasena);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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