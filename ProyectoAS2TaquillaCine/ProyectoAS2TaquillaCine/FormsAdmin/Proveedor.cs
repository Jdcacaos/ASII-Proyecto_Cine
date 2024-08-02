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
    public partial class Proveedor : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
       
        public Proveedor()
        {
            InitializeComponent();
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_proveedor_pelicula (nombre) VALUES (@Nombre)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                    CargarProveedores();  // Actualizar los datos en el DataGridView después de insertar un nuevo registro.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el proveedor: " + ex.Message);
                }
            }
        }
        private void CargarProveedores()
            {
                string query = "SELECT ID_proveedor, nombre FROM tbl_proveedor_pelicula";

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

                                dgvProveedores.DataSource = dataTable;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
                    }
                }
            }

        private void button7_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dgvProveedores.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvProveedores.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProveedores.Rows[selectedRowIndex];
                int idProveedor = Convert.ToInt32(selectedRow.Cells["ID_proveedor"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas editar este registro?", "Confirmar edición", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "UPDATE tbl_proveedor_pelicula SET nombre = @Nombre WHERE ID_proveedor = @ID_proveedor";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                                command.Parameters.AddWithValue("@ID_proveedor", idProveedor);

                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Registro actualizado exitosamente.");
                            CargarProveedores();  // Actualizar los datos en el DataGridView después de editar el registro.
                            LimpiarCampos(); // Limpiar los TextBoxes después de editar
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar el proveedor: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para editar.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvProveedores.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProveedores.Rows[selectedRowIndex];
                int idProveedor = Convert.ToInt32(selectedRow.Cells["ID_proveedor"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_proveedor_pelicula WHERE ID_proveedor = @ID_proveedor";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_proveedor", idProveedor);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Registro eliminado exitosamente.");
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el registro para eliminar.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                        }
                    }

                    // Actualizar el DataGridView
                    CargarProveedores();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        
        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }
=======
        private void Proveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}
>>>>>>> d0ca6f15de6bfbc3f2c8c3463d85476367b33b26

