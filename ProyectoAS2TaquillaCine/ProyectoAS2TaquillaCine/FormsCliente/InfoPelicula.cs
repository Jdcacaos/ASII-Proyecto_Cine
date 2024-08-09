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
        private int idCliente;

        private string trailerUrl; // Asegúrate de que esta variable esté inicializada

        public InfoPelicula(int id, int idCliente)
        {
            InitializeComponent();
            idpelicula = id;
            this.idCliente = idCliente;

            this.btn_reserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReserva
            // 
            this.btn_reserva.Location = new System.Drawing.Point(12, 12);
            this.btn_reserva.Name = "btnReserva";
            this.btn_reserva.Size = new System.Drawing.Size(120, 30);
            this.btn_reserva.TabIndex = 0;
            this.btn_reserva.Text = "Reservar";
            this.btn_reserva.UseVisualStyleBackColor = true;
            this.btn_reserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reserva);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.ResumeLayout(false);
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

                        lb_nombre.Text = nombre;
                        lb_duracion.Text = "Duración: " + duracion + " min";
                        picbx_imagenPelicula.Image = imagen(fotografia);
                        lb_genero.Text = "Género: " + genero;
                        txtbx_sinopsis.Text = sinopsis;
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
            FormsCliente.CarteleraNueva Cartelera = new CarteleraNueva(idCliente);
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

            FormsCliente.Reserva FormReserva = new Reserva(idpelicula, idCliente);
            this.Hide();
            FormReserva.ShowDialog();
            this.Close();
        }

        private void picbox1_Click(object sender, EventArgs e)
        {

        }
    }
}



