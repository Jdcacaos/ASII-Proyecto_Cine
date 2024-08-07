
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
            this.lb_fechaHora = new System.Windows.Forms.Label();
            this.lb_ciudad = new System.Windows.Forms.Label();
            this.lb_direccion = new System.Windows.Forms.Label();
            this.txtbx_ciudad = new System.Windows.Forms.TextBox();
            this.txtbx_ubicacion = new System.Windows.Forms.TextBox();
            this.tmr_tiempo = new System.Windows.Forms.Timer(this.components);
            this.panel_panel1 = new System.Windows.Forms.Panel();
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.lb_mantUbicacion = new System.Windows.Forms.Label();
            this.btn_boton5 = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.dgv_ubicaciones = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel_panel2.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fechaHora
            // 
            this.lb_fechaHora.AutoSize = true;
            this.lb_fechaHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaHora.Location = new System.Drawing.Point(234, 66);
            this.lb_fechaHora.Name = "lb_fechaHora";
            this.lb_fechaHora.Size = new System.Drawing.Size(37, 13);
            this.lb_fechaHora.TabIndex = 26;
            this.lb_fechaHora.Text = "Fecha";
            // 
            // lb_ciudad
            // 
            this.lb_ciudad.AutoSize = true;
            this.lb_ciudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ciudad.Location = new System.Drawing.Point(70, 312);
            this.lb_ciudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ciudad.Name = "lb_ciudad";
            this.lb_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lb_ciudad.TabIndex = 32;
            this.lb_ciudad.Text = "Ciudad";
            // 
            // lb_direccion
            // 
            this.lb_direccion.AutoSize = true;
            this.lb_direccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_direccion.Location = new System.Drawing.Point(50, 355);
            this.lb_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_direccion.Name = "lb_direccion";
            this.lb_direccion.Size = new System.Drawing.Size(87, 13);
            this.lb_direccion.TabIndex = 33;
            this.lb_direccion.Text = "Centro Comercial";
            // 
            // txtbx_ciudad
            // 
            this.txtbx_ciudad.Location = new System.Drawing.Point(141, 310);
            this.txtbx_ciudad.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_ciudad.Name = "txtbx_ciudad";
            this.txtbx_ciudad.Size = new System.Drawing.Size(157, 20);
            this.txtbx_ciudad.TabIndex = 0;
            // 
            // txtbx_ubicacion
            // 
            this.txtbx_ubicacion.Location = new System.Drawing.Point(141, 352);
            this.txtbx_ubicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_ubicacion.Name = "txtbx_ubicacion";
            this.txtbx_ubicacion.Size = new System.Drawing.Size(157, 20);
            this.txtbx_ubicacion.TabIndex = 1;
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(980, 28);
            this.panel_panel1.TabIndex = 36;
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.lb_mantUbicacion);
            this.panel_panel2.Controls.Add(this.btn_boton5);
            this.panel_panel2.Controls.Add(this.txtbx_ubicacion);
            this.panel_panel2.Controls.Add(this.txtbx_ciudad);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Controls.Add(this.lb_direccion);
            this.panel_panel2.Controls.Add(this.lb_fechaHora);
            this.panel_panel2.Controls.Add(this.lb_ciudad);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(612, 28);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(368, 680);
            this.panel_panel2.TabIndex = 37;
            // 
            // lb_mantUbicacion
            // 
            this.lb_mantUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantUbicacion.AutoSize = true;
            this.lb_mantUbicacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantUbicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantUbicacion.Location = new System.Drawing.Point(93, 133);
            this.lb_mantUbicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mantUbicacion.Name = "lb_mantUbicacion";
            this.lb_mantUbicacion.Size = new System.Drawing.Size(228, 19);
            this.lb_mantUbicacion.TabIndex = 53;
            this.lb_mantUbicacion.Text = "Mantenimiento de Ubicacion";
            // 
            // btn_boton5
            // 
            this.btn_boton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_boton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_boton5.Location = new System.Drawing.Point(60, 566);
            this.btn_boton5.Name = "btn_boton5";
            this.btn_boton5.Size = new System.Drawing.Size(237, 41);
            this.btn_boton5.TabIndex = 2;
            this.btn_boton5.Text = "Guardar";
            this.btn_boton5.UseVisualStyleBackColor = false;
            this.btn_boton5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(237, 6);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(91, 33);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Controls.Add(this.dgv_ubicaciones);
            this.panel_panel3.Controls.Add(this.btn_editar);
            this.panel_panel3.Controls.Add(this.btn_eliminar);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 28);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(612, 680);
            this.panel_panel3.TabIndex = 77;
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(182, 36);
            this.lb_cinehub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(282, 85);
            this.lb_cinehub.TabIndex = 182;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_ubicaciones
            // 
            this.dgv_ubicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ubicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ubicaciones.Location = new System.Drawing.Point(47, 157);
            this.dgv_ubicaciones.Name = "dgv_ubicaciones";
            this.dgv_ubicaciones.RowHeadersWidth = 51;
            this.dgv_ubicaciones.Size = new System.Drawing.Size(520, 366);
            this.dgv_ubicaciones.TabIndex = 181;
            this.dgv_ubicaciones.Tag = "";
            this.dgv_ubicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Ubicaciones_CellContentClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Location = new System.Drawing.Point(56, 580);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(119, 39);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Location = new System.Drawing.Point(192, 580);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(111, 39);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button6_Click);
            // 
            // Ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 708);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubicaciones";
            this.Text = "Ubicaciones";
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.panel_panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_fechaHora;
        private System.Windows.Forms.Label lb_ciudad;
        private System.Windows.Forms.Label lb_direccion;
        private System.Windows.Forms.TextBox txtbx_ciudad;
        private System.Windows.Forms.TextBox txtbx_ubicacion;
        private System.Windows.Forms.Timer tmr_tiempo;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Label lb_mantUbicacion;
        private System.Windows.Forms.Button btn_boton5;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.DataGridView dgv_ubicaciones;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}