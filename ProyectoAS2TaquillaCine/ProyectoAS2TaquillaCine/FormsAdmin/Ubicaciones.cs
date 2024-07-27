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
    public partial class Ubicaciones : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public Ubicaciones()
        {
            InitializeComponent();
            dgvUbicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_ubicacion (Ciudad, Direccion) VALUES (@Ciudad, @Direccion)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                        command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                    CargarUbicaciones();  // Actualizar los datos en el DataGridView después de insertar un nuevo registro.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la ubicación: " + ex.Message);
                }
            }
        }
        private void CargarUbicaciones()
        {
            string query = "SELECT ID_ubicacion, Ciudad, Direccion FROM tbl_ubicacion";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            var dataTable = new DataTable();
                            dataTable.Load(reader);

                            dgvUbicaciones.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las ubicaciones: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarUbicaciones();
        }
    }
}
