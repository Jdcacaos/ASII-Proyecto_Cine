<<<<<<< HEAD
﻿using System;
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

<<<<<<< HEAD
        private void button4_Click(object sender, EventArgs e)
        {
            FormsCliente.Reserva formReserva = new FormsCliente.Reserva();
            formReserva.Show();
            this.Hide();
        }
=======
        private void Cartelera_Load(object sender, EventArgs e)
        {

        }

>>>>>>> d0ca6f15de6bfbc3f2c8c3463d85476367b33b26
    }
}
=======
﻿using System;
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

<<<<<<< HEAD
        private void button4_Click(object sender, EventArgs e)
        {
            FormsCliente.Reserva formReserva = new FormsCliente.Reserva();
            formReserva.Show();
            this.Hide();
        }
=======
        private void Cartelera_Load(object sender, EventArgs e)
        {

        }

>>>>>>> d0ca6f15de6bfbc3f2c8c3463d85476367b33b26
    }
}
>>>>>>> 5c43817564edecd27c4406aeb1729dacf07823b0
