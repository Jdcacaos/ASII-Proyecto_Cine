using System;
using System.IO;
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
using System.Drawing.Imaging;
using System.Text.RegularExpressions;


namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    public partial class AgregarPeliculas : Form
    {
        string connectionString = DatabaseConfig.ConnectionString; // Debe ser una cadena de conexión MySQL

        public AgregarPeliculas()
        {
            InitializeComponent();
            dgv_peliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tmr_timer1 = new Timer();
            tmr_timer1.Interval = 100; // Intervalo en milisegundos (1000 ms = 1 segundo)
            tmr_timer1.Tick += new EventHandler(tmr_timer1_Tick);
            tmr_timer1.Start(); // Iniciar el Timer
            btn_editar.Visible = GlobalSettings.IsAdmin;
            btn_eliminar.Visible = GlobalSettings.IsAdmin;
            gpb_ingresar.Visible = GlobalSettings.IsAdmin;
        }


        private void Peliculas_Load(object sender, EventArgs e)
        {
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            PllenarComboBox_clasificacion();
            PllenarComboBox_proveedor();
            PllenarComboBox_estado();

            try
            {
                conexionDB = new MySqlConnection(connectionString);

                // Consulta SQL actualizada para incluir las uniones
                MySqlCommand comando = new MySqlCommand(
                    " SELECT p.*, c.Nombre AS Clasificacion, pr.Nombre AS Proveedor " +
                    "FROM tbl_pelicula p " +
                    "JOIN tbl_clasificacion c ON p.FK_ID_Clasificacion = c.ID_Clasificacion " +
                    "JOIN tbl_proveedor_pelicula pr ON p.FK_ID_Proveedor = pr.ID_Proveedor", conexionDB);

                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                // Asignar el DataTable al DataGridView
                dgv_peliculas.DataSource = dataTable;

                // Opcional: Ocultar las columnas de ID si ya no se necesitan
                dgv_peliculas.Columns["FK_ID_Clasificacion"].Visible = false;
                dgv_peliculas.Columns["FK_ID_Proveedor"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PllenarComboBox_clasificacion()
        {
            string query = "SELECT ID_Clasificacion, Nombre FROM tbl_clasificacion";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cb_clasificacion.Items.Clear();

                            while (reader.Read())
                            {
                                int idclasificacion = reader.GetInt32("ID_Clasificacion");
                                string nombre = reader.GetString("Nombre");

                                cb_clasificacion.Items.Add(new KeyValuePair<int, string>(idclasificacion, nombre));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cb_clasificacion.DisplayMember = "Value";
            cb_clasificacion.ValueMember = "Key";
            if (cb_clasificacion.Items.Count > 0)
            {
                cb_clasificacion.SelectedIndex = 0;
            }
        }

        private void PllenarComboBox_proveedor()
        {
            string query = "SELECT ID_Proveedor, Nombre FROM tbl_proveedor_pelicula";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cb_productor.Items.Clear();

                            while (reader.Read())
                            {
                                int idproveedor = reader.GetInt32("ID_Proveedor");
                                string nombre = reader.GetString("Nombre");

                                cb_productor.Items.Add(new KeyValuePair<int, string>(idproveedor, nombre));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

            cb_productor.DisplayMember = "Value";
            cb_productor.ValueMember = "Key";
            if (cb_productor.Items.Count > 0)
            {
                cb_productor.SelectedIndex = 0;
            }
        }

        private void PllenarComboBox_estado()
        {
            cb_estado.Items.Clear();
            cb_estado.Items.Add("Activo");
            cb_estado.Items.Add("Inactivo");
            if (cb_estado.Items.Count > 0)
            {
                cb_estado.SelectedIndex = 0;
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

                MySqlCommand comando = new MySqlCommand(
                    "SELECT p.*, c.Nombre AS Clasificacion, pr.Nombre AS Proveedor " +
                    "FROM tbl_pelicula p " +
                    "JOIN tbl_clasificacion c ON p.FK_ID_Clasificacion = c.ID_Clasificacion " +
                    "JOIN tbl_proveedor_pelicula pr ON p.FK_ID_Proveedor = pr.ID_Proveedor", conexionDB);

                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                dgv_peliculas.DataSource = dataTable;

                dgv_peliculas.Columns["FK_ID_Clasificacion"].Visible = false;
                dgv_peliculas.Columns["FK_ID_Proveedor"].Visible = false;

                // Convertir los bytes de imagen a una imagen y asignarla a la celda
                foreach (DataGridViewRow row in dgv_peliculas.Rows)
                {
                    if (row.Cells["Imagen"] != null && row.Cells["Imagen"].Value != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])row.Cells["Imagen"].Value;
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            row.Cells["Imagen"].Value = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_peliculas.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_peliculas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_peliculas.Rows[selectedRowIndex];

                txtbx_titulo.Text = Convert.ToString(selectedRow.Cells["Titulo"].Value);
                txtbx_genero.Text = Convert.ToString(selectedRow.Cells["Genero"].Value);
                txtbx_duracion.Text = Convert.ToString(selectedRow.Cells["Duracion"].Value);
                txtbx_sinopsis.Text = Convert.ToString(selectedRow.Cells["Sinopsis"].Value);

                string clasificacionnombre = Convert.ToString(selectedRow.Cells["Clasificacion"].Value);
                string proveedornombre = Convert.ToString(selectedRow.Cells["Proveedor"].Value);
                string estadoNombre = Convert.ToString(selectedRow.Cells["Estado_tbl_pelicula"].Value);

                // Buscar y seleccionar el valor en el ComboBox de clasificacion
                foreach (var item in cb_clasificacion.Items)
                {
                    var keyValuePair = (KeyValuePair<int, string>)item;
                    if (keyValuePair.Value == clasificacionnombre)
                    {
                        cb_clasificacion.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Buscar y seleccionar el valor en el ComboBox de proveedor
                foreach (var item in cb_productor.Items)
                {
                    var keyValuePair = (KeyValuePair<int, string>)item;
                    if (keyValuePair.Value == proveedornombre)
                    {
                        cb_productor.SelectedItem = keyValuePair;
                        break;
                    }
                }

                // Asignar el valor del estado
                cb_estado.SelectedItem = estadoNombre;

                // Mostrar la imagen en el PictureBox
                if (selectedRow.Cells["Imagen"].Value != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])selectedRow.Cells["Imagen"].Value;
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        picbx_imagenPelicula.Image = Image.FromStream(ms);
                        picbx_imagenPelicula.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar la imagen al PictureBox
                    }
                }
                else
                {
                    picbx_imagenPelicula.Image = null; // Si no hay imagen, limpiar el PictureBox
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       



        private object ObtenerValorCelda(string nombreColumna)
        {
            if (dgv_peliculas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_peliculas.SelectedRows[0];
                return filaSeleccionada.Cells[nombreColumna].Value;
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.");
                return null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }

        private bool datosCorrectos()
        {
            if (txtbx_titulo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el título.");
                return false;
            }

            if (txtbx_genero.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el género.");
                return false;
            }

            if (txtbx_sinopsis.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la sinopsis.");
                return false;
            }

            if (cb_clasificacion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione la clasificación.");
                return false;
            }

            if (cb_productor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione el proveedor.");
                return false;
            }

            if (cb_estado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione un estado.");
                return false;
            }

            if (string.IsNullOrEmpty(txtbx_imagen.Text))
            {
                MessageBox.Show("Debe seleccionar una imagen.");
                return false;
            }

            // Validar URL del tráiler
            if (string.IsNullOrEmpty(txtbx_trailer.Text) || !EsUrlDeYouTube(txtbx_trailer.Text))
            {
                MessageBox.Show("Debe ingresar una URL de tráiler válida de YouTube.");
                return false;
            }

            return true;
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen en el PictureBox
                    picbx_imagenPelicula.Image = Image.FromFile(openFileDialog.FileName);
                    // Guardar la ruta de la imagen en un TextBox o variable
                    txtbx_imagen.Text = openFileDialog.FileName;
                }
            }
        }

        private Image RedimensionarImagen(Image imagenOriginal, int anchoDeseado, int altoDeseado)
        {
            // Crear un nuevo objeto Bitmap con las dimensiones deseadas
            Bitmap imagenRedimensionada = new Bitmap(anchoDeseado, altoDeseado);

            // Crear un objeto Graphics para dibujar la imagen redimensionada
            using (Graphics g = Graphics.FromImage(imagenRedimensionada))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imagenOriginal, 0, 0, anchoDeseado, altoDeseado);
            }

            return imagenRedimensionada;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            int idclasificacion = ((KeyValuePair<int, string>)cb_clasificacion.SelectedItem).Key;
            int idproveedor = ((KeyValuePair<int, string>)cb_productor.SelectedItem).Key;

            int duracion;
            if (!int.TryParse(txtbx_duracion.Text, out duracion))
            {
                MessageBox.Show("Duración no válida.");
                return;
            }

            byte[] imagenBytes = null;
            if (!string.IsNullOrEmpty(txtbx_imagen.Text))
            {
                try
                {
                    using (FileStream fs = new FileStream(txtbx_imagen.Text, FileMode.Open, FileAccess.Read))
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        Image imagenOriginal = Image.FromStream(fs);

                        // Redimensionar la imagen antes de convertirla a bytes
                        Image imagenRedimensionada = RedimensionarImagen(imagenOriginal, 200, 200); // Ajusta el tamaño deseado aquí

                        using (MemoryStream ms = new MemoryStream())
                        {
                            imagenRedimensionada.Save(ms, ImageFormat.Jpeg); // Usa el formato adecuado
                            imagenBytes = ms.ToArray();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer la imagen: " + ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una imagen.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_pelicula (Titulo, Genero, Duracion, FK_ID_Clasificacion, Imagen, Sinopsis, FK_ID_Proveedor, Estado_tbl_pelicula, trailer_url) " +
                                   "VALUES (@Titulo, @Genero, @Duracion, @FK_ID_Clasificacion, @Imagen, @Sinopsis, @FK_ID_Proveedor, @Estado_tbl_pelicula, @Trailer_url)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", txtbx_titulo.Text);
                        command.Parameters.AddWithValue("@Genero", txtbx_genero.Text);
                        command.Parameters.AddWithValue("@Duracion", duracion);
                        command.Parameters.AddWithValue("@FK_ID_Clasificacion", idclasificacion);
                        command.Parameters.AddWithValue("@Imagen", imagenBytes);
                        command.Parameters.AddWithValue("@Sinopsis", txtbx_sinopsis.Text);
                        command.Parameters.AddWithValue("@FK_ID_Proveedor", idproveedor);
                        command.Parameters.AddWithValue("@Estado_tbl_pelicula", cb_estado.Text);
                        command.Parameters.AddWithValue("@Trailer_url", txtbx_trailer.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la película: " + ex.Message);
                }
            }

            llenar_tabla();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_clasificacion.SelectedItem == null || cb_productor.SelectedItem == null || cb_estado.SelectedItem == null || string.IsNullOrEmpty(txtbx_trailer.Text) || string.IsNullOrEmpty(txtbx_imagen.Text))
                {
                    MessageBox.Show("Por favor, actualiza todos los datos.");
                    return;
                }

                int idclasificacion = ((KeyValuePair<int, string>)cb_clasificacion.SelectedItem).Key;
                int idproveedor = ((KeyValuePair<int, string>)cb_productor.SelectedItem).Key;

                Object obtener = ObtenerValorCelda("ID_Pelicula");
                if (obtener == null)
                {
                    MessageBox.Show("No se pudo obtener el valor de ID_Pelicula.");
                    return;
                }

                int ValorObtenido = Convert.ToInt32(obtener);
                string imagenPath = txtbx_imagen.Text;

                byte[] imagenBytes = null;
                if (!string.IsNullOrEmpty(imagenPath))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(imagenPath, FileMode.Open, FileAccess.Read))
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            Image imagenOriginal = Image.FromStream(fs);

                            // Redimensionar la imagen antes de convertirla a bytes
                            Image imagenRedimensionada = RedimensionarImagen(imagenOriginal, 200, 200); // Ajusta el tamaño deseado aquí

                            using (MemoryStream ms = new MemoryStream())
                            {
                                imagenRedimensionada.Save(ms, ImageFormat.Jpeg); // Usa el formato adecuado
                                imagenBytes = ms.ToArray();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer la imagen: " + ex.Message);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una imagen.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string consulta = "UPDATE tbl_pelicula SET Titulo = @Titulo, Genero = @Genero, Duracion = @Duracion, FK_ID_Clasificacion = @FK_ID_Clasificacion, Imagen = @Imagen, Sinopsis = @Sinopsis, FK_ID_Proveedor = @FK_ID_Proveedor, Estado_tbl_pelicula = @Estado_tbl_pelicula, trailer_url = @trailer_url WHERE ID_Pelicula = @ID_Pelicula";
                    MySqlCommand comando = new MySqlCommand(consulta, connection);

                    comando.Parameters.AddWithValue("@Titulo", txtbx_titulo.Text);
                    comando.Parameters.AddWithValue("@Genero", txtbx_genero.Text);
                    comando.Parameters.AddWithValue("@Duracion", txtbx_duracion.Text);
                    comando.Parameters.AddWithValue("@FK_ID_Clasificacion", idclasificacion);
                    comando.Parameters.AddWithValue("@Imagen", imagenBytes);
                    comando.Parameters.AddWithValue("@Sinopsis", txtbx_sinopsis.Text);
                    comando.Parameters.AddWithValue("@FK_ID_Proveedor", idproveedor);
                    comando.Parameters.AddWithValue("@Estado_tbl_pelicula", cb_estado.Text);
                    comando.Parameters.AddWithValue("@ID_Pelicula", ValorObtenido);
                    comando.Parameters.AddWithValue("@trailer_url", txtbx_trailer.Text);

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

        private bool EsUrlDeYouTube(string url)
        {
            string patron = @"^(https?:\/\/)?(www\.)?(youtube\.com\/watch\?v=|youtu\.be\/)[a-zA-Z0-9_-]{11}$";
            Regex regex = new Regex(patron, RegexOptions.IgnoreCase);
            return regex.IsMatch(url);
        }


        private void button6_Click(object sender, EventArgs e)
        {

            if (dgv_peliculas.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_peliculas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_peliculas.Rows[selectedRowIndex];
                int idPelicula = Convert.ToInt32(selectedRow.Cells["ID_Pelicula"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_pelicula WHERE ID_Pelicula = @ID_Pelicula";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Pelicula", idPelicula);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtgenero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

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

        private void txtbxBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda
            string searchText = txbx_buscar.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                // Si el texto de búsqueda está vacío, no aplicar filtro
                (dgv_peliculas.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                return;
            }

            // Crear una lista para las expresiones de filtro
            List<string> filterExpressions = new List<string>();

            // Obtener el DataTable
            DataTable dataTable = dgv_peliculas.DataSource as DataTable;

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
            (dgv_peliculas.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen en el PictureBox
                    picbx_imagenPelicula.Image = Image.FromFile(openFileDialog.FileName);
                    // Guardar la ruta de la imagen en un TextBox o variable
                    txtbx_imagen.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            int idclasificacion = ((KeyValuePair<int, string>)cb_clasificacion.SelectedItem).Key;
            int idproveedor = ((KeyValuePair<int, string>)cb_productor.SelectedItem).Key;

            int duracion;
            if (!int.TryParse(txtbx_duracion.Text, out duracion))
            {
                MessageBox.Show("Duración no válida.");
                return;
            }

            byte[] imagenBytes = null;
            if (!string.IsNullOrEmpty(txtbx_imagen.Text))
            {
                try
                {
                    using (FileStream fs = new FileStream(txtbx_imagen.Text, FileMode.Open, FileAccess.Read))
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        Image imagenOriginal = Image.FromStream(fs);

                        // Redimensionar la imagen antes de convertirla a bytes
                        Image imagenRedimensionada = RedimensionarImagen(imagenOriginal, 200, 200); // Ajusta el tamaño deseado aquí

                        using (MemoryStream ms = new MemoryStream())
                        {
                            imagenRedimensionada.Save(ms, ImageFormat.Jpeg); // Usa el formato adecuado
                            imagenBytes = ms.ToArray();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer la imagen: " + ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una imagen.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_pelicula (Titulo, Genero, Duracion, FK_ID_Clasificacion, Imagen, Sinopsis, FK_ID_Proveedor, Estado_tbl_pelicula, trailer_url) " +
                                   "VALUES (@Titulo, @Genero, @Duracion, @FK_ID_Clasificacion, @Imagen, @Sinopsis, @FK_ID_Proveedor, @Estado_tbl_pelicula, @Trailer_url)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", txtbx_titulo.Text);
                        command.Parameters.AddWithValue("@Genero", txtbx_genero.Text);
                        command.Parameters.AddWithValue("@Duracion", duracion);
                        command.Parameters.AddWithValue("@FK_ID_Clasificacion", idclasificacion);
                        command.Parameters.AddWithValue("@Imagen", imagenBytes);
                        command.Parameters.AddWithValue("@Sinopsis", txtbx_sinopsis.Text);
                        command.Parameters.AddWithValue("@FK_ID_Proveedor", idproveedor);
                        command.Parameters.AddWithValue("@Estado_tbl_pelicula", cb_estado.Text);
                        command.Parameters.AddWithValue("@Trailer_url", txtbx_trailer.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la película: " + ex.Message);
                }
            }

            llenar_tabla();

        }
    }
}

