﻿using System;
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
            dtp_inicio.ValueChanged += dtp_Inicio_ValueChanged;
            dtp_final.ValueChanged += dtp_Final_ValueChanged;
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
            if (dtp_inicio.Value > dtp_final.Value)
            {
                dtp_final.Value = dtp_inicio.Value;
            }
        }

        private void dtp_Final_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
            if (dtp_inicio.Value > dtp_final.Value)
            {
                dtp_final.Value = dtp_inicio.Value;
            }
        }

        private void RegistroTaquilla_Load(object sender, EventArgs e)
        {
            // Cargar datos inicialmente con el rango de fechas predeterminado
            dtp_inicio.Value = DateTime.Now.AddMonths(-1); 
            dtp_final.Value = DateTime.Now;
            CargarDatos();
        }
        private void CargarDatos()
        {
            // Obtener las fechas seleccionadas
            DateTime Inicio = dtp_inicio.Value.Date;
            DateTime Final = dtp_final.Value.Date;

            Final = Final.AddHours(23).AddMinutes(59).AddSeconds(59);

            if (dtp_inicio.Value > dtp_final.Value)
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
                adaptador.SelectCommand.Parameters.AddWithValue("@Inicio", dtp_inicio.Value.Date);
                adaptador.SelectCommand.Parameters.AddWithValue("@Final", dtp_final.Value.Date.AddDays(1).AddTicks(-1)); 

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgv_taquilla.DataSource = dt;
            }
        }

        private void btn_generareporte_Click(object sender, EventArgs e)
        {
            if (dgv_taquilla.Rows.Count == 0 || (dgv_taquilla.Rows.Count == 1 && dgv_taquilla.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay datos para generar el reporte. Por favor, carga los datos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaInicio = dtp_inicio.Value;
            DateTime fechaFinal = dtp_final.Value;

            GenerarReportePDF(fechaInicio, fechaFinal);
        }




        private void GenerarReportePDF(DateTime fechaInicio, DateTime fechaFinal)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfDirectory = Path.Combine(desktopPath, "Reportes");

            if (!Directory.Exists(pdfDirectory))
            {
                Directory.CreateDirectory(pdfDirectory);
            }

            string pdfFileName = $"Taquilla_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string pdfPath = Path.Combine(pdfDirectory, pdfFileName);

            try
            {
                using (Document document = new Document(PageSize.A4))
                {
                    PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
                    document.Open();

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

                    PdfPTable table = new PdfPTable(dgv_taquilla.Columns.Count)
                    {
                        WidthPercentage = 100
                    };

                    foreach (DataGridViewColumn column in dgv_taquilla.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText));
                    }
                    foreach (DataGridViewRow row in dgv_taquilla.Rows)
                    {
                        if (row.IsNewRow) continue;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                        }
                    }

                    document.Add(table);

                    document.Add(new Paragraph("\n"));

                    document.Close();
                }

                Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte en PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


//CODIGO CREADO POR JOEL LOPEZ
