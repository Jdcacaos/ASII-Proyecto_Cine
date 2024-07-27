using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoAS2TaquillaCine.FormsGlobales
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario LoginCliente
            FormsCliente.LoginCliente loginForm = new FormsCliente.LoginCliente();

            // Mostrar el formulario LoginCliente
            loginForm.Show();

            // Opcional: Cerrar o esconder el formulario actual
            this.Hide(); // Si quieres ocultar el formulario actual
                         // this.Close(); // Si quieres cerrar el formulario actual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario LoginCliente
            FormsAdmin.LoginAdmin loginForm = new FormsAdmin.LoginAdmin();

            // Mostrar el formulario LoginCliente
            loginForm.Show();

            // Opcional: Cerrar o esconder el formulario actual
            this.Hide(); // Si quieres ocultar el formulario actual
                         // this.Close(); // Si quieres cerrar el formulario actual
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del formulario LoginCliente
            FormsCliente.LoginCliente loginForm = new FormsCliente.LoginCliente();

            // Mostrar el formulario LoginCliente
            loginForm.Show();

            // Opcional: Cerrar o esconder el formulario actual
            this.Hide(); // Si quieres ocultar el formulario actual
                         // this.Close(); // Si quieres cerrar el formulario actual
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del formulario LoginCliente
            FormsAdmin.MenuGeneral loginForm = new FormsAdmin.MenuGeneral();

            // Mostrar el formulario LoginCliente
            loginForm.Show();

            // Opcional: Cerrar o esconder el formulario actual
            this.Hide(); // Si quieres ocultar el formulario actual
                         // this.Close(); // Si quieres cerrar el formulario actual
        }
    }
}
