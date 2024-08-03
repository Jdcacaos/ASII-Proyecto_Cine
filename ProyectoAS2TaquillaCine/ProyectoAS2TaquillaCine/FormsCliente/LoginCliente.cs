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
    public partial class LoginCliente : Form
    {
        public LoginCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsGlobales.Menu loginForm = new FormsGlobales.Menu();

            // Mostrar el formulario LoginCliente
            loginForm.Show();

            // Opcional: Cerrar o esconder el formulario actual
            this.Hide();
        }

        private void LoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario LoginCliente
            FormsCliente.RegistroCliente RegistroForm= new FormsCliente.RegistroCliente();

            // Mostrar el formulario LoginCliente
            RegistroForm.Show();

            // Opcional: Cerrar o esconder el formulario actual
            this.Hide(); // Si quieres ocultar el formulario actual
                         // this.Close(); // Si quieres cerrar el formulario actual
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cadena de conexión a tu base de datos MySQL
            string connectionString = DatabaseConfig.ConnectionString;

            // Obtener los valores ingresados por el usuario
            string email = txtuser.Text;
            string contrasena = txtContrasena.Text;

            // Validar que el correo tenga el sufijo @gmail.com
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("El correo electrónico debe tener el sufijo @gmail.com.", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una conexión a la base de datos
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crear un comando para validar el email y la contraseña
                    string query = "SELECT COUNT(1) FROM tbl_cliente WHERE email = @Email AND contrasena = @Contrasena";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros con los valores ingresados
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        // Ejecutar el comando y obtener el resultado
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            // Las credenciales son correctas, permitir el acceso
                            MessageBox.Show("Inicio de sesión exitoso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Aquí puedes abrir el formulario principal de tu aplicación o proceder según tu lógica
                            // Ejemplo:
                            FormsCliente.CarteleraNueva CarteleraForm = new FormsCliente.CarteleraNueva();

                            // Mostrar el formulario
                            CarteleraForm.Show();

                            // Opcional: Cerrar o esconder el formulario actual
                            this.Hide();
                        }
                        else
                        {
                            // Las credenciales son incorrectas, mostrar un mensaje de error
                            MessageBox.Show("Correo o contraseña incorrectos.", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }


        private void mostrarCon_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarCon.Checked)
            {
                // Mostrar la contraseña
                txtContrasena.PasswordChar = '\0'; // \0 es el carácter nulo, que muestra el texto plano
            }
            else
            {
                // Ocultar la contraseña
                txtContrasena.PasswordChar = '*'; // O cualquier otro carácter de tu elección
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
