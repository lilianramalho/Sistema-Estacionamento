using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Estacionamento
{
    public partial class Entrada : Form
    {
        public Entrada(String placa)
        {
            InitializeComponent();
            placaEntrada.Text = "Placa: "+placa;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.getConexao();
            String query = "insert into tbCarro" +
                "(modeloCarro , marcaCarro , dataCarro , horaCarro , corCarro , codCliente) values" +
                "(@modelo , @marca , @data , @hora , @cor , @cliente)";


            SqlCommand comando = new SqlCommand(query , conn);
            comando.Parameters.Add(new SqlParameter("@modelo", modeloCarro.Text));
            comando.Parameters.Add(new SqlParameter("@marca", carroCarro.Text));
            comando.Parameters.Add(new SqlParameter("@data", dataCarro.Text));
            comando.Parameters.Add(new SqlParameter("@hora", horaCarro.Text));
            comando.Parameters.Add(new SqlParameter("@cor", corCarro));
            comando.Parameters.Add(new SqlParameter("@cliente", 1));

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboCliente.Items.Add("Avulso");
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
