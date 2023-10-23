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
using System.Windows.Forms;
using Sistema_Controle_Vendas.br.com.projeto.dao;

namespace Sistema_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
        {
            InitializeComponent();
        }

        public void btnnovo_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtcomplemento.Clear();
            txtnumero.Clear();
            txtcelular.Clear();
            txtemail.Clear();
            txtcidade.Clear();
            txtcep.Clear();
            txtendereco.Clear();
            txtbairro.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //Botão salvar:

            Fornecedor obj = new Fornecedor();
            obj.Nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.Email = txtemail.Text;
            obj.Celular = txtcelular.Text;
            obj.CEP = txtcep.Text;
            obj.Endereco = txtendereco.Text;
            obj.Numero = txtnumero.Text;
            obj.Complemento = txtcomplemento.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.Text;

            // Criar o objeto correspondente a classe FornecedorDAO:
            FornecedorDAO dao = new FornecedorDAO();    
            dao.cadastrarFornecedor(obj);

            // Data Grid View ATT:
            tabelafornecedor.DataSource = dao.listarFornecedores();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            
            obj.codigo = int.Parse(txtcodigo.Text);

            // Criar o objeto correspondente a classe FornecedorDAO:
            FornecedorDAO dao = new FornecedorDAO();
            dao.excluirFornecedor(obj);

            // Data Grid View ATT:
            tabelafornecedor.DataSource = dao.listarFornecedores();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            Fornecedor obj = new Fornecedor();
            obj.Nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.Email = txtemail.Text;
            obj.Celular = txtcelular.Text;
            obj.CEP = txtcep.Text;
            obj.Endereco = txtendereco.Text;
            obj.Numero = txtnumero.Text;
            obj.Complemento = txtcomplemento.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.Text;

            obj.codigo = int.Parse(txtcodigo.Text);

            // Criar o objeto correspondente a classe FornecedorDAO:
            FornecedorDAO dao = new FornecedorDAO();
            dao.AlterarFornecedor(obj);

            // Data Grid View ATT:
            tabelafornecedor.DataSource = dao.listarFornecedores();
        }

        public void button3_Click(object sender, EventArgs e)

        {
            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedor.DataSource = dao.listarFornecedores();
            MessageBox.Show("Os dados foram atualizados no banco de dados!");
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
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

        private void btnbuscar_Click_1(object sender, EventArgs e)
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

        public void Frmfornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedor.DataSource = dao.listarFornecedores();
            
        }

        private void tabelafornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelafornecedor.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafornecedor.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = tabelafornecedor.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelafornecedor.CurrentRow.Cells[6].Value.ToString();
            txtemail.Text = tabelafornecedor.CurrentRow.Cells[3].Value.ToString();
            txtcelular.Text = tabelafornecedor.CurrentRow.Cells[5].Value.ToString();
            txtendereco.Text = tabelafornecedor.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelafornecedor.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = tabelafornecedor.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelafornecedor.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelafornecedor.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text = tabelafornecedor.CurrentRow.Cells[12].Value.ToString();

            // Clicou no dado, ele arrasta para a primeira página (frmclientes.cs):
             tabfornecedor.SelectedTab = tabPage1;
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            //Botão pesquisar por nome:
            string nome = txtPesquisa.Text;
            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedor.DataSource = dao.BuscarFornecedorPorNome(nome);

            // Se a contagem de linhas for igual à 1 ou 0, ele não encontra ngm ent:
            if (tabelafornecedor.Rows.Count == 1)
            {
                MessageBox.Show("Sinto muito, mas nenhum fornecedor foi encontrado.");
                // Recarregar o nosso gridview (mantendo ele não branco):
                tabelafornecedor.DataSource = dao.listarFornecedores();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Porcentagem indica que nao importa o que tem no começo e o que tem no final, ele vai encontrar tudo que tem nesse meio (txtpesquisa.text)
            string nome = "%" + txtPesquisa.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedor.DataSource = dao.ListarFornecedorPorNome(nome);
        }
    }
    }
