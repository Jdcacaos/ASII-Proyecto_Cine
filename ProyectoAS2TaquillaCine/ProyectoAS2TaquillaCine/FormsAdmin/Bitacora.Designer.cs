
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class Bitacora
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
            this.dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bitacora
            // 
            this.dgv_bitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bitacora.Location = new System.Drawing.Point(76, 171);
            this.dgv_bitacora.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_bitacora.Name = "dgv_bitacora";
            this.dgv_bitacora.RowHeadersWidth = 51;
            this.dgv_bitacora.Size = new System.Drawing.Size(1285, 471);
            this.dgv_bitacora.TabIndex = 185;
            this.dgv_bitacora.Tag = "";
            this.dgv_bitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(501, 32);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(420, 105);
            this.lb_cinehub.TabIndex = 186;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(1240, 32);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(121, 41);
            this.btn_regresar.TabIndex = 187;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1421, 694);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lb_cinehub);
            this.Controls.Add(this.dgv_bitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bitacora;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Button btn_regresar;
    }
}