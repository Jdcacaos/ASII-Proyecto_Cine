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

namespace ProyectoAS2TaquillaCine.FormsAdmin
{
    public partial class Salas : Form
    {
        string connectionString = DatabaseConfig.ConnectionString; // Debe ser una cadena de conexión MySQL

        public Salas()
        {
            InitializeComponent();
        }

        private void Salas_Load(object sender, EventArgs e)
        {
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(connectionString);

                // Consulta SQL actualizada para incluir las uniones
                MySqlCommand comando = new MySqlCommand(
                    "SELECT s.*, ts.Tipo, u.Direccion " +
                    "FROM tbl_sala s " +
                    "JOIN tbl_tipo_sala ts ON s.FK_ID_Tipo_Sala = ts.ID_Tipo_Sala " +
                    "JOIN tbl_ubicacion u ON s.FK_ID_Ubicacion = u.ID_Ubicacion", conexionDB);
                comando.CommandType = CommandType.Text;

                conexionDB.Open();

                resultado = comando.ExecuteReader();

                dataTable.Load(resultado);

                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dataTable;

                // Opcional: Ocultar las columnas de ID si ya no se necesitan
                dataGridView1.Columns["FK_ID_Tipo_Sala"].Visible = false;
                dataGridView1.Columns["FK_ID_Ubicacion"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejo de eventos de clic en las celdas del DataGridView (si es necesario)
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}