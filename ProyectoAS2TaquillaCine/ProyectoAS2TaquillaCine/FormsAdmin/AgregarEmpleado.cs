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
    public partial class AgregarEmpleado : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;

        private void LlenarComboBox()
        {
            string query = "SELECT ID_Cargo, Nombre FROM tbl_cargo";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cbCargo.Items.Clear();

                            while (reader.Read())
                            {
                                int idCargo = reader.GetInt32("ID_Cargo");
                                string nombre = reader.GetString("Nombre");

                                cbCargo.Items.Add(new KeyValuePair<int, string>(idCargo, nombre));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cbCargo.DisplayMember = "Value";
            cbCargo.ValueMember = "Key";
        }




        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text != txtContrasenaVer.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idCargo = ((KeyValuePair<int, string>)cbCargo.SelectedItem).Key;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_empleado (nombre, apellido, FK_ID_Cargo, email, telefono, contrasena) " +
                                   "VALUES (@Nombre, @Apellido, @Cargo, @Email, @Telefono, @Contrasena)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@Cargo", idCargo); 
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el empleado: " + ex.Message);
                }
            }
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }
    }
}
