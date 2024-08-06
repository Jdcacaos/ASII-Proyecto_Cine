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

        private void button1_Click(object sender, EventArgs e)
        {
            // Cadena de conexión a tu base de datos MySQL
            string connectionString = DatabaseConfig.ConnectionString;

            // Obtener los valores ingresados por el usuario
            string email = txtuser.Text;
            string contrasena = txtContra.Text;

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
                    string query = "SELECT Contrasena FROM tbl_empleado WHERE Email = @Email";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar el parámetro con el valor ingresado
                        command.Parameters.AddWithValue("@Email", email);

                        // Ejecutar el comando y obtener el resultado
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string storedPassword = result.ToString();

                            // Verificar si la contraseña almacenada comienza con "000"
                            bool isAdmin = storedPassword.StartsWith("000");

                            // Comparar la contraseña ingresada con la almacenada
                            if (storedPassword == contrasena)
                            {
                                if (isAdmin)
                                {
                                    // Las credenciales son correctas y el usuario es administrador
                                    GlobalSettings.IsAdmin = true; // Activar la variable global
                                }
                                else
                                {
                                    // Las credenciales son correctas pero no es administrador
                                    GlobalSettings.IsAdmin = false; // O cualquier otra lógica según sea necesario
                                }

                                MessageBox.Show("Inicio de sesión exitoso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Aquí puedes abrir el formulario principal de tu aplicación o proceder según tu lógica
                                FormsAdmin.MenuGeneral dashboardForm = new FormsAdmin.MenuGeneral();
                                dashboardForm.Show();

                                // Opcional: Cerrar o esconder el formulario actual
                                this.Hide();
                            }
                            else
                            {
                                // La contraseña es incorrecta, mostrar un mensaje de error
                                MessageBox.Show("Correo o contraseña incorrectos.", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // El correo no existe, mostrar un mensaje de error
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



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Mostrar la contraseña
                txtContra.PasswordChar = '\0'; // \0 es el carácter nulo, que muestra el texto plano
            }
            else
            {
                // Ocultar la contraseña
                txtContra.PasswordChar = '*'; // O cualquier otro carácter de tu elección
            }
        }
    }
}
