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
            this.MaximizeBox = false;
            idCliente = idcliente;
            pelicula = id;
            totalventa = total;
            idproye = idproyeccion;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Tick;

            descu = desc;
            horario = horar;

            // Asignar el mismo método a todos los botones
            btn_A1.Click += Asiento_Click;
            btn_A2.Click += Asiento_Click;
            btn_A3.Click += Asiento_Click;
            btn_A4.Click += Asiento_Click;
            btn_A5.Click += Asiento_Click;
            btn_A6.Click += Asiento_Click;
            btn_A7.Click += Asiento_Click;
            btn_A8.Click += Asiento_Click;
            btn_A9.Click += Asiento_Click;
            btn_A10.Click += Asiento_Click;

            btn_B1.Click += Asiento_Click;
            btn_B2.Click += Asiento_Click;
            btn_B3.Click += Asiento_Click;
            btn_B4.Click += Asiento_Click;
            btn_B5.Click += Asiento_Click;
            btn_B6.Click += Asiento_Click;
            btn_B7.Click += Asiento_Click;
            btn_B8.Click += Asiento_Click;
            btn_B9.Click += Asiento_Click;
            btn_B10.Click += Asiento_Click;

            btn_C1.Click += Asiento_Click;
            btn_C2.Click += Asiento_Click;
            btn_C3.Click += Asiento_Click;
            btn_C4.Click += Asiento_Click;
            btn_C5.Click += Asiento_Click;
            btn_C6.Click += Asiento_Click;
            btn_C7.Click += Asiento_Click;
            btn_C8.Click += Asiento_Click;
            btn_C9.Click += Asiento_Click;
            btn_C10.Click += Asiento_Click;

            btn_D4.Click += Asiento_Click;
            btn_D5.Click += Asiento_Click;
            btn_D6.Click += Asiento_Click;
            btn_D7.Click += Asiento_Click;
            btn_D8.Click += Asiento_Click;
            btn_D9.Click += Asiento_Click;
            btn_D10.Click += Asiento_Click;

            btn_E4.Click += Asiento_Click;
            btn_E5.Click += Asiento_Click;
            btn_E6.Click += Asiento_Click;
            btn_E7.Click += Asiento_Click;
            btn_E8.Click += Asiento_Click;
            btn_E9.Click += Asiento_Click;
            btn_E10.Click += Asiento_Click;

            btn_F4.Click += Asiento_Click;
            btn_F5.Click += Asiento_Click;
            btn_F6.Click += Asiento_Click;
            btn_F7.Click += Asiento_Click;
            btn_F8.Click += Asiento_Click;
            btn_F9.Click += Asiento_Click;
            btn_F10.Click += Asiento_Click;

            btn_G4.Click += Asiento_Click;
            btn_G5.Click += Asiento_Click;
            btn_G6.Click += Asiento_Click;
            btn_G7.Click += Asiento_Click;
            btn_G8.Click += Asiento_Click;
            btn_G9.Click += Asiento_Click;
            btn_G10.Click += Asiento_Click;

            btn_H4.Click += Asiento_Click;
            btn_H5.Click += Asiento_Click;
            btn_H6.Click += Asiento_Click;
            btn_H7.Click += Asiento_Click;
            btn_H8.Click += Asiento_Click;
            btn_H9.Click += Asiento_Click;
            btn_H10.Click += Asiento_Click;

            btn_I4.Click += Asiento_Click;
            btn_I5.Click += Asiento_Click;
            btn_I6.Click += Asiento_Click;
            btn_I7.Click += Asiento_Click;
            btn_I8.Click += Asiento_Click;
            btn_I9.Click += Asiento_Click;
            btn_I10.Click += Asiento_Click;


            lb_totalVentas.Text = Convert.ToString(totalventa + descu);
        }

        private void IniciarCronometro(int segundos)
        {
            if (pgb_tiempo == null || lb_timer == null)
            {
                MessageBox.Show("Controles no inicializados.");
                return;
            }

            tiempoTotal = segundos;
            tiempoRestante = segundos;
            pgb_tiempo.Maximum = tiempoTotal;
            pgb_tiempo.Value = tiempoTotal;

            lb_timer.Text = TimeSpan.FromSeconds(tiempoRestante).ToString(@"hh\:mm\:ss");
            // Inicia el Timer
            timer.Start();
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            lb_timer.Text = TimeSpan.FromSeconds(tiempoRestante).ToString(@"hh\:mm\:ss");

            pgb_tiempo.Value = tiempoRestante;
            if (tiempoRestante <= 0)
            {
                timer.Stop();
                lb_timer.Text = "00:00:00";
                pgb_tiempo.Value = 0;
                MessageBox.Show("¡Tiempo agotado!");

                CarteleraNueva carteleraNueva = new CarteleraNueva(idCliente);
                carteleraNueva.Show();
                this.Close();
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
            char fila = btn.Name[3];
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
            lb_noBoletos.Text = TotalAsientos.ToString();
            lb_descuentoA.Text = Convert.ToString(descu);
            lb_totalC.Text = Convert.ToString(totalventa);
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT Titulo, Imagen FROM tbl_pelicula WHERE ID_pelicula = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", pelicula);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string nombre = reader["Titulo"].ToString();
                        byte[] fotografia = (byte[])reader["Imagen"];

                        lb_pelicula.Text = nombre;
                        picbx_pelicula.Image = imagen(fotografia);
                    }

                    reader.Close();

                    string query2 = "SELECT FK_ID_Sala, Fecha, Hora FROM tbl_proyeccion WHERE FK_ID_Pelicula = @id";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
                    cmd2.Parameters.AddWithValue("@id", pelicula);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        string fecha = reader2["Fecha"].ToString();
                        string horario = reader2["Hora"].ToString();

                        lb_fechaProyeccion.Text = "Fecha: " + fecha;
                        lb_horaProyeccion.Text = "Horario: " + horario;
                    }

                    reader2.Close();

                    string query3 = "SELECT A.Fila, A.Numero FROM tbl_reservacion R " +
                           "JOIN tbl_asiento A ON R.Fk_ID_Asiento = A.ID_Asiento " +
                           "WHERE R.Fk_ID_Proyeccion = @proyeccionId";
                    MySqlCommand cmd3 = new MySqlCommand(query3, conexion);
                    cmd3.Parameters.AddWithValue("@proyeccionId", idproye);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();
                    int asientosOcupados = 0;
                    while (reader3.Read())
                    {
                        char fila = reader3["Fila"].ToString()[0];
                        int numero = Convert.ToInt32(reader3["Numero"]);

                        MarcarAsientoOcupado(fila, numero);
                        asientosOcupados++;
                    }

                    reader3.Close();
                    if (asientosOcupados >= 72)
                    {
                        MessageBox.Show("Todos los asientos están ocupados. No se pueden hacer más reservas.");
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
                    btn.Enabled = false;
                }
            }
        }
        private void MarcarAsientoOcupado(char fila, int numero)
        {
            Button btn = null;

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
            string nompeli = lb_pelicula.Text;
            List<(char fila, int numero)> asientosSeleccionados = ObtenerAsientosSeleccionados();
            if (asientosSeleccionados.Count != TotalAsientos)
            {
                MessageBox.Show("TERMINE DE SELECCIONAR SUS ASIENTOS ...");
            }
            else
            {


                FormsCliente.Pago formPago = new FormsCliente.Pago(totalventa - descu, idCliente, asientosSeleccionados, idproye, descu, horario, nompeli);
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


//CODIGO CREADO BRAYAN HERNANDEZ
