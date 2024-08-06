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

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            LlenarComboBox();
            try
            {
                conexionDB = new MySqlConnection(connectionString);

                // Consulta SQL actualizada para incluir las uniones
                MySqlCommand comando = new MySqlCommand(
                "SELECT e.*, c.Nombre AS Cargo " +
                "FROM tbl_empleado e " +
                "JOIN tbl_cargo c ON e.FK_ID_Cargo = c.ID_Cargo", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);



                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["FK_ID_Cargo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
            timer1 = new Timer();
            timer1.Interval = 100; // Intervalo en milisegundos (1000 ms = 1 segundo)
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start(); // Iniciar el Timer
            button3.Visible = GlobalSettings.IsAdmin;
            button2.Visible = GlobalSettings.IsAdmin;
            groupBox2.Visible = GlobalSettings.IsAdmin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // Asignar valores a los TextBox, manejando posibles valores nulos
                txtnombre.Text = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                txtApellido.Text = Convert.ToString(selectedRow.Cells["Apellido"].Value);
                txtEmail.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                txtContrasena.Text = Convert.ToString(selectedRow.Cells["Contrasena"].Value);
                txtTelefono.Text = Convert.ToString(selectedRow.Cells["Telefono"].Value);

                // Obtener el valor del cargo y estado
                var cargoId = Convert.ToInt32(selectedRow.Cells["FK_ID_Cargo"].Value);
                var estado = Convert.ToString(selectedRow.Cells["Estado_tbl_empleado"].Value);

                // Buscar y seleccionar el valor en el ComboBox de cargo
                foreach (var item in cbCargo.Items)
                {
                    if (item is KeyValuePair<int, string> keyValuePair && keyValuePair.Key == cargoId)
                    {
                        cbCargo.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Asignar el valor del estado al ComboBox
                cbEstado.SelectedItem = estado;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtApellido.Text=="" || txtContrasena.Text=="" || txtContrasenaVer.Text=="" || txtEmail.Text=="" || txtnombre.Text=="" || txtTelefono == null || cbCargo.Text=="" || cbEstado.Text=="") 
            {
                MessageBox.Show("Hay campos vacios, LLENE TODOS LOS CAMPOS", "Error de llenado de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

                    string query = "INSERT INTO tbl_empleado (nombre, apellido, FK_ID_Cargo, email, telefono, Estado_tbl_empleado, contrasena) " +
                                   "VALUES (@Nombre, @Apellido, @Cargo, @Email, @Telefono, @Estado, @Contrasena)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@Cargo", idCargo);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@Estado", cbEstado.Text);

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
            vaciar();
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }
        public void vaciar() {
            txtApellido.Text = "";
            txtContrasena.Text = "";
            txtContrasenaVer.Text = "";
            txtEmail.Text = "";
            txtnombre.Text="";
            txtTelefono.Text = "";
            cbCargo.Text = "";
            cbEstado.Text = "";
        }


        public void llenar_tabla()
        {
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            LlenarComboBox();
            try
            {
                conexionDB = new MySqlConnection(connectionString);

                // Consulta SQL actualizada para incluir las uniones
                MySqlCommand comando = new MySqlCommand(
                "SELECT e.*, c.Nombre AS Cargo " +
                "FROM tbl_empleado e " +
                "JOIN tbl_cargo c ON e.FK_ID_Cargo = c.ID_Cargo", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);



                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["FK_ID_Cargo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                int idEmpleado = Convert.ToInt32(selectedRow.Cells["ID_Empleado"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_empleado WHERE ID_Empleado = @ID_Empleado";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Empleado", idEmpleado);
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
                    vaciar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas editar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    // Obtener valores del ComboBox
                    int cargo = ((KeyValuePair<int, string>)cbCargo.SelectedItem).Key;

                    // Obtener valor de la celda
                    Object obtener = ObtenerValorCelda("ID_Empleado");
                    if (obtener == null)
                    {
                        MessageBox.Show("No se pudo obtener el valor de ID_Empleado.");
                        return;
                    }

                    int ValorObtenido = Convert.ToInt32(obtener);

                    // Actualizar base de datos
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string consulta = "UPDATE tbl_empleado SET Nombre = @Nombre, Apellido = @Apellido, FK_ID_Cargo = @FK_ID_Cargo, Email = @Email, Telefono = @Telefono, Estado_tbl_empleado = @Estado, Contrasena = @Contrasena WHERE ID_Empleado = @ID_Empleado";
                        MySqlCommand comando = new MySqlCommand(consulta, connection);
                        comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        comando.Parameters.AddWithValue("@FK_ID_Cargo", cargo);
                        comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        comando.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                        comando.Parameters.AddWithValue("@ID_Empleado", ValorObtenido);

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
                        vaciar();
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
                }    }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void UpdateDateTimeLabel()
        {
            // Obtener la fecha y hora actuales
            DateTime now = DateTime.Now;

            // Formatear la fecha y hora como texto
            string dateTimeText = now.ToString("yyyy-MM-dd HH:mm:ss"); // Cambia el formato según tus necesidades

            // Establecer el texto del Label
            Tiempo.Text = dateTimeText;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                UpdateDateTimeLabel();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txtApellido.Text == "" || txtContrasena.Text == "" || txtContrasenaVer.Text == "" || txtEmail.Text == "" || txtnombre.Text == "" || txtTelefono == null || cbCargo.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Hay campos vacios, LLENE TODOS LOS CAMPOS", "Error de llenado de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

                    string query = "INSERT INTO tbl_empleado (nombre, apellido, FK_ID_Cargo, email, telefono, Estado_tbl_empleado, contrasena) " +
                                   "VALUES (@Nombre, @Apellido, @Cargo, @Email, @Telefono, @Estado, @Contrasena)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@Cargo", idCargo);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@Estado", cbEstado.Text);

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
            vaciar();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas editar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    // Obtener valores del ComboBox
                    int cargo = ((KeyValuePair<int, string>)cbCargo.SelectedItem).Key;

                    // Obtener valor de la celda
                    Object obtener = ObtenerValorCelda("ID_Empleado");
                    if (obtener == null)
                    {
                        MessageBox.Show("No se pudo obtener el valor de ID_Empleado.");
                        return;
                    }

                    int ValorObtenido = Convert.ToInt32(obtener);

                    // Actualizar base de datos
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string consulta = "UPDATE tbl_empleado SET Nombre = @Nombre, Apellido = @Apellido, FK_ID_Cargo = @FK_ID_Cargo, Email = @Email, Telefono = @Telefono, Estado_tbl_empleado = @Estado, Contrasena = @Contrasena WHERE ID_Empleado = @ID_Empleado";
                        MySqlCommand comando = new MySqlCommand(consulta, connection);
                        comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                        comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        comando.Parameters.AddWithValue("@FK_ID_Cargo", cargo);
                        comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        comando.Parameters.AddWithValue("@Estado", cbEstado.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                        comando.Parameters.AddWithValue("@ID_Empleado", ValorObtenido);

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
                        vaciar();
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
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                int idEmpleado = Convert.ToInt32(selectedRow.Cells["ID_Empleado"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_empleado WHERE ID_Empleado = @ID_Empleado";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Empleado", idEmpleado);
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
                    vaciar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtbxBuscar2_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda
            string searchText = txtbxBuscar2.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                // Si el texto de búsqueda está vacío, no aplicar filtro
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                return;
            }

            // Crear una lista para las expresiones de filtro
            List<string> filterExpressions = new List<string>();

            // Obtener el DataTable
            DataTable dataTable = dataGridView1.DataSource as DataTable;

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
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

    }
}
