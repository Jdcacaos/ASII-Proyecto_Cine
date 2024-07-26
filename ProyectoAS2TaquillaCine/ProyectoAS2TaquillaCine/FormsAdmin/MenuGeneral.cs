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

        private void button1_Click(object sender, EventArgs e)
        {
            FormsAdmin.AgregarEmpleado AgregarUsuarioForm = new FormsAdmin.AgregarEmpleado();
            AgregarUsuarioForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsAdmin.AgregarPeliculas AgregarPeliculasForm = new FormsAdmin.AgregarPeliculas();
            AgregarPeliculasForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsAdmin.Salas SalasForm = new FormsAdmin.Salas();
            SalasForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsAdmin.Ubicaciones UbicacionesForm = new FormsAdmin.Ubicaciones();
            UbicacionesForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormsAdmin.Horarios HorariosForm = new FormsAdmin.Horarios();
            HorariosForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormsAdmin.Proveedor ProveedorForm = new FormsAdmin.Proveedor();
            ProveedorForm.Show();
            this.Hide();
        }
    }
}
