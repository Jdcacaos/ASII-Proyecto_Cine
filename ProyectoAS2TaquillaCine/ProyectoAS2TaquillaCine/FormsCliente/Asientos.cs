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
        public Asientos()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

<<<<<<< HEAD
        private void button8_Click(object sender, EventArgs e)
        {
            FormsCliente.Reserva formReserva = new FormsCliente.Reserva();
            formReserva.Show();
            this.Hide();
        }
=======
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



>>>>>>> d0ca6f15de6bfbc3f2c8c3463d85476367b33b26
=======
>>>>>>> parent of 8ce81a1 (Form cartelera y asietnos)
    }
}
