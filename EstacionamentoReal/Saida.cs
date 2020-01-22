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
    public partial class Saida : Form
    {
        public Saida(String placa)
        {
            InitializeComponent();
            placaSaida.Text = "Placa: "+placa;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.getConexao(); 

            String query = "select placa from tbCarro where placa = " + placa + "";
            SqlCommand comando = new SqlCommand(query, conn);

            comando.ExecuteNonQuery();
            MessageBox.Show("cadastrado com sucesso!");
            new Conexao().Fechar(conn);

            var reader = comando.ExecuteReader();

            if (reader.HasRows == false)
            {
                Visible = false;
                Entrada entrada = new Entrada(placaCarro.Text);
                entrada.Show();
            }
            else
            {
                Visible = false;
                Saida saida = new Saida(placaCarro.Text);
                saida.Show();
            }
        }
    }
}
