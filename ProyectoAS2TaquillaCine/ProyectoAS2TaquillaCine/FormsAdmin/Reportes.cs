using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    public partial class Reportes : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;

        public Reportes()
        {
            InitializeComponent();
            // Asociar eventos para validar fechas
            dtp_inidio.ValueChanged += dtp_Inicio_ValueChanged;
            dtp_final.ValueChanged += dtp_Final_ValueChanged;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // Cargar datos inicialmente con el rango de fechas predeterminado
            dtp_inidio.Value = DateTime.Now.AddMonths(-1); // Por ejemplo, últimos 30 días
            dtp_final.Value = DateTime.Now;
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Obtener las fechas seleccionadas
            DateTime Inicio = dtp_inidio.Value.Date;
            DateTime Final = dtp_final.Value.Date;

            // Asegurarse de que fechaFinal incluya el final del día
            Final = Final.AddHours(23).AddMinutes(59).AddSeconds(59);
            // Verificar que las fechas son válidas
            if (dtp_inidio.Value > dtp_final.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string consulta = @"
                SELECT * 
                FROM tbl_venta 
                WHERE Fecha_Hora BETWEEN @Inicio AND @Final";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conn);
                adaptador.SelectCommand.Parameters.AddWithValue("@Inicio", dtp_inidio.Value.Date);
                adaptador.SelectCommand.Parameters.AddWithValue("@Final", dtp_final.Value.Date.AddDays(1).AddTicks(-1)); // Hasta el final del día

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Asignar el DataTable al DataGridView
                dgv_ganancias.DataSource = dt;

                // Calcular la suma de la columna Monto_Total
                decimal totalMonto = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Monto_Total"] != DBNull.Value)
                    {
                        totalMonto += Convert.ToDecimal(row["Monto_Total"]);
                    }
                }

                // Mostrar la suma en la Label
                lb_total.Text = $"Total: {totalMonto:C}";
            }
        }
        private void btn_generareporte_Click(object sender, EventArgs e)
        {
            // Verificar si el DataGridView está vacío
            if (dgv_ganancias.Rows.Count == 0 || (dgv_ganancias.Rows.Count == 1 && dgv_ganancias.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay datos para generar el reporte. Por favor, carga los datos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaInicio = dtp_inidio.Value;
            DateTime fechaFinal = dtp_final.Value;

            GenerarFacturaPDF(fechaInicio, fechaFinal);
        }



        private void GenerarFacturaPDF(DateTime fechaInicio, DateTime fechaFinal)
        {
            // Obtener la ruta de la carpeta de "Escritorio"
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfDirectory = Path.Combine(desktopPath, "Reportes");

            // Asegúrate de que el directorio existe
            if (!Directory.Exists(pdfDirectory))
            {
                Directory.CreateDirectory(pdfDirectory);
            }

            string pdfFileName = $"Ganancias_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string pdfPath = Path.Combine(pdfDirectory, pdfFileName);

            try
            {
                // Crear un documento PDF
                using (Document document = new Document(PageSize.A4))
                {
                    PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
                    document.Open();

                    // Añadir título
                    Paragraph title = new Paragraph("Reporte de Ventas")
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
                    document.Add(new Paragraph("\n"));

                    // Añadir fechas de inicio y fin
                    Paragraph fechaInicioParagraph = new Paragraph($"Fecha de Inicio: {fechaInicio:dd MMMM yyyy}")
                    {
                        Alignment = Element.ALIGN_LEFT,
                        Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
                    };
                    document.Add(fechaInicioParagraph);

                    Paragraph fechaFinalParagraph = new Paragraph($"Fecha de Fin: {fechaFinal:dd MMMM yyyy}")
                    {
                        Alignment = Element.ALIGN_LEFT,
                        Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
                    };
                    document.Add(fechaFinalParagraph);

                    document.Add(new Paragraph("\n"));

                    // Crear una tabla para los datos
                    PdfPTable table = new PdfPTable(dgv_ganancias.Columns.Count)
                    {
                        WidthPercentage = 100
                    };

                    // Añadir encabezados
                    foreach (DataGridViewColumn column in dgv_ganancias.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText));
                    }

                    // Añadir filas
                    foreach (DataGridViewRow row in dgv_ganancias.Rows)
                    {
                        if (row.IsNewRow) continue;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                        }
                    }

                    // Añadir la tabla al documento
                    document.Add(table);

                    // Añadir el total al final del PDF
                    Paragraph totalParagraph = new Paragraph($"{lb_total.Text}")
                    {
                        Alignment = Element.ALIGN_RIGHT,
                        Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)
                    };
                    document.Add(new Paragraph("\n"));
                    document.Add(totalParagraph);

                    document.Close();
                }

                // Abrir el PDF automáticamente después de generarlo
                Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte en PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral newMenu = new FormsAdmin.MenuGeneral();
            newMenu.Show();
            this.Close();
        }

        private void dtp_Inicio_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
            if (dtp_inidio.Value > dtp_final.Value)
            {
                dtp_final.Value = dtp_inidio.Value;
            }
        }

        private void dtp_Final_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
            if (dtp_final.Value < dtp_inidio.Value)
            {
                dtp_final.Value = dtp_inidio.Value;
            }
        }
    }
}


