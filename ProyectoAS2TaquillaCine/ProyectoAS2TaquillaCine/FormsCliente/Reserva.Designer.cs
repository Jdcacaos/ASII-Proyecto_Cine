
namespace ProyectoAS2TaquillaCine.FormsCliente
{
    partial class Reserva
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
            this.lb_fecha = new System.Windows.Forms.Label();
            this.cb_fecha = new System.Windows.Forms.ComboBox();
            this.cb_hora = new System.Windows.Forms.ComboBox();
            this.lb_horario = new System.Windows.Forms.Label();
            this.lb_texto = new System.Windows.Forms.Label();
            this.lb_texto2 = new System.Windows.Forms.Label();
            this.lb_nino = new System.Windows.Forms.Label();
            this.lb_adulto = new System.Windows.Forms.Label();
            this.lb_3raEdad = new System.Windows.Forms.Label();
            this.lb_precioNino = new System.Windows.Forms.Label();
            this.lb_precioAdulto = new System.Windows.Forms.Label();
            this.lb_precio3ra = new System.Windows.Forms.Label();
            this.txtbx_noNinos = new System.Windows.Forms.TextBox();
            this.txtbx_noAdulto = new System.Windows.Forms.TextBox();
            this.txtbx_no3ra = new System.Windows.Forms.TextBox();
            this.btn_restarNino = new System.Windows.Forms.Button();
            this.btn_sumarNino = new System.Windows.Forms.Button();
            this.btn_sumarAdulto = new System.Windows.Forms.Button();
            this.btn_restarAdulto = new System.Windows.Forms.Button();
            this.btn_sumar3ra = new System.Windows.Forms.Button();
            this.btn_restar3ra = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.txtbx_totalAsientos = new System.Windows.Forms.TextBox();
            this.lb_subtotalNino = new System.Windows.Forms.Label();
            this.lb_subtotalAdulto = new System.Windows.Forms.Label();
            this.lb_subtotal3ra = new System.Windows.Forms.Label();
            this.lb_totalPagar = new System.Windows.Forms.Label();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lb_17 = new System.Windows.Forms.Label();
            this.lb_18 = new System.Windows.Forms.Label();
            this.panel_agregarboletos = new System.Windows.Forms.Panel();
            this.panel_3ra = new System.Windows.Forms.Panel();
            this.panel_nino = new System.Windows.Forms.Panel();
            this.panel_adulto = new System.Windows.Forms.Panel();
            this.panel_agregarboletos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_cinehub
            // 
            this.lb_cinehub.AutoSize = true;
            this.lb_cinehub.Font = new System.Drawing.Font("Arial Narrow", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cinehub.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_cinehub.Location = new System.Drawing.Point(340, 25);
            this.lb_cinehub.Name = "lb_cinehub";
            this.lb_cinehub.Size = new System.Drawing.Size(376, 105);
            this.lb_cinehub.TabIndex = 2;
            this.lb_cinehub.Text = "CINEHUB";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_fecha.Location = new System.Drawing.Point(201, 148);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(218, 23);
            this.lb_fecha.TabIndex = 3;
            this.lb_fecha.Text = "Seleccione una fecha";
            this.lb_fecha.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_fecha
            // 
            this.cb_fecha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_fecha.FormattingEnabled = true;
            this.cb_fecha.Location = new System.Drawing.Point(221, 174);
            this.cb_fecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_fecha.Name = "cb_fecha";
            this.cb_fecha.Size = new System.Drawing.Size(207, 24);
            this.cb_fecha.TabIndex = 1;
            this.cb_fecha.Text = "Seleccione una fecha ....";
            this.cb_fecha.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_hora
            // 
            this.cb_hora.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_hora.FormattingEnabled = true;
            this.cb_hora.Location = new System.Drawing.Point(641, 174);
            this.cb_hora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_hora.Name = "cb_hora";
            this.cb_hora.Size = new System.Drawing.Size(207, 24);
            this.cb_hora.TabIndex = 2;
            this.cb_hora.Text = "Seleccione un horario ...";
            this.cb_hora.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lb_horario
            // 
            this.lb_horario.AutoSize = true;
            this.lb_horario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horario.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_horario.Location = new System.Drawing.Point(637, 148);
            this.lb_horario.Name = "lb_horario";
            this.lb_horario.Size = new System.Drawing.Size(222, 23);
            this.lb_horario.TabIndex = 5;
            this.lb_horario.Text = "Seleccione un horario";
            this.lb_horario.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_texto.Location = new System.Drawing.Point(419, 225);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(229, 23);
            this.lb_texto.TabIndex = 7;
            this.lb_texto.Text = "Selecciona tus boletos";
            // 
            // lb_texto2
            // 
            this.lb_texto2.AutoSize = true;
            this.lb_texto2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto2.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_texto2.Location = new System.Drawing.Point(277, 247);
            this.lb_texto2.Name = "lb_texto2";
            this.lb_texto2.Size = new System.Drawing.Size(525, 23);
            this.lb_texto2.TabIndex = 8;
            this.lb_texto2.Text = "Puedes comprar 10 boletos máximo por transacción.";
            // 
            // lb_nino
            // 
            this.lb_nino.AutoSize = true;
            this.lb_nino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nino.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nino.Location = new System.Drawing.Point(249, 161);
            this.lb_nino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nino.Name = "lb_nino";
            this.lb_nino.Size = new System.Drawing.Size(62, 23);
            this.lb_nino.TabIndex = 9;
            this.lb_nino.Text = "NIÑO";
            // 
            // lb_adulto
            // 
            this.lb_adulto.AutoSize = true;
            this.lb_adulto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adulto.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_adulto.Location = new System.Drawing.Point(247, 58);
            this.lb_adulto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_adulto.Name = "lb_adulto";
            this.lb_adulto.Size = new System.Drawing.Size(95, 23);
            this.lb_adulto.TabIndex = 10;
            this.lb_adulto.Text = "ADULTO";
            this.lb_adulto.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_3raEdad
            // 
            this.lb_3raEdad.AutoSize = true;
            this.lb_3raEdad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3raEdad.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_3raEdad.Location = new System.Drawing.Point(247, 252);
            this.lb_3raEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_3raEdad.Name = "lb_3raEdad";
            this.lb_3raEdad.Size = new System.Drawing.Size(130, 23);
            this.lb_3raEdad.TabIndex = 11;
            this.lb_3raEdad.Text = "3 ERA EDAD";
            // 
            // lb_precioNino
            // 
            this.lb_precioNino.AutoSize = true;
            this.lb_precioNino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precioNino.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_precioNino.Location = new System.Drawing.Point(383, 161);
            this.lb_precioNino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_precioNino.Name = "lb_precioNino";
            this.lb_precioNino.Size = new System.Drawing.Size(22, 23);
            this.lb_precioNino.TabIndex = 12;
            this.lb_precioNino.Text = "0";
            // 
            // lb_precioAdulto
            // 
            this.lb_precioAdulto.AutoSize = true;
            this.lb_precioAdulto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precioAdulto.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_precioAdulto.Location = new System.Drawing.Point(383, 54);
            this.lb_precioAdulto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_precioAdulto.Name = "lb_precioAdulto";
            this.lb_precioAdulto.Size = new System.Drawing.Size(22, 23);
            this.lb_precioAdulto.TabIndex = 13;
            this.lb_precioAdulto.Text = "0";
            // 
            // lb_precio3ra
            // 
            this.lb_precio3ra.AutoSize = true;
            this.lb_precio3ra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precio3ra.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_precio3ra.Location = new System.Drawing.Point(384, 252);
            this.lb_precio3ra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_precio3ra.Name = "lb_precio3ra";
            this.lb_precio3ra.Size = new System.Drawing.Size(22, 23);
            this.lb_precio3ra.TabIndex = 14;
            this.lb_precio3ra.Text = "0";
            // 
            // txtbx_noNinos
            // 
            this.txtbx_noNinos.Enabled = false;
            this.txtbx_noNinos.Location = new System.Drawing.Point(472, 161);
            this.txtbx_noNinos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_noNinos.Name = "txtbx_noNinos";
            this.txtbx_noNinos.Size = new System.Drawing.Size(43, 22);
            this.txtbx_noNinos.TabIndex = 15;
            this.txtbx_noNinos.Text = "0";
            // 
            // txtbx_noAdulto
            // 
            this.txtbx_noAdulto.Enabled = false;
            this.txtbx_noAdulto.Location = new System.Drawing.Point(472, 54);
            this.txtbx_noAdulto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_noAdulto.Name = "txtbx_noAdulto";
            this.txtbx_noAdulto.Size = new System.Drawing.Size(43, 22);
            this.txtbx_noAdulto.TabIndex = 16;
            this.txtbx_noAdulto.Text = "0";
            this.txtbx_noAdulto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtbx_no3ra
            // 
            this.txtbx_no3ra.Enabled = false;
            this.txtbx_no3ra.Location = new System.Drawing.Point(472, 254);
            this.txtbx_no3ra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_no3ra.Name = "txtbx_no3ra";
            this.txtbx_no3ra.Size = new System.Drawing.Size(43, 22);
            this.txtbx_no3ra.TabIndex = 17;
            this.txtbx_no3ra.Text = "0";
            // 
            // btn_restarNino
            // 
            this.btn_restarNino.Location = new System.Drawing.Point(551, 164);
            this.btn_restarNino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_restarNino.Name = "btn_restarNino";
            this.btn_restarNino.Size = new System.Drawing.Size(55, 25);
            this.btn_restarNino.TabIndex = 18;
            this.btn_restarNino.Text = "-";
            this.btn_restarNino.UseVisualStyleBackColor = true;
            this.btn_restarNino.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sumarNino
            // 
            this.btn_sumarNino.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_sumarNino.Location = new System.Drawing.Point(601, 164);
            this.btn_sumarNino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sumarNino.Name = "btn_sumarNino";
            this.btn_sumarNino.Size = new System.Drawing.Size(55, 25);
            this.btn_sumarNino.TabIndex = 4;
            this.btn_sumarNino.Text = "+";
            this.btn_sumarNino.UseVisualStyleBackColor = true;
            this.btn_sumarNino.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sumarAdulto
            // 
            this.btn_sumarAdulto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_sumarAdulto.Location = new System.Drawing.Point(599, 55);
            this.btn_sumarAdulto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sumarAdulto.Name = "btn_sumarAdulto";
            this.btn_sumarAdulto.Size = new System.Drawing.Size(55, 25);
            this.btn_sumarAdulto.TabIndex = 3;
            this.btn_sumarAdulto.Text = "+";
            this.btn_sumarAdulto.UseVisualStyleBackColor = true;
            this.btn_sumarAdulto.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_restarAdulto
            // 
            this.btn_restarAdulto.Location = new System.Drawing.Point(547, 55);
            this.btn_restarAdulto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_restarAdulto.Name = "btn_restarAdulto";
            this.btn_restarAdulto.Size = new System.Drawing.Size(55, 25);
            this.btn_restarAdulto.TabIndex = 20;
            this.btn_restarAdulto.Text = "-";
            this.btn_restarAdulto.UseVisualStyleBackColor = true;
            this.btn_restarAdulto.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_sumar3ra
            // 
            this.btn_sumar3ra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_sumar3ra.Location = new System.Drawing.Point(601, 252);
            this.btn_sumar3ra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sumar3ra.Name = "btn_sumar3ra";
            this.btn_sumar3ra.Size = new System.Drawing.Size(55, 25);
            this.btn_sumar3ra.TabIndex = 5;
            this.btn_sumar3ra.Text = "+";
            this.btn_sumar3ra.UseVisualStyleBackColor = true;
            this.btn_sumar3ra.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_restar3ra
            // 
            this.btn_restar3ra.Location = new System.Drawing.Point(551, 252);
            this.btn_restar3ra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_restar3ra.Name = "btn_restar3ra";
            this.btn_restar3ra.Size = new System.Drawing.Size(55, 25);
            this.btn_restar3ra.TabIndex = 22;
            this.btn_restar3ra.Text = "-";
            this.btn_restar3ra.UseVisualStyleBackColor = true;
            this.btn_restar3ra.Click += new System.EventHandler(this.button6_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_total.Location = new System.Drawing.Point(256, 332);
            this.lb_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(78, 23);
            this.lb_total.TabIndex = 24;
            this.lb_total.Text = "TOTAL";
            // 
            // txtbx_totalAsientos
            // 
            this.txtbx_totalAsientos.Enabled = false;
            this.txtbx_totalAsientos.Location = new System.Drawing.Point(517, 332);
            this.txtbx_totalAsientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_totalAsientos.Name = "txtbx_totalAsientos";
            this.txtbx_totalAsientos.Size = new System.Drawing.Size(43, 22);
            this.txtbx_totalAsientos.TabIndex = 25;
            // 
            // lb_subtotalNino
            // 
            this.lb_subtotalNino.AutoSize = true;
            this.lb_subtotalNino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtotalNino.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_subtotalNino.Location = new System.Drawing.Point(689, 164);
            this.lb_subtotalNino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_subtotalNino.Name = "lb_subtotalNino";
            this.lb_subtotalNino.Size = new System.Drawing.Size(22, 23);
            this.lb_subtotalNino.TabIndex = 26;
            this.lb_subtotalNino.Text = "0";
            // 
            // lb_subtotalAdulto
            // 
            this.lb_subtotalAdulto.AutoSize = true;
            this.lb_subtotalAdulto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtotalAdulto.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_subtotalAdulto.Location = new System.Drawing.Point(687, 55);
            this.lb_subtotalAdulto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_subtotalAdulto.Name = "lb_subtotalAdulto";
            this.lb_subtotalAdulto.Size = new System.Drawing.Size(22, 23);
            this.lb_subtotalAdulto.TabIndex = 27;
            this.lb_subtotalAdulto.Text = "0";
            // 
            // lb_subtotal3ra
            // 
            this.lb_subtotal3ra.AutoSize = true;
            this.lb_subtotal3ra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtotal3ra.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_subtotal3ra.Location = new System.Drawing.Point(689, 255);
            this.lb_subtotal3ra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_subtotal3ra.Name = "lb_subtotal3ra";
            this.lb_subtotal3ra.Size = new System.Drawing.Size(22, 23);
            this.lb_subtotal3ra.TabIndex = 28;
            this.lb_subtotal3ra.Text = "0";
            // 
            // lb_totalPagar
            // 
            this.lb_totalPagar.AutoSize = true;
            this.lb_totalPagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPagar.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_totalPagar.Location = new System.Drawing.Point(597, 332);
            this.lb_totalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_totalPagar.Name = "lb_totalPagar";
            this.lb_totalPagar.Size = new System.Drawing.Size(22, 23);
            this.lb_totalPagar.TabIndex = 29;
            this.lb_totalPagar.Text = "0";
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.ForeColor = System.Drawing.Color.White;
            this.btn_continuar.Location = new System.Drawing.Point(409, 683);
            this.btn_continuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(244, 63);
            this.btn_continuar.TabIndex = 6;
            this.btn_continuar.Text = "CONTINUAR";
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Red;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regresar.Location = new System.Drawing.Point(13, 25);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(115, 46);
            this.btn_regresar.TabIndex = 31;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button8_Click);
            // 
            // lb_17
            // 
            this.lb_17.AutoSize = true;
            this.lb_17.Location = new System.Drawing.Point(1761, 39);
            this.lb_17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_17.Name = "lb_17";
            this.lb_17.Size = new System.Drawing.Size(39, 17);
            this.lb_17.TabIndex = 33;
            this.lb_17.Text = "Hora";
            // 
            // lb_18
            // 
            this.lb_18.AutoSize = true;
            this.lb_18.Location = new System.Drawing.Point(1761, 11);
            this.lb_18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_18.Name = "lb_18";
            this.lb_18.Size = new System.Drawing.Size(47, 17);
            this.lb_18.TabIndex = 32;
            this.lb_18.Text = "Fecha";
            // 
            // panel_agregarboletos
            // 
            this.panel_agregarboletos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_agregarboletos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_agregarboletos.Controls.Add(this.panel_3ra);
            this.panel_agregarboletos.Controls.Add(this.panel_nino);
            this.panel_agregarboletos.Controls.Add(this.btn_sumarNino);
            this.panel_agregarboletos.Controls.Add(this.panel_adulto);
            this.panel_agregarboletos.Controls.Add(this.lb_nino);
            this.panel_agregarboletos.Controls.Add(this.lb_adulto);
            this.panel_agregarboletos.Controls.Add(this.lb_3raEdad);
            this.panel_agregarboletos.Controls.Add(this.lb_precioNino);
            this.panel_agregarboletos.Controls.Add(this.lb_precioAdulto);
            this.panel_agregarboletos.Controls.Add(this.lb_totalPagar);
            this.panel_agregarboletos.Controls.Add(this.lb_precio3ra);
            this.panel_agregarboletos.Controls.Add(this.lb_subtotal3ra);
            this.panel_agregarboletos.Controls.Add(this.txtbx_noNinos);
            this.panel_agregarboletos.Controls.Add(this.lb_subtotalAdulto);
            this.panel_agregarboletos.Controls.Add(this.txtbx_noAdulto);
            this.panel_agregarboletos.Controls.Add(this.lb_subtotalNino);
            this.panel_agregarboletos.Controls.Add(this.txtbx_no3ra);
            this.panel_agregarboletos.Controls.Add(this.txtbx_totalAsientos);
            this.panel_agregarboletos.Controls.Add(this.btn_restarNino);
            this.panel_agregarboletos.Controls.Add(this.lb_total);
            this.panel_agregarboletos.Controls.Add(this.btn_restarAdulto);
            this.panel_agregarboletos.Controls.Add(this.btn_sumar3ra);
            this.panel_agregarboletos.Controls.Add(this.btn_sumarAdulto);
            this.panel_agregarboletos.Controls.Add(this.btn_restar3ra);
            this.panel_agregarboletos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel_agregarboletos.Location = new System.Drawing.Point(148, 288);
            this.panel_agregarboletos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_agregarboletos.Name = "panel_agregarboletos";
            this.panel_agregarboletos.Size = new System.Drawing.Size(778, 384);
            this.panel_agregarboletos.TabIndex = 161;
            // 
            // panel_3ra
            // 
            this.panel_3ra.BackgroundImage = global::ProyectoAS2TaquillaCine.Properties.Resources.anciano;
            this.panel_3ra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_3ra.Location = new System.Drawing.Point(175, 225);
            this.panel_3ra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_3ra.Name = "panel_3ra";
            this.panel_3ra.Size = new System.Drawing.Size(65, 78);
            this.panel_3ra.TabIndex = 36;
            // 
            // panel_nino
            // 
            this.panel_nino.BackgroundImage = global::ProyectoAS2TaquillaCine.Properties.Resources.ninos__1_;
            this.panel_nino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_nino.Location = new System.Drawing.Point(175, 129);
            this.panel_nino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_nino.Name = "panel_nino";
            this.panel_nino.Size = new System.Drawing.Size(65, 78);
            this.panel_nino.TabIndex = 35;
            // 
            // panel_adulto
            // 
            this.panel_adulto.BackgroundImage = global::ProyectoAS2TaquillaCine.Properties.Resources.hombre;
            this.panel_adulto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_adulto.Location = new System.Drawing.Point(175, 34);
            this.panel_adulto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_adulto.Name = "panel_adulto";
            this.panel_adulto.Size = new System.Drawing.Size(65, 78);
            this.panel_adulto.TabIndex = 34;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1065, 761);
            this.Controls.Add(this.panel_agregarboletos);
            this.Controls.Add(this.lb_17);
            this.Controls.Add(this.lb_18);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.lb_texto2);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.cb_hora);
            this.Controls.Add(this.lb_horario);
            this.Controls.Add(this.cb_fecha);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.lb_cinehub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.panel_agregarboletos.ResumeLayout(false);
            this.panel_agregarboletos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cinehub;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.ComboBox cb_fecha;
        private System.Windows.Forms.ComboBox cb_hora;
        private System.Windows.Forms.Label lb_horario;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Label lb_texto2;
        private System.Windows.Forms.Label lb_nino;
        private System.Windows.Forms.Label lb_adulto;
        private System.Windows.Forms.Label lb_3raEdad;
        private System.Windows.Forms.Label lb_precioNino;
        private System.Windows.Forms.Label lb_precioAdulto;
        private System.Windows.Forms.Label lb_precio3ra;
        private System.Windows.Forms.TextBox txtbx_noNinos;
        private System.Windows.Forms.TextBox txtbx_noAdulto;
        private System.Windows.Forms.TextBox txtbx_no3ra;
        private System.Windows.Forms.Button btn_restarNino;
        private System.Windows.Forms.Button btn_sumarNino;
        private System.Windows.Forms.Button btn_sumarAdulto;
        private System.Windows.Forms.Button btn_restarAdulto;
        private System.Windows.Forms.Button btn_sumar3ra;
        private System.Windows.Forms.Button btn_restar3ra;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TextBox txtbx_totalAsientos;
        private System.Windows.Forms.Label lb_subtotalNino;
        private System.Windows.Forms.Label lb_subtotalAdulto;
        private System.Windows.Forms.Label lb_subtotal3ra;
        private System.Windows.Forms.Label lb_totalPagar;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lb_17;
        private System.Windows.Forms.Label lb_18;
        private System.Windows.Forms.Panel panel_adulto;
        private System.Windows.Forms.Panel panel_agregarboletos;
        private System.Windows.Forms.Panel panel_nino;
        private System.Windows.Forms.Panel panel_3ra;
    }
}