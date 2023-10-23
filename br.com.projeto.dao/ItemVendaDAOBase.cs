using MySql.Data.MySqlClient;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Windows.Forms;

namespace Sistema_Controle_Vendas.br.com.projeto.dao
{
    public class ItemVendaDAOBase
    {
        private MySqlConnection conexao; // Declare a variável de conexão aqui

        public ItemVendaDAOBase(string connectionString)
        {
            conexao = new MySqlConnection(connectionString); // Inicialize a conexão no construtor da classe
        }

        
        
    }
}
