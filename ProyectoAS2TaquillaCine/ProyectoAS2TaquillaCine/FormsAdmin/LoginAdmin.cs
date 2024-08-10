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
using Org.BouncyCastle.Crypto.Generators;

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
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseConfig.ConnectionString;

            // Obtener los valores ingresados por el usuario
            string email = txtbx_user.Text;
            string contrasena = txtbx_contrasena.Text;

            // Validar que el correo tenga el sufijo @gmail.com
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Correo o contraseña invalido.", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crear un comando para validar el email y la contraseña
                    string query = "SELECT Contrasena, FK_ID_Cargo FROM tbl_empleado WHERE Email = @Email";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader.GetString("Contrasena");
                                int cargoId = Convert.ToInt32(reader["FK_ID_Cargo"]);

                                // Comparar la contraseña ingresada con la almacenada
                                if (BCrypt.Net.BCrypt.Verify(contrasena, hashedPassword))//
                                {
                                    if (cargoId == 1)
                                    {
                                        GlobalSettings.IsAdmin = true; 
                                    }
                                    else
                                    {
                                        // El usuario no es administrador
                                        GlobalSettings.IsAdmin = false;
                                    }

                                    MessageBox.Show("Inicio de sesión exitoso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);                                
                                    FormsAdmin.MenuGeneral dashboardForm = new FormsAdmin.MenuGeneral();
                                    dashboardForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Correo o contraseña incorrectos.", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Correo o contraseña incorrectos.", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
            if (chb_mostrarCont.Checked)
            {
                txtbx_contrasena.PasswordChar = '\0'; 
            }
            else
            {
                txtbx_contrasena.PasswordChar = '*'; 
            }
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txtbx_contrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


//CODIGO CREADO POR DIGO MARROQUIN Y BRAYAN HERNANDEZ