using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estacionamento
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            exibir();
        }

        private void exibir() {
            SqlConnection conn = new Conexao().getConexao();
            String sql = "select * from tbCliente";
            SqlCommand comando = new SqlCommand(sql , conn);
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            adp.Fill(table);
            dataGridView1.DataSource = table;
            new Conexao().Fechar(conn);

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Visible = false;
            MenuInicial menuinicial = new MenuInicial();
            menuinicial.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Conexao conn = new Conexao();
            SqlConnection conexao = conn.getConexao();
            String query = "insert into tbCliente" +
                "(nomeCliente , cpfCliente , rgCliente , logradouroCliente , numeroResidenciaCliente , cidadeCliente) values" +
                "(@nomecliente , @cpfcliente  , @rgcliente ,  @logradourocliente , @numeroresidenciacliente , @cidadecliente)";

            SqlCommand comando = new SqlCommand(query, conexao);
            comando.Parameters.Add(new SqlParameter("@nomecliente", nomecliente.Text));
            comando.Parameters.Add(new SqlParameter("@cpfcliente", cpfcliente.Text));
            comando.Parameters.Add(new SqlParameter("@rgcliente", rgcliente.Text));
            comando.Parameters.Add(new SqlParameter("@logradourocliente", logradourocliente.Text));
            comando.Parameters.Add(new SqlParameter("@numeroresidenciacliente", numerorescliente.Text));
            comando.Parameters.Add(new SqlParameter("@cidadecliente", cidadecliente.Text));

            comando.ExecuteNonQuery();
            MessageBox.Show("cadastrado com sucesso!");
            conn.Fechar(conexao);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
