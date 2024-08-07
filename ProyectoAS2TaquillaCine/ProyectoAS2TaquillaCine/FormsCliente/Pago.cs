using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAS2TaquillaCine.FormsCliente
{
    public partial class Pago : Form
    {
        private List<(char fila, int numero)> asientosSeleccionados;
        private int Venta { get; set; }
        string connectionString = DatabaseConfig.ConnectionString;
        private Timer timer; 
        private int tiempoRestante; 
        private int idCliente;
        private int descu;
        private int idproyeccion;

        private string nombreCliente;
        private string nombrePelicula;
        private string horario;
        private int numAsientos;
        public Pago(int TotalVenta, int idCliente, List<(char fila, int numero)> asientos, int idproye, int desc)
        {
            InitializeComponent();
            LlenarComboEmpleados();
            Llenar_ComboBox_ano();
            Llenar_ComboBox_mes();
            txtCorreo.TextChanged += TxtCorreo_TextChanged;
            asientosSeleccionados = asientos;
            // Inicializa el Timer
            timer = new Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (1000 ms = 1 segundo)
            timer.Tick += new EventHandler(timer_Tick);

            descu = desc;
            // Configura la ProgressBar
            pb1.Maximum = 500; // Puedes ajustar el valor máximo según tus necesidades
            pb1.Value = 500;

            // Configura el tiempo restante
            tiempoRestante = 500; // En segundos, por ejemplo
            lblT.Text = FormatTime(tiempoRestante);

            // Inicia el Timer
            timer.Start();

            idproyeccion = idproye;
            this.idCliente = idCliente;
            Venta = TotalVenta;
            

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
        public void InsertarAsientosSeleccionados()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();

                foreach (var asiento in asientosSeleccionados)
                {
                    cmd.CommandText = "INSERT INTO tbl_reservacion (Fk_ID_Proyeccion, Fk_ID_cliente, Fk_ID_Asiento, precio, descuento) " +
                                      "VALUES (@proyeccionId, @clienteId, @asientoId, @precio, @descuento)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@proyeccionId", idproyeccion);
                    cmd.Parameters.AddWithValue("@clienteId", idCliente);
                    cmd.Parameters.AddWithValue("@asientoId", ObtenerIDAsiento(asiento.fila, asiento.numero));
                    cmd.Parameters.AddWithValue("@precio", Venta-descu); // Ejemplo de precio
                    cmd.Parameters.AddWithValue("@descuento", descu); // Ejemplo de descuento

                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        

        private void Pago_Load(object sender, EventArgs e)
        {
            obtnerdatosfactura();
        }

        private void LlenarComboEmpleados()
        {
            string query = "SELECT ID_Empleado, Nombre FROM tbl_empleado";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cbEmpleados.Items.Clear();

                            // Crear una lista temporal para almacenar los elementos
                            List<KeyValuePair<int, string>> empleados = new List<KeyValuePair<int, string>>();

                            while (reader.Read())
                            {
                                int idEmpleado = reader.GetInt32("ID_Empleado");
                                string nombre = reader.GetString("Nombre");

                                // Añadir a la lista de empleados
                                empleados.Add(new KeyValuePair<int, string>(idEmpleado, nombre));
                            }

                            // Establecer la fuente de datos del ComboBox
                            cbEmpleados.DataSource = empleados;
                            cbEmpleados.DisplayMember = "Value";
                            cbEmpleados.ValueMember = "Key";

                            if (cbEmpleados.Items.Count > 0)
                            {
                                cbEmpleados.SelectedIndex = 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void obtnerdatosfactura()
        {
            string tipoTarjeta = rb_Credito.Checked ? "Credito" : "Debito";
            int totalVenta = Venta;
            int descuento = descu;
            numAsientos = asientosSeleccionados.Count;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener los datos de la factura
                    string query = @"
                                  SELECT 
                        c.Nombre AS NombreCliente, 
                        p.Titulo AS NombrePelicula, 
                        CONCAT(pr.Fecha, ' ', pr.Hora) AS Horario
                    FROM tbl_cliente c
                    JOIN tbl_reservacion r ON c.ID_Cliente = r.Fk_ID_cliente
                    JOIN tbl_proyeccion pr ON r.Fk_ID_Proyeccion = pr.ID_Proyeccion
                    JOIN tbl_pelicula p ON pr.FK_ID_Pelicula = p.ID_Pelicula
                    WHERE c.ID_Cliente = @idCliente AND pr.ID_Proyeccion = @idProyeccion";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCliente", idCliente);
                        command.Parameters.AddWithValue("@idProyeccion", idproyeccion);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombreCliente = reader.GetString("NombreCliente");
                                nombrePelicula = reader.GetString("NombrePelicula");
                                horario = reader.GetString("Horario");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos de la factura: " + ex.Message);
                }
            }
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            VerificarCorreo(correo);
        }

        private void VerificarCorreo(string correo)
        {
            bool correoEnCliente = false;
            bool correoEnEmpleado = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar si el correo está en tbl_cliente
                    string queryCliente = "SELECT COUNT(*) FROM tbl_cliente WHERE Email = @Correo";
                    using (MySqlCommand command = new MySqlCommand(queryCliente, connection))
                    {
                        command.Parameters.AddWithValue("@Correo", correo);
                        correoEnCliente = Convert.ToInt32(command.ExecuteScalar()) > 0;
                        cbEmpleados.SelectedItem = "Generado por cliente";
                        cbEmpleados.Text = "Seleccione un empleado";
                    }

                    // Verificar si el correo está en tbl_empleado
                    string queryEmpleado = "SELECT COUNT(*) FROM tbl_empleado WHERE Email = @Correo";
                    using (MySqlCommand command = new MySqlCommand(queryEmpleado, connection))
                    {
                        command.Parameters.AddWithValue("@Correo", correo);
                        correoEnEmpleado = Convert.ToInt32(command.ExecuteScalar()) > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el correo: " + ex.Message);
                }
            }

            if (correoEnCliente)
            {
                cbEmpleados.Enabled = false;
            }
            else
            {
                cbEmpleados.Enabled = true;
            }
        }

        private void Llenar_ComboBox_mes()
        {
            cbmes.Items.Clear();
            cbmes.Items.Add("01");
            cbmes.Items.Add("02");
            cbmes.Items.Add("03");
            cbmes.Items.Add("04");
            cbmes.Items.Add("05");
            cbmes.Items.Add("06");
            cbmes.Items.Add("07");
            cbmes.Items.Add("08");
            cbmes.Items.Add("09");
            cbmes.Items.Add("10");
            cbmes.Items.Add("11");
            cbmes.Items.Add("12");
            if (cbmes.Items.Count > 0)
            {
                cbmes.SelectedIndex = 0;
            }
        }

        private void Llenar_ComboBox_ano()
        {
            cbano.Items.Clear();
            cbano.Items.Add("23");
            cbano.Items.Add("24");
            cbano.Items.Add("25");
            cbano.Items.Add("26");
            cbano.Items.Add("27");
            cbano.Items.Add("28");
            cbano.Items.Add("29");
            cbano.Items.Add("30");
            cbano.Items.Add("31");
            cbano.Items.Add("32");
            cbano.Items.Add("33");
            cbano.Items.Add("34");
            cbano.Items.Add("35");
            cbano.Items.Add("36");
            cbano.Items.Add("37");
            cbano.Items.Add("38");
            cbano.Items.Add("39");
            cbano.Items.Add("40");
            if (cbano.Items.Count > 0)
            {
                cbano.SelectedIndex = 0;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                pb1.Value = tiempoRestante; // Ajusta el valor de la ProgressBar
                lblT.Text = FormatTime(tiempoRestante); // Actualiza la Label con el tiempo restante
            }
            else
            {
                timer.Stop(); // Detiene el Timer cuando el tiempo se acaba
                lblT.Text = "¡Tiempo terminado!";
                this.Close();
            }
        }

        private string FormatTime(int segundos)
        {
            TimeSpan tiempo = TimeSpan.FromSeconds(segundos);
            return tiempo.ToString(@"mm\:ss"); // Formato mm:ss
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            InsertarAsientosSeleccionados();
            // Obtener los valores del formulario
            string numeroTarjeta = txtTj.Text;
            string mesExpiracion = cbmes.SelectedItem.ToString();
            string anoExpiracion = cbano.SelectedItem.ToString();

            // Asegúrate de que el mes tenga dos dígitos (ej. 01, 02, ..., 12)
            string mesFormateado = mesExpiracion.PadLeft(2, '0');
            // Construir la fecha de expiración en formato YYYY-MM-DD
            string fechaExpiracion = $"{anoExpiracion}-{mesFormateado}-01";

            string cvv = txtCVV.Text;
            string nombreTitular = txtNombre.Text;
            string tipoTarjeta = rb_Credito.Checked ? "Credito" : "Debito";
            string estado = "Activo";

            // Obtener el ID del empleado desde el ComboBox
            int idEmpleado = Convert.ToInt32(cbEmpleados.SelectedValue);

            // Obtener la fecha y hora actuales
            DateTime fechaHora = DateTime.Now;

            // Concatenar el método de pago
            string metodoPago = "Tarjeta " + (rb_Credito.Checked ? "Credito" : "Debito");

            // Establecer la conexión a la base de datos
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si la tarjeta ya existe
                string checkQuery = "SELECT ID_Tarjeta FROM tbl_tarjeta WHERE Numero_Tarjeta = @numeroTarjeta";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                    object result = checkCommand.ExecuteScalar();

                    if (result != null)
                    {
                        // La tarjeta ya existe, actualizar los datos
                        string updateQuery = "UPDATE tbl_tarjeta SET Fecha_Expiracion = @fechaExpiracion, CVV = @cvv, Nombre_Titular = @nombreTitular, Tipo_Tarjeta = @tipoTarjeta, Estado_tbl_tarjeta = @estado WHERE Numero_Tarjeta = @numeroTarjeta";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@fechaExpiracion", fechaExpiracion);
                            updateCommand.Parameters.AddWithValue("@cvv", cvv);
                            updateCommand.Parameters.AddWithValue("@nombreTitular", nombreTitular);
                            updateCommand.Parameters.AddWithValue("@tipoTarjeta", tipoTarjeta);
                            updateCommand.Parameters.AddWithValue("@estado", estado);
                            updateCommand.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // La tarjeta no existe, insertarla
                        string insertQuery = "INSERT INTO tbl_tarjeta (Numero_Tarjeta, Fecha_Expiracion, CVV, Nombre_Titular, Tipo_Tarjeta, Estado_tbl_tarjeta, FK_ID_Cliente) VALUES (@numeroTarjeta, @fechaExpiracion, @cvv, @nombreTitular, @tipoTarjeta, @estado, @idCliente)";
                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                            insertCommand.Parameters.AddWithValue("@fechaExpiracion", fechaExpiracion);
                            insertCommand.Parameters.AddWithValue("@cvv", cvv);
                            insertCommand.Parameters.AddWithValue("@nombreTitular", nombreTitular);
                            insertCommand.Parameters.AddWithValue("@tipoTarjeta", tipoTarjeta);
                            insertCommand.Parameters.AddWithValue("@estado", estado);

                            // Obtener el ID del cliente
                            int idcliente = idCliente;
                            insertCommand.Parameters.AddWithValue("@idCliente", idcliente);

                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    // Verificar si el ID del empleado existe
                    string checkEmpleadoQuery = "SELECT COUNT(*) FROM tbl_empleado WHERE ID_Empleado = @idEmpleado";
                    using (MySqlCommand checkEmpleadoCommand = new MySqlCommand(checkEmpleadoQuery, connection))
                    {
                        checkEmpleadoCommand.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                        int empleadoCount = Convert.ToInt32(checkEmpleadoCommand.ExecuteScalar());
                        if (empleadoCount == 0)
                        {
                            MessageBox.Show("El ID del empleado no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insertar en la tabla tbl_venta
                    string insertVentaQuery = "INSERT INTO tbl_venta (FK_ID_Empleado, Fecha_Hora, Metodo_Pago, Monto_Total) VALUES (@idEmpleado, @fechaHora, @metodoPago, @montoTotal)";
                    using (MySqlCommand insertVentaCommand = new MySqlCommand(insertVentaQuery, connection))
                    {
                        insertVentaCommand.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        insertVentaCommand.Parameters.AddWithValue("@fechaHora", fechaHora);
                        insertVentaCommand.Parameters.AddWithValue("@metodoPago", metodoPago);
                        insertVentaCommand.Parameters.AddWithValue("@montoTotal", Venta);

                        insertVentaCommand.ExecuteNonQuery();
                    }
                }

                // Mensaje de confirmación
                MessageBox.Show("Boletos comprados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerarFacturaPDF();
                timer.Stop();
                this.Close();
            }

        }





        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            timer.Stop();
        }

        private void txtTj_Leave(object sender, EventArgs e)
        {
          
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GenerarFacturaPDF()
        {
            int venta = Venta;
            int descuento = descu;
            string metodoPago = "Tarjeta " + (rb_Credito.Checked ? "Credito" : "Debito");
            DateTime fechaHora = DateTime.Now;
            int idEmpleado = Convert.ToInt32(cbEmpleados.SelectedValue);

            string nombrec = txtNombre.Text;

            // Generar un número de factura (correlativo)
            int numeroFactura = GenerarNumeroFactura(); // Método que genera o recupera el número de factura

            // Ruta para guardar el PDF
            string pdfDirectory = @"C:\Users\bhern\Desktop\PDF";
            string pdfFileName = $"Factura_{numeroFactura}_{fechaHora:yyyyMMdd_HHmmss}.pdf";
            string pdfPath = Path.Combine(pdfDirectory, pdfFileName);

            // Crear un documento PDF
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

            // Abrir el documento para escribir
            document.Open();

            // Añadir contenido al documento

            document.Add(new Paragraph($"Fecha y Hora: {fechaHora}"));
            document.Add(new Paragraph($"Nombre del cliente: {nombrec}"));
            document.Add(new Paragraph($"Nombre de la película: {nombrePelicula}"));
            document.Add(new Paragraph($"Horario: {horario}"));
            document.Add(new Paragraph($"Número de asientos: {numAsientos}"));
            document.Add(new Paragraph($"Descuento: {descuento}"));
            document.Add(new Paragraph($"Total de venta: {venta}"));
            document.Add(new Paragraph($"Método de Pago: {metodoPago}"));
            document.Add(new Paragraph($"ID del Empleado: {idEmpleado}"));

            // Cerrar el documento
            document.Close();

            MessageBox.Show($"PDF generado con éxito en {pdfPath}");
        }

        private int GenerarNumeroFactura()
        {
            int numeroFactura = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener el último número de factura
                    string query = "SELECT MAX(NumeroFactura) FROM tbl_factura";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            numeroFactura = Convert.ToInt32(result) + 1;
                        }
                        else
                        {
                            numeroFactura = 1; // Primera factura
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el número de factura: " + ex.Message);
                }
            }

            return numeroFactura;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
