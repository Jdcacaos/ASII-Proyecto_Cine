
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class Reportes
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
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_generaReporte = new System.Windows.Forms.Button();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.dtp_inidio = new System.Windows.Forms.DateTimePicker();
            this.dgv_ganancias = new System.Windows.Forms.DataGridView();
            this.lb_subtitulo = new System.Windows.Forms.Label();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.panel_panelReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ganancias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_panelReporte
            // 
            this.panel_panelReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panelReporte.Controls.Add(this.lb_hasta);
            this.panel_panelReporte.Controls.Add(this.lb_inicio);
            this.panel_panelReporte.Controls.Add(this.btn_salir);
            this.panel_panelReporte.Controls.Add(this.lb_total);
            this.panel_panelReporte.Controls.Add(this.btn_generaReporte);
            this.panel_panelReporte.Controls.Add(this.dtp_final);
            this.panel_panelReporte.Controls.Add(this.dtp_inidio);
            this.panel_panelReporte.Controls.Add(this.dgv_ganancias);
            this.panel_panelReporte.Controls.Add(this.lb_subtitulo);
            this.panel_panelReporte.Controls.Add(this.lb_cinehub);
            this.panel_panelReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panelReporte.Location = new System.Drawing.Point(0, 0);
            this.panel_panelReporte.Name = "panel_panelReporte";
            this.panel_panelReporte.Size = new System.Drawing.Size(797, 450);
            this.panel_panelReporte.TabIndex = 0;
            // 
            // lb_hasta
            // 
            this.lb_hasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_hasta.AutoSize = true;
            this.lb_hasta.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hasta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_hasta.Location = new System.Drawing.Point(428, 125);
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
            this.lb_inicio.Location = new System.Drawing.Point(55, 125);
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
            this.btn_salir.Location = new System.Drawing.Point(49, 79);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(123, 34);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lb_total
            // 
            this.lb_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_total.Location = new System.Drawing.Point(526, 422);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(44, 19);
            this.lb_total.TabIndex = 189;
            this.lb_total.Text = "total";
            // 
            // btn_generaReporte
            // 
            this.btn_generaReporte.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_generaReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generaReporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_generaReporte.Location = new System.Drawing.Point(601, 79);
            this.btn_generaReporte.Name = "btn_generaReporte";
            this.btn_generaReporte.Size = new System.Drawing.Size(123, 34);
            this.btn_generaReporte.TabIndex = 3;
            this.btn_generaReporte.Text = "Generar Reporte";
            this.btn_generaReporte.UseVisualStyleBackColor = false;
            this.btn_generaReporte.Click += new System.EventHandler(this.btn_generareporte_Click);
            // 
            // dtp_final
            // 
            this.dtp_final.CustomFormat = "yyyy/MM/dd";
            this.dtp_final.Location = new System.Drawing.Point(489, 125);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(200, 20);
            this.dtp_final.TabIndex = 2;
            this.dtp_final.Value = new System.DateTime(2024, 8, 8, 16, 54, 16, 0);
            // 
            // dtp_inidio
            // 
            this.dtp_inidio.CustomFormat = "yyyy/MM/dd";
            this.dtp_inidio.Location = new System.Drawing.Point(119, 125);
            this.dtp_inidio.Name = "dtp_inidio";
            this.dtp_inidio.Size = new System.Drawing.Size(202, 20);
            this.dtp_inidio.TabIndex = 1;
            this.dtp_inidio.Value = new System.DateTime(2024, 8, 8, 16, 54, 21, 0);
            // 
            // dgv_ganancias
            // 
            this.dgv_ganancias.AllowUserToOrderColumns = true;
            this.dgv_ganancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ganancias.Location = new System.Drawing.Point(59, 151);
            this.dgv_ganancias.Name = "dgv_ganancias";
            this.dgv_ganancias.ReadOnly = true;
            this.dgv_ganancias.Size = new System.Drawing.Size(677, 257);
            this.dgv_ganancias.TabIndex = 185;
            // 
            // lb_subtitulo
            // 
            this.lb_subtitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_subtitulo.AutoSize = true;
            this.lb_subtitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_subtitulo.Location = new System.Drawing.Point(334, 94);
            this.lb_subtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_subtitulo.Name = "lb_subtitulo";
            this.lb_subtitulo.Size = new System.Drawing.Size(86, 19);
            this.lb_subtitulo.TabIndex = 184;
            this.lb_subtitulo.Text = "Ganancias";
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(227, 9);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(316, 85);
            this.lb_cinehub.TabIndex = 183;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.panel_panelReporte);
            this.Name = "Reportes";
            this.Text = "Ganancias";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel_panelReporte.ResumeLayout(false);
            this.panel_panelReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ganancias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_panelReporte;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.DataGridView dgv_ganancias;
        private System.Windows.Forms.Label lb_subtitulo;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.DateTimePicker dtp_inidio;
        private System.Windows.Forms.Button btn_generaReporte;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lb_hasta;
        private System.Windows.Forms.Label lb_inicio;
    }
}