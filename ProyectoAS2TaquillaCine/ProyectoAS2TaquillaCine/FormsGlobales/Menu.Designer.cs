
namespace ProyectoAS2TaquillaCine.FormsGlobales
{
    partial class Menu
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
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.btn_administrador = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.AutoSize = true;
            this.lb_cinehub.BackColor = System.Drawing.Color.Transparent;
            this.lb_cinehub.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.Color.AliceBlue;
            this.lb_cinehub.Location = new System.Drawing.Point(229, 106);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(192, 46);
            this.lb_cinehub.TabIndex = 8;
            this.lb_cinehub.Text = "CINEHUB";
            // 
            // btn_administrador
            // 
            this.btn_administrador.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrador.Location = new System.Drawing.Point(374, 251);
            this.btn_administrador.Name = "btn_administrador";
            this.btn_administrador.Size = new System.Drawing.Size(221, 79);
            this.btn_administrador.TabIndex = 2;
            this.btn_administrador.Text = "Administrador";
            this.btn_administrador.UseVisualStyleBackColor = false;
            this.btn_administrador.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Location = new System.Drawing.Point(84, 251);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(201, 79);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.Red;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_apagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_apagar.Location = new System.Drawing.Point(12, 12);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_apagar.Size = new System.Drawing.Size(120, 60);
            this.btn_apagar.TabIndex = 3;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoAS2TaquillaCine.Properties.Resources.cinema_movies_concept_background_with_5761469;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 445);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lb_cinehub);
            this.Controls.Add(this.btn_administrador);
            this.Controls.Add(this.btn_cliente);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Button btn_administrador;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_apagar;
    }
}