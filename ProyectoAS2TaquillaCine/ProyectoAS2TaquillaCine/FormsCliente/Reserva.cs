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

        private int precioniño;
        private int precioadulto;
        private int precioterceraedad;
        private int descuento;

        private string horario;
        private string hora;
        private string fecha;
        public Reserva(int id, int idCliente)
        {
            InitializeComponent();
            pelicula = id;
            this.idCliente = idCliente;
            this.MaximizeBox = false;
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
            LoadFechas(pelicula); 



        }
        private void cargarPrecios()
        {
            string query = "SELECT Precio_Nino,Precio_Adulto,Precio_3ra_Edad FROM tbl_proyeccion WHERE Fecha = @Fecha AND Hora=@Hora";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Fecha", cb_fecha.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Hora", cb_hora.SelectedItem.ToString());
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lb_precioNino.Text = reader["Precio_Nino"].ToString();
                    lb_precioAdulto.Text = reader["Precio_Adulto"].ToString();
                    lb_precio3ra.Text = reader["Precio_3ra_Edad"].ToString();
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private int clasificacionPelicula;

        private void ObtenerClasificacionPelicula(int idPelicula)
        {
            string query = "SELECT FK_ID_Clasificacion FROM tbl_pelicula WHERE ID_Pelicula = @ID_Pelicula";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Pelicula", idPelicula);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    clasificacionPelicula = Convert.ToInt32(result);
                }
            }
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
                string query = "SELECT DISTINCT Fecha FROM tbl_proyeccion WHERE FK_ID_Pelicula = @ID_Pelicula  AND Fecha >= @Today";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Pelicula", idPelicula);
                        command.Parameters.AddWithValue("@Today", DateTime.Now.ToString("yyyy-MM-dd"));

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cb_fecha.Items.Clear();

                            while (reader.Read())
                            {
                                DateTime fecha = reader.GetDateTime(0);
                                cb_fecha.Items.Add(fecha.ToString("yyyy-MM-dd"));
                            }
                        }
                    }
                }

                ObtenerClasificacionPelicula(idPelicula);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            if (cb_fecha.Items.Count > 0)
            {
                cb_fecha.SelectedIndex = 0;
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
                        cb_hora.Items.Add(reader.GetTimeSpan("Hora").ToString());
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

            if (textBox == txtbx_noNinos) 
            {
                if (clasificacionPelicula == 5 || clasificacionPelicula == 6)
                {
                    MessageBox.Show("No se pueden seleccionar boletos para niños para esta película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (valor >= 5)
            {
                descuento = 10;
            }
            else if (valor >= 8)
            {
                descuento = 20;
            }
            else if (valor == 10)
            {
                descuento = 30;
            }
            if (valor < 10)
            {
                valor++;
                textBox.Text = valor.ToString();
            }
            else
            {
                MessageBox.Show("El número máximo de boletos para esta categoría es 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restar(TextBox textBox)
        {
            int valor = Convert.ToInt16(textBox.Text);
            if (textBox == txtbx_noNinos) 
            {
                if (clasificacionPelicula == 5 || clasificacionPelicula == 6)
                {
                    MessageBox.Show("No se pueden seleccionar boletos para niños para esta película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (valor > 0)
            {
                valor--;
                textBox.Text = valor.ToString();
            }
            else
            {
                MessageBox.Show("El número de boletos no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void operar(TextBox textbox, Label label, Label label1) 
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
                lb_totalPagar.Text = "0";
                txtbx_totalAsientos.Text = "0";
                lb_subtotalAdulto.Text = "0";
                lb_subtotalNino.Text = "0";
                lb_subtotal3ra.Text = "0";
            }
            
            else
            {
                lb_totalPagar.Text = total.ToString();
                txtbx_totalAsientos.Text = totalAsientos.ToString();
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_hora.Items.Clear();
            LoadHoras(cb_fecha.SelectedItem.ToString(), pelicula);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sumar(txtbx_noNinos);
            operar(txtbx_noNinos, lb_precioNino, lb_subtotalNino);
            total(txtbx_noNinos, txtbx_noAdulto, txtbx_no3ra, lb_subtotalNino, lb_subtotalAdulto, lb_subtotal3ra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            restar(txtbx_noNinos);
            operar(txtbx_noNinos, lb_precioNino, lb_subtotalNino);
            total(txtbx_noNinos, txtbx_noAdulto, txtbx_no3ra, lb_subtotalNino, lb_subtotalAdulto, lb_subtotal3ra);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sumar(txtbx_noAdulto);
            operar(txtbx_noAdulto, lb_precioAdulto, lb_subtotalAdulto);
            total(txtbx_noNinos, txtbx_noAdulto, txtbx_no3ra, lb_subtotalNino, lb_subtotalAdulto, lb_subtotal3ra);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            restar(txtbx_noAdulto);
            operar(txtbx_noAdulto, lb_precioAdulto, lb_subtotalAdulto);
            total(txtbx_noNinos, txtbx_noAdulto, txtbx_no3ra, lb_subtotalNino, lb_subtotalAdulto, lb_subtotal3ra);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sumar(txtbx_no3ra);
            operar(txtbx_no3ra, lb_precio3ra, lb_subtotal3ra);
            total(txtbx_noNinos, txtbx_noAdulto, txtbx_no3ra, lb_subtotalNino, lb_subtotalAdulto, lb_subtotal3ra);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            restar(txtbx_no3ra);
            operar(txtbx_no3ra, lb_precio3ra, lb_subtotal3ra);
            total(txtbx_noNinos, txtbx_noAdulto, txtbx_no3ra, lb_subtotalNino, lb_subtotalAdulto, lb_subtotal3ra);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPrecios();
            operar(txtbx_noNinos, lb_precioNino, lb_subtotalNino);
            operar(txtbx_noAdulto, lb_precioAdulto, lb_subtotalAdulto);
            operar(txtbx_no3ra, lb_precio3ra, lb_subtotal3ra);
            total(txtbx_noNinos, txtbx_noAdulto, txtbx_no3ra, lb_subtotalNino, lb_subtotalAdulto, lb_subtotal3ra);
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
            try
            {
                int totalAsientos = Convert.ToInt32(txtbx_noNinos.Text) + Convert.ToInt32(txtbx_noAdulto.Text) + Convert.ToInt32(txtbx_no3ra.Text);
                if (totalAsientos == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un boleto para proceder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbx_totalAsientos.Text = "0";
                }
                else
                {
                    fecha = Convert.ToString(cb_fecha.SelectedItem);

                    if (cb_hora.SelectedItem == null)
                    {
                        throw new Exception("Debe seleccionar una hora para proceder.");
                    }

                    hora = Convert.ToString(cb_hora.SelectedItem);
                    horario = fecha + " " + hora;
                    totalventa = Convert.ToInt32(lb_totalPagar.Text);
                    int idProyeccion = ObtenerIdProyeccion(pelicula, cb_fecha.SelectedItem.ToString(), cb_hora.SelectedItem.ToString());
                    FormsCliente.Asientos formAsientos = new FormsCliente.Asientos(pelicula, totalventa, idProyeccion, idCliente, descuento, horario);
                    formAsientos.TotalAsientos = totalAsientos;

                    formAsientos.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

//CODIGO CREADO POR SEBASTIAN LETONA


