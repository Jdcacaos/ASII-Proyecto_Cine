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
    public partial class RegistroTaquilla : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public RegistroTaquilla()
        {
            InitializeComponent();
            // Asociar eventos para validar fechas
            dtp_Inicio.ValueChanged += dtp_Inicio_ValueChanged;
            dtp_Final.ValueChanged += dtp_Final_ValueChanged;
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
            if (dtp_Inicio.Value > dtp_Final.Value)
            {
                dtp_Final.Value = dtp_Inicio.Value;
            }
        }

        private void dtp_Final_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
            if (dtp_Inicio.Value > dtp_Final.Value)
            {
                dtp_Final.Value = dtp_Inicio.Value;
            }
        }

        private void RegistroTaquilla_Load(object sender, EventArgs e)
        {
            // Cargar datos inicialmente con el rango de fechas predeterminado
            dtp_Inicio.Value = DateTime.Now.AddMonths(-1); // Por ejemplo, últimos 30 días
            dtp_Final.Value = DateTime.Now;
            CargarDatos();
        }
        private void CargarDatos()
        {
            // Obtener las fechas seleccionadas
            DateTime Inicio = dtp_Inicio.Value.Date;
            DateTime Final = dtp_Final.Value.Date;

            // Asegurarse de que fechaFinal incluya el final del día
            Final = Final.AddHours(23).AddMinutes(59).AddSeconds(59);

            if (dtp_Inicio.Value > dtp_Final.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string consulta = @"
                SELECT 
                        p.titulo AS Nombre_Pelicula,
                         SUM(r.Precio - IFNULL(r.Descuento, 0)) AS Recaudacion_Total
                        FROM 
                        tbl_pelicula p
                        JOIN 
                        tbl_proyeccion pr ON p.ID_Pelicula = pr.FK_ID_Pelicula
                        JOIN 
                        tbl_reservacion r ON pr.ID_Proyeccion = r.FK_ID_Proyeccion
                        WHERE 
                        pr.Fecha BETWEEN @Inicio AND @Final
                        GROUP BY 
                        p.ID_Pelicula
                        ORDER BY 
                        Recaudacion_Total DESC
                        LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conn);
                adaptador.SelectCommand.Parameters.AddWithValue("@Inicio", dtp_Inicio.Value.Date);
                adaptador.SelectCommand.Parameters.AddWithValue("@Final", dtp_Final.Value.Date.AddDays(1).AddTicks(-1)); // Hasta el final del día

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Asignar el DataTable al DataGridView
                dgv_taquilla.DataSource = dt;
            }
        }

        private void btn_generareporte_Click(object sender, EventArgs e)
        {
            // Verificar si el DataGridView está vacío
            if (dgv_taquilla.Rows.Count == 0 || (dgv_taquilla.Rows.Count == 1 && dgv_taquilla.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay datos para generar el reporte. Por favor, carga los datos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaInicio = dtp_Inicio.Value;
            DateTime fechaFinal = dtp_Final.Value;

            GenerarReportePDF(fechaInicio, fechaFinal);
        }




        private void GenerarReportePDF(DateTime fechaInicio, DateTime fechaFinal)
        {
            // Obtener la ruta de la carpeta de "Escritorio"
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfDirectory = Path.Combine(desktopPath, "Reportes");

            // Asegúrate de que el directorio existe
            if (!Directory.Exists(pdfDirectory))
            {
                Directory.CreateDirectory(pdfDirectory);
            }

            string pdfFileName = $"Taquilla_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string pdfPath = Path.Combine(pdfDirectory, pdfFileName);

            try
            {
                // Crear un documento PDF
                using (Document document = new Document(PageSize.A4))
                {
                    PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
                    document.Open();

                    // Añadir título
                    Paragraph title = new Paragraph("Pelicula más taquillera")
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
                    PdfPTable table = new PdfPTable(dgv_taquilla.Columns.Count)
                    {
                        WidthPercentage = 100
                    };

                    // Añadir encabezados
                    foreach (DataGridViewColumn column in dgv_taquilla.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText));
                    }

                    // Añadir filas
                    foreach (DataGridViewRow row in dgv_taquilla.Rows)
                    {
                        if (row.IsNewRow) continue;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                        }
                    }

                    // Añadir la tabla al documento
                    document.Add(table);

                    document.Add(new Paragraph("\n"));

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

    }
}
