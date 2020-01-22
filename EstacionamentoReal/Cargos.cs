using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Estacionamento
{
    public partial class Cargos : Form
    {
        public Cargos()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Visible = false;
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.getConexao();
            String sql = "insert into tbCargoFuncionario" + "(nomeCargo) values" + "(@nomeCargo)";
            SqlCommand comando = new SqlCommand(sql , conn);
            comando.Parameters.Add(new SqlParameter("@nomeCargo", textBox1.Text));

            comando.ExecuteNonQuery();
            MessageBox.Show("foi");


            
        }
    }
}
