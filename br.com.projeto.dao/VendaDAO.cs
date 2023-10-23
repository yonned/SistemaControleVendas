using MySql.Data.MySqlClient;
using Sistema_Controle_Vendas.br.com.projeto.conexao;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Controle_Vendas.br.com.projeto.dao
{
    public class VendaDAO
    {
        private MySqlConnection conexao;

        // Consultor:
        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método de cadastrar a venda

        public void cadastrarVenda(Vendas obj)
        {
            try
            {
                // Criar o comando sql:

                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes) 
              values (@cliente_id, @data_venda, @total_venda, @obs)";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.obs); 

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda cadastrada!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("O erro foi: " + erro);
            }
        }


        #endregion

        #region Metodo Que Retorna ID da ultima venda:

        public int retornaidultilmavenda()
        {
            try
            {
                int idvenda = 0;

                //
                string sql = @"select max(id) id from tb_vendas";
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                conexao.Open();

                MySqlDataReader rs = executacmdsql.ExecuteReader();

                if (rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                    conexao.Close();
                    
                }
                return idvenda;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro:" + erro);
                conexao.Close();
                return 0;
            }
        }

        #endregion


    }
}
