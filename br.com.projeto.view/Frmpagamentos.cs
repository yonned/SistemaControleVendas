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
    public partial class Frmpagamentos : Form
    {
        // Atribuição de classes: (imports)
        Cliente Cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;

        // Os parametros devem ser seguidos
        public Frmpagamentos(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {
            InitializeComponent();
            this.Cliente = cliente;
            this.carrinho = carrinho;
            this.dataatual = dataatual;
        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {
            //Carregar a tela:
            txttroco.Text = "0,00";
            txtdinheiro.Text = "0,00";
            txtcartao.Text = "0,00";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            // Botão finalizar venda:
            try
            {
                // Dinheiro e pagamento:
                decimal v_dinheiro, v_cartao, troco, totalpago,total;

                // Estoque:
                int qtd_estoque, qtd_comprada, estoque_atualizado;
                ProdutoDAO dao_produto = new ProdutoDAO();

                v_dinheiro = decimal.Parse(txtdinheiro.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                totalpago = v_dinheiro + v_cartao;
                troco = totalpago - total;

                Vendas venda = new Vendas();

                //venda.cliente_id = Cliente.codigo;
                //venda.cliente_id = 14;
                venda.cliente_id = this.Cliente.codigo;
                venda.data_venda = dataatual;
                venda.total_venda = total;
                venda.obs = txtobs.Text;

                VendaDAO vdao = new VendaDAO();
                txttroco.Text = troco.ToString();

                vdao.cadastrarVenda(venda);

                // Cadastrar os itens da venda:

                // Laço de repetição, onde irá percorrer pelos itens do carrinho.
                // Cada item irá gravar o dados de uma linha dentro da variável linha:
                foreach(DataRow linha in carrinho.Rows)
                {                                                                                         
                    ItemVenda item = new ItemVenda();
                    item.venda_id = vdao.retornaidultilmavenda();
                    item.produto_id = int.Parse(linha["Código"].ToString());
                    item.qtd = int.Parse(linha["Qtd"].ToString());
                    item.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                    // Baixa no estoque:
                    qtd_estoque = dao_produto.retornaestoqueatual(item.produto_id);
                    qtd_comprada = item.qtd;
                    estoque_atualizado = qtd_estoque - qtd_comprada;

                    dao_produto.baixaestoque(item.produto_id, estoque_atualizado);
                            


                    ItemVendaDAO itemdao = new ItemVendaDAO();
                    itemdao.cadastraritem(item);
                }

                MessageBox.Show("Venda finalizada com sucesso!");
                this.Dispose();

                new Frmvendas().ShowDialog();
                
                
                


                // Condições:
                if(totalpago < total)
                {
                    MessageBox.Show("O total valor pago é menor que o valor total da venda");
                }
                else
                {
                    venda.cliente_id = Cliente.codigo;
                    venda.data_venda = dataatual;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Deu erro em " + error);
                throw;
            }

            
        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
