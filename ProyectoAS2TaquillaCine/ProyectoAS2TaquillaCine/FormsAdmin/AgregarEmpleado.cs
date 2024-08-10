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
            var emailPlaceholder = new FormsCliente.PlaceholderManager(
              cb_cargo,
              "Añada un cargo",
              Color.Gray,
              Color.White
          );

            var passPlaceholder = new FormsCliente.PlaceholderManager(
                cb_estadoEmp,
                "ingrese un estado",
                Color.Gray,
                Color.White
            );
            cb_cargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estadoEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estadoEmp.SelectedItem = "Activo";
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                dgv_empleados.DataSource = dataTable;

                dgv_empleados.DataBindingComplete += (s, args) =>
                {
                    if (dgv_empleados.Columns["Contrasena"] != null)
                    {
                        dgv_empleados.Columns["Contrasena"].Visible = false;
                    }
                    if (dgv_empleados.Columns["FK_ID_Cargo"] != null)
                    {
                        dgv_empleados.Columns["FK_ID_Cargo"].Visible = false;
                    }
                };
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
                            cb_cargo.Items.Clear();

                            while (reader.Read())
                            {
                                int idCargo = reader.GetInt32("ID_Cargo");
                                string nombre = reader.GetString("Nombre");

                                cb_cargo.Items.Add(new KeyValuePair<int, string>(idCargo, nombre));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cb_cargo.DisplayMember = "Value";
            cb_cargo.ValueMember = "Key";
        }




        public AgregarEmpleado()
        {
            InitializeComponent();
            tmr_timer1 = new Timer();
            tmr_timer1.Interval = 100;
            tmr_timer1.Tick += new EventHandler(timer1_Tick);
            tmr_timer1.Start(); 
            btn_editar.Visible = GlobalSettings.IsAdmin;
            btn_eliminar.Visible = GlobalSettings.IsAdmin;
            gbIngresar.Visible = GlobalSettings.IsAdmin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_empleados.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_empleados.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_empleados.Rows[selectedRowIndex];

                txtbx_nombre.Text = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                txtbx_apellido.Text = Convert.ToString(selectedRow.Cells["Apellido"].Value);
                txtbx_email.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
               
                txtbx_telefono.Text = Convert.ToString(selectedRow.Cells["Telefono"].Value);

                var cargoId = Convert.ToInt32(selectedRow.Cells["FK_ID_Cargo"].Value);
                var estado = Convert.ToString(selectedRow.Cells["Estado_tbl_empleado"].Value);

                foreach (var item in cb_cargo.Items)
                {
                    if (item is KeyValuePair<int, string> keyValuePair && keyValuePair.Key == cargoId)
                    {
                        cb_cargo.SelectedItem = keyValuePair;
                        break;
                    }
                }

                cb_estadoEmp.SelectedItem = estado;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtbx_apellido.Text == "" || txtbx_contrasena.Text == "" || txtbx_confContra.Text == "" || txtbx_email.Text == "" || txtbx_nombre.Text == "" || txtbx_telefono == null || cb_cargo.Text == "" || cb_estadoEmp.Text == "")
            {
                MessageBox.Show("Hay campos vacios, LLENE TODOS LOS CAMPOS", "Error de llenado de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbx_contrasena.Text != txtbx_confContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idCargo = ((KeyValuePair<int, string>)cb_cargo.SelectedItem).Key;
            string contrasenaEncriptada = BCrypt.Net.BCrypt.HashPassword(txtbx_contrasena.Text);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_empleado (nombre, apellido, FK_ID_Cargo, email, telefono, Estado_tbl_empleado, contrasena) " +
                                   "VALUES (@Nombre, @Apellido, @Cargo, @Email, @Telefono, @Estado, @Contrasena)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtbx_apellido.Text);
                        command.Parameters.AddWithValue("@Cargo", idCargo);
                        command.Parameters.AddWithValue("@Email", txtbx_email.Text);
                        command.Parameters.AddWithValue("@Contrasena", contrasenaEncriptada);
                        command.Parameters.AddWithValue("@Telefono", txtbx_telefono.Text);
                        command.Parameters.AddWithValue("@Estado", cb_estadoEmp.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el empleado: " + ex.Message);
                }
            }
            PllenarTabla();
            Pvaciar();
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }
        public void Pvaciar()
        {
            txtbx_apellido.Text = "";
            txtbx_contrasena.Text = "";
            txtbx_confContra.Text = "";
            txtbx_email.Text = "";
            txtbx_nombre.Text = "";
            txtbx_telefono.Text = "";
            cb_cargo.Text = "";
            cb_estadoEmp.Text = "";
        }


        public void PllenarTabla()
        {
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            LlenarComboBox();
            try
            {
                conexionDB = new MySqlConnection(connectionString);

                MySqlCommand comando = new MySqlCommand(
                "SELECT e.*, c.Nombre AS Cargo " +
                "FROM tbl_empleado e " +
                "JOIN tbl_cargo c ON e.FK_ID_Cargo = c.ID_Cargo", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

               
                dgv_empleados.DataSource = dataTable;
                
                if (dgv_empleados.Columns["Contrasena"] != null)
                {
                    dgv_empleados.Columns["Contrasena"].Visible = false;
                }

                if (dgv_empleados.Columns["FK_ID_Cargo"] != null)
                {
                    dgv_empleados.Columns["FK_ID_Cargo"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_empleados.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_empleados.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_empleados.Rows[selectedRowIndex];
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

                    PllenarTabla();
                    Pvaciar();
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
            if (dgv_empleados.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_empleados.SelectedRows[0];
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

                    int cargo = ((KeyValuePair<int, string>)cb_cargo.SelectedItem).Key;

                    Object obtener = ObtenerValorCelda("ID_Empleado");
                    if (obtener == null)
                    {
                        MessageBox.Show("No se pudo obtener el valor de ID_Empleado.");
                        return;
                    }

                    int ValorObtenido = Convert.ToInt32(obtener);

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string consulta = "UPDATE tbl_empleado SET Nombre = @Nombre, Apellido = @Apellido, FK_ID_Cargo = @FK_ID_Cargo, Email = @Email, Telefono = @Telefono, Estado_tbl_empleado = @Estado, Contrasena = @Contrasena WHERE ID_Empleado = @ID_Empleado";
                        MySqlCommand comando = new MySqlCommand(consulta, connection);
                        comando.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                        comando.Parameters.AddWithValue("@Apellido", txtbx_apellido.Text);
                        comando.Parameters.AddWithValue("@FK_ID_Cargo", cargo);
                        comando.Parameters.AddWithValue("@Email", txtbx_email.Text);
                        comando.Parameters.AddWithValue("@Telefono", txtbx_telefono.Text);
                        comando.Parameters.AddWithValue("@Estado", cb_estadoEmp.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@Contrasena", txtbx_contrasena.Text);
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
                        PllenarTabla();
                        Pvaciar();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void UpdateDateTimeLabel()
        {
            DateTime now = DateTime.Now;

            string dateTimeText = now.ToString("yyyy-MM-dd HH:mm:ss"); 

            lb_tiempoSys.Text = dateTimeText;
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

            if (txtbx_apellido.Text == "" || txtbx_contrasena.Text == "" || txtbx_confContra.Text == "" || txtbx_email.Text == "" || txtbx_nombre.Text == "" || txtbx_telefono == null || cb_cargo.Text == "" || cb_estadoEmp.Text == "")
            {
                MessageBox.Show("Hay campos vacios, LLENE TODOS LOS CAMPOS", "Error de llenado de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbx_contrasena.Text != txtbx_confContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idCargo = ((KeyValuePair<int, string>)cb_cargo.SelectedItem).Key;
            string contrasenaEncriptada = BCrypt.Net.BCrypt.HashPassword(txtbx_contrasena.Text);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_empleado (nombre, apellido, FK_ID_Cargo, email, telefono, Estado_tbl_empleado, contrasena) " +
                                   "VALUES (@Nombre, @Apellido, @Cargo, @Email, @Telefono, @Estado, @Contrasena)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtbx_apellido.Text);
                        command.Parameters.AddWithValue("@Cargo", idCargo);
                        command.Parameters.AddWithValue("@Email", txtbx_email.Text);
                        command.Parameters.AddWithValue("@Contrasena", contrasenaEncriptada);
                        command.Parameters.AddWithValue("@Telefono", txtbx_telefono.Text);
                        command.Parameters.AddWithValue("@Estado", cb_estadoEmp.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el empleado: " + ex.Message);
                }
            }
            PllenarTabla();
            Pvaciar();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtbx_apellido.Text == "" || txtbx_contrasena.Text == "" || txtbx_confContra.Text == "" || txtbx_email.Text == "" || txtbx_nombre.Text == "" || txtbx_telefono == null || cb_cargo.Text == "" || cb_estadoEmp.Text == "")
            {
                MessageBox.Show("Hay campos vacios, LLENE TODOS LOS CAMPOS", "Error de llenado de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtbx_contrasena.Text != txtbx_confContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idCargo = ((KeyValuePair<int, string>)cb_cargo.SelectedItem).Key;
            string contrasenaEncriptada = BCrypt.Net.BCrypt.HashPassword(txtbx_contrasena.Text);

            int idEmpleado = Convert.ToInt32(dgv_empleados.SelectedRows[0].Cells["ID_Empleado"].Value);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tbl_empleado SET nombre = @Nombre, apellido = @Apellido, FK_ID_Cargo = @Cargo, email = @Email, telefono = @Telefono, Estado_tbl_empleado = @Estado, contrasena = @Contrasena WHERE ID_Empleado = @ID_Empleado";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtbx_apellido.Text);
                        command.Parameters.AddWithValue("@Cargo", idCargo);
                        command.Parameters.AddWithValue("@Email", txtbx_email.Text);
                        command.Parameters.AddWithValue("@Contrasena", contrasenaEncriptada);
                        command.Parameters.AddWithValue("@Telefono", txtbx_telefono.Text);
                        command.Parameters.AddWithValue("@Estado", cb_estadoEmp.Text);
                        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Empleado actualizado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
                }
            }

            PllenarTabla();
            Pvaciar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dgv_empleados.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_empleados.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_empleados.Rows[selectedRowIndex];
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

                    PllenarTabla();
                    Pvaciar();
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

        private void txtbxBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtbx_buscar.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                (dgv_empleados.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                return;
            }

            List<string> filterExpressions = new List<string>();

            DataTable dataTable = dgv_empleados.DataSource as DataTable;

            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.DataType == typeof(string))
                {
                    filterExpressions.Add($"[{column.ColumnName}] LIKE '%{searchText}%'");
                }
            }

            string filterExpression = string.Join(" OR ", filterExpressions);

            (dgv_empleados.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txtbx_apellido.Text == "" || txtbx_contrasena.Text == "" || txtbx_confContra.Text == "" || txtbx_email.Text == "" || txtbx_nombre.Text == "" || txtbx_telefono == null || cb_cargo.Text == "" || cb_estadoEmp.Text == "")
            {
                MessageBox.Show("Hay campos vacios, LLENE TODOS LOS CAMPOS", "Error de llenado de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtbx_contrasena.Text != txtbx_confContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de confirmación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idCargo = ((KeyValuePair<int, string>)cb_cargo.SelectedItem).Key;
            string contrasenaEncriptada = BCrypt.Net.BCrypt.HashPassword(txtbx_contrasena.Text);
            

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkEmailQuery = "SELECT COUNT(*) FROM tbl_empleado WHERE Email = @Email";
                    using (MySqlCommand checkEmailCommand = new MySqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCommand.Parameters.AddWithValue("@Email", txtbx_email.Text);

                        int emailCount = Convert.ToInt32(checkEmailCommand.ExecuteScalar());

                        if (emailCount > 0)
                        {
                            MessageBox.Show("El correo ya está registrado. Por favor, use otro correo.", "Error de duplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = "INSERT INTO tbl_empleado (nombre, apellido, FK_ID_Cargo, email, telefono, Estado_tbl_empleado, contrasena) " +
                                   "VALUES (@Nombre, @Apellido, @Cargo, @Email, @Telefono, @Estado, @Contrasena)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtbx_apellido.Text);
                        command.Parameters.AddWithValue("@Cargo", idCargo);
                        command.Parameters.AddWithValue("@Email", txtbx_email.Text);
                        command.Parameters.AddWithValue("@Contrasena", contrasenaEncriptada);
                        command.Parameters.AddWithValue("@Telefono", txtbx_telefono.Text);
                        command.Parameters.AddWithValue("@Estado", cb_estadoEmp.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el empleado: " + ex.Message);
                }
            }
            PllenarTabla();
            Pvaciar();
        }

        private void panel_panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbx_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//CODIGO CREADO POR BRAYAN HERNANDEZ
