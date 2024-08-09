
namespace ProyectoAS2TaquillaCine.FormsCliente
{
    partial class CarteleraNueva
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
            this.cb_direccion = new System.Windows.Forms.ComboBox();
            this.cb_depto = new System.Windows.Forms.ComboBox();
            this.panel_panelPelicula = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_cerrarSesion = new System.Windows.Forms.Button();
            this.btn_quitarFiltro = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.lb_cinehub.AutoSize = true;
            this.lb_cinehub.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_cinehub.Location = new System.Drawing.Point(334, 17);
            this.lb_cinehub.Name = "label1";
            this.lb_cinehub.Size = new System.Drawing.Size(359, 82);
            this.lb_cinehub.TabIndex = 1;
            this.lb_cinehub.Text = "CINEHUB";
            // 
            // cbDireccion
            // 
            this.cb_direccion.FormattingEnabled = true;
            this.cb_direccion.Location = new System.Drawing.Point(413, 108);
            this.cb_direccion.Name = "cbDireccion";
            this.cb_direccion.Size = new System.Drawing.Size(121, 21);
            this.cb_direccion.TabIndex = 7;
            // 
            // cbDepto
            // 
            this.cb_depto.FormattingEnabled = true;
            this.cb_depto.Location = new System.Drawing.Point(286, 108);
            this.cb_depto.Name = "cbDepto";
            this.cb_depto.Size = new System.Drawing.Size(121, 21);
            this.cb_depto.TabIndex = 6;
            this.cb_depto.SelectedIndexChanged += new System.EventHandler(this.cbDepto_SelectedIndexChanged);
            // 
            // PeliculaPanel
            // 
            this.panel_panelPelicula.Location = new System.Drawing.Point(47, 147);
            this.panel_panelPelicula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_panelPelicula.Name = "PeliculaPanel";
            this.panel_panelPelicula.Size = new System.Drawing.Size(1305, 557);
            this.panel_panelPelicula.TabIndex = 10;
            // 
            // button2
            // 
            this.btn_cerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btn_cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_cerrarSesion.Location = new System.Drawing.Point(9, 10);
            this.btn_cerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cerrarSesion.Name = "button2";
            this.btn_cerrarSesion.Size = new System.Drawing.Size(96, 31);
            this.btn_cerrarSesion.TabIndex = 12;
            this.btn_cerrarSesion.Text = "Cerrar Sesion";
            this.btn_cerrarSesion.UseVisualStyleBackColor = false;
            this.btn_cerrarSesion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQF
            // 
            this.btn_quitarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitarFiltro.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.filtrar;
            this.btn_quitarFiltro.Location = new System.Drawing.Point(599, 103);
            this.btn_quitarFiltro.Name = "btnQF";
            this.btn_quitarFiltro.Size = new System.Drawing.Size(59, 29);
            this.btn_quitarFiltro.TabIndex = 9;
            this.btn_quitarFiltro.UseVisualStyleBackColor = true;
            this.btn_quitarFiltro.Click += new System.EventHandler(this.btnQF_Click_1);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtrar.Image = global::ProyectoAS2TaquillaCine.Properties.Resources.buscar;
            this.btn_filtrar.Location = new System.Drawing.Point(541, 103);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(46, 29);
            this.btn_filtrar.TabIndex = 8;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click_1);
            // 
            // CarteleraNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.btn_cerrarSesion);
            this.Controls.Add(this.panel_panelPelicula);
            this.Controls.Add(this.btn_quitarFiltro);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.cb_direccion);
            this.Controls.Add(this.cb_depto);
            this.Controls.Add(this.lb_cinehub);
            this.Name = "CarteleraNueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartelera";
            this.Load += new System.EventHandler(this.CarteleraNueva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.ComboBox cb_direccion;
        private System.Windows.Forms.ComboBox cb_depto;
        private System.Windows.Forms.Button btn_quitarFiltro;
        private System.Windows.Forms.FlowLayoutPanel panel_panelPelicula;
        private System.Windows.Forms.Button btn_cerrarSesion;
    }
}