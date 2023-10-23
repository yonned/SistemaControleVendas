using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Controle_Vendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            // Conexão com o banco de dados:
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
