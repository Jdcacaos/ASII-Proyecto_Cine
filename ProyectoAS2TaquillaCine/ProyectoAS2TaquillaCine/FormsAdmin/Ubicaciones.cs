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
using System.Data.SqlClient;

namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    public partial class Ubicaciones : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
  
        private void TimerFechaHora_Tick(object sender, EventArgs e)
        {
            lbl_FechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public Ubicaciones()
        {
            InitializeComponent();
            DGV_Ubicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Configurar el Timer
            tm_tiempo = new Timer();
            tm_tiempo.Interval = 1000; // 1000 ms = 1 segundo
            tm_tiempo.Tick += new EventHandler(this.TimerFechaHora_Tick);
            tm_tiempo.Start(); // Iniciar el Timer
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }



        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Verifica si los datos son correctos
            if (!datosCorrectos())
            {
                return; // Si los datos no son correctos, no se continúa con el proceso
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_ubicacion (Ciudad, Direccion) VALUES (@Ciudad, @Direccion)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                        command.Parameters.AddWithValue("@Direccion", txtUbicacion.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la ubicación: " + ex.Message);
                }

                llenar_tabla();

                // Limpiar campos
                txtCiudad.Text = "";
                txtUbicacion.Text = "";
            }
        }

        private object ObtenerValorCelda(string nombreColumna)
        {
            if (DGV_Ubicaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DGV_Ubicaciones.SelectedRows[0];
                return filaSeleccionada.Cells[nombreColumna].Value;
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.");
                return null;
            }
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "" || txtUbicacion.Text == "")
            {
                MessageBox.Show("Por favor, llena los datos");
                return;
            }

            try
            {
                // Obtener valor de la celda
                Object obtener = ObtenerValorCelda("ID_Ubicacion");
                if (obtener == null)
                {
                    MessageBox.Show("No se pudo obtener el valor de ID_Ubicacion");
                    return;
                }

                int ValorObtenido = Convert.ToInt32(obtener);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string consulta = "UPDATE tbl_Ubicacion SET Ciudad = @Ciudad, Direccion = @Direccion WHERE ID_Ubicacion = @ID_Ubicacion";
                    MySqlCommand comando = new MySqlCommand(consulta, connection);
                    comando.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                    comando.Parameters.AddWithValue("@Direccion", txtUbicacion.Text);
                    comando.Parameters.AddWithValue("@ID_Ubicacion", ValorObtenido);

                    int cantidad = comando.ExecuteNonQuery();
                    if (cantidad > 0)
                    {
                        MessageBox.Show("Registro modificado");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para modificar.");
                    }
                    llenar_tabla();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de datos incorrecto: " + ex.Message);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }

            txtCiudad.Text = "";
            txtUbicacion.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (DGV_Ubicaciones.SelectedCells.Count > 0)
            {
                int selectedRowIndex = DGV_Ubicaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DGV_Ubicaciones.Rows[selectedRowIndex];
                int idubicacion = Convert.ToInt32(selectedRow.Cells["ID_Ubicacion"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_ubicacion WHERE ID_Ubicacion = @ID_Ubicacion";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Ubicacion", idubicacion);
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
                    llenar_tabla();
                }
                txtCiudad.Text = "";
                txtUbicacion.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }
        private void Ubicacion_Load(object sender, EventArgs e)
        {
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(connectionString);

                MySqlCommand comando = new MySqlCommand("SELECT * FROM tbl_ubicacion", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                // Asignar el DataTable al DataGridView
                DGV_Ubicaciones.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenar_tabla()
        {
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(connectionString);

                MySqlCommand comando = new MySqlCommand("SELECT * FROM tbl_ubicacion", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                // Asignar el DataTable al DataGridView
                DGV_Ubicaciones.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool datosCorrectos()
        {
            if (txtCiudad.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre de la ciudad.");
                return false;
            }

            if (txtUbicacion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la dirección.");
                return false;
            }

            return true;
        }


        private void DGV_Ubicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Ubicaciones.SelectedCells.Count > 0)
            {
                int selectedRowIndex = DGV_Ubicaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DGV_Ubicaciones.Rows[selectedRowIndex];

                txtCiudad.Text = Convert.ToString(selectedRow.Cells["Ciudad"].Value);
                txtUbicacion.Text = Convert.ToString(selectedRow.Cells["Direccion"].Value);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_ubicacion (Ciudad, Direccion)" +
                                   "VALUES (@Ciudad, @Direccion)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                        command.Parameters.AddWithValue("@Direccion", txtUbicacion.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el cine: " + ex.Message);
                }

                llenar_tabla();

                txtCiudad.Text = "";
                txtUbicacion.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "" || txtUbicacion.Text == "")
            {
                MessageBox.Show("Por favor, llena los datos");
                return;
            }

            try
            {
                // Obtener valor de la celda
                Object obtener = ObtenerValorCelda("ID_Ubicacion");
                if (obtener == null)
                {
                    MessageBox.Show("No se pudo obtener el valor de ID_Ubicacion");
                    return;
                }

                int ValorObtenido = Convert.ToInt32(obtener);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string consulta = "UPDATE tbl_Ubicacion SET Ciudad = @Ciudad, Direccion = @Direccion WHERE ID_Ubicacion = @ID_Ubicacion";
                    MySqlCommand comando = new MySqlCommand(consulta, connection);
                    comando.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                    comando.Parameters.AddWithValue("@Direccion", txtUbicacion.Text);
                    comando.Parameters.AddWithValue("@ID_Ubicacion", ValorObtenido);

                    int cantidad = comando.ExecuteNonQuery();
                    if (cantidad > 0)
                    {
                        MessageBox.Show("Registro modificado");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para modificar.");
                    }
                    llenar_tabla();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de datos incorrecto: " + ex.Message);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }

            txtCiudad.Text = "";
            txtUbicacion.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DGV_Ubicaciones.SelectedCells.Count > 0)
            {
                int selectedRowIndex = DGV_Ubicaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DGV_Ubicaciones.Rows[selectedRowIndex];
                int idubicacion = Convert.ToInt32(selectedRow.Cells["ID_Ubicacion"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_ubicacion WHERE ID_Ubicacion = @ID_Ubicacion";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Ubicacion", idubicacion);
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
                    llenar_tabla();
                }
                txtCiudad.Text = "";
                txtUbicacion.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}

