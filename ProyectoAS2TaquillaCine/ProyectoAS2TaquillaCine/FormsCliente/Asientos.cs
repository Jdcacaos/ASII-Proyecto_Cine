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

        private void button8_Click(object sender, EventArgs e)
        {
            FormsCliente.Reserva formReserva = new FormsCliente.Reserva();
            formReserva.Show();
            this.Hide();
        }
    }
}
