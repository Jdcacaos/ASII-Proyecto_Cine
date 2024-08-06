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
using System.Data.SqlClient;


namespace ProyectoAS2TaquillaCine.FormsCliente
{

    public partial class Reserva : Form
    {

        private int pelicula;
        private int idCliente;

        public int totalventa { get; set; }

        public Reserva(int id, int idCliente)
        {
            InitializeComponent();
            pelicula = id;
            this.idCliente = idCliente;
        }

        string connectionString = DatabaseConfig.ConnectionString;
        public Reserva()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            LoadFechas(pelicula); //Depende el ID de la pelicula.



        }
        private void cargarPrecios()
        {
            string query = "SELECT Precio_Nino,Precio_Adulto,Precio_3ra_Edad FROM tbl_proyeccion WHERE Fecha = @Fecha AND Hora=@Hora";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Fecha", comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Hora", comboBox2.SelectedItem.ToString());
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    label9.Text = reader["Precio_Nino"].ToString();
                    label10.Text = reader["Precio_Adulto"].ToString();
                    label11.Text = reader["Precio_3ra_Edad"].ToString();
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormsCliente.CarteleraNueva formCartelera = new FormsCliente.CarteleraNueva(idCliente);
            formCartelera.Show();
            this.Hide();
        }
        private void LoadFechas(int idPelicula)
        {
            try
            {
                // Consulta SQL para obtener las fechas de la proyección
                string query = "SELECT DISTINCT Fecha FROM tbl_proyeccion WHERE FK_ID_Pelicula = @ID_Pelicula  AND Fecha >= @Today";
                // Crea una nueva conexión SQL
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Abre la conexión
                    connection.Open();

                    // Crea un comando SQL
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agrega el parámetro de ID de proyección
                        command.Parameters.AddWithValue("@ID_Pelicula", idPelicula);
                        command.Parameters.AddWithValue("@Today", DateTime.Now.ToString("yyyy-MM-dd"));

                        // Ejecuta la consulta y obtiene los resultados
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Limpia el ComboBox antes de llenarlo
                            comboBox1.Items.Clear();

                            // Llena el ComboBox con los resultados
                            while (reader.Read())
                            {
                                DateTime fecha = reader.GetDateTime(0);
                                comboBox1.Items.Add(fecha.ToString("yyyy-MM-dd"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void LoadHoras(string fecha, int id_Pelicula)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string query = "SELECT Hora FROM tbl_proyeccion WHERE Fecha = @Fecha AND FK_ID_Pelicula = @ID_Pelicula";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@ID_Pelicula", id_Pelicula);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader.GetTimeSpan("Hora").ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }

        private void sumar(TextBox textBox)
        {
            int valor = Convert.ToInt16(textBox.Text);
            if (valor < 10)
            {
                valor++;
                textBox.Text = valor.ToString();
                operar(textBox, label9, label13); // Asegúrate de actualizar los cálculos
                total(textBox1, textBox2, textBox3, label13, label14, label15); // Asegúrate de actualizar el total
            }
            else
            {
                MessageBox.Show("El número máximo de boletos para esta categoría es 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restar(TextBox textBox)
        {
            int valor = Convert.ToInt16(textBox.Text);
            if (valor > 0)
            {
                valor--;
                textBox.Text = valor.ToString();
                operar(textBox, label9, label13); // Asegúrate de actualizar los cálculos
                total(textBox1, textBox2, textBox3, label13, label14, label15); // Asegúrate de actualizar el total
            }
            else
            {
                MessageBox.Show("El número de boletos no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void operar(TextBox textbox, Label label, Label label1) //Opera Entradas * Precio
        {
            double entradas, precio, subtotal;
            entradas = Convert.ToDouble(textbox.Text);
            precio = Convert.ToDouble(label.Text);
            subtotal = entradas * precio;
            label1.Text = subtotal.ToString();
        }

        private void total(TextBox textbox1, TextBox textbox2, TextBox textbox3, Label label1, Label label2, Label label3)
        {
            double totalAsientos, total, valor1, valor2, valor3;
            valor1 = Convert.ToDouble(textbox1.Text);
            valor2 = Convert.ToDouble(textbox2.Text);
            valor3 = Convert.ToDouble(textbox3.Text);

            totalAsientos = valor1 + valor2 + valor3;
            total = Convert.ToDouble(label1.Text) + Convert.ToDouble(label2.Text) + Convert.ToDouble(label3.Text);

            if (totalAsientos > 10)
            {
                MessageBox.Show("El número total de boletos no puede superar 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox1.Text = "0";
                textbox2.Text = "0";
                textbox3.Text = "0";
                label16.Text = "0";
                textBox4.Text = "0";
            }
            else if (totalAsientos == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un boleto para proceder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "0";
            }
            else
            {
                label16.Text = total.ToString();
                textBox4.Text = totalAsientos.ToString();
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            LoadHoras(comboBox1.SelectedItem.ToString(), pelicula);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sumar(textBox1);
            operar(textBox1, label9, label13);
            total(textBox1, textBox2, textBox3, label13, label14, label15);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restar(textBox1);
            operar(textBox1, label9, label13);
            total(textBox1, textBox2, textBox3, label13, label14, label15);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sumar(textBox2);
            operar(textBox2, label10, label14);
            total(textBox1, textBox2, textBox3, label13, label14, label15);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            restar(textBox2);
            operar(textBox2, label10, label14);
            total(textBox1, textBox2, textBox3, label13, label14, label15);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sumar(textBox3);
            operar(textBox3, label11, label15);
            total(textBox1, textBox2, textBox3, label13, label14, label15);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            restar(textBox3);
            operar(textBox3, label11, label15);
            total(textBox1, textBox2, textBox3, label13, label14, label15);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPrecios();
            operar(textBox1, label9, label13);
            operar(textBox2, label10, label14);
            operar(textBox3, label11, label15);
            total(textBox1, textBox2, textBox3, label13, label14, label15);
        }
        private int ObtenerIdProyeccion(int idPelicula, string fecha, string hora)
        {
            int idProyeccion = -1;
            string query = "SELECT ID_Proyeccion FROM tbl_proyeccion WHERE FK_ID_Pelicula = @ID_Pelicula AND Fecha = @Fecha AND Hora = @Hora";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Pelicula", idPelicula);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@Hora", hora);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    idProyeccion = Convert.ToInt32(result);
                }
            }

            return idProyeccion;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int totalAsientos = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
            totalventa = Convert.ToInt32(label16.Text);
            int idProyeccion = ObtenerIdProyeccion(pelicula, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            FormsCliente.Asientos formAsientos = new FormsCliente.Asientos(pelicula, totalventa, idProyeccion, idCliente);
            formAsientos.TotalAsientos = totalAsientos;
            FormsCliente.Pago formPago = new FormsCliente.Pago(totalventa, idCliente);

            formAsientos.Show();
            this.Hide();
        }
    }
}



