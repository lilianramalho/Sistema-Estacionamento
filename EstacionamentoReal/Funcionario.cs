using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estacionamento
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Visible = false;
            MenuInicial menuinicial = new MenuInicial();
            menuinicial.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Cargos cargos = new Cargos();
            cargos.Show();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
