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
            cb_depto.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_direccion.DropDownStyle = ComboBoxStyle.DropDownList;
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
            Panel moviePanel = new Panel();
            moviePanel.Size = new Size(200, 250); 
            moviePanel.BorderStyle = BorderStyle.FixedSingle;
            moviePanel.Tag = id; 

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(200, 200);
            pictureBox.Image = ImagenMetodo(fotografia); 
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Click += new EventHandler(MoviePanel_Click); 

            Label Pelinombre = new Label();
            Pelinombre.Text = nombre;
            Pelinombre.AutoSize = false;
            Pelinombre.TextAlign = ContentAlignment.MiddleCenter;
            Pelinombre.Dock = DockStyle.Bottom;
            Pelinombre.Height = 50;
            Pelinombre.Click += new EventHandler(MoviePanel_Click); 

            moviePanel.Controls.Add(pictureBox);
            moviePanel.Controls.Add(Pelinombre);

            moviePanel.Click += new EventHandler(MoviePanel_Click);

            panel_panelPelicula.Controls.Add(moviePanel);
        }

        private void MoviePanel_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            while (control != null && !(control is Panel))
            {
                control = control.Parent;
            }

            if (control != null && control is Panel moviePanel)
            {
                int pelicula = (int)moviePanel.Tag;

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

                        panel_panelPelicula.Controls.Clear();

                        while (reader.Read())
                        {
                            string titulo = reader["titulo"].ToString();
                            byte[] imagenData = reader["imagen"] as byte[];
                            int idPelicula = Convert.ToInt32(reader["ID_pelicula"]);

                            Panel panel = new Panel
                            {
                                Width = 220, // Ancho del panel
                                Height = 250, // Altura total del panel
                                BorderStyle = BorderStyle.FixedSingle,
                                Padding = new Padding(0), // Quitar el padding para que todo el panel sea clicable
                                Tag = idPelicula,
                                BackColor = Color.LightGray // Color de fondo para hacer el panel más visible
                            };

                            PictureBox pictureBox = new PictureBox
                            {
                                Image = imagenData != null ? Image.FromStream(new MemoryStream(imagenData)) : null,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Dock = DockStyle.Top,
                                Height = 180, // Ajustar altura de la imagen
                                BorderStyle = BorderStyle.None // Asegurarse de que no tenga border style
                            };

                            Label label = new Label
                            {
                                Text = titulo,
                                Dock = DockStyle.Bottom,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Height = 40, // Altura del label
                                BorderStyle = BorderStyle.None // Asegurarse de que no tenga border style
                            };

                            panel.Controls.Add(pictureBox);
                            panel.Controls.Add(label);

                            panel.Click += (s, args) =>
                            {
                                int id = (int)panel.Tag;
                                this.Hide();
                                InfoPelicula form = new InfoPelicula(id, idCliente);
                                form.ShowDialog();
                                this.Close();
                            };

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
                FormsGlobales.Menu newMenu = new FormsGlobales.Menu();
                newMenu.Show();

                this.Hide();
            }
        }

        private void cbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


//CODIGO CREADO POR JOSUE CACAO Y SEBASTIAN LETONA
