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
using BCrypt.Net; // Asegúrate de tener esta referencia

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

            DialogResult resultado = MessageBox.Show(
                   "¿Estás seguro de que deseas cerrar sesión?",
                   "Confirmar Cierre de Sesión",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
                        );

            if (resultado == DialogResult.Yes)
            {
                // Verifica si el usuario es administrador y cambia la variable global si es necesario
                if (GlobalSettings.IsAdmin)
                {
                    GlobalSettings.IsAdmin = false;
                }
                // Si el usuario confirma, cerrar sesión
                FormsGlobales.Menu newMenu = new FormsGlobales.Menu();
                newMenu.Show();

                // Cerrar el formulario actual
                this.Hide();
            }
        }

        private void btn_bitacora_Click(object sender, EventArgs e)
        {
            AbrirformHijo(new FormsAdmin.Bitacora());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {

        }

        private void btn_reportes_Click_1(object sender, EventArgs e)
        {
            FormsAdmin.Reportes newReporte = new FormsAdmin.Reportes();
            newReporte.Show();
            this.Hide();
        }

        private void btn_Taquilla_Click(object sender, EventArgs e)
        {
            FormsAdmin.RegistroTaquilla newTaquilla = new FormsAdmin.RegistroTaquilla();
            newTaquilla.Show();
            this.Hide();
        }

    }
}