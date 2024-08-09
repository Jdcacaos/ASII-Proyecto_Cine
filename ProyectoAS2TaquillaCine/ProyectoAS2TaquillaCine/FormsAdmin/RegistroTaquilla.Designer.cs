
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class RegistroTaquilla
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
            this.panel_panelReporte = new System.Windows.Forms.Panel();
            this.lb_hasta = new System.Windows.Forms.Label();
            this.lb_inicio = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_generarReporte = new System.Windows.Forms.Button();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dgv_taquilla = new System.Windows.Forms.DataGridView();
            this.lb_subtitulo = new System.Windows.Forms.Label();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.panel_panelReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taquilla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_panelReporte
            // 
            this.panel_panelReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panelReporte.Controls.Add(this.lb_hasta);
            this.panel_panelReporte.Controls.Add(this.lb_inicio);
            this.panel_panelReporte.Controls.Add(this.btn_salir);
            this.panel_panelReporte.Controls.Add(this.btn_generarReporte);
            this.panel_panelReporte.Controls.Add(this.dtp_final);
            this.panel_panelReporte.Controls.Add(this.dtp_inicio);
            this.panel_panelReporte.Controls.Add(this.dgv_taquilla);
            this.panel_panelReporte.Controls.Add(this.lb_subtitulo);
            this.panel_panelReporte.Controls.Add(this.lb_cinehub);
            this.panel_panelReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panelReporte.Location = new System.Drawing.Point(0, 0);
            this.panel_panelReporte.Name = "panel_panelReporte";
            this.panel_panelReporte.Size = new System.Drawing.Size(800, 450);
            this.panel_panelReporte.TabIndex = 1;
            // 
            // lb_hasta
            // 
            this.lb_hasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_hasta.AutoSize = true;
            this.lb_hasta.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hasta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_hasta.Location = new System.Drawing.Point(427, 171);
            this.lb_hasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hasta.Name = "lb_hasta";
            this.lb_hasta.Size = new System.Drawing.Size(52, 19);
            this.lb_hasta.TabIndex = 192;
            this.lb_hasta.Text = "Hasta";
            // 
            // lb_inicio
            // 
            this.lb_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_inicio.AutoSize = true;
            this.lb_inicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_inicio.Location = new System.Drawing.Point(57, 171);
            this.lb_inicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_inicio.Name = "lb_inicio";
            this.lb_inicio.Size = new System.Drawing.Size(56, 19);
            this.lb_inicio.TabIndex = 191;
            this.lb_inicio.Text = "Desde";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.LightCoral;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Location = new System.Drawing.Point(61, 117);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(123, 34);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_generarReporte
            // 
            this.btn_generarReporte.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_generarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarReporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_generarReporte.Location = new System.Drawing.Point(603, 117);
            this.btn_generarReporte.Name = "btn_generarReporte";
            this.btn_generarReporte.Size = new System.Drawing.Size(123, 34);
            this.btn_generarReporte.TabIndex = 3;
            this.btn_generarReporte.Text = "Generar Reporte";
            this.btn_generarReporte.UseVisualStyleBackColor = false;
            this.btn_generarReporte.Click += new System.EventHandler(this.btn_generareporte_Click);
            // 
            // dtp_final
            // 
            this.dtp_final.CustomFormat = "yyyy/MM/dd";
            this.dtp_final.Location = new System.Drawing.Point(484, 169);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(200, 20);
            this.dtp_final.TabIndex = 2;
            this.dtp_final.Value = new System.DateTime(2024, 8, 8, 16, 54, 16, 0);
            this.dtp_final.ValueChanged += new System.EventHandler(this.dtp_Final_ValueChanged);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CustomFormat = "yyyy/MM/dd";
            this.dtp_inicio.Location = new System.Drawing.Point(121, 171);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(202, 20);
            this.dtp_inicio.TabIndex = 1;
            this.dtp_inicio.Value = new System.DateTime(2024, 8, 8, 16, 54, 21, 0);
            this.dtp_inicio.ValueChanged += new System.EventHandler(this.dtp_Inicio_ValueChanged);
            // 
            // dgv_taquilla
            // 
            this.dgv_taquilla.AllowUserToOrderColumns = true;
            this.dgv_taquilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taquilla.Location = new System.Drawing.Point(61, 216);
            this.dgv_taquilla.Name = "dgv_taquilla";
            this.dgv_taquilla.ReadOnly = true;
            this.dgv_taquilla.Size = new System.Drawing.Size(665, 148);
            this.dgv_taquilla.TabIndex = 185;
            // 
            // lb_subtitulo
            // 
            this.lb_subtitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_subtitulo.AutoSize = true;
            this.lb_subtitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_subtitulo.Location = new System.Drawing.Point(349, 94);
            this.lb_subtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_subtitulo.Name = "lb_subtitulo";
            this.lb_subtitulo.Size = new System.Drawing.Size(68, 19);
            this.lb_subtitulo.TabIndex = 184;
            this.lb_subtitulo.Text = "Taquilla";
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(229, 9);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(316, 85);
            this.lb_cinehub.TabIndex = 183;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistroTaquilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_panelReporte);
            this.Name = "RegistroTaquilla";
            this.Text = "RegistroTaquilla";
            this.Load += new System.EventHandler(this.RegistroTaquilla_Load);
            this.panel_panelReporte.ResumeLayout(false);
            this.panel_panelReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taquilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_panelReporte;
        private System.Windows.Forms.Label lb_hasta;
        private System.Windows.Forms.Label lb_inicio;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_generarReporte;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DataGridView dgv_taquilla;
        private System.Windows.Forms.Label lb_subtitulo;
        private System.Windows.Forms.Label lb_cinehub;
    }
}