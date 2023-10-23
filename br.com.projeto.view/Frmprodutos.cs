using Sistema_Controle_Vendas.br.com.projeto.dao;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            // Tudo direto no load da aplicação:
            FornecedorDAO f_dao = new FornecedorDAO();
            // Fazer a listagem de fornecedores usando o FornecedorDAO:
            cbfornecedor.DataSource = f_dao.listarFornecedores();
            // Nome ou CNPJ:
            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaproduto.DataSource = dao.listarprodutos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O ID é " + cbfornecedor.SelectedValue);
        }

        public void btnsalvar_Click(object sender, EventArgs e)
        {
            // Receber todos dados da tela:
            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());


            // Criar objeto DAO

            ProdutoDAO dao = new ProdutoDAO();
            dao.CadastraProduto(obj);

            txtdesc.Clear();
            txtpreco.Clear();
            txtqtd.Clear();

            tabelaproduto.DataSource = dao.listarprodutos();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "1";
        }

        private void tabelafuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void tabelaproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaproduto.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = tabelaproduto.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaproduto.CurrentRow.Cells[2].Value.ToString();
            txtqtd.Text = tabelaproduto.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = tabelaproduto.CurrentRow.Cells[4].Value.ToString();

            tabprodutos.SelectedTab = tabPage1;
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            txtdesc.Clear();
            txtpreco.Clear();
            txtqtd.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Botão de editar:
            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());
            obj.id = int.Parse(txtcodigo.Text);


            // Criar objeto DAO

            ProdutoDAO dao = new ProdutoDAO();
            dao.AlterarProduto(obj);

            // Recarregar o DGV
            tabelaproduto.DataSource = dao.listarprodutos();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // Botão de excluir
            Produto obj = new Produto();

            obj.id = int.Parse(txtcodigo.Text);


            // Criar objeto DAO

            ProdutoDAO dao = new ProdutoDAO();
            dao.ExcluirProduto(obj);

            // Recarregar o DGV
            tabelaproduto.DataSource = dao.listarprodutos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Faz a procura por aproximação no MYSQL:
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();
            tabelaproduto.DataSource = dao.listarprodutospornome(nome);
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
           
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            // Chamar os funcionários:
            Produto p = new Produto();
            ProdutoDAO pdao = new ProdutoDAO();

            // Se apertar enter
            if (e.KeyChar == 13)
            {
                p = pdao.RetornaProdutoPorCodigo(int.Parse(txtcodigo.Text));
                txtdesc.Text = p.descricao;
                txtpreco.Text = p.preco.ToString();
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
