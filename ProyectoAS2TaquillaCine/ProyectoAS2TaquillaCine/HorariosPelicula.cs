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
using ProyectoAS2TaquillaCine.FormsCliente;

namespace ProyectoAS2TaquillaCine
{
    public partial class HorariosPelicula : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        private int idpelicula;

        public HorariosPelicula(int id)
        {
            InitializeComponent();
            idpelicula = id;
        }

        private void HorariosPelicula_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT Titulo, Sinopsis, Genero, Duracion, Imagen FROM tbl_pelicula WHERE ID_pelicula = @id";
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

        private void byn_back_Click(object sender, EventArgs e)
        {
            FormsCliente.CarteleraNueva Cartelera = new CarteleraNueva();
            this.Hide();
            Cartelera.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserva formReserva = new Reserva();
            formReserva.Show();
            this.Hide();
        }
    }
}
