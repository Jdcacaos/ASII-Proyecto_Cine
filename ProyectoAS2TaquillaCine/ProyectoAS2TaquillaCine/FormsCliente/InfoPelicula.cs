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
    public partial class InfoPelicula : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        private int idpelicula;
        private string trailerUrl; // Asegúrate de que esta variable esté inicializada

        public InfoPelicula(int id)
        {
            InitializeComponent();
            idpelicula = id;
        }

        private void InfoPelicula_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT Titulo, Sinopsis, Genero, Duracion, Imagen, trailer_url FROM tbl_pelicula WHERE ID_pelicula = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", idpelicula);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string nombre = reader["Titulo"].ToString();
                        string sinopsis = reader["Sinopsis"].ToString();
                        string genero = reader["Genero"].ToString();
                        int duracion = Convert.ToInt32(reader["Duracion"]);
                        byte[] fotografia = (byte[])reader["Imagen"];
                        trailerUrl = reader["trailer_url"].ToString(); // Asigna el valor del trailer_url

                        lbl_nombre.Text = nombre;
                        lbl_duracion.Text = "Duración: " + duracion + " min";
                        picbox1.Image = imagen(fotografia);
                        lbl_genero.Text = "Género: " + genero;
                        lbl_sinopsis.Text = sinopsis;
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

        private Image imagen(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void byn_back_Click_1(object sender, EventArgs e)
        {
            FormsCliente.CarteleraNueva Cartelera = new CarteleraNueva();
            this.Hide();
            Cartelera.ShowDialog();
            this.Close();
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(trailerUrl))
            {
                try
                {
                    System.Diagnostics.Process.Start(trailerUrl); // Abre la URL en el navegador predeterminado
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el trailer: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay URL de trailer disponible.");
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            FormsCliente.Reserva FormReserva = new Reserva();
            this.Hide();
            FormReserva.ShowDialog();
            this.Close();
        }
    }
}



