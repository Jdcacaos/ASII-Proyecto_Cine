using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

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
        private string nPelicula;
        private string horario;
        private int numAsientos;
        private int numeroFactura;



        public Pago(int TotalVenta, int idCliente, List<(char fila, int numero)> asientos, int idproye, int desc, string horar, string nombrepeli)
        {
            InitializeComponent();
            LlenarComboEmpleados();
            Llenar_ComboBox_ano();
            Llenar_ComboBox_mes();
            txtbx_correo.TextChanged += TxtCorreo_TextChanged;
            asientosSeleccionados = asientos;
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(timer_Tick);


            nPelicula = nombrepeli;
            descu = desc;
            pgb_tiempo.Maximum = 500; 
            pgb_tiempo.Value = 500;

            tiempoRestante = 500; 
            lb_tiempo.Text = FormatTime(tiempoRestante);

            timer.Start();

            idproyeccion = idproye;
            this.idCliente = idCliente;
            Venta = TotalVenta;
            horario = horar;

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
                    cmd.Parameters.AddWithValue("@precio", Venta-descu); 
                    cmd.Parameters.AddWithValue("@descuento", descu); 

                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        

        private void Pago_Load(object sender, EventArgs e)
        {
            obtnerdatosfactura();
            cb_mes.SelectedItem = "09";
            cb_ano.SelectedItem = "24";
           cb_mes.DropDownStyle = ComboBoxStyle.DropDownList;
           cb_ano.DropDownStyle = ComboBoxStyle.DropDownList;
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
                            cb_empleados.Items.Clear();

                            List<KeyValuePair<int, string>> empleados = new List<KeyValuePair<int, string>>();

                            while (reader.Read())
                            {
                                int idEmpleado = reader.GetInt32("ID_Empleado");
                                string nombre = reader.GetString("Nombre");

                                empleados.Add(new KeyValuePair<int, string>(idEmpleado, nombre));
                            }

                            cb_empleados.DataSource = empleados;
                            cb_empleados.DisplayMember = "Value";
                            cb_empleados.ValueMember = "Key";

                            if (cb_empleados.Items.Count > 0)
                            {
                                cb_empleados.SelectedIndex = 0;
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
            string tipoTarjeta = rdb_credito.Checked ? "Credito" : "Debito";
            int totalVenta = Venta;
            int descuento = descu;
            numAsientos = asientosSeleccionados.Count;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                    SELECT 
                        p.Titulo AS NombrePelicula, 
                        CONCAT(pr.Fecha, ' ', pr.Hora) AS Horario
                    FROM tbl_reservacion r
                    JOIN tbl_proyeccion pr ON r.Fk_ID_Proyeccion = pr.ID_Proyeccion
                    JOIN tbl_pelicula p ON pr.FK_ID_Pelicula = p.ID_Pelicula
                    WHERE r.Fk_ID_Proyeccion = @idProyeccion";


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idProyeccion", idproyeccion);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombrePelicula = reader.GetString("NombrePelicula");
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
            string correo = txtbx_correo.Text.Trim();
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

                    string queryCliente = "SELECT COUNT(*) FROM tbl_cliente WHERE Email = @Correo";
                    using (MySqlCommand command = new MySqlCommand(queryCliente, connection))
                    {
                        command.Parameters.AddWithValue("@Correo", correo);
                        correoEnCliente = Convert.ToInt32(command.ExecuteScalar()) > 0;
                        cb_empleados.SelectedItem = "Generado por cliente";
                        cb_empleados.Text = "Seleccione un empleado";
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
                cb_empleados.Enabled = false;
            }
            else
            {
                cb_empleados.Enabled = true;
            }
        }

        private void Llenar_ComboBox_mes()
        {
            cb_mes.Items.Clear();
            cb_mes.Items.Add("01");
            cb_mes.Items.Add("02");
            cb_mes.Items.Add("03");
            cb_mes.Items.Add("04");
            cb_mes.Items.Add("05");
            cb_mes.Items.Add("06");
            cb_mes.Items.Add("07");
            cb_mes.Items.Add("08");
            cb_mes.Items.Add("09");
            cb_mes.Items.Add("10");
            cb_mes.Items.Add("11");
            cb_mes.Items.Add("12");
            
            if (cb_mes.Items.Count > 0)
            {
                cb_mes.SelectedIndex = 0;
            }
        }

        private void Llenar_ComboBox_ano()
        {
            cb_ano.Items.Clear();
            cb_ano.Items.Add("23");
            cb_ano.Items.Add("24");
            cb_ano.Items.Add("25");
            cb_ano.Items.Add("26");
            cb_ano.Items.Add("27");
            cb_ano.Items.Add("28");
            cb_ano.Items.Add("29");
            cb_ano.Items.Add("30");
            cb_ano.Items.Add("31");
            cb_ano.Items.Add("32");
            cb_ano.Items.Add("33");
            cb_ano.Items.Add("34");
            cb_ano.Items.Add("35");
            cb_ano.Items.Add("36");
            cb_ano.Items.Add("37");
            cb_ano.Items.Add("38");
            cb_ano.Items.Add("39");
            cb_ano.Items.Add("40");
            if (cb_ano.Items.Count > 0)
            {
                cb_ano.SelectedIndex = 0;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                pgb_tiempo.Value = tiempoRestante; 
                lb_tiempo.Text = FormatTime(tiempoRestante); 
            }
            else
            {
                timer.Stop(); 
                lb_tiempo.Text = "¡Tiempo terminado!";
                this.Close();
            }
        }

        private string FormatTime(int segundos)
        {
            TimeSpan tiempo = TimeSpan.FromSeconds(segundos);
            return tiempo.ToString(@"mm\:ss"); 
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_correo.Text) ||
               string.IsNullOrWhiteSpace(txtbx_noTarjeta.Text) ||
               string.IsNullOrWhiteSpace(txtbx_nit.Text) ||
               string.IsNullOrWhiteSpace(txtbx_nombre.Text) ||
               string.IsNullOrWhiteSpace(txtbx_telefono.Text) ||
               string.IsNullOrWhiteSpace(txtbx_telefono.Text) ||
               string.IsNullOrWhiteSpace(txtbx_codigoSeg.Text) ||
               string.IsNullOrWhiteSpace(cb_mes.Text) ||
               string.IsNullOrWhiteSpace(cb_ano.Text) ||

               string.IsNullOrWhiteSpace(txtbx_nit.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rdb_credito.Checked && !rdb_debito.Checked)
            {
                // Ningún RadioButton está seleccionado
                MessageBox.Show("Por favor, seleccione una opción de pago.");
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbx_nombre.Text, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1\s]+$"))
            {
                MessageBox.Show("Ingrese valores válidos. Nombre ", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtbx_correo.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Ingrese valores válidos. Email incorrecto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbx_telefono.Text, @"^[\d+]+$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtbx_codigoSeg.Text, @"^[\d+]+$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtbx_noTarjeta.Text, @"^[\d+]+$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtbx_nit.Text, @"^[\d+]+$"))
            {
                MessageBox.Show("Ingrese valores válidos. Telefono o cvv ingreso numeros", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(txtbx_noTarjeta.Text) || string.IsNullOrEmpty(txtbx_codigoSeg.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InsertarAsientosSeleccionados();
                string numeroTarjeta = txtbx_noTarjeta.Text;
                string mesExpiracion = cb_mes.SelectedItem.ToString();
                string anoExpiracion = cb_ano.SelectedItem.ToString();
                string mesFormateado = mesExpiracion.PadLeft(2, '0');
                string fechaExpiracion = $"{anoExpiracion}-{mesFormateado}-01";
                string cvv = txtbx_codigoSeg.Text;
                string nombreTitular = txtbx_nombre.Text;
                string tipoTarjeta = rdb_credito.Checked ? "Credito" : "Debito";
                string estado = "Activo";

                // Encriptar el CVV
                string cvvEncriptado = BCrypt.Net.BCrypt.HashPassword(cvv);

                int idEmpleado = Convert.ToInt32(cb_empleados.SelectedValue);
                DateTime fechaHora = DateTime.Now;
                string metodoPago = "Tarjeta " + (rdb_credito.Checked ? "Credito" : "Debito");

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar y actualizar o insertar tarjeta
                    string checkQuery = "SELECT ID_Tarjeta FROM tbl_tarjeta WHERE Numero_Tarjeta = @numeroTarjeta";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                        object result = checkCommand.ExecuteScalar();

                        if (result != null)
                        {
                            string updateQuery = "UPDATE tbl_tarjeta SET Fecha_Expiracion = @fechaExpiracion, CVV = @cvv, Nombre_Titular = @nombreTitular, Tipo_Tarjeta = @tipoTarjeta, Estado_tbl_tarjeta = @estado WHERE Numero_Tarjeta = @numeroTarjeta";
                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@fechaExpiracion", fechaExpiracion);
                                updateCommand.Parameters.AddWithValue("@cvv", cvvEncriptado);
                                updateCommand.Parameters.AddWithValue("@nombreTitular", nombreTitular);
                                updateCommand.Parameters.AddWithValue("@tipoTarjeta", tipoTarjeta);
                                updateCommand.Parameters.AddWithValue("@estado", estado);
                                updateCommand.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO tbl_tarjeta (Numero_Tarjeta, Fecha_Expiracion, CVV, Nombre_Titular, Tipo_Tarjeta, Estado_tbl_tarjeta, FK_ID_Cliente) VALUES (@numeroTarjeta, @fechaExpiracion, @cvv, @nombreTitular, @tipoTarjeta, @estado, @idCliente)";
                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                                insertCommand.Parameters.AddWithValue("@fechaExpiracion", fechaExpiracion);
                                insertCommand.Parameters.AddWithValue("@cvv", cvvEncriptado);
                                insertCommand.Parameters.AddWithValue("@nombreTitular", nombreTitular);
                                insertCommand.Parameters.AddWithValue("@tipoTarjeta", tipoTarjeta);
                                insertCommand.Parameters.AddWithValue("@estado", estado);
                                insertCommand.Parameters.AddWithValue("@idCliente", idCliente);

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }

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

                    // Insertar en tbl_venta y tbl_factura
                    string insertVentaQuery = "INSERT INTO tbl_venta (FK_ID_Empleado, Fecha_Hora, Metodo_Pago, Monto_Total) VALUES (@idEmpleado, @fechaHora, @metodoPago, @montoTotal)";
                    using (MySqlCommand insertVentaCommand = new MySqlCommand(insertVentaQuery, connection))
                    {
                        insertVentaCommand.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        insertVentaCommand.Parameters.AddWithValue("@fechaHora", fechaHora);
                        insertVentaCommand.Parameters.AddWithValue("@metodoPago", metodoPago);
                        insertVentaCommand.Parameters.AddWithValue("@montoTotal", Venta);

                        insertVentaCommand.ExecuteNonQuery();

                        long ventaId = insertVentaCommand.LastInsertedId;
                        numeroFactura = GenerarNumeroFactura();

                        string insertFacturaQuery = "INSERT INTO tbl_factura (FK_ID_Reservacion, FK_ID_Venta, Fecha, NumeroFactura) VALUES (@reservacionId, @ventaId, @fecha, @numeroFactura)";
                        using (MySqlCommand insertFacturaCommand = new MySqlCommand(insertFacturaQuery, connection))
                        {
                            foreach (var asiento in asientosSeleccionados)
                            {
                                int idAsiento = ObtenerIDAsiento(asiento.fila, asiento.numero);
                                if (idAsiento == -1)
                                {
                                    MessageBox.Show($"Asiento {asiento.fila}{asiento.numero} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                string reservacionQuery = "SELECT ID_Reservacion FROM tbl_reservacion WHERE Fk_ID_Asiento = @asientoId";
                                using (MySqlCommand reservacionCommand = new MySqlCommand(reservacionQuery, connection))
                                {
                                    reservacionCommand.Parameters.AddWithValue("@asientoId", idAsiento);
                                    object reservacionId = reservacionCommand.ExecuteScalar();
                                    if (reservacionId == null)
                                    {
                                        MessageBox.Show($"No se encontró reserva para el asiento {asiento.fila}{asiento.numero}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    insertFacturaCommand.Parameters.Clear();
                                    insertFacturaCommand.Parameters.AddWithValue("@reservacionId", reservacionId);
                                    insertFacturaCommand.Parameters.AddWithValue("@ventaId", ventaId);
                                    insertFacturaCommand.Parameters.AddWithValue("@fecha", fechaHora);
                                    insertFacturaCommand.Parameters.AddWithValue("@numeroFactura", numeroFactura);

                                    insertFacturaCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                    MessageBox.Show("Boletos comprados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerarFacturaPDF();
                    FormsCliente.CarteleraNueva formCartelera = new FormsCliente.CarteleraNueva(idCliente);
                    formCartelera.Show();
                    timer.Stop();
                    this.Close();
                }
        catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante el proceso de pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormsCliente.CarteleraNueva formCartelera = new FormsCliente.CarteleraNueva(idCliente);


            formCartelera.Show();
            timer.Stop();
            this.Close();
            timer.Stop();
        }

        private void txtTj_Leave(object sender, EventArgs e)
        {
          
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int ObtenerNumeroSala(int idProyeccion)
        {
            int numeroSala = -1; 

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                string query = @"
            SELECT s.Numero_Sala
            FROM tbl_proyeccion p
            JOIN tbl_sala s ON p.FK_ID_Sala = s.ID_Sala
            WHERE p.ID_Proyeccion = @idProyeccion";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idProyeccion", idProyeccion);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    numeroSala = Convert.ToInt32(result);
                }
            }

            return numeroSala;
        }

        private void GenerarFacturaPDF()
        {
            int venta = Venta;
            int descuento = descu;
            string metodoPago = "Tarjeta " + (rdb_credito.Checked ? "Credito" : "Debito");
            DateTime fechaHora = DateTime.Now;
            int idEmpleado = Convert.ToInt32(cb_empleados.SelectedValue);

            string nombrec = txtbx_nombre.Text;


            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pdfDirectory = Path.Combine(downloadsPath, "Descargas");

            if (!Directory.Exists(pdfDirectory))
            {
                Directory.CreateDirectory(pdfDirectory);
            }

            string pdfFileName = $"Factura_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string pdfPath = Path.Combine(pdfDirectory, pdfFileName);

            string numsala = Convert.ToString(ObtenerNumeroSala(idproyeccion));

            try
            {
                using (Document document = new Document(PageSize.A4))
                {
                    PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
                    document.Open();

                    Paragraph title = new Paragraph("Factura de Compra")
                    {
                        Alignment = Element.ALIGN_CENTER,
                        Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20)
                    };
                    document.Add(title);

                    Paragraph dateParagraph = new Paragraph($"Fecha: {DateTime.Now:dd MMMM yyyy}")
                    {
                        Alignment = Element.ALIGN_RIGHT,
                        Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
                    };
                    document.Add(dateParagraph);

                    Paragraph correlativo = new Paragraph($"CORRELATIVO : {numeroFactura}")
                    {
                        Alignment = Element.ALIGN_LEFT,
                        Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
                    };
                    document.Add(correlativo);
                    document.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(2)
                    {
                        WidthPercentage = 100
                    };
                    table.SetWidths(new float[] { 1f, 2f });

                    table.AddCell("Nombre del Cliente:");
                    table.AddCell(nombrec);

                    table.AddCell("NIT:");
                    table.AddCell(txtbx_nit.Text);

                    table.AddCell("Nombre de la Película:");
                    table.AddCell(nPelicula);

                    table.AddCell("Horario:");
                    table.AddCell(horario);

                    table.AddCell("Monto Total:");
                    table.AddCell(venta.ToString());

                    table.AddCell("Descuento:");
                    table.AddCell(descuento.ToString());

                    table.AddCell("Método de Pago:");
                    table.AddCell(metodoPago);
                    if (cb_empleados.Enabled == true)
                    {
                        table.AddCell("ID Empleado:");
                        table.AddCell(idEmpleado.ToString());
                    }
                    table.AddCell("Sala:");
                    table.AddCell(numsala);

                    table.AddCell("Asientos Seleccionados:");
                    PdfPCell seatsCell = new PdfPCell();
                    foreach (var asiento in asientosSeleccionados)
                    {
                        seatsCell.AddElement(new Paragraph($"{asiento.fila}{asiento.numero}"));
                    }
                    table.AddCell(seatsCell);

                    document.Add(table);

                    document.Close();
                }

                Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura en PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int GenerarNumeroFactura()
        {
            int numeroFactura = -1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

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
                            numeroFactura = 1; 
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
        private void BuscarNombrePorCorreo()
        {
            string correo = txtbx_correo.Text.Trim();

            if (string.IsNullOrEmpty(correo))
            {
                txtbx_nombre.Text = string.Empty;
                return;
            }

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string consulta = "SELECT Nombre FROM tbl_empleado WHERE Email = @correo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@correo", correo);

                        object resultado = comando.ExecuteScalar();

                        if (resultado != null)
                        {
                            cb_nombreEmpleado.Text = resultado.ToString();
                        }
                        else
                        {
                            cb_nombreEmpleado.Enabled = false;
                            cb_nombreEmpleado.Text = "No se encontró el empleado";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el empleado: " + ex.Message);
                }
            }
        }
        private void txtCorreo_TextChanged_1(object sender, EventArgs e)
        {
            BuscarNombrePorCorreo();
        }

        private void txtNomEmple_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_ano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

//CODIGO CREADO POR JOSUE CACAO Y BRAYAN HERNANDEZ Y JOSE VICTOR CASTELLANOS