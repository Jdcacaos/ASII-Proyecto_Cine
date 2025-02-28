﻿
namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    partial class Proveedor
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
            this.panel_panel1 = new System.Windows.Forms.Panel();
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.gpb_ingresar = new System.Windows.Forms.GroupBox();
            this.lb_productoras = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txtbx_nombre = new System.Windows.Forms.TextBox();
            this.lb_nombreProductora = new System.Windows.Forms.Label();
            this.lb_tiempoSys = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.gpb_buscar = new System.Windows.Forms.GroupBox();
            this.txtbx_buscar = new System.Windows.Forms.TextBox();
            this.lb_buscar = new System.Windows.Forms.Label();
            this.lb_texto = new System.Windows.Forms.Label();
            this.dgv_productores = new System.Windows.Forms.DataGridView();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.tmr_timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_panel2.SuspendLayout();
            this.gpb_ingresar.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            this.gpb_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(1272, 34);
            this.panel_panel1.TabIndex = 35;
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.gpb_ingresar);
            this.panel_panel2.Controls.Add(this.lb_tiempoSys);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(781, 34);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(491, 754);
            this.panel_panel2.TabIndex = 36;
            this.panel_panel2.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gpb_ingresar
            // 
            this.gpb_ingresar.Controls.Add(this.lb_productoras);
            this.gpb_ingresar.Controls.Add(this.btn_guardar);
            this.gpb_ingresar.Controls.Add(this.txtbx_nombre);
            this.gpb_ingresar.Controls.Add(this.lb_nombreProductora);
            this.gpb_ingresar.Controls.Add(this.btn_editar);
            this.gpb_ingresar.Controls.Add(this.btn_eliminar);
            this.gpb_ingresar.Location = new System.Drawing.Point(0, 100);
            this.gpb_ingresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpb_ingresar.Name = "gpb_ingresar";
            this.gpb_ingresar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpb_ingresar.Size = new System.Drawing.Size(491, 711);
            this.gpb_ingresar.TabIndex = 71;
            this.gpb_ingresar.TabStop = false;
            // 
            // lb_productoras
            // 
            this.lb_productoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_productoras.AutoSize = true;
            this.lb_productoras.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productoras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_productoras.Location = new System.Drawing.Point(111, 142);
            this.lb_productoras.Name = "lb_productoras";
            this.lb_productoras.Size = new System.Drawing.Size(234, 26);
            this.lb_productoras.TabIndex = 57;
            this.lb_productoras.Text = "Ingreso de Productoras";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guardar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.diskette_save_saveas_1514;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(160, 468);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(162, 48);
            this.btn_guardar.TabIndex = 55;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txtbx_nombre
            // 
            this.txtbx_nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_nombre.Location = new System.Drawing.Point(272, 305);
            this.txtbx_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_nombre.Name = "txtbx_nombre";
            this.txtbx_nombre.Size = new System.Drawing.Size(152, 22);
            this.txtbx_nombre.TabIndex = 54;
            // 
            // lb_nombreProductora
            // 
            this.lb_nombreProductora.AutoSize = true;
            this.lb_nombreProductora.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombreProductora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_nombreProductora.Location = new System.Drawing.Point(33, 303);
            this.lb_nombreProductora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nombreProductora.Name = "lb_nombreProductora";
            this.lb_nombreProductora.Size = new System.Drawing.Size(231, 24);
            this.lb_nombreProductora.TabIndex = 56;
            this.lb_nombreProductora.Text = "Nombre de la Productora:";
            // 
            // lb_tiempoSys
            // 
            this.lb_tiempoSys.AutoSize = true;
            this.lb_tiempoSys.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_tiempoSys.Location = new System.Drawing.Point(301, 76);
            this.lb_tiempoSys.Name = "lb_tiempoSys";
            this.lb_tiempoSys.Size = new System.Drawing.Size(46, 17);
            this.lb_tiempoSys.TabIndex = 70;
            this.lb_tiempoSys.Text = "label7";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(304, 23);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(121, 41);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.gpb_buscar);
            this.panel_panel3.Controls.Add(this.lb_texto);
            this.panel_panel3.Controls.Add(this.dgv_productores);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 34);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(781, 754);
            this.panel_panel3.TabIndex = 77;
            this.panel_panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // gpb_buscar
            // 
            this.gpb_buscar.Controls.Add(this.txtbx_buscar);
            this.gpb_buscar.Controls.Add(this.lb_buscar);
            this.gpb_buscar.Location = new System.Drawing.Point(0, 7);
            this.gpb_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpb_buscar.Name = "gpb_buscar";
            this.gpb_buscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpb_buscar.Size = new System.Drawing.Size(757, 65);
            this.gpb_buscar.TabIndex = 185;
            this.gpb_buscar.TabStop = false;
            // 
            // txtbx_buscar
            // 
            this.txtbx_buscar.Location = new System.Drawing.Point(95, 16);
            this.txtbx_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_buscar.Multiline = true;
            this.txtbx_buscar.Name = "txtbx_buscar";
            this.txtbx_buscar.Size = new System.Drawing.Size(653, 37);
            this.txtbx_buscar.TabIndex = 182;
            this.txtbx_buscar.TextChanged += new System.EventHandler(this.txtbxBuscar_TextChanged);
            // 
            // lb_buscar
            // 
            this.lb_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_buscar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_buscar.Location = new System.Drawing.Point(-5, 20);
            this.lb_buscar.Name = "lb_buscar";
            this.lb_buscar.Size = new System.Drawing.Size(103, 32);
            this.lb_buscar.TabIndex = 181;
            this.lb_buscar.Text = "Buscar";
            this.lb_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_texto
            // 
            this.lb_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_texto.Location = new System.Drawing.Point(236, 204);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(243, 26);
            this.lb_texto.TabIndex = 71;
            this.lb_texto.Text = "Registro de Productoras";
            // 
            // dgv_productores
            // 
            this.dgv_productores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_productores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productores.Location = new System.Drawing.Point(12, 263);
            this.dgv_productores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_productores.Name = "dgv_productores";
            this.dgv_productores.RowHeadersWidth = 51;
            this.dgv_productores.Size = new System.Drawing.Size(763, 223);
            this.dgv_productores.TabIndex = 184;
            this.dgv_productores.Tag = "";
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(113, 100);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(517, 105);
            this.lb_cinehub.TabIndex = 182;
            this.lb_cinehub.Text = "CINEHUB";
            this.lb_cinehub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.editsquare_120033;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(8, 468);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(129, 48);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.delete_button_6303088;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(330, 468);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(148, 48);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button6_Click);
            // 
            // tmr_timer1
            // 
            this.tmr_timer1.Tick += new System.EventHandler(this.tmr_timer1_Tick);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 788);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Proveedor";
            this.Text = "Productora";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.gpb_ingresar.ResumeLayout(false);
            this.gpb_ingresar.PerformLayout();
            this.panel_panel3.ResumeLayout(false);
            this.panel_panel3.PerformLayout();
            this.gpb_buscar.ResumeLayout(false);
            this.gpb_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Label lb_tiempoSys;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dgv_productores;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.GroupBox gpb_buscar;
        private System.Windows.Forms.TextBox txtbx_buscar;
        private System.Windows.Forms.Label lb_buscar;
        private System.Windows.Forms.GroupBox gpb_ingresar;
        private System.Windows.Forms.Label lb_productoras;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txtbx_nombre;
        private System.Windows.Forms.Label lb_nombreProductora;
        private System.Windows.Forms.Timer tmr_timer1;
    }
}