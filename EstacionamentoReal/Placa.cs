using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Placa : Form
    {

        public Placa()
        {
            InitializeComponent();
            var placa = placaCarro.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.getConexao();

            String placa = placaCarro.Text;

            String query = "select placa from tbCarro where placa = "+placa+"";
            SqlCommand comando = new SqlCommand(query, conn);

            comando.ExecuteNonQuery();
            MessageBox.Show("cadastrado com sucesso!");
            

            var reader = comando.ExecuteReader();

            if (reader.HasRows == false)
            {
                Visible = false;
                Entrada entrada = new Entrada(placaCarro.Text);
                entrada.Show();

                new Conexao().Fechar(conn);
            }
            else
            {

                Visible = false;
                Saida saida = new Saida(placaCarro.Text);
                saida.Show();

                new Conexao().Fechar(conn);
            }
            {

            }
        }
    }
}
