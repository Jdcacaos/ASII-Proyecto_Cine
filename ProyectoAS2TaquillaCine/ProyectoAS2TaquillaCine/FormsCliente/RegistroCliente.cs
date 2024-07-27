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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text != txtContrasenaVer.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Cadena de conexión a tu base de datos MySQL
            string connectionString = DatabaseConfig.ConnectionString;
            // Crear una conexión a la base de datos
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crear un comando para insertar los datos en la tabla cliente
                    string query = "INSERT INTO tbl_cliente (nombre, apellido, email, contrasena, telefono, nit, fecha_nacimiento) " +
                                   "VALUES (@Nombre, @Apellido, @Email, @Contrasena, @Telefono, @Nit, @FechaNacimiento)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros con los valores de los TextBox
                        command.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@Nit", txtNit.Text);

                        string fechaNacimiento = dpFechaNac.Value.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                        // Ejecutar el comando
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

        // Otros métodos y eventos del formulario
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
    }
}
