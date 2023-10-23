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
    public partial class Frmvendas : Form
    {

        // Objetos de CLiente e ClienteDAO:
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        // Objetos de produto:
        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        // Variáveis:
        int qtd;
        decimal preco;
        decimal subtotal, total;

        // Carrinho:
        DataTable carrinho = new DataTable();

        public Frmvendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));


            tabelaProdutos.DataSource = carrinho;

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtquantidade.Text);
                preco = decimal.Parse(txtpreco.Text);

                subtotal = qtd * preco;
                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdesc.Text, qtd, preco, subtotal);
                txttotal.Text = total.ToString();
                txtdesc.Clear();
                txtcodigo.Clear();
                txtcodigo.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Digite o código do produto!" + erro);
            }
        }



        private void btnremover_Click(object sender, EventArgs e)
        {
            /* Botão remover item:
            int indice = tabelaProdutos.CurrentRow.Index;
            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
            DataRow linha = carrinho.Rows[indice];
            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;

            txttotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso!");

            if(indice == " ")
            {
                return Frmvendas;
            }
            */

            if (tabelaProdutos.CurrentRow != null)
            {
                int indice = tabelaProdutos.CurrentRow.Index;
                decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
                DataRow linha = carrinho.Rows[indice];
                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();

                total -= subproduto;

                txttotal.Text = total.ToString();

                MessageBox.Show("Item removido do carrinho com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um item na tabela de produtos para remover do carrinho.");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Chamada dos funcionários:
            //Cliente cliente = new Cliente();
            //ClienteDAO cdao = new ClienteDAO();

            // Se ele apertou "enter":
           if(e.KeyChar == 13)
            {
                 cliente = cdao.retornaClientePorCpf(txtcpf.Text);
                if(cliente != null)
                {
                    txtnome.Text = cliente.Nome;
                }
                else
                {
                    // Limpeza e focus // Deixa o lugar piscando, apaga e retorna:
                    txtcpf.Clear();
                    txtcpf.Focus();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtqtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Produto p = new Produto();
            ProdutoDAO pdao = new ProdutoDAO();            
            

            if(e.KeyChar == 13)
            {
                p = pdao.RetornaProdutoPorCodigo(int.Parse(txtcodigo.Text));

                if(p != null)
                {
                    txtdesc.Text = p.descricao;
                    txtpreco.Text = p.preco.ToString();
                    txtquantidade.Text = p.qtdestoque.ToString();
                }
                else
                {
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
            }
            
        }

        private void tabelaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(txtdata.Text);
            Frmpagamentos tela = new Frmpagamentos(cliente, carrinho, dataatual);

            // Passar o total pra tela de pagamentos: (modifier public)
            tela.txttotal.Text = total.ToString();


            tela.ShowDialog();
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            // Pegando a data atual;
            txtdata.Text = DateTime.Now.ToShortDateString();
        }
    }
}
