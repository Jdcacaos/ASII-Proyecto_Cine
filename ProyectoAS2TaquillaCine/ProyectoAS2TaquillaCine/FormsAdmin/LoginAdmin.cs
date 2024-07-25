using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsGlobales.Menu loginForm = new FormsGlobales.Menu();

            // Mostrar el formulario LoginCliente
            loginForm.Show();

            // Opcional: Cerrar o esconder el formulario actual
            this.Hide();
        }
    }
}
