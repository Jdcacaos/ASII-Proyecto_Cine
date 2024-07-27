
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
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_FechaHora = new System.Windows.Forms.Label();
            this.DGV_Ubicaciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Ciudad = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.tm_tiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ubicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 41);
            this.button4.TabIndex = 31;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(665, 498);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(121, 41);
            this.btn_Editar.TabIndex = 30;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(665, 449);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(121, 41);
            this.btn_Agregar.TabIndex = 29;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(665, 547);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(121, 41);
            this.btn_eliminar.TabIndex = 28;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lbl_FechaHora
            // 
            this.lbl_FechaHora.AutoSize = true;
            this.lbl_FechaHora.Location = new System.Drawing.Point(739, 27);
            this.lbl_FechaHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FechaHora.Name = "lbl_FechaHora";
            this.lbl_FechaHora.Size = new System.Drawing.Size(47, 17);
            this.lbl_FechaHora.TabIndex = 26;
            this.lbl_FechaHora.Text = "Fecha";
            // 
            // DGV_Ubicaciones
            // 
            this.DGV_Ubicaciones.AllowUserToAddRows = false;
            this.DGV_Ubicaciones.AllowUserToDeleteRows = false;
            this.DGV_Ubicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ubicaciones.Location = new System.Drawing.Point(42, 231);
            this.DGV_Ubicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Ubicaciones.Name = "DGV_Ubicaciones";
            this.DGV_Ubicaciones.ReadOnly = true;
            this.DGV_Ubicaciones.RowHeadersWidth = 51;
            this.DGV_Ubicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Ubicaciones.Size = new System.Drawing.Size(475, 428);
            this.DGV_Ubicaciones.TabIndex = 25;
            this.DGV_Ubicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Ubicaciones_CellContentClick);
            this.DGV_Ubicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Ubicaciones_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 52);
            this.label2.TabIndex = 24;
            this.label2.Text = "UBICACIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 102);
            this.label1.TabIndex = 23;
            this.label1.Text = "CINEHUB";
            // 
            // lbl_Ciudad
            // 
            this.lbl_Ciudad.AutoSize = true;
            this.lbl_Ciudad.Location = new System.Drawing.Point(574, 317);
            this.lbl_Ciudad.Name = "lbl_Ciudad";
            this.lbl_Ciudad.Size = new System.Drawing.Size(52, 17);
            this.lbl_Ciudad.TabIndex = 32;
            this.lbl_Ciudad.Text = "Ciudad";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(547, 370);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(116, 17);
            this.lbl_Direccion.TabIndex = 33;
            this.lbl_Direccion.Text = "Centro Comercial";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(669, 314);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(208, 22);
            this.txtCiudad.TabIndex = 34;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(669, 365);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(208, 22);
            this.txtUbicacion.TabIndex = 35;
            // 
            // Ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 701);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Ciudad);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.lbl_FechaHora);
            this.Controls.Add(this.DGV_Ubicaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ubicaciones";
            this.Text = "Ubicaciones";
            this.Load += new System.EventHandler(this.Ubicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ubicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_FechaHora;
        private System.Windows.Forms.DataGridView DGV_Ubicaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Timer tm_tiempo;
    }
}