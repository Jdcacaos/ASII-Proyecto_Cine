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
    public partial class MenuGeneral : Form
    {
        public MenuGeneral()
        {
            InitializeComponent();
        }
        public void AbrirformHijo(object formhijo)
        {
            if (this.panel_panelGeneral.Controls.Count > 0)
                this.panel_panelGeneral.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_panelGeneral.Controls.Add(fh);
            this.panel_panelGeneral.Tag = fh;
            fh.Show();


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsAdmin.AgregarEmpleado());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsAdmin.AgregarPeliculas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsAdmin.Ubicaciones());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsAdmin.Salas());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsAdmin.Horarios());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsAdmin.Proveedor());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Verifica si el usuario es administrador y cambia la variable global si es necesario
            if (GlobalSettings.IsAdmin)
            {
                GlobalSettings.IsAdmin = false;
            }

            // Mostrar el formulario de inicio de sesión (o cualquier otro formulario de tu elección)
            FormsGlobales.Menu newMenu = new FormsGlobales.Menu();
            newMenu.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void btn_bitacora_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsAdmin.Bitacora());
        }
    }
}