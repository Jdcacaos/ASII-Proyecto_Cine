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
    public partial class Horarios : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public Horarios()
        {
            InitializeComponent();
            dgv_horario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_horario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tmr_timer1 = new Timer();
            tmr_timer1.Interval = 100; // Intervalo en milisegundos (1000 ms = 1 segundo)
            tmr_timer1.Tick += new EventHandler(tmr_timer1_Tick);
            tmr_timer1.Start(); // Iniciar el Timer
            btn_editar.Visible = GlobalSettings.IsAdmin;
            btn_eliminar.Visible = GlobalSettings.IsAdmin;
            gbIngresar.Visible = GlobalSettings.IsAdmin;
        }
        private void Horarios_Load(object sender, EventArgs e)
        {   
            

            LlenarComboBox_estado();
            LlenarComboBox_idSala();
            LlenarComboBox_Pelicula();

            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(connectionString);

                // Consulta SQL actualizada para incluir las uniones
                MySqlCommand comando = new MySqlCommand("SELECT p.ID_Proyeccion, pel.Titulo AS Pelicula, s.Numero_Sala AS Sala, p.Fecha, p.Hora, p.Estado_tbl_proyeccion AS Estado ,p.Precio_Nino , p.Precio_Adulto , p.Precio_3ra_Edad " +
                    "FROM tbl_proyeccion p " +
                    "JOIN tbl_pelicula pel ON p.FK_ID_Pelicula = pel.ID_Pelicula " +
                    "JOIN tbl_sala s ON p.FK_ID_Sala = s.ID_Sala", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                // Asignar el DataTable al DataGridView
                dgv_horario.DataSource = dataTable;
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

                // Consulta SQL actualizada para incluir las uniones
                MySqlCommand comando = new MySqlCommand("SELECT p.ID_Proyeccion, pel.Titulo AS Pelicula, s.Numero_Sala AS Sala, p.Fecha, p.Hora, p.Estado_tbl_proyeccion AS Estado , p.Precio_Nino , p.Precio_Adulto , p.Precio_3ra_Edad " +
                    "FROM tbl_proyeccion p " +
                    "JOIN tbl_pelicula pel ON p.FK_ID_Pelicula = pel.ID_Pelicula " +
                    "JOIN tbl_sala s ON p.FK_ID_Sala = s.ID_Sala", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                // Asignar el DataTable al DataGridView
                dgv_horario.DataSource = dataTable;
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

        private void LlenarComboBox_estado()
        {
            cb_Estado.Items.Clear();
            cb_Estado.Items.Add("Activo");
            cb_Estado.Items.Add("Inactivo");
            if (cb_Estado.Items.Count > 0)
            {
                cb_Estado.SelectedIndex = 0;
            }
        }
        private void LlenarComboBox_idSala()
        {
            string query = "SELECT ID_Sala, Numero_Sala FROM tbl_sala";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cb_id_Sala.Items.Clear();

                            while (reader.Read())
                            {
                                int idsala = reader.GetInt32("ID_Sala");
                                int numerosala = reader.GetInt32("Numero_Sala");

                                cb_id_Sala.Items.Add(new KeyValuePair<int, int>(idsala, numerosala));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cb_id_Sala.DisplayMember = "Value";
            cb_id_Sala.ValueMember = "Key";
            if (cb_id_Sala.Items.Count > 0)
            {
                cb_id_Sala.SelectedIndex = 0;
            }
        }

        private void LlenarComboBox_Pelicula()
        {
            string query = "SELECT ID_Pelicula , Titulo FROM tbl_pelicula;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cb_Pelicula.Items.Clear();

                            while (reader.Read())
                            {
                                int idpelicula = reader.GetInt32("ID_Pelicula");
                                string nompelicula = reader.GetString("Titulo");

                                cb_Pelicula.Items.Add(new KeyValuePair<int,string>(idpelicula, nompelicula));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cb_Pelicula.DisplayMember = "Value";
            cb_Pelicula.ValueMember = "Key";
            if (cb_Pelicula.Items.Count > 0)
            {
                cb_Pelicula.SelectedIndex = 0;
            }
        }

       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Agregar Datos
        private bool datosCorrectos()
        {
            // Verificar que todos los ComboBox tengan una selección
            if (cb_Pelicula.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Pelicula");
                return false;
            }

            if (cb_id_Sala.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una Sala");
                return false;
            }

            if (cb_Estado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado");
                return false;
            }

            // Verificar que todos los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtbx_nino.Text))
            {
                MessageBox.Show("Ingrese el precio para niños");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbx_adulto.Text))
            {
                MessageBox.Show("Ingrese el precio para adultos");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbx_3ra.Text))
            {
                MessageBox.Show("Ingrese el precio para tercera edad");
                return false;
            }

            return true;
        }


        //Editar
        private object ObtenerValorCelda(string nombreColumna)
        {
            if (dgv_horario.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_horario.SelectedRows[0];
                return filaSeleccionada.Cells[nombreColumna].Value;
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.");
                return null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!datosCorrectos())
                {
                    return; // No proceder si los datos no son correctos
                }

                // Obtener valores del ComboBox
                int idPelicula = ((KeyValuePair<int, string>)cb_Pelicula.SelectedItem).Key;
                int idSala = ((KeyValuePair<int, int>)cb_id_Sala.SelectedItem).Key;

                // Obtener valor de la celda
                Object obtener = ObtenerValorCelda("ID_Proyeccion");
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
                    string consulta = "UPDATE tbl_proyeccion SET FK_ID_Pelicula = @FK_ID_Pelicula, FK_ID_Sala = @FK_ID_Sala, Fecha = @Fecha, " +
                           "Estado_tbl_proyeccion = @Estado_tbl_proyeccion, Hora = @Hora , Precio_Nino = @Precio_Nino , Precio_Adulto = @Precio_Adulto , Precio_3ra_Edad = @Precio_3ra_Edad WHERE ID_Proyeccion = @ID_Proyeccion";
                    MySqlCommand command = new MySqlCommand(consulta, connection);
                    command.Parameters.AddWithValue("@FK_ID_Pelicula", idPelicula);
                    command.Parameters.AddWithValue("@FK_ID_Sala", idSala);
                    command.Parameters.AddWithValue("@Fecha", dtp_fecha.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Estado_tbl_proyeccion", cb_Estado.Text);
                    command.Parameters.AddWithValue("@Hora", dtp_hora.Value.ToString("HH:mm:ss"));
                    command.Parameters.AddWithValue("@Precio_Nino", txtbx_nino.Text);
                    command.Parameters.AddWithValue("@Precio_Adulto", txtbx_adulto.Text);
                    command.Parameters.AddWithValue("@Precio_3ra_Edad", txtbx_3ra.Text);
                    command.Parameters.AddWithValue("@ID_Proyeccion", ValorObtenido);

                    int cantidad = command.ExecuteNonQuery();
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
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_horario.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_horario.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_horario.Rows[selectedRowIndex];

                txtbx_nino.Text = Convert.ToString(selectedRow.Cells["Precio_Nino"].Value);
                txtbx_adulto.Text = Convert.ToString(selectedRow.Cells["Precio_Adulto"].Value);
                txtbx_3ra.Text = Convert.ToString(selectedRow.Cells["Precio_3ra_Edad"].Value);

                string pelicula = Convert.ToString(selectedRow.Cells["Pelicula"].Value);
                int sala = Convert.ToInt32(selectedRow.Cells["Sala"].Value);
                string estado = Convert.ToString(selectedRow.Cells["Estado"].Value);
                //string hora = Convert.ToString(selectedRow.Cells["Hora"].Value);

                // Buscar y seleccionar el valor en el ComboBox de tipo de sala
                foreach (var item in cb_Pelicula.Items)
                {
                    var keyValuePair = (KeyValuePair<int, string>)item;
                    if (keyValuePair.Value == pelicula)
                    {
                        cb_Pelicula.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Buscar y seleccionar el valor en el ComboBox de ubicación
                foreach (var item in cb_id_Sala.Items)
                {
                    var keyValuePair = (KeyValuePair<int, int>)item;
                    if (keyValuePair.Value == sala)
                    {
                        cb_id_Sala.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Asignar el valor del estado
                cb_Estado.SelectedItem = estado;

                string hora = Convert.ToString(selectedRow.Cells["Hora"].Value);
                DateTime horaDateTime;
                if (DateTime.TryParse(hora, out horaDateTime))
                {
                    dtp_hora.Value = horaDateTime;
                }

                string fecha = Convert.ToString(selectedRow.Cells["Fecha"].Value);
                DateTime fechaDateTime;
                if (DateTime.TryParse(fecha, out fechaDateTime))
                {
                    dtp_fecha.Value = fechaDateTime;
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (dgv_horario.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_horario.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_horario.Rows[selectedRowIndex];
                int idProyeccion = Convert.ToInt32(selectedRow.Cells["ID_Proyeccion"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_proyeccion WHERE ID_Proyeccion = @ID_Proyeccion";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Proyeccion", idProyeccion);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNino_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtAdulto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt3ra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda
            string searchText = txtbxBuscar.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                // Si el texto de búsqueda está vacío, no aplicar filtro
                (dgv_horario.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                return;
            }

            // Crear una lista para las expresiones de filtro
            List<string> filterExpressions = new List<string>();

            // Obtener el DataTable
            DataTable dataTable = dgv_horario.DataSource as DataTable;

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
            (dgv_horario.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
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
                return; // No proceder si los datos no son correctos
            }

            int idPelicula = ((KeyValuePair<int, string>)cb_Pelicula.SelectedItem).Key;
            int idSala = ((KeyValuePair<int, int>)cb_id_Sala.SelectedItem).Key;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_proyeccion (FK_ID_Pelicula, FK_ID_Sala, Fecha, Estado_tbl_proyeccion, Hora, Precio_Nino, Precio_Adulto , Precio_3ra_Edad) " +
                        "VALUES (@FK_ID_Pelicula, @FK_ID_Sala, @Fecha, @Estado_tbl_proyeccion, @Hora , @Precio_Nino, @Precio_Adulto , @Precio_3ra_Edad)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FK_ID_Pelicula", idPelicula);
                        command.Parameters.AddWithValue("@FK_ID_Sala", idSala);
                        command.Parameters.AddWithValue("@Fecha", dtp_fecha.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Estado_tbl_proyeccion", cb_Estado.Text);
                        command.Parameters.AddWithValue("@Hora", dtp_hora.Value.ToString("HH:mm:ss"));
                        command.Parameters.AddWithValue("@Precio_Nino", txtbx_nino.Text);
                        command.Parameters.AddWithValue("@Precio_Adulto", txtbx_adulto.Text);
                        command.Parameters.AddWithValue("@Precio_3ra_Edad", txtbx_3ra.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la proyeccion: " + ex.Message);
                }
            }

            llenar_tabla();
        }
    }

}
