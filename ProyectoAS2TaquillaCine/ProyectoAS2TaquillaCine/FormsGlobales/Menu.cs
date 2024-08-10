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
            FormsCliente.LoginCliente loginForm = new FormsCliente.LoginCliente();

            loginForm.Show();

            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsAdmin.LoginAdmin loginForm = new FormsAdmin.LoginAdmin();

            loginForm.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormsCliente.LoginCliente loginForm = new FormsCliente.LoginCliente();

            loginForm.Show();

            this.Hide(); 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormsAdmin.LoginAdmin loginForm = new FormsAdmin.LoginAdmin();
            loginForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

//CODIGO CREADO POR DIEGO MARROQUIN
