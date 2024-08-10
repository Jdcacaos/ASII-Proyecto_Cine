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
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
            dtp_fecha.MaxDate = DateTime.Today.AddYears(-7); 
            dtp_fecha.MinDate = DateTime.Today.AddYears(-120);
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_nombre.Text) ||
                string.IsNullOrWhiteSpace(txtbx_apellido.Text) ||
                string.IsNullOrWhiteSpace(txtbx_email.Text) ||
                string.IsNullOrWhiteSpace(txtbx_contrasena.Text) ||
                string.IsNullOrWhiteSpace(txtbx_verifContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtbx_telefono.Text) ||
                string.IsNullOrWhiteSpace(txtbx_nit.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtbx_contrasena.Text != txtbx_verifContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbx_nombre.Text, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1\s]+$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtbx_apellido.Text, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1\s]+$"))
            {
                MessageBox.Show("Ingrese valores válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtbx_email.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Ingrese valores válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbx_telefono.Text, @"^[\d+]+$"))
            {
                MessageBox.Show("Ingrese valores válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtbx_contrasena.Text);

            string connectionString = DatabaseConfig.ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string checkEmailQuery = "SELECT COUNT(*) FROM tbl_cliente WHERE email = @Email";
                    using (MySqlCommand checkEmailCommand = new MySqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCommand.Parameters.AddWithValue("@Email", txtbx_email.Text);

                        int emailCount = Convert.ToInt32(checkEmailCommand.ExecuteScalar());

                        if (emailCount > 0)
                        {
                            MessageBox.Show("El correo ya está registrado. Por favor, use otro correo.", "Error de duplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string query = "INSERT INTO tbl_cliente (Nombre, Apellido, Email, Contrasena, Telefono, NIT, Fecha_Nacimiento) " +
                                   "VALUES (@Nombre, @Apellido, @Email, @Contrasena, @Telefono, @Nit, @FechaNacimiento)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtbx_apellido.Text);
                        command.Parameters.AddWithValue("@Email", txtbx_email.Text);
                        command.Parameters.AddWithValue("@Contrasena", hashedPassword); 
                        command.Parameters.AddWithValue("@Telefono", txtbx_telefono.Text);
                        command.Parameters.AddWithValue("@Nit", txtbx_nit.Text);

                        string fechaNacimiento = dtp_fecha.Value.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");

                    FormsCliente.LoginCliente loginForm = new FormsCliente.LoginCliente();
                    loginForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el cliente: " + ex.Message);
                }
            }
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasenaVer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormsCliente.LoginCliente loginForm = new FormsCliente.LoginCliente();
            loginForm.Show();
            this.Hide();
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}


//CODIGO CREADO POR JOSE VICTOR CASTELLANOS, JOEL LOPEZ Y BRAYAN HERNANDEZ
