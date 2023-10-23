using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Sistema_Controle_Vendas.br.com.projeto.conexao;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Controle_Vendas.br.com.projeto.dao
{
    public class ProdutoDAO
    {

        private MySqlConnection conexao;
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método Cadastrar Produto

        public void CadastraProduto(Produto obj)
        {
            try
            {
                // Criar o SQL:
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes) values (@cliente_id, @data_venda, @total_venda, @obs)";


                // Organização:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                // Abrir conexão:
                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Show! Produto cadastrado com sucesso!");

                conexao.Close();





            }
            catch (Exception erro)
            {
                MessageBox.Show("Infelizmente ocorreu um erro " + erro);
                throw;
            }
        }

        #endregion

        #region ExcluirProduto
        public void ExcluirProduto(Produto obj)
        {
            try
            {
                // Criar o SQL:
                string sql = @"delete from tb_produtos where id = @id";


                // Organização:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                // Abrir conexão:
                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Show! Produto excluído com sucesso!");

                conexao.Close();





            }
            catch (Exception erro)
            {
                MessageBox.Show("Infelizmente ocorreu um erro " + erro);
                throw;
            }
        }

        #endregion

        #region ExcluirProduto
        public void AlterarProduto(Produto obj)
        {
            try
            {
                // Criar o SQL:
                string sql = @"UPDATE tb_produtos set descricao= @descricao, preco= @preco, qtd_estoque= @qtd, for_id= @for_id where id = @id";


                // Organização:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                // Abrir conexão:
                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Show! Produto alterado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Infelizmente ocorreu um erro " + erro);
                throw;
            }
        }
        #endregion


        #region Método ListarProdutos
        public DataTable listarprodutos()
        {
            try
            {
                try
                {
                    // Criar o DataTable e o comando SQL:
                    DataTable tabelaproduto = new DataTable();
                    string sql = @"SELECT 
                    tb_produtos.id AS 'Código',
                    tb_produtos.descricao AS 'Descrição',
                    tb_produtos.preco AS 'Preço',
                    tb_produtos.qtd_estoque AS 'Qtd/Estoque',
                    tb_fornecedores.nome AS 'Fornecedor'
                FROM tb_produtos
                JOIN tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id";

                    // Organizar os comandos e executá-los:
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    conexao.Open();

                    // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelaproduto);

                    // Sempre fechar conexão no final:
                    conexao.Close();
                    return tabelaproduto;
                }
                catch (Exception ex)
                {
                    // Lidar com exceções, se necessário.
                    Console.WriteLine("Erro: " + ex.Message);
                    return null;
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }
        }
        #endregion

        #region ListarProdutosPorNome
        public DataTable listarprodutospornome(string nome)
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelaproduto = new DataTable();
                string sql = @"SELECT 
                    tb_produtos.id AS 'Código',
                    tb_produtos.descricao AS 'Descrição',
                    tb_produtos.preco AS 'Preço',
                    tb_produtos.qtd_estoque AS 'Qtd/Estoque',
                    tb_fornecedores.nome AS 'Fornecedor'
                FROM tb_produtos
                JOIN tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id
                WHERE tb_produtos.descricao LIKE @nome;";


                // Organizar os comandos e executá-los:

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();


                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaproduto);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelaproduto;


            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }
        }
        #endregion

        #region BuscarProdutoPorNome
        public DataTable buscarprodutospornome(string nome)
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                try
                {
                    // Criar o DataTable e o comando SQL:
                    DataTable tabelaproduto = new DataTable();
                    string sql = @"SELECT 
                    tb_produtos.id AS 'Código',
                    tb_produtos.descricao AS 'Descrição',
                    tb_produtos.preco AS 'Preço',
                    tb_produtos.qtd_estoque AS 'Qtd/Estoque',
                    tb_fornecedores.nome AS 'Fornecedor'
                FROM tb_produtos
                JOIN tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id
                WHERE tb_produtos.descricao = @nome;";

                    // Organizar os comandos e executá-los:
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", nome);
                    conexao.Open();

                    // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelaproduto);

                    // Sempre fechar conexão no final:
                    conexao.Close();
                    return tabelaproduto;
                }
                catch (Exception ex)
                {
                    // Lidar com exceções, se necessário.
                    Console.WriteLine("Erro: " + ex.Message);
                    return null;
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }
        }
        #endregion

        #region Método que retorna produto por código
            public Produto RetornaProdutoPorCodigo(int id)
        {
            try
            {
                // Comando
                string sql = @"select * from tb_produtos where id = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                // Vai encontrar e armazenar
                if (rs.Read())
                {
                    Produto p = new Produto();
                    p.id = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");

                    conexao.Close();
                    return p;

                }

                else
                {
                    MessageBox.Show("Ish, deu erro aqui na aba de retornar por ID");
                    return null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ish, deu erro aqui na aba de retornar por ID" + erro);
              
                throw;
            }
        }
        #endregion

        #region Método que baixa o estoque quando usado
        public void baixaestoque(int idproduto, int qtdestoque)
        {
            try
            {
                // Criar o comando sql:
                string sql = @"update tb_produtos set qtd_estoque=@qtd where id = @id";

                // Executar o comando sql:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@qtd", qtdestoque);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                // Abrir conexão:
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                throw;
            }
        }
        #endregion

        #region Método que retorna o estoque atual de um produto
        public int retornaestoqueatual(int idproduto)
        {
            try
            {
                string sql = @"select qtd_estoque from tb_produtos where id = @id";
                int qtd_estoque = 0;
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", idproduto);
                conexao.Open();

                

                MySqlDataReader rs = executacmd.ExecuteReader();
                if(rs.Read())
                {
                    qtd_estoque = rs.GetInt32("qtd_estoque");
                    conexao.Close();
                }

                return qtd_estoque;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return 0;
                throw;
            }
        }
        #endregion


    }
}
