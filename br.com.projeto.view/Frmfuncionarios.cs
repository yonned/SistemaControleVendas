using Sistema_Controle_Vendas.br.com.projeto.dao;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.listarfuncionarios();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtcelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {

            string nome = txtPesquisa.Text;

            // Chamada do funcionárioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            
            // Criação e atribuição do datatable com a busca de funcionários por nome (método)
            DataTable dtFuncionarios = dao.BuscafuncionariosPorNome(nome);


            // Se o datatablefuncionarios for maior que 0 o código se concreta.
            if (dtFuncionarios.Rows.Count > 0)
            {
                tabelafuncionario.DataSource = dtFuncionarios;
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado! Atualizando a página!");
                tabelafuncionario.DataSource = dao.listarfuncionarios();
            }


        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // Implementação do botão salvar:
            Funcionario obj = new Funcionario();

            // Receber os dados dos campos:
            obj.Nome = txtnome.Text;
            obj.RG = txtrg.Text;
            obj.CPF = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.senha = txtSenha.Text;
            obj.nivel_acesso = cbnivel.SelectedItem?.ToString(); // Utilizando o operador "?." para evitar exceção se o item selecionado for nulo
            obj.Celular = txtcelular.Text;
            obj.CEP = txtcep.Text;
            obj.Endereco = txtendereco.Text;
            obj.Numero = txtnumero.Text;
            obj.Complemento = txtcomplemento.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.SelectedItem?.ToString(); // Utilizando o operador "?." para evitar exceção se o item selecionado for nulo
            obj.Cargo = cbcargo.SelectedItem?.ToString(); // Utilizando o operador "?." para evitar exceção se o item selecionado for nulo


            // Criar o objeto FUNCIONARIODAO:   
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.Cadastrarfuncionario(obj);
            tabelafuncionario.DataSource = dao.listarfuncionarios();
        }

        private void txtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Botão para pesquisar o CEP:
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";
                DataSet dados = new DataSet();

                // Ler o XML
                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Dados não encontrados. Por favor digite manualmente!");
            }
        }

        private void tabelafuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar informação e passar pro data grid view:
            txtcodigo.Text = tabelafuncionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafuncionario.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelafuncionario.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelafuncionario.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelafuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = tabelafuncionario.CurrentRow.Cells[5].Value.ToString();
            cbcargo.Text = tabelafuncionario.CurrentRow.Cells[6].Value.ToString();
            cbnivel.Text = tabelafuncionario.CurrentRow.Cells[7].Value.ToString();
            txtcelular.Text = tabelafuncionario.CurrentRow.Cells[8].Value.ToString();
            txtcep.Text = tabelafuncionario.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = tabelafuncionario.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelafuncionario.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = tabelafuncionario.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = tabelafuncionario.CurrentRow.Cells[14].Value.ToString();
            cbuf.Text = tabelafuncionario.CurrentRow.Cells[15].Value.ToString();
            tabfuncionario.SelectedTab = tabPage1;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Botão excluir:
            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(txtcodigo.Text);
            
            // Criação da função:
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.DeletarFuncionario(obj);

            tabelafuncionario.DataSource = dao.listarfuncionarios();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Implementação do botão salvar:
            Funcionario obj = new Funcionario();

            // Receber os dados dos campos:
            obj.Nome = txtnome.Text;
            obj.RG = txtrg.Text;
            obj.CPF = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.senha = txtSenha.Text;
            obj.nivel_acesso = cbnivel.SelectedItem?.ToString(); // Utilizando o operador "?." para evitar exceção se o item selecionado for nulo
            obj.Celular = txtcelular.Text;
            obj.CEP = txtcep.Text;
            obj.Endereco = txtendereco.Text;
            obj.Numero = txtnumero.Text;
            obj.Complemento = txtcomplemento.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.SelectedItem?.ToString(); // Utilizando o operador "?." para evitar exceção se o item selecionado for nulo
            obj.Cargo = cbcargo.SelectedItem?.ToString(); // Utilizando o operador "?." para evitar exceção se o item selecionado for nulo
            obj.codigo = int.Parse(txtcodigo.Text);

            // Criar o objeto FUNCIONARIODAO:   
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);

            tabelafuncionario.DataSource = dao.listarfuncionarios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Chama novamente a função de listar funcionário no datagridview
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.listarfuncionarios();
            MessageBox.Show("Os dados foram atualizados no banco de dados!");
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Porcentagem indica que nao importa o que tem no começo e o que tem no final, ele vai encontrar tudo que tem nesse meio (txtpesquisa.text)
            string nome = "%" + txtPesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.listarfuncionariospornome(nome);
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            // Limpar os dados correspondentes ao form FRMCLIENTES.CS

            txtnome.Clear();
            txtrg.Clear();
            txtcomplemento.Clear();
            txtnumero.Clear();
            txtcelular.Clear();
            txtcpf.Clear();
            txtemail.Clear();
            txtcidade.Clear();
            txtcep.Clear();
            txtendereco.Clear();
            txtbairro.Clear();

            MessageBox.Show("Pronto, limpinho.");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    }

