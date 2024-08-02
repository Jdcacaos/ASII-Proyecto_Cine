using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAS2TaquillaCine.FormsCliente
{
    public partial class Asientos : Form
    {
        private Timer timer;
        private int tiempoTotal; // Tiempo total en segundos
        private int tiempoRestante; // Tiempo restante en segundos

        public Asientos()
        {
            InitializeComponent();

            btnI10.BackColor = Color.Red;

            // Asegúrate de que el Timer se inicializa y se configura correctamente
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Tick;

            // Asignar el mismo método a todos los botones
            btnA1.Click += Asiento_Click;
            btnA2.Click += Asiento_Click;
            btnA3.Click += Asiento_Click;
            btnA4.Click += Asiento_Click;
            btnA5.Click += Asiento_Click;
            btnA6.Click += Asiento_Click;
            btnA7.Click += Asiento_Click;
            btnA8.Click += Asiento_Click;
            btnA9.Click += Asiento_Click;
            btnA10.Click += Asiento_Click;

            btnB1.Click += Asiento_Click;
            btnB2.Click += Asiento_Click;
            btnB3.Click += Asiento_Click;
            btnB4.Click += Asiento_Click;
            btnB5.Click += Asiento_Click;
            btnB6.Click += Asiento_Click;
            btnB7.Click += Asiento_Click;
            btnB8.Click += Asiento_Click;
            btnB9.Click += Asiento_Click;
            btnB10.Click += Asiento_Click;

            btnC1.Click += Asiento_Click;
            btnC2.Click += Asiento_Click;
            btnC3.Click += Asiento_Click;
            btnC4.Click += Asiento_Click;
            btnC5.Click += Asiento_Click;
            btnC6.Click += Asiento_Click;
            btnC7.Click += Asiento_Click;
            btnC8.Click += Asiento_Click;
            btnC9.Click += Asiento_Click;
            btnC10.Click += Asiento_Click;

            btnD4.Click += Asiento_Click;
            btnD5.Click += Asiento_Click;
            btnD6.Click += Asiento_Click;
            btnD7.Click += Asiento_Click;
            btnD8.Click += Asiento_Click;
            btnD9.Click += Asiento_Click;
            btnD10.Click += Asiento_Click;

            btnE4.Click += Asiento_Click;
            btnE5.Click += Asiento_Click;
            btnE6.Click += Asiento_Click;
            btnE7.Click += Asiento_Click;
            btnE8.Click += Asiento_Click;
            btnE9.Click += Asiento_Click;
            btnE10.Click += Asiento_Click;

            btnF4.Click += Asiento_Click;
            btnF5.Click += Asiento_Click;
            btnF6.Click += Asiento_Click;
            btnF7.Click += Asiento_Click;
            btnF8.Click += Asiento_Click;
            btnF9.Click += Asiento_Click;
            btnF10.Click += Asiento_Click;

            btnG4.Click += Asiento_Click;
            btnG5.Click += Asiento_Click;
            btnG6.Click += Asiento_Click;
            btnG7.Click += Asiento_Click;
            btnG8.Click += Asiento_Click;
            btnG9.Click += Asiento_Click;
            btnG10.Click += Asiento_Click;

            btnH4.Click += Asiento_Click;
            btnH5.Click += Asiento_Click;
            btnH6.Click += Asiento_Click;
            btnH7.Click += Asiento_Click;
            btnH8.Click += Asiento_Click;
            btnH9.Click += Asiento_Click;
            btnH10.Click += Asiento_Click;

            btnI4.Click += Asiento_Click;
            btnI5.Click += Asiento_Click;
            btnI6.Click += Asiento_Click;
            btnI7.Click += Asiento_Click;
            btnI8.Click += Asiento_Click;
            btnI9.Click += Asiento_Click;
            btnI10.Click += Asiento_Click;
        }

        private void Asientos_Load(object sender, EventArgs e)
        {
            IniciarCronometro(30);
        }
        private void IniciarCronometro(int segundos)
        {
            if (pb1 == null || lblT == null)
            {
                MessageBox.Show("Controles no inicializados.");
                return;
            }

            tiempoTotal = segundos;
            tiempoRestante = segundos;
            pb1.Maximum = tiempoTotal;
            pb1.Value = tiempoTotal;

            // Inicia el Timer
            timer.Start();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            // Actualiza la Label con el tiempo restante
            lblT.Text = TimeSpan.FromSeconds(tiempoRestante).ToString(@"hh\:mm\:ss");

            // Actualiza la ProgressBar
            pb1.Value = tiempoRestante;

            // Detén el Timer cuando el tiempo se acabe
            if (tiempoRestante <= 0)
            {
                timer.Stop();
                lblT.Text = "00:00:00";
                pb1.Value = 0;
                MessageBox.Show("¡Tiempo agotado!");

                // Redirige al formulario CarteleraNueva
                CarteleraNueva carteleraNueva = new CarteleraNueva();
                carteleraNueva.Show();
                this.Close(); // Opcional: cierra el formulario actual si ya no es necesario
            }
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
           
        }

        private void A2_Click(object sender, EventArgs e)
        {
            

        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            

        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
           
        }

        private void btnA9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnA10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
           
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnB10_Click(object sender, EventArgs e)
        {
           
        }

        private void btnC1_Click(object sender, EventArgs e)
        {

        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnE7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnE8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnE9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnE10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
           
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnG5_Click(object sender, EventArgs e)
        {

        }

        private void btnG6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnG7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnG8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnG9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnG10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnH4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnH5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnH6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnH7_Click(object sender, EventArgs e)
        {
           
        }

        private void btnH8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnH9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnH10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnI4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnI5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnI6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnI7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnI8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnI9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnI10_Click(object sender, EventArgs e)
        {
            
        }

        private void Asiento_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Verificar si el botón es rojo, en cuyo caso no hacer nada
            if (btn.BackColor == Color.Red)
            {
                btn.Enabled = false;
                return; // Salir del método si el botón es rojo
            }

            // Alternar el color de los botones que no son rojos
            if (btn.BackColor == Color.Lime)
            {
                btn.BackColor = Color.DarkBlue;
            }
            else
            {
                btn.BackColor = Color.Lime;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button95_Click(object sender, EventArgs e)
        {
            FormsCliente.Pago newPago = new FormsCliente.Pago();
            newPago.Show();
            this.Hide();
        }
    }
}
