using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class EntradaESaida : Form
    {
        public EntradaESaida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Placa placa = new Placa();
            placa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            Placa placa = new Placa();
            placa.Show();
        }
    }
}
