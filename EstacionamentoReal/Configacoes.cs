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
    public partial class Configacoes : Form
    {
        public Configacoes()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Visible = false;
            MenuInicial menuinicial = new MenuInicial();
            menuinicial.Show();
        }
    }
}
