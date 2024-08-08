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
        string connectionString = DatabaseConfig.ConnectionString; 

        public Salas()
        {
            InitializeComponent();
            dgv_sala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tmr_timer1 = new Timer();
            tmr_timer1.Interval = 100; // Intervalo en milisegundos (1000 ms = 1 segundo)
            tmr_timer1.Tick += new EventHandler(tmr_timer1_Tick);
            tmr_timer1.Start(); // Iniciar el Timer
            btn_editar.Visible = GlobalSettings.IsAdmin;
            btn_eliminar.Visible = GlobalSettings.IsAdmin;
            gbIngresar.Visible = GlobalSettings.IsAdmin;
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
                dgv_sala.DataSource = dataTable;

                // Opcional: Ocultar las columnas de ID si ya no se necesitan
                dgv_sala.Columns["FK_ID_Tipo_Sala"].Visible = false;
                dgv_sala.Columns["FK_ID_Ubicacion"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LlenarComboBox_estado()
        {
            cb_estado.Items.Clear();
            cb_estado.Items.Add("Activo");
            cb_estado.Items.Add("Inactivo");
            if (cb_estado.Items.Count > 0)
            {
                cb_estado.SelectedIndex = 0;
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
                            cb_tipoSala.Items.Clear();

                            while (reader.Read())
                            {
                                int idtsala = reader.GetInt32("ID_tipo_sala");
                                string tipo = reader.GetString("Tipo");

                                cb_tipoSala.Items.Add(new KeyValuePair<int, string>(idtsala, tipo));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cb_tipoSala.DisplayMember = "Value";
            cb_tipoSala.ValueMember = "Key";
            if (cb_tipoSala.Items.Count > 0)
            {
                cb_tipoSala.SelectedIndex = 0;
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
                            cb_ubicacion.Items.Clear();

                            while (reader.Read())
                            {
                                int idubicacion = reader.GetInt32("ID_Ubicacion");
                                string direccion = reader.GetString("Direccion");

                                cb_ubicacion.Items.Add(new KeyValuePair<int, string>(idubicacion, direccion));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cb_ubicacion.DisplayMember = "Value";
            cb_ubicacion.ValueMember = "Key";
            if (cb_ubicacion.Items.Count > 0)
            {
                cb_ubicacion.SelectedIndex = 0;
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
                dgv_sala.DataSource = dataTable;

                // Opcional: Ocultar las columnas de ID si ya no se necesitan
                dgv_sala.Columns["FK_ID_Tipo_Sala"].Visible = false;
                dgv_sala.Columns["FK_ID_Ubicacion"].Visible = false;
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
            if (dgv_sala.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_sala.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_sala.Rows[selectedRowIndex];

                txtbx_noSala.Text = Convert.ToString(selectedRow.Cells["Numero_Sala"].Value);
                txtbx_capacidad.Text = Convert.ToString(selectedRow.Cells["Capacidad"].Value);

                string tipoSalaNombre = Convert.ToString(selectedRow.Cells["Tipo"].Value);
                string ubicacionNombre = Convert.ToString(selectedRow.Cells["Direccion"].Value);
                string estadoNombre = Convert.ToString(selectedRow.Cells["Estado_tbl_sala"].Value);

                // Buscar y seleccionar el valor en el ComboBox de tipo de sala
                foreach (var item in cb_tipoSala.Items)
                {
                    var keyValuePair = (KeyValuePair<int, string>)item;
                    if (keyValuePair.Value == tipoSalaNombre)
                    {
                        cb_tipoSala.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Buscar y seleccionar el valor en el ComboBox de ubicación
                foreach (var item in cb_ubicacion.Items)
                {
                    var keyValuePair = (KeyValuePair<int, string>)item;
                    if (keyValuePair.Value == ubicacionNombre)
                    {
                        cb_ubicacion.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Asignar el valor del estado
                cb_estado.SelectedItem = estadoNombre;
            }
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los datos sean correctos
            if (!datosCorrectos())
            {
                return;
            }

            int idtiposala = ((KeyValuePair<int, string>)cb_tipoSala.SelectedItem).Key;
            int idubicacion = ((KeyValuePair<int, string>)cb_ubicacion.SelectedItem).Key;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_sala (Numero_Sala, Capacidad, FK_ID_Tipo_Sala, FK_ID_Ubicacion, Estado_tbl_sala) " +
                                   "VALUES (@Numero_Sala, @Capacidad, @FK_ID_Tipo_Sala, @FK_ID_Ubicacion, @Estado_tbl_sala)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Numero_Sala", txtbx_noSala.Text);
                        command.Parameters.AddWithValue("@Capacidad", txtbx_capacidad.Text);
                        command.Parameters.AddWithValue("@FK_ID_Tipo_Sala", idtiposala);
                        command.Parameters.AddWithValue("@FK_ID_Ubicacion", idubicacion);
                        command.Parameters.AddWithValue("@Estado_tbl_sala", cb_estado.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la sala: " + ex.Message);
                }
            }

            llenar_tabla();
        }


        private object ObtenerValorCelda(string nombreColumna)
        {
            if (dgv_sala.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_sala.SelectedRows[0];
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
                if (cb_tipoSala.SelectedItem == null || cb_ubicacion.SelectedItem == null || cb_estado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, actualiza todos los datos");
                    return;
                }

                // Obtener valores del ComboBox
                int tiposala = ((KeyValuePair<int, string>)cb_tipoSala.SelectedItem).Key;
                int ubicacion = ((KeyValuePair<int, string>)cb_ubicacion.SelectedItem).Key;

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
                    comando.Parameters.AddWithValue("@Numero_Sala", txtbx_noSala.Text);
                    comando.Parameters.AddWithValue("@Capacidad", txtbx_capacidad.Text);
                    comando.Parameters.AddWithValue("@FK_ID_Tipo_Sala", tiposala);
                    comando.Parameters.AddWithValue("@FK_ID_Ubicacion", ubicacion);
                    comando.Parameters.AddWithValue("@Estado_tbl_sala", cb_estado.SelectedItem.ToString());
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
            if (dgv_sala.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_sala.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_sala.Rows[selectedRowIndex];
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
            // Verificar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(txtbx_noSala.Text))
            {
                MessageBox.Show("Ingrese el número de sala.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbx_capacidad.Text))
            {
                MessageBox.Show("Ingrese la capacidad.");
                return false;
            }

            // Verificar que se haya seleccionado un tipo de sala
            if (cb_tipoSala.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de sala.");
                return false;
            }

            // Verificar que se haya seleccionado una ubicación
            if (cb_ubicacion.SelectedItem == null)
            {
                MessageBox.Show("Seleccione la ubicación.");
                return false;
            }

            // Verificar que se haya seleccionado un estado
            if (cb_estado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado.");
                return false;
            }

            // Verificar que la capacidad sea un número positivo
            int capacidad;
            if (!int.TryParse(txtbx_capacidad.Text, out capacidad) || capacidad <= 0)
            {
                MessageBox.Show("La capacidad debe ser un número positivo.");
                return false;
            }

            return true;
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            int idtiposala = ((KeyValuePair<int, string>)cb_tipoSala.SelectedItem).Key;
            int idubicacion = ((KeyValuePair<int, string>)cb_ubicacion.SelectedItem).Key;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_sala (Numero_Sala, Capacidad, FK_ID_Tipo_Sala, FK_ID_Ubicacion, Estado_tbl_sala) " +
                                   "VALUES (@Numero_Sala, @Capacidad, @FK_ID_Tipo_Sala, @FK_ID_Ubicacion, @Estado_tbl_sala)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Numero_Sala", txtbx_noSala.Text);
                        command.Parameters.AddWithValue("@Capacidad", txtbx_capacidad.Text);
                        command.Parameters.AddWithValue("@FK_ID_Tipo_Sala", idtiposala);
                        command.Parameters.AddWithValue("@FK_ID_Ubicacion", idubicacion);
                        command.Parameters.AddWithValue("@Estado_tbl_sala", cb_estado.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la sala: " + ex.Message);
                }
            }

            llenar_tabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_tipoSala.SelectedItem == null || cb_ubicacion.SelectedItem == null || cb_estado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, actualiza todos los datos");
                    return;
                }

                // Obtener valores del ComboBox
                int tiposala = ((KeyValuePair<int, string>)cb_tipoSala.SelectedItem).Key;
                int ubicacion = ((KeyValuePair<int, string>)cb_ubicacion.SelectedItem).Key;

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
                    comando.Parameters.AddWithValue("@Numero_Sala", txtbx_noSala.Text);
                    comando.Parameters.AddWithValue("@Capacidad", txtbx_capacidad.Text);
                    comando.Parameters.AddWithValue("@FK_ID_Tipo_Sala", tiposala);
                    comando.Parameters.AddWithValue("@FK_ID_Ubicacion", ubicacion);
                    comando.Parameters.AddWithValue("@Estado_tbl_sala", cb_estado.SelectedItem.ToString());
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_sala.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_sala.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_sala.Rows[selectedRowIndex];
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtbxBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda
            string searchText = txtbxBuscar.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                // Si el texto de búsqueda está vacío, no aplicar filtro
                (dgv_sala.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                return;
            }

            // Crear una lista para las expresiones de filtro
            List<string> filterExpressions = new List<string>();

            // Obtener el DataTable
            DataTable dataTable = dgv_sala.DataSource as DataTable;

            // Recorrer todas las columnas del DataTable
            foreach (DataColumn column in dataTable.Columns)
            {
                // Excluir columnas que no sean de tipo texto
                if (column.DataType == typeof(string))
                {
                    // Agregar expresión de filtro para la columna
                    filterExpressions.Add($"[{column.ColumnName}] LIKE '%{searchText}%'");
                }
            }

            // Unir todas las expresiones de filtro con el operador OR
            string filterExpression = string.Join(" OR ", filterExpressions);

            // Aplicar el filtro
            (dgv_sala.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void UpdateDateTimeLabel()
        {
            // Obtener la fecha y hora actuales
            DateTime now = DateTime.Now;

            // Formatear la fecha y hora como texto
            string dateTimeText = now.ToString("yyyy-MM-dd HH:mm:ss"); // Cambia el formato según tus necesidades

            // Establecer el texto del Label
            lb_fechaSys.Text = dateTimeText;
        }
        private void tmr_timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            int idtiposala = ((KeyValuePair<int, string>)cb_tipoSala.SelectedItem).Key;
            int idubicacion = ((KeyValuePair<int, string>)cb_ubicacion.SelectedItem).Key;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_sala (Numero_Sala, Capacidad, FK_ID_Tipo_Sala, FK_ID_Ubicacion, Estado_tbl_sala) " +
                                   "VALUES (@Numero_Sala, @Capacidad, @FK_ID_Tipo_Sala, @FK_ID_Ubicacion, @Estado_tbl_sala)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Numero_Sala", txtbx_noSala.Text);
                        command.Parameters.AddWithValue("@Capacidad", txtbx_capacidad.Text);
                        command.Parameters.AddWithValue("@FK_ID_Tipo_Sala", idtiposala);
                        command.Parameters.AddWithValue("@FK_ID_Ubicacion", idubicacion);
                        command.Parameters.AddWithValue("@Estado_tbl_sala", cb_estado.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la sala: " + ex.Message);
                }
            }

            llenar_tabla();
        }
    }
}