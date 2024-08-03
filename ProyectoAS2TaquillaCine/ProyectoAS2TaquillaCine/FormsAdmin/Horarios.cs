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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                dataGridView1.DataSource = dataTable;
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
                dataGridView1.DataSource = dataTable;
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
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
            if (cbEstado.Items.Count > 0)
            {
                cbEstado.SelectedIndex = 0;
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
            if (cb_Pelicula.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione una Pelicula");
                return false;
            }

            if (cb_id_Sala.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione una Sala");
                return false;
            }

            if (cbEstado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione un estado");
                return false;
            }
            if (txtNino.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione un precio");
                return false;
            }
            if (txtAdulto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione un precio");
                return false;
            }
            if (txt3ra.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione un precio");
                return false;
            }

            return true;
        }

        //Editar
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Pelicula.SelectedItem == null || cb_id_Sala == null || cbEstado.SelectedItem == null || txt3ra.Text == null || txtNino.Text == null || txtAdulto.Text == null)
                {
                    MessageBox.Show("Por favor, actualiza todos los datos");
                    return;
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
                    command.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Estado_tbl_proyeccion", cbEstado.Text);
                    command.Parameters.AddWithValue("@Hora", dateTimePicker2.Value.ToString("HH:mm:ss"));
                    command.Parameters.AddWithValue("@Precio_Nino", txtNino.Text);
                    command.Parameters.AddWithValue("@Precio_Adulto", txtAdulto.Text);
                    command.Parameters.AddWithValue("@Precio_3ra_Edad", txt3ra.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                txtNino.Text = Convert.ToString(selectedRow.Cells["Precio_Nino"].Value);
                txtAdulto.Text = Convert.ToString(selectedRow.Cells["Precio_Adulto"].Value);
                txt3ra.Text = Convert.ToString(selectedRow.Cells["Precio_3ra_Edad"].Value);

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
                cbEstado.SelectedItem = estado;

                string hora = Convert.ToString(selectedRow.Cells["Hora"].Value);
                DateTime horaDateTime;
                if (DateTime.TryParse(hora, out horaDateTime))
                {
                    dateTimePicker2.Value = horaDateTime;
                }

                string fecha = Convert.ToString(selectedRow.Cells["Fecha"].Value);
                DateTime fechaDateTime;
                if (DateTime.TryParse(fecha, out fechaDateTime))
                {
                    dateTimePicker1.Value = fechaDateTime;
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (!datosCorrectos())
            {
                return;
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
                        command.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Estado_tbl_proyeccion", cbEstado.Text);
                        command.Parameters.AddWithValue("@Hora", dateTimePicker2.Value.ToString("HH:mm:ss"));
                        command.Parameters.AddWithValue("@Precio_Nino", txtNino.Text);
                        command.Parameters.AddWithValue("@Precio_Adulto", txtAdulto.Text);
                        command.Parameters.AddWithValue("@Precio_3ra_Edad", txt3ra.Text);

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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
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
    }

}
