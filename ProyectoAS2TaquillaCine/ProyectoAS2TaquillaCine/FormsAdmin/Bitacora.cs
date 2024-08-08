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

namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    public partial class Bitacora : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;


        public Bitacora()
        {
            InitializeComponent();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarBitacora()
        {
            string query = "SELECT ID_Auditoria, Tabla, Accion, Datos_Antiguos, Datos_Nuevos, Fecha, Usuario FROM tbl_bitacora";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            var dataTable = new DataTable();
                            dataTable.Load(reader);

                            dgv_bitacora.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la bitácora: " + ex.Message);
                }
            }
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
