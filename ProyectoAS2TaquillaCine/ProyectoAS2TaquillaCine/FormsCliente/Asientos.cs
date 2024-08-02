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

            lblT.Text = TimeSpan.FromSeconds(tiempoRestante).ToString(@"hh\:mm\:ss");
            // Inicia el Timer
            timer.Start();
        }

        private void Label15_Click(object sender, EventArgs e)
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormsCliente.Reserva formReserva = new FormsCliente.Reserva();
            formReserva.Show();
            this.Hide();
        }

        private void Asientos_Load_1(object sender, EventArgs e)
        {
            IniciarCronometro(60);
        }
    }
}
