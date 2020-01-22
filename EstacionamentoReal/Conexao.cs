using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Estacionamento
{
    class Conexao
    {
        public SqlConnection getConexao() {
            String Path = "Server = LAPTOP-G5B656K1/VAN;" + "Database=bdEstacionamento;"+"Integrated Security = SSPI;";
            SqlConnection conn = new SqlConnection(Path);
            conn.Open();
            return conn;
        }

        public void Fechar(SqlConnection conn){
            if(conn!= null){
                conn.Close();
            }
        }
    }
}
