
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class Ubicaciones
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
            this.lbl_FechaHora = new System.Windows.Forms.Label();
            this.lbl_Ciudad = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.tm_tiempo = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Ubicaciones = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ubicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FechaHora
            // 
            this.lbl_FechaHora.AutoSize = true;
            this.lbl_FechaHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_FechaHora.Location = new System.Drawing.Point(277, 69);
            this.lbl_FechaHora.Name = "lbl_FechaHora";
            this.lbl_FechaHora.Size = new System.Drawing.Size(37, 13);
            this.lbl_FechaHora.TabIndex = 26;
            this.lbl_FechaHora.Text = "Fecha";
            // 
            // lbl_Ciudad
            // 
            this.lbl_Ciudad.AutoSize = true;
            this.lbl_Ciudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Ciudad.Location = new System.Drawing.Point(70, 312);
            this.lbl_Ciudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ciudad.Name = "lbl_Ciudad";
            this.lbl_Ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_Ciudad.TabIndex = 32;
            this.lbl_Ciudad.Text = "Ciudad";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Direccion.Location = new System.Drawing.Point(50, 355);
            this.lbl_Direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(87, 13);
            this.lbl_Direccion.TabIndex = 33;
            this.lbl_Direccion.Text = "Centro Comercial";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(141, 310);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(157, 20);
            this.txtCiudad.TabIndex = 34;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(141, 352);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(157, 20);
            this.txtUbicacion.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 28);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.txtUbicacion);
            this.panel2.Controls.Add(this.txtCiudad);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbl_Direccion);
            this.panel2.Controls.Add(this.lbl_FechaHora);
            this.panel2.Controls.Add(this.lbl_Ciudad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(612, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 680);
            this.panel2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(93, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mantenimiento de Ubicacion";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(60, 566);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 41);
            this.button5.TabIndex = 38;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(237, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.DGV_Ubicaciones);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 680);
            this.panel3.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(182, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 85);
            this.label1.TabIndex = 182;
            this.label1.Text = "CINEHUB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DGV_Ubicaciones
            // 
            this.DGV_Ubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Ubicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ubicaciones.Location = new System.Drawing.Point(47, 157);
            this.DGV_Ubicaciones.Name = "DGV_Ubicaciones";
            this.DGV_Ubicaciones.RowHeadersWidth = 51;
            this.DGV_Ubicaciones.Size = new System.Drawing.Size(520, 366);
            this.DGV_Ubicaciones.TabIndex = 181;
            this.DGV_Ubicaciones.Tag = "";
            this.DGV_Ubicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Ubicaciones_CellContentClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(56, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 39);
            this.button3.TabIndex = 40;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(192, 580);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 39);
            this.button6.TabIndex = 41;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubicaciones";
            this.Text = "Ubicaciones";
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ubicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_FechaHora;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Timer tm_tiempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Ubicaciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
    }
}