﻿using System;
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
    public partial class Proveedor : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        
        int selectedProveedorId = -1; 
       
        public Proveedor()
        {
            InitializeComponent();
            dgv_productores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tmr_timer1 = new Timer();
            tmr_timer1.Interval = 100; 
            tmr_timer1.Tick += new EventHandler(tmr_timer1_Tick);
            tmr_timer1.Start(); // Iniciar el Timer
            btn_editar.Visible = GlobalSettings.IsAdmin;
            btn_eliminar.Visible = GlobalSettings.IsAdmin;
            gpb_ingresar.Visible = GlobalSettings.IsAdmin;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsAdmin.MenuGeneral MenuForm = new FormsAdmin.MenuGeneral();
            MenuForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return; 
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_proveedor_pelicula (nombre) VALUES (@Nombre)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                    CargarProveedores();  // Actualizar los datos en el DataGridView después de insertar un nuevo registro.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el proveedor: " + ex.Message);
                }
            }
        }

        private void CargarProveedores()
            {
                string query = "SELECT ID_proveedor, nombre FROM tbl_proveedor_pelicula";

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

                                dgv_productores.DataSource = dataTable;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
                    }
                }
            }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private bool datosCorrectos()
        {
            if (string.IsNullOrWhiteSpace(txtbx_nombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!datosCorrectos())
            {
                return; 
            }

            if (dgv_productores.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_productores.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_productores.Rows[selectedRowIndex];
                int idProveedor = Convert.ToInt32(selectedRow.Cells["ID_proveedor"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas editar este registro?", "Confirmar edición", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "UPDATE tbl_proveedor_pelicula SET nombre = @Nombre WHERE ID_proveedor = @ID_proveedor";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                                command.Parameters.AddWithValue("@ID_proveedor", idProveedor);

                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Registro actualizado exitosamente.");
                            CargarProveedores(); 
                            LimpiarCampos(); 
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error de base de datos: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha producido un error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un productor para editar.");
            }
        }

        private void LimpiarCampos()
        {
            txtbx_nombre.Text = string.Empty;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_productores.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgv_productores.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_productores.Rows[selectedRowIndex];
                int idProveedor = Convert.ToInt32(selectedRow.Cells["ID_proveedor"].Value);

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_proveedor_pelicula WHERE ID_proveedor = @ID_proveedor";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_proveedor", idProveedor);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Registro eliminado exitosamente.");
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el registro para eliminar.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                        }
                    }
                    CargarProveedores();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void txtbxBuscar_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtbx_buscar.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {

                (dgv_productores.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                return;
            }


            List<string> filterExpressions = new List<string>();


            DataTable dataTable = dgv_productores.DataSource as DataTable;


            foreach (DataColumn column in dataTable.Columns)
            {

                if (column.DataType == typeof(string))
                {

                    filterExpressions.Add($"[{column.ColumnName}] LIKE '%{searchText}%'");
                }
            }


            string filterExpression = string.Join(" OR ", filterExpressions);


            (dgv_productores.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void UpdateDateTimeLabel()
        { 
            DateTime now = DateTime.Now;

            string dateTimeText = now.ToString("yyyy-MM-dd HH:mm:ss"); 

            lb_tiempoSys.Text = dateTimeText;
        }

        private void tmr_timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return; 
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_proveedor_pelicula (nombre) VALUES (@Nombre)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtbx_nombre.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro completado exitosamente.");
                    CargarProveedores(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el proveedor: " + ex.Message);
                }
            }
        }
    }
    }


//CODIGO CREADO POR JOSUE CACAO

