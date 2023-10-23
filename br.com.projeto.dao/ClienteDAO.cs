using MySql.Data.MySqlClient;
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
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        // Consultor:
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region CadastrarCliente
        // Método para cadastrar o cliente:
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                // Definir o comando SQL: (INSERT INTO)
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular
                             ,endereco,numero,complemento,bairro,cidade,estado,cep)values
                             (@nome,@rg,@cpf,@email,@telefone,@celular
                             ,@endereco,@numero,@complemento,@bairro,@cidade,@estado,@cep)";

                // Organizar o comando SQL:
                MySqlCommand executacmd = new MySqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@Nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
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

                MessageBox.Show("Cliente cadastrado com sucesso!");
                // Sempre fechar conexão no final:
                conexao.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                throw;
            }
        }
        #endregion



        #region ListarCliente
        // Listar os clientes no datagrid:
        public DataTable listarClientes()
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelacliente;
               

            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null; 
            }
        }
        #endregion

        #region AlterarCliente
        // Método para alterar o cliente:
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                // Definir o comando SQL: (update (exemplo) set (nome=@nome) por seu ID.
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular
                             ,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado,cep=@cep
                             where id=@id";

                // Organizar o comando SQL:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@Nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
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
                MessageBox.Show("Cliente alterado com sucesso!");
                // Sempre fechar conexão no final:
                conexao.Close();



            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                throw;
            }
        }


        #endregion

        #region ExcluirCliente
        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                // Definir o comando SQL: (update (exemplo) set (nome=@nome) por seu ID.
                string sql = @"delete from tb_clientes where id = @id";

                // Organizar o comando SQL:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@Nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
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

                MessageBox.Show("Cliente excluído com sucesso!");
                
                // Sempre fechar conexão no final:
                conexao.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                throw;
            }
        }

        #endregion

        #region BuscarClientePorNome
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome = @nome";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelacliente;


            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }
        }
        #endregion

        #region ListarClientePorNome
        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                // Criar o DataTable e o comando SQL:
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Criar o arquivo MySqlAdapter para preencher os dados no DT:
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                // Sempre fechar conexão no final:
                conexao.Close();
                return tabelacliente;


            }
            catch (Exception)
            {
                MessageBox.Show("Erro no SQL!");
                return null;
            }
        }
        #endregion

        #region Método que retorna um cliente por CPF:
        public Cliente retornaClientePorCpf(string cpf)
        {
            try
            {
                // Criar comando SQL e objeto que vai retornar (cliente):
                Cliente obj = new Cliente();
                string sql = @"SELECT * FROM tb_clientes WHERE cpf = @cpf";

                // Organizar os comandos e executá-los:
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();

                // Ele vai executar o sql, pq retorna um só.
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    obj.codigo = rs.GetInt32("id");
                    obj.Nome = rs.GetString("nome");
                }

                else
                {
                    MessageBox.Show("CPF Inválido");
                }

                conexao.Close(); // Sempre fechar conexão no final.

                return obj;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu um problema no clientedao!");
                throw;
            }
        }


        #endregion

    }
}
