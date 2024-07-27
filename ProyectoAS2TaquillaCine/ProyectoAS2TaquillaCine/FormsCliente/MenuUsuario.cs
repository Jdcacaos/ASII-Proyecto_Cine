using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ProyectoAS2TaquillaCine.FormsCliente
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }
        public void AbrirformHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count>0)
                this.PanelContenedor.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fh);
                this.PanelContenedor.Tag = fh;
                fh.Show();
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirformHijo(new FormsCliente.Principal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsCliente.Cartelera());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsCliente.Asientos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsCliente.Reserva());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsCliente.Pago());
        }
    }
}
