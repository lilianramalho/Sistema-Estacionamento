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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Funcionario funcionarios = new Funcionario();
            funcionarios.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Visible = false;
            EntradaESaida carros = new EntradaESaida();
            carros.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Visible = false;
            Configacoes configuracoes = new Configacoes();
            configuracoes.Show();
        }
    }
}
