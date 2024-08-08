
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
            this.tmr_tiempo = new System.Windows.Forms.Timer(this.components);
            this.panel_panel1 = new System.Windows.Forms.Panel();
            this.panel_panel2 = new System.Windows.Forms.Panel();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.lb_mantUbicacion = new System.Windows.Forms.Label();
            this.btn_boton5 = new System.Windows.Forms.Button();
            this.txtbx_ubicacion = new System.Windows.Forms.TextBox();
            this.txtbx_ciudad = new System.Windows.Forms.TextBox();
            this.lb_direccion = new System.Windows.Forms.Label();
            this.lb_ciudad = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel_panel3 = new System.Windows.Forms.Panel();
            this.gbbuscar = new System.Windows.Forms.GroupBox();
            this.txtbxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cinehub = new System.Windows.Forms.Label();
            this.dgv_ubicaciones = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel_panel2.SuspendLayout();
            this.gbIngresar.SuspendLayout();
            this.panel_panel3.SuspendLayout();
            this.gbbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fechaHora
            // 
            this.lb_fechaHora.AutoSize = true;
            this.lb_fechaHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_fechaHora.Location = new System.Drawing.Point(312, 81);
            this.lb_fechaHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fechaHora.Name = "lb_fechaHora";
            this.lb_fechaHora.Size = new System.Drawing.Size(47, 17);
            this.lb_fechaHora.TabIndex = 26;
            this.lb_fechaHora.Text = "Fecha";
            // 
            // tmr_tiempo
            // 
            this.tmr_tiempo.Tick += new System.EventHandler(this.tmr_tiempo_Tick);
            // 
            // panel_panel1
            // 
            this.panel_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_panel1.Location = new System.Drawing.Point(0, 0);
            this.panel_panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel1.Name = "panel_panel1";
            this.panel_panel1.Size = new System.Drawing.Size(1307, 34);
            this.panel_panel1.TabIndex = 36;
            // 
            // panel_panel2
            // 
            this.panel_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel_panel2.Controls.Add(this.gbIngresar);
            this.panel_panel2.Controls.Add(this.btn_regresar);
            this.panel_panel2.Controls.Add(this.lb_fechaHora);
            this.panel_panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_panel2.Location = new System.Drawing.Point(816, 34);
            this.panel_panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel2.Name = "panel_panel2";
            this.panel_panel2.Size = new System.Drawing.Size(491, 837);
            this.panel_panel2.TabIndex = 37;
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.lb_mantUbicacion);
            this.gbIngresar.Controls.Add(this.btn_boton5);
            this.gbIngresar.Controls.Add(this.txtbx_ubicacion);
            this.gbIngresar.Controls.Add(this.txtbx_ciudad);
            this.gbIngresar.Controls.Add(this.lb_direccion);
            this.gbIngresar.Controls.Add(this.lb_ciudad);
            this.gbIngresar.Location = new System.Drawing.Point(7, 113);
            this.gbIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIngresar.Size = new System.Drawing.Size(484, 720);
            this.gbIngresar.TabIndex = 54;
            this.gbIngresar.TabStop = false;
            // 
            // lb_mantUbicacion
            // 
            this.lb_mantUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_mantUbicacion.AutoSize = true;
            this.lb_mantUbicacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mantUbicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_mantUbicacion.Location = new System.Drawing.Point(127, 105);
            this.lb_mantUbicacion.Name = "lb_mantUbicacion";
            this.lb_mantUbicacion.Size = new System.Drawing.Size(291, 26);
            this.lb_mantUbicacion.TabIndex = 59;
            this.lb_mantUbicacion.Text = "Mantenimiento de Ubicacion";
            // 
            // btn_boton5
            // 
            this.btn_boton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_boton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_boton5.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.diskette_save_saveas_1514;
            this.btn_boton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_boton5.Location = new System.Drawing.Point(170, 542);
            this.btn_boton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_boton5.Name = "btn_boton5";
            this.btn_boton5.Size = new System.Drawing.Size(158, 83);
            this.btn_boton5.TabIndex = 56;
            this.btn_boton5.Text = "Guardar";
            this.btn_boton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_boton5.UseVisualStyleBackColor = false;
            // 
            // txtbx_ubicacion
            // 
            this.txtbx_ubicacion.Location = new System.Drawing.Point(245, 359);
            this.txtbx_ubicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_ubicacion.Name = "txtbx_ubicacion";
            this.txtbx_ubicacion.Size = new System.Drawing.Size(208, 22);
            this.txtbx_ubicacion.TabIndex = 55;
            // 
            // txtbx_ciudad
            // 
            this.txtbx_ciudad.Location = new System.Drawing.Point(245, 288);
            this.txtbx_ciudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_ciudad.Name = "txtbx_ciudad";
            this.txtbx_ciudad.Size = new System.Drawing.Size(208, 22);
            this.txtbx_ciudad.TabIndex = 54;
            // 
            // lb_direccion
            // 
            this.lb_direccion.AutoSize = true;
            this.lb_direccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_direccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_direccion.Location = new System.Drawing.Point(51, 355);
            this.lb_direccion.Name = "lb_direccion";
            this.lb_direccion.Size = new System.Drawing.Size(178, 26);
            this.lb_direccion.TabIndex = 58;
            this.lb_direccion.Text = "Centro Comercial";
            // 
            // lb_ciudad
            // 
            this.lb_ciudad.AutoSize = true;
            this.lb_ciudad.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ciudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ciudad.Location = new System.Drawing.Point(88, 288);
            this.lb_ciudad.Name = "lb_ciudad";
            this.lb_ciudad.Size = new System.Drawing.Size(80, 26);
            this.lb_ciudad.TabIndex = 57;
            this.lb_ciudad.Text = "Ciudad";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar.Location = new System.Drawing.Point(316, 25);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(121, 41);
            this.btn_regresar.TabIndex = 5;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_panel3
            // 
            this.panel_panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel_panel3.Controls.Add(this.gbbuscar);
            this.panel_panel3.Controls.Add(this.label1);
            this.panel_panel3.Controls.Add(this.lb_cinehub);
            this.panel_panel3.Controls.Add(this.dgv_ubicaciones);
            this.panel_panel3.Controls.Add(this.btn_editar);
            this.panel_panel3.Controls.Add(this.btn_eliminar);
            this.panel_panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_panel3.Location = new System.Drawing.Point(0, 34);
            this.panel_panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_panel3.Name = "panel_panel3";
            this.panel_panel3.Size = new System.Drawing.Size(816, 837);
            this.panel_panel3.TabIndex = 77;
            // 
            // gbbuscar
            // 
            this.gbbuscar.Controls.Add(this.txtbxBuscar);
            this.gbbuscar.Controls.Add(this.label2);
            this.gbbuscar.Location = new System.Drawing.Point(0, 0);
            this.gbbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbbuscar.Name = "gbbuscar";
            this.gbbuscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbbuscar.Size = new System.Drawing.Size(812, 65);
            this.gbbuscar.TabIndex = 182;
            this.gbbuscar.TabStop = false;
            // 
            // txtbxBuscar
            // 
            this.txtbxBuscar.Location = new System.Drawing.Point(95, 16);
            this.txtbxBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxBuscar.Multiline = true;
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(708, 37);
            this.txtbxBuscar.TabIndex = 182;
            this.txtbxBuscar.TextChanged += new System.EventHandler(this.txtbxBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(-5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 181;
            this.label2.Text = "Buscar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(288, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 54;
            this.label1.Text = "Registros Ubicación";
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_cinehub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cinehub.Location = new System.Drawing.Point(191, 113);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(421, 105);
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
            this.dgv_ubicaciones.Location = new System.Drawing.Point(63, 261);
            this.dgv_ubicaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_ubicaciones.Name = "dgv_ubicaciones";
            this.dgv_ubicaciones.RowHeadersWidth = 51;
            this.dgv_ubicaciones.Size = new System.Drawing.Size(693, 450);
            this.dgv_ubicaciones.TabIndex = 181;
            this.dgv_ubicaciones.Tag = "";
            this.dgv_ubicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Ubicaciones_CellContentClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.editsquare_120033;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(63, 734);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(122, 48);
            this.btn_editar.TabIndex = 3;
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
            this.btn_eliminar.Location = new System.Drawing.Point(253, 734);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(139, 48);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button6_Click);
            // 
            // Ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 871);
            this.Controls.Add(this.panel_panel3);
            this.Controls.Add(this.panel_panel2);
            this.Controls.Add(this.panel_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ubicaciones";
            this.Text = "Ubicaciones";
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            this.panel_panel2.ResumeLayout(false);
            this.panel_panel2.PerformLayout();
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            this.panel_panel3.ResumeLayout(false);
            this.panel_panel3.PerformLayout();
            this.gbbuscar.ResumeLayout(false);
            this.gbbuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_fechaHora;
        private System.Windows.Forms.Timer tmr_tiempo;
        private System.Windows.Forms.Panel panel_panel1;
        private System.Windows.Forms.Panel panel_panel2;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_panel3;
        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.DataGridView dgv_ubicaciones;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.Label lb_mantUbicacion;
        private System.Windows.Forms.Button btn_boton5;
        private System.Windows.Forms.TextBox txtbx_ubicacion;
        private System.Windows.Forms.TextBox txtbx_ciudad;
        private System.Windows.Forms.Label lb_direccion;
        private System.Windows.Forms.Label lb_ciudad;
        private System.Windows.Forms.GroupBox gbbuscar;
        private System.Windows.Forms.TextBox txtbxBuscar;
        private System.Windows.Forms.Label label2;
    }
}