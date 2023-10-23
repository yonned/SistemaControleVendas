using MySql.Data.MySqlClient;
using Sistema_Controle_Vendas.br.com.projeto.conexao;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Controle_Vendas.br.com.projeto.dao
{
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        public void cadastraritem(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal) values (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conexao.Open(); // Abra a conexão antes de executar a inserção
                executacmd.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show("O erro foi: " + erro);
            }
            finally
            {
                conexao.Close(); // Feche a conexão no bloco finally para garantir que ela seja liberada corretamente
            }
        }
    }
}
