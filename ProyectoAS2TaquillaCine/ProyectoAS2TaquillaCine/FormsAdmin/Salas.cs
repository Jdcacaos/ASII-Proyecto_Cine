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
    public partial class Salas : Form
    {
        string connectionString = DatabaseConfig.ConnectionString; // Debe ser una cadena de conexión MySQL

        public Salas()
        {
            InitializeComponent();
        }

        private void Salas_Load(object sender, EventArgs e)
        {
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            LlenarComboBox_tiposala();
            LlenarComboBox_ubicacion();
            LlenarComboBox_estado();

            try
            {
                conexionDB = new MySqlConnection(connectionString);

                // Consulta SQL actualizada para incluir las uniones
                MySqlCommand comando = new MySqlCommand(
                    "SELECT s.*, ts.Tipo, u.Direccion " +
                    "FROM tbl_sala s " +
                    "JOIN tbl_tipo_sala ts ON s.FK_ID_Tipo_Sala = ts.ID_Tipo_Sala " +
                    "JOIN tbl_ubicacion u ON s.FK_ID_Ubicacion = u.ID_Ubicacion", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dataTable;

                // Opcional: Ocultar las columnas de ID si ya no se necesitan
                dataGridView1.Columns["FK_ID_Tipo_Sala"].Visible = false;
                dataGridView1.Columns["FK_ID_Ubicacion"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LlenarComboBox_estado()
        {
            cbestado.Items.Clear();
            cbestado.Items.Add("Activo");
            cbestado.Items.Add("Inactivo");
            if (cbestado.Items.Count > 0)
            {
                cbestado.SelectedIndex = 0;
            }
        }


        private void LlenarComboBox_tiposala()
        {
            string query = "SELECT ID_tipo_sala, Tipo FROM tbl_tipo_sala";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cbtiposala.Items.Clear();

                            while (reader.Read())
                            {
                                int idtsala = reader.GetInt32("ID_tipo_sala");
                                string tipo = reader.GetString("Tipo");

                                cbtiposala.Items.Add(new KeyValuePair<int, string>(idtsala, tipo));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cbtiposala.DisplayMember = "Value";
            cbtiposala.ValueMember = "Key";
            if (cbtiposala.Items.Count > 0)
            {
                cbtiposala.SelectedIndex = 0;
            }
        }

        private void LlenarComboBox_ubicacion()
        {
            string query = "SELECT ID_Ubicacion, Direccion FROM tbl_ubicacion";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cbubicacion.Items.Clear();

                            while (reader.Read())
                            {
                                int idubicacion = reader.GetInt32("ID_Ubicacion");
                                string direccion = reader.GetString("Direccion");

                                cbubicacion.Items.Add(new KeyValuePair<int, string>(idubicacion, direccion));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cbubicacion.DisplayMember = "Value";
            cbubicacion.ValueMember = "Key";
            if (cbubicacion.Items.Count > 0)
            {
                cbubicacion.SelectedIndex = 0;
            }
        }

        public void llenar_tabla()
        {
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(connectionString);

                // Consulta SQL actualizada para incluir las uniones
                MySqlCommand comando = new MySqlCommand(
                    "SELECT s.*, ts.Tipo, u.Direccion " +
                    "FROM tbl_sala s " +
                    "JOIN tbl_tipo_sala ts ON s.FK_ID_Tipo_Sala = ts.ID_Tipo_Sala " +
                    "JOIN tbl_ubicacion u ON s.FK_ID_Ubicacion = u.ID_Ubicacion", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dataTable;

                // Opcional: Ocultar las columnas de ID si ya no se necesitan
                dataGridView1.Columns["FK_ID_Tipo_Sala"].Visible = false;
                dataGridView1.Columns["FK_ID_Ubicacion"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                txtnosala.Text = Convert.ToString(selectedRow.Cells["Numero_Sala"].Value);
                txtcapacidad.Text = Convert.ToString(selectedRow.Cells["Capacidad"].Value);

                string tipoSalaNombre = Convert.ToString(selectedRow.Cells["Tipo"].Value);
                string ubicacionNombre = Convert.ToString(selectedRow.Cells["Direccion"].Value);
                string estadoNombre = Convert.ToString(selectedRow.Cells["Estado_tbl_sala"].Value);

                // Buscar y seleccionar el valor en el ComboBox de tipo de sala
                foreach (var item in cbtiposala.Items)
                {
                    var keyValuePair = (KeyValuePair<int, string>)item;
                    if (keyValuePair.Value == tipoSalaNombre)
                    {
                        cbtiposala.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Buscar y seleccionar el valor en el ComboBox de ubicación
                foreach (var item in cbubicacion.Items)
                {
                    var keyValuePair = (KeyValuePair<int, string>)item;
                    if (keyValuePair.Value == ubicacionNombre)
                    {
                        cbubicacion.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Asignar el valor del estado
                cbestado.SelectedItem = estadoNombre;
            }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            int idtiposala = ((KeyValuePair<int, string>)cbtiposala.SelectedItem).Key;
            int idubicacion = ((KeyValuePair<int, string>)cbubicacion.SelectedItem).Key;
      

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_sala (Numero_Sala, Capacidad, FK_ID_Tipo_Sala, FK_ID_Ubicacion, Estado_tbl_sala) " +
                                   "VALUES (@Numero_Sala, @Capacidad, @FK_ID_Tipo_Sala, @FK_ID_Ubicacion, @Estado_tbl_sala)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Numero_Sala", txtnosala.Text);
                        command.Parameters.AddWithValue("@Capacidad", txtcapacidad.Text);
                        command.Parameters.AddWithValue("@FK_ID_Tipo_Sala", idtiposala);
                        command.Parameters.AddWithValue("@FK_ID_Ubicacion", idubicacion);
                        command.Parameters.AddWithValue("@Estado_tbl_sala", cbestado.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el empleado: " + ex.Message);
                }
            }

            llenar_tabla();
        }

        private object ObtenerValorCelda(string nombreColumna)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                return filaSeleccionada.Cells[nombreColumna].Value;
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.");
                return null;        
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbtiposala.SelectedItem == null || cbubicacion.SelectedItem == null || cbestado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, actualiza todos los datos");
                    return;
                }

                // Obtener valores del ComboBox
                int tiposala = ((KeyValuePair<int, string>)cbtiposala.SelectedItem).Key;
                int ubicacion = ((KeyValuePair<int, string>)cbubicacion.SelectedItem).Key;

                // Obtener valor de la celda
                Object obtener = ObtenerValorCelda("ID_Sala");
                if (obtener == null)
                {
                    MessageBox.Show("No se pudo obtener el valor de ID_Sala.");
                    return;
                }

                int ValorObtenido = Convert.ToInt32(obtener);

                // Actualizar base de datos
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string consulta = "UPDATE tbl_sala SET Numero_Sala = @Numero_Sala, Capacidad = @Capacidad, FK_ID_Tipo_Sala = @FK_ID_Tipo_Sala, FK_ID_Ubicacion = @FK_ID_Ubicacion, Estado_tbl_sala = @Estado_tbl_sala WHERE ID_Sala = @ID_Sala";
                    MySqlCommand comando = new MySqlCommand(consulta, connection);
                    comando.Parameters.AddWithValue("@Numero_Sala", txtnosala.Text);
                    comando.Parameters.AddWithValue("@Capacidad", txtcapacidad.Text);
                    comando.Parameters.AddWithValue("@FK_ID_Tipo_Sala", tiposala);
                    comando.Parameters.AddWithValue("@FK_ID_Ubicacion", ubicacion);
                    comando.Parameters.AddWithValue("@Estado_tbl_sala", cbestado.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@ID_Sala", ValorObtenido);

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
        }




        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                int idSala = Convert.ToInt32(selectedRow.Cells["ID_Sala"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_sala WHERE ID_Sala = @ID_Sala";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Sala", idSala);
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
                    llenar_tabla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }


        private bool datosCorrectos()
        {
            if(txtcapacidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }

            if (txtnosala.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el numero de sala");
                return false;
            }

            if (cbtiposala.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione el tipo de sala");
                return false;
            }

            if (cbubicacion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione la ubicación");
                return false;
            }

            if (cbestado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione un estado");
                return false;
            }

            return true;
        }
    }
}