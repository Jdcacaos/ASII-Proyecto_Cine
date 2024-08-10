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
using BCrypt.Net; 

namespace ProyectoAS2TaquillaCine.FormsCliente
{
    public partial class LoginCliente : Form
    {
        public LoginCliente()
        {
            InitializeComponent();
            txtbx_correoUsuario.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            txtbx_contrasena.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            this.MaximizeBox = false;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsGlobales.Menu menuForm = new FormsGlobales.Menu();
            menuForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsCliente.RegistroCliente registroForm = new FormsCliente.RegistroCliente();
            registroForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseConfig.ConnectionString;
            string email = txtbx_correoUsuario.Text.Trim();
            string contrasena = txtbx_contrasena.Text.Trim();

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

                    string query = "SELECT ID_Cliente, Contrasena FROM tbl_cliente WHERE Email = @Email";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idCliente = reader.GetInt32("ID_Cliente");
                                string hashedPassword = reader.GetString("Contrasena");

                                // Verificar la contraseña ingresada con la contraseña encriptada
                                if (BCrypt.Net.BCrypt.Verify(contrasena, hashedPassword))
                                {
                                    MessageBox.Show("Inicio de sesión exitoso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    FormsCliente.CarteleraNueva pagoForm = new FormsCliente.CarteleraNueva(idCliente);
                                    pagoForm.Show();
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

        private void mostrarCon_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_mostrarContra.Checked)
            {
                txtbx_contrasena.PasswordChar = '\0'; 
            }
            else
            {
                txtbx_contrasena.PasswordChar = '*'; 
            }
        }

        private void LoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormsCliente.Cambiocontrasena loginForm = new FormsCliente.Cambiocontrasena();
            loginForm.Show();
            this.Hide();
        }
    }
}

//CODIGO CREADO POR JOSUE CACAO Y JOSE VICTOR CASTELLANOS

