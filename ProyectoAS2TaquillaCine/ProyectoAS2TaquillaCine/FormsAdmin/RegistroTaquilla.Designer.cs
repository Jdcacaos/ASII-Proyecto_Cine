
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
            this.lb_Hasta = new System.Windows.Forms.Label();
            this.lb_Inicio = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_generareporte = new System.Windows.Forms.Button();
            this.dtp_Final = new System.Windows.Forms.DateTimePicker();
            this.dtp_Inicio = new System.Windows.Forms.DateTimePicker();
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
            this.panel_panelReporte.Controls.Add(this.lb_Hasta);
            this.panel_panelReporte.Controls.Add(this.lb_Inicio);
            this.panel_panelReporte.Controls.Add(this.btn_Salir);
            this.panel_panelReporte.Controls.Add(this.btn_generareporte);
            this.panel_panelReporte.Controls.Add(this.dtp_Final);
            this.panel_panelReporte.Controls.Add(this.dtp_Inicio);
            this.panel_panelReporte.Controls.Add(this.dgv_taquilla);
            this.panel_panelReporte.Controls.Add(this.lb_subtitulo);
            this.panel_panelReporte.Controls.Add(this.lb_cinehub);
            this.panel_panelReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panelReporte.Location = new System.Drawing.Point(0, 0);
            this.panel_panelReporte.Name = "panel_panelReporte";
            this.panel_panelReporte.Size = new System.Drawing.Size(800, 450);
            this.panel_panelReporte.TabIndex = 1;
            // 
            // lb_Hasta
            // 
            this.lb_Hasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_Hasta.AutoSize = true;
            this.lb_Hasta.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hasta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Hasta.Location = new System.Drawing.Point(427, 171);
            this.lb_Hasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Hasta.Name = "lb_Hasta";
            this.lb_Hasta.Size = new System.Drawing.Size(52, 19);
            this.lb_Hasta.TabIndex = 192;
            this.lb_Hasta.Text = "Hasta";
            // 
            // lb_Inicio
            // 
            this.lb_Inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_Inicio.AutoSize = true;
            this.lb_Inicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Inicio.Location = new System.Drawing.Point(57, 171);
            this.lb_Inicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Inicio.Name = "lb_Inicio";
            this.lb_Inicio.Size = new System.Drawing.Size(56, 19);
            this.lb_Inicio.TabIndex = 191;
            this.lb_Inicio.Text = "Desde";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Salir.Location = new System.Drawing.Point(61, 117);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(123, 34);
            this.btn_Salir.TabIndex = 190;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_generareporte
            // 
            this.btn_generareporte.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_generareporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generareporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_generareporte.Location = new System.Drawing.Point(603, 117);
            this.btn_generareporte.Name = "btn_generareporte";
            this.btn_generareporte.Size = new System.Drawing.Size(123, 34);
            this.btn_generareporte.TabIndex = 188;
            this.btn_generareporte.Text = "Generar Reporte";
            this.btn_generareporte.UseVisualStyleBackColor = false;
            this.btn_generareporte.Click += new System.EventHandler(this.btn_generareporte_Click);
            // 
            // dtp_Final
            // 
            this.dtp_Final.CustomFormat = "yyyy/MM/dd";
            this.dtp_Final.Location = new System.Drawing.Point(484, 169);
            this.dtp_Final.Name = "dtp_Final";
            this.dtp_Final.Size = new System.Drawing.Size(200, 20);
            this.dtp_Final.TabIndex = 187;
            this.dtp_Final.Value = new System.DateTime(2024, 8, 8, 16, 54, 16, 0);
            this.dtp_Final.ValueChanged += new System.EventHandler(this.dtp_Final_ValueChanged);
            // 
            // dtp_Inicio
            // 
            this.dtp_Inicio.CustomFormat = "yyyy/MM/dd";
            this.dtp_Inicio.Location = new System.Drawing.Point(121, 171);
            this.dtp_Inicio.Name = "dtp_Inicio";
            this.dtp_Inicio.Size = new System.Drawing.Size(202, 20);
            this.dtp_Inicio.TabIndex = 186;
            this.dtp_Inicio.Value = new System.DateTime(2024, 8, 8, 16, 54, 21, 0);
            this.dtp_Inicio.ValueChanged += new System.EventHandler(this.dtp_Inicio_ValueChanged);
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
        private System.Windows.Forms.Label lb_Hasta;
        private System.Windows.Forms.Label lb_Inicio;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_generareporte;
        private System.Windows.Forms.DateTimePicker dtp_Final;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.DataGridView dgv_taquilla;
        private System.Windows.Forms.Label lb_subtitulo;
        private System.Windows.Forms.Label lb_cinehub;
    }
}