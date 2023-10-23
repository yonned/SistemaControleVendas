using MySql.Data.MySqlClient;
using Sistema_Controle_Vendas.br.com.projeto.conexao;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sistema_Controle_Vendas.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;
        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Funcionario
        public void Cadastrarfuncionario(Funcionario obj)
        {
            try
            {
                // Criando comando sql:
                string sql = "INSERT INTO tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, celular, cep, endereco, numero, complemento, bairro, cidade, estado, telefone, id) " +
             "VALUES (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @telefone, @id)";

                // Executa os comandos:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.CEP);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                // Executar o comando SQL: (Abrir e executar conexão)

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                
                // Sempre fechar conexão no final:
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro.Message);
                throw;
            }
            #endregion
        }


        #region ListarFuncionarios
        public DataTable listarfuncionarios()
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelafuncionario;


            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }
        }

        #endregion


        #region AlterarFuncionario

        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "UPDATE tb_funcionarios SET nome = @nome, rg = @rg, cpf = @cpf, email = @email,senha = @senha, cargo = @cargo, nivel_acesso = @nivel, celular = @celular, cep = @cep,endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro,cidade = @cidade, estado = @estado, telefone = @telefone WHERE id = @codigo";
        
        using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                {
                    executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                    executacmd.Parameters.AddWithValue("@rg", obj.RG);
                    executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
                    executacmd.Parameters.AddWithValue("@email", obj.Email);
                    executacmd.Parameters.AddWithValue("@senha", obj.senha);
                    executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                    executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                    executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                    executacmd.Parameters.AddWithValue("@cep", obj.CEP);
                    executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                    executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                    executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                    executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                    executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                    executacmd.Parameters.AddWithValue("@estado", obj.Estado);
                    executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                    executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o funcionário: " + erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        #region ExcluirFuncionario
        public void excluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "delete from tb_funcionarios where id = @codigo";

                using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                {
                    
                    executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionário excluído com sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o funcionário: " + erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        #endregion

        #endregion

        #region ExcluirFuncionario
        public void DeletarFuncionario(Funcionario obj)
        {
            try
            {
                // Faz o update do funcionário:
                string sql = "delete from tb_funcionarios where id = @codigo";

                // Executa os comandos:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);


                // Executar o comando SQL: (Abrir e executar conexão)

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluído com sucesso!");

                // Sempre fechar conexão no final:
                conexao.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Teve algum erro!" + erro);
                throw;
            }
        }
        #endregion
        #region Metodo ListarFuncionarioPorNome
        public DataTable BuscafuncionariosPorNome(string nome)
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelafuncionario;


            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }
        }
        #endregion

        #region MetodoListaFuncionariosPorNome
        public DataTable listarfuncionariospornome(string nome)
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelafuncionario;


            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }
        }
        #endregion
        #region Método para listar os fornecedores:

        #endregion
    }
}

