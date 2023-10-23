using MySql.Data.MySqlClient;
using Sistema_Controle_Vendas.br.com.projeto.conexao;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Controle_Vendas.br.com.projeto.dao
{
    public class FornecedorDAO
    {
        // Conexão SQL:
        private MySqlConnection conexao;

        // Consultor:
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                // Definir o comando SQL: (INSERT INTO)
                string sql = @"insert into tb_fornecedores (nome,cnpj,email,telefone,celular
                             ,endereco,numero,complemento,bairro,cidade,estado,cep)values
                             (@nome,@cnpj,@email,@telefone,@celular
                             ,@endereco,@numero,@complemento,@bairro,@cidade,@estado,@cep)";

                // Organizar o comando SQL:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@Nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.CEP);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);


                // Executar o comando SQL: (Abrir e executar conexão)

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                // Sempre fechar conexão no final:
                conexao.Close();
            }
            
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                throw;
            }
        }
        
        // Método para listar fornecedores
       public DataTable listarFornecedores()
            {
                try
                {
                    // Criar o DataTable e o comando SQL:
                    DataTable tabelafornecedor = new DataTable();
                    string sql = "select * from tb_fornecedores";

                    // Organizar os comandos e executá-los:
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelafornecedor);

                    // Sempre fechar conexão no final:
                    conexao.Close();
                    return tabelafornecedor;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro no SQL!");
                    return null;
                }

            }

        #region Método alterar o fornecedor:

        public void AlterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"update tb_fornecedores set nome = @nome, cnpj = @cnpj, email = @email, telefone = @telefone, celular = @celular,
                       numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@Nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.CEP);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu um erro" + erro);
                throw;
            }
        }

        public void excluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"delete from tb_fornecedores where id = @id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso!");

                conexao.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Deu um erro" + error);
                throw;
            }
        }


        #endregion
        public DataTable ListarFornecedorPorNome(string nome)
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelafornecedor;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }

        }


        public DataTable BuscarFornecedorPorNome(string nome)
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome = @nome";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelafornecedor;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }

        }


    }




}

