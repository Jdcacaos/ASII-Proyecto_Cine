using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoAS2TaquillaCine.FormsCliente
{
    public partial class Asientos : Form
    {
        private int asientosSeleccionados = 1;
        public int TotalAsientos { get; set; }
        string connectionString = DatabaseConfig.ConnectionString;
        private Timer timer;
        private int tiempoTotal; // Tiempo total en segundos
        private int tiempoRestante; // Tiempo restante en segundos
        private int pelicula;
        private int totalventa;
        private int idproye;
        private int idCliente;
        private int descu;
        private string horario;
        private List<(char fila, int numero)> asientosSeleccionadosList = new List<(char fila, int numero)>(); // Lista de asientos seleccionados
        public Asientos(int id, int total, int idproyeccion, int idcliente, int desc, string horar)
        {
            InitializeComponent();
            idCliente = idcliente;
            pelicula = id;
            totalventa = total;
            idproye = idproyeccion;
            // Asegúrate de que el Timer se inicializa y se configura correctamente
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Tick;

            descu = desc;
            horario = horar;

            // Asignar el mismo método a todos los botones
            btnA1.Click += Asiento_Click;
            btnA2.Click += Asiento_Click;
            btnA3.Click += Asiento_Click;
            btnA4.Click += Asiento_Click;
            btnA5.Click += Asiento_Click;
            btnA6.Click += Asiento_Click;
            btnA7.Click += Asiento_Click;
            btnA8.Click += Asiento_Click;
            btnA9.Click += Asiento_Click;
            btnA10.Click += Asiento_Click;

            btnB1.Click += Asiento_Click;
            btnB2.Click += Asiento_Click;
            btnB3.Click += Asiento_Click;
            btnB4.Click += Asiento_Click;
            btnB5.Click += Asiento_Click;
            btnB6.Click += Asiento_Click;
            btnB7.Click += Asiento_Click;
            btnB8.Click += Asiento_Click;
            btnB9.Click += Asiento_Click;
            btnB10.Click += Asiento_Click;

            btnC1.Click += Asiento_Click;
            btnC2.Click += Asiento_Click;
            btnC3.Click += Asiento_Click;
            btnC4.Click += Asiento_Click;
            btnC5.Click += Asiento_Click;
            btnC6.Click += Asiento_Click;
            btnC7.Click += Asiento_Click;
            btnC8.Click += Asiento_Click;
            btnC9.Click += Asiento_Click;
            btnC10.Click += Asiento_Click;

            btnD4.Click += Asiento_Click;
            btnD5.Click += Asiento_Click;
            btnD6.Click += Asiento_Click;
            btnD7.Click += Asiento_Click;
            btnD8.Click += Asiento_Click;
            btnD9.Click += Asiento_Click;
            btnD10.Click += Asiento_Click;

            btnE4.Click += Asiento_Click;
            btnE5.Click += Asiento_Click;
            btnE6.Click += Asiento_Click;
            btnE7.Click += Asiento_Click;
            btnE8.Click += Asiento_Click;
            btnE9.Click += Asiento_Click;
            btnE10.Click += Asiento_Click;

            btnF4.Click += Asiento_Click;
            btnF5.Click += Asiento_Click;
            btnF6.Click += Asiento_Click;
            btnF7.Click += Asiento_Click;
            btnF8.Click += Asiento_Click;
            btnF9.Click += Asiento_Click;
            btnF10.Click += Asiento_Click;

            btnG4.Click += Asiento_Click;
            btnG5.Click += Asiento_Click;
            btnG6.Click += Asiento_Click;
            btnG7.Click += Asiento_Click;
            btnG8.Click += Asiento_Click;
            btnG9.Click += Asiento_Click;
            btnG10.Click += Asiento_Click;

            btnH4.Click += Asiento_Click;
            btnH5.Click += Asiento_Click;
            btnH6.Click += Asiento_Click;
            btnH7.Click += Asiento_Click;
            btnH8.Click += Asiento_Click;
            btnH9.Click += Asiento_Click;
            btnH10.Click += Asiento_Click;

            btnI4.Click += Asiento_Click;
            btnI5.Click += Asiento_Click;
            btnI6.Click += Asiento_Click;
            btnI7.Click += Asiento_Click;
            btnI8.Click += Asiento_Click;
            btnI9.Click += Asiento_Click;
            btnI10.Click += Asiento_Click;


            lbl_totalventa.Text = Convert.ToString(totalventa + descu);
        }

        private void IniciarCronometro(int segundos)
        {
            if (pb1 == null || lblT == null)
            {
                MessageBox.Show("Controles no inicializados.");
                return;
            }

            tiempoTotal = segundos;
            tiempoRestante = segundos;
            pb1.Maximum = tiempoTotal;
            pb1.Value = tiempoTotal;

            lblT.Text = TimeSpan.FromSeconds(tiempoRestante).ToString(@"hh\:mm\:ss");
            // Inicia el Timer
            timer.Start();
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            // Actualiza la Label con el tiempo restante
            lblT.Text = TimeSpan.FromSeconds(tiempoRestante).ToString(@"hh\:mm\:ss");

            // Actualiza la ProgressBar
            pb1.Value = tiempoRestante;

            // Detén el Timer cuando el tiempo se acabe
            if (tiempoRestante <= 0)
            {
                timer.Stop();
                lblT.Text = "00:00:00";
                pb1.Value = 0;
                MessageBox.Show("¡Tiempo agotado!");

                // Redirige al formulario CarteleraNueva
                CarteleraNueva carteleraNueva = new CarteleraNueva(idCliente);
                carteleraNueva.Show();
                this.Close(); // Opcional: cierra el formulario actual si ya no es necesario
            }
        }
        private int ObtenerIDAsiento(char fila, int numero)
        {
            int idAsiento = -1;

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT ID_Asiento FROM tbl_asiento WHERE Fila = @fila AND Numero = @numero";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@fila", fila);
                cmd.Parameters.AddWithValue("@numero", numero);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idAsiento = Convert.ToInt32(result);
                }
            }

            return idAsiento;
        }

        private void Asiento_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // No hacer nada si el botón está deshabilitado (asiento ocupado)
            if (!btn.Enabled)
                return;
            char fila = btn.Name[3]; // Asumiendo que el nombre del botón sigue el formato btnA1, btnB2, etc.
            int numero = int.Parse(btn.Name.Substring(4));

            // Alternar el color de los botones que no son rojos
            if (btn.BackColor == Color.Lime)
            {
                if (asientosSeleccionados <= TotalAsientos)
                {
                    btn.BackColor = Color.DarkBlue;
                    asientosSeleccionados++;
                    asientosSeleccionadosList.Add((fila, numero));
                }
                else
                {
                    MessageBox.Show("Has alcanzado el número máximo de asientos seleccionados.");
                    btn.BackColor = Color.Lime;

                }

            }
            else if (btn.BackColor == Color.DarkBlue)
            {
                btn.BackColor = Color.Lime;
                asientosSeleccionados--;
                asientosSeleccionadosList.Remove((fila, numero));
            }


        }

        public List<(char fila, int numero)> ObtenerAsientosSeleccionados()
        {
            return asientosSeleccionadosList;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormsCliente.CarteleraNueva formReserva = new FormsCliente.CarteleraNueva(idCliente);
            formReserva.Show();
            timer.Stop();
            this.Close();
        }


        private void Asientos_Load_1(object sender, EventArgs e)
        {
            IniciarCronometro(60);
            label25.Text = TotalAsientos.ToString();
            lbl_descuento.Text = Convert.ToString(descu);
            lbl_totalC.Text = Convert.ToString(totalventa);
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // Ejecutar la primera consulta
                    string query = "SELECT Titulo, Imagen FROM tbl_pelicula WHERE ID_pelicula = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", pelicula);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string nombre = reader["Titulo"].ToString();
                        byte[] fotografia = (byte[])reader["Imagen"];

                        lbl_NomPelicula.Text = nombre;
                        picbx_pelicula.Image = imagen(fotografia);
                    }

                    reader.Close(); // Cerrar el primer lector antes de ejecutar la segunda consulta

                    // Ejecutar la segunda consulta
                    string query2 = "SELECT FK_ID_Sala, Fecha, Hora FROM tbl_proyeccion WHERE FK_ID_Pelicula = @id";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
                    cmd2.Parameters.AddWithValue("@id", pelicula);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        string fecha = reader2["Fecha"].ToString();
                        string horario = reader2["Hora"].ToString();

                        lbl_FechaProyeccion.Text = "Fecha: " + fecha;
                        lbl_horarioproyeccion.Text = "Horario: " + horario;
                    }

                    reader2.Close(); // Cerrar el segundo lector

                    string query3 = "SELECT A.Fila, A.Numero FROM tbl_reservacion R " +
                           "JOIN tbl_asiento A ON R.Fk_ID_Asiento = A.ID_Asiento " +
                           "WHERE R.Fk_ID_Proyeccion = @proyeccionId";
                    MySqlCommand cmd3 = new MySqlCommand(query3, conexion);
                    cmd3.Parameters.AddWithValue("@proyeccionId", idproye); // Reemplazar 'pelicula' por el ID de la proyección si es necesario
                    MySqlDataReader reader3 = cmd3.ExecuteReader();
                    int asientosOcupados = 0;
                    while (reader3.Read())
                    {
                        char fila = reader3["Fila"].ToString()[0];
                        int numero = Convert.ToInt32(reader3["Numero"]);

                        // Marcar el asiento como ocupado
                        MarcarAsientoOcupado(fila, numero);
                        asientosOcupados++;
                    }

                    reader3.Close();
                    if (asientosOcupados >= 72)
                    {
                        MessageBox.Show("Todos los asientos están ocupados. No se pueden hacer más reservas.");
                        // Deshabilitar todos los botones de los asientos
                        FormsCliente.CarteleraNueva formCartelera = new FormsCliente.CarteleraNueva(idCliente);
                        formCartelera.Show();
                        this.Close();
                        timer.Stop();
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
        private void DeshabilitarBotonesAsientos()
{
    foreach (Control control in this.Controls)
    {
        if (control is Button btn && btn.Name.StartsWith("btn"))
        {
            btn.Enabled = false; // Deshabilitar todos los botones de los asientos
        }
    }
}
        private void MarcarAsientoOcupado(char fila, int numero)
        {
            Button btn = null;

            // Obtener el botón correspondiente al asiento
            switch (fila)
            {
                case 'A':
                    btn = this.Controls.Find("btnA" + numero, true).FirstOrDefault() as Button;
                    break;
                case 'B':
                    btn = this.Controls.Find("btnB" + numero, true).FirstOrDefault() as Button;
                    break;
                case 'C':
                    btn = this.Controls.Find("btnC" + numero, true).FirstOrDefault() as Button;
                    break;
                case 'D':
                    btn = this.Controls.Find("btnD" + numero, true).FirstOrDefault() as Button;
                    break;
                case 'E':
                    btn = this.Controls.Find("btnE" + numero, true).FirstOrDefault() as Button;
                    break;
                case 'F':
                    btn = this.Controls.Find("btnF" + numero, true).FirstOrDefault() as Button;
                    break;
                case 'G':
                    btn = this.Controls.Find("btnG" + numero, true).FirstOrDefault() as Button;
                    break;
                case 'H':
                    btn = this.Controls.Find("btnH" + numero, true).FirstOrDefault() as Button;
                    break;
                case 'I':
                    btn = this.Controls.Find("btnI" + numero, true).FirstOrDefault() as Button;
                    break;

            }

            // Si se encuentra el botón, marcarlo como ocupado
            if (btn != null)
            {
                btn.BackColor = Color.Red;
                btn.Enabled = false;
            }
        }
        private Image imagen(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void btnI10_Click(object sender, EventArgs e)
        {

        }

        private void btnA2_Click(object sender, EventArgs e)
        {

        }

        private void button95_Click(object sender, EventArgs e)
        {
           
            List<(char fila, int numero)> asientosSeleccionados = ObtenerAsientosSeleccionados();
            if (asientosSeleccionados.Count != TotalAsientos)
            {
                MessageBox.Show("TERMINE DE SELECCIONAR SUS ASIENTOS ...");
            }
            else
            {

                
                FormsCliente.Pago formPago = new FormsCliente.Pago(totalventa - descu, idCliente, asientosSeleccionados, idproye, descu, horario);
                formPago.Show();
                timer.Stop();
                this.Hide();
            }
        }

        private void lbl_totalventa_Click(object sender, EventArgs e)
        {

        }
    }
}
