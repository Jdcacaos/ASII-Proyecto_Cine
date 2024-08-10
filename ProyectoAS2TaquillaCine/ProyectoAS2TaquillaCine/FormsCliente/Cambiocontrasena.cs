using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAS2TaquillaCine.FormsCliente
{
    public partial class Cambiocontrasena : Form
    {
        public Cambiocontrasena()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string email = txt_correo.Text.Trim();
            string nuevaContrasena = txt_nuevacontrasena.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nuevaContrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Encriptar la nueva contraseña
            string nuevaContrasenaEncriptada = BCrypt.Net.BCrypt.HashPassword(nuevaContrasena);

            string connectionString = DatabaseConfig.ConnectionString;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Validar si el correo existe en la base de datos
                    string checkEmailQuery = "SELECT COUNT(*) FROM tbl_cliente WHERE email = @Email";
                    using (MySqlCommand checkEmailCommand = new MySqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCommand.Parameters.AddWithValue("@Email", email);
                        int emailCount = Convert.ToInt32(checkEmailCommand.ExecuteScalar());

                        if (emailCount == 0)
                        {
                            MessageBox.Show("Correo no encontrado. Verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Actualizar la contraseña en la base de datos
                    string updateQuery = "UPDATE tbl_cliente SET contrasena = @NuevaContrasena WHERE Email = @Email";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NuevaContrasena", nuevaContrasenaEncriptada);
                        updateCommand.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormsCliente.LoginCliente pagoForm = new FormsCliente.LoginCliente();
                            pagoForm.Show();
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la contraseña. Inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void Cambiocontrasena_Load(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            FormsCliente.LoginCliente pagoForm = new FormsCliente.LoginCliente();
            pagoForm.Show();
            this.Close(); 
        }
    }
}


//CODIGO CREADO POR BRAYAN HERNANDEZ Y SEBASTIAN LETONA
