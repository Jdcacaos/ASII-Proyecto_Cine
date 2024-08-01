using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoAS2TaquillaCine.Cartelera.cs
{
    public partial class Cartelera : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public Cartelera()
        {
            InitializeComponent();
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {

        }

    }
}
