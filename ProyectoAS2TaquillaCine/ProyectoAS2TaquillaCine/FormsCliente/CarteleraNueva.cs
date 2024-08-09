using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAS2TaquillaCine.FormsCliente
{
    public partial class CarteleraNueva : Form
    {
        private int idCliente;
        string connectionString = DatabaseConfig.ConnectionString;
        public CarteleraNueva(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        private void CarteleraNueva_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT ID_Pelicula, Titulo, Duracion, Imagen FROM tbl_pelicula WHERE Estado_tbl_pelicula = 'activo';";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    LlenarComboBoxCiudad();
                    LlenarComboBoxCC();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID_Pelicula"]);
                        string nombre = reader["Titulo"].ToString();
                        byte[] imagen = (byte[])reader["imagen"];

                        PeliculaAPanel(id, nombre, imagen);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }

            }
        }
        private void PeliculaAPanel(int id, string nombre, byte[] fotografia)
        {
            // Crear un nuevo panel para la película
            Panel moviePanel = new Panel();
            moviePanel.Size = new Size(200, 250); // Ajusta el tamaño según necesites
            moviePanel.BorderStyle = BorderStyle.FixedSingle;
            moviePanel.Tag = id; // Guardar el ID de la película en el Tag del panel

            // Crear y configurar el PictureBox para la fotografía
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(200, 200);
            pictureBox.Image = ImagenMetodo(fotografia); // Convertir el byte array a imagen
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Click += new EventHandler(MoviePanel_Click); // Asignar el evento de clic

            // Crear y configurar el Label para el nombre de la película
            Label Pelinombre = new Label();
            Pelinombre.Text = nombre;
            Pelinombre.AutoSize = false;
            Pelinombre.TextAlign = ContentAlignment.MiddleCenter;
            Pelinombre.Dock = DockStyle.Bottom;
            Pelinombre.Height = 50;
            Pelinombre.Click += new EventHandler(MoviePanel_Click); // Asignar el evento de clic

            // Agregar los controles al panel de la película
            moviePanel.Controls.Add(pictureBox);
            moviePanel.Controls.Add(Pelinombre);

            // Agregar evento de clic al panel de la película
            moviePanel.Click += new EventHandler(MoviePanel_Click);

            // Agregar el panel de la película al FlowLayoutPanel
            panel_panelPelicula.Controls.Add(moviePanel); // PeliculaPanel es tu contenedor
        }

        private void MoviePanel_Click(object sender, EventArgs e)
        {
            // Obtener el panel de la película desde el control que disparó el evento
            Control control = (Control)sender;
            while (control != null && !(control is Panel))
            {
                control = control.Parent;
            }

            if (control != null && control is Panel moviePanel)
            {
                int pelicula = (int)moviePanel.Tag;

                // Abrir el formulario de detalles de la película
                InfoPelicula formhorario = new InfoPelicula(pelicula, idCliente);
                this.Hide();
                formhorario.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo obtener la pelicula desada");
            }
        }


        private Image ImagenMetodo(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void LlenarComboBoxCiudad()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT ID_Ubicacion, Ciudad FROM tbl_ubicacion;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cb_depto.DisplayMember = "Ciudad";
                    cb_depto.ValueMember = "ID_Ubicacion";
                    cb_depto.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void LlenarComboBoxCC()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT ID_Ubicacion, Direccion FROM tbl_ubicacion;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cb_direccion.DisplayMember = "Direccion";
                    cb_direccion.ValueMember = "ID_Ubicacion";
                    cb_direccion.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
        private void btn_filtrar_Click_1(object sender, EventArgs e)
        {
            // Verificar si los ComboBox tienen una selección válida
            if (cb_depto.SelectedValue != null && cb_direccion.SelectedValue != null)
            {
                int direccionIdSeleccionada = Convert.ToInt32(cb_direccion.SelectedValue);

                string query = @"
            SELECT p.imagen, p.titulo, p.ID_pelicula
            FROM tbl_pelicula p
            INNER JOIN tbl_proyeccion pr ON p.id_pelicula = pr.FK_ID_Pelicula
            INNER JOIN tbl_sala s ON pr.FK_ID_Sala = s.id_sala
            INNER JOIN tbl_ubicacion u ON s.FK_ID_Ubicacion = u.id_ubicacion
            WHERE u.ID_Ubicacion = @direccionId AND p.Estado_tbl_pelicula = 'Activo'";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@direccionId", direccionIdSeleccionada);

                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        // Limpiar el FlowLayoutPanel antes de agregar nuevos controles
                        panel_panelPelicula.Controls.Clear();

                        while (reader.Read())
                        {
                            string titulo = reader["titulo"].ToString();
                            byte[] imagenData = reader["imagen"] as byte[];
                            int idPelicula = Convert.ToInt32(reader["ID_pelicula"]);

                            // Crear un panel para cada película
                            Panel panel = new Panel
                            {
                                Width = 220, // Ancho del panel
                                Height = 250, // Altura total del panel
                                BorderStyle = BorderStyle.FixedSingle,
                                Padding = new Padding(0), // Quitar el padding para que todo el panel sea clicable
                                Tag = idPelicula,
                                BackColor = Color.LightGray // Color de fondo para hacer el panel más visible
                            };

                            // Crear un PictureBox para la imagen
                            PictureBox pictureBox = new PictureBox
                            {
                                Image = imagenData != null ? Image.FromStream(new MemoryStream(imagenData)) : null,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Dock = DockStyle.Top,
                                Height = 180, // Ajustar altura de la imagen
                                BorderStyle = BorderStyle.None // Asegurarse de que no tenga border style
                            };

                            // Crear un Label para el título
                            Label label = new Label
                            {
                                Text = titulo,
                                Dock = DockStyle.Bottom,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Height = 40, // Altura del label
                                BorderStyle = BorderStyle.None // Asegurarse de que no tenga border style
                            };

                            // Añadir controles al panel
                            panel.Controls.Add(pictureBox);
                            panel.Controls.Add(label);

                            // Añadir el manejador de eventos de clic al panel
                            panel.Click += (s, args) =>
                            {
                                int id = (int)panel.Tag;
                                this.Hide();
                                InfoPelicula form = new InfoPelicula(id, idCliente);
                                form.ShowDialog();
                                this.Close();
                            };

                            // Añadir el panel al FlowLayoutPanel
                            panel_panelPelicula.Controls.Add(panel);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una ciudad y una dirección.");
            }
        }

        private void btnQF_Click_1(object sender, EventArgs e)
        {
            panel_panelPelicula.Controls.Clear();
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT ID_Pelicula, Titulo, Duracion, Imagen FROM tbl_pelicula WHERE Estado_tbl_pelicula = 'activo';";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    LlenarComboBoxCiudad();
                    LlenarComboBoxCC();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID_Pelicula"]);
                        string nombre = reader["Titulo"].ToString();
                        byte[] imagen = (byte[])reader["imagen"];

                        PeliculaAPanel(id, nombre, imagen);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsGlobales.Menu newMenu = new FormsGlobales.Menu();
            newMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "¿Estás seguro de que deseas cerrar sesión?",
       "Confirmar Cierre de Sesión",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Si el usuario confirma, cerrar sesión
                FormsGlobales.Menu newMenu = new FormsGlobales.Menu();
                newMenu.Show();

                // Cerrar el formulario actual
                this.Hide();
            }
        }

        private void cbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
