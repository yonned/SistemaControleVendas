using Sistema_Controle_Vendas.br.com.projeto.dao;
using Sistema_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmClientes : Form
    {
        private object txtpesquisa;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Mostrar a tabela do banco de dados no gridview:
            
            tabelacliente.DefaultCellStyle.ForeColor = Color.Black;
            ClienteDAO dao = new ClienteDAO();
            tabelacliente.DataSource = dao.listarClientes();


        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // Implementação do cadastro & Receber os dados dentro do objeto:
            Cliente obj = new Cliente();
            obj.codigo = int.Parse(txtcodigo.Text);
            obj.Nome = txtnome.Text;
            obj.RG = txtrg.Text;
            obj.CPF = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.Endereco = txtendereco.Text;
            obj.Numero = txtnumero.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.Text;
            obj.CEP = txtcep.Text;
            obj.Celular = txtcelular.Text;
            obj.Complemento = txtcomplemento.Text;

            // Criar um objetov da classe ClienteDAO e chamar o método (cadastraCliente):
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //Recarregar o gridview:
            tabelacliente.DataSource = dao.listarClientes();

        }

        private void tabelacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Implementação do cadastro & Receber os dados dentro do objeto:
            Cliente obj = new Cliente();
            obj.Nome = txtnome.Text;
            obj.RG = txtrg.Text;
            obj.CPF = txtcpf.Text;
            obj.Email = txtemail.Text;
            obj.Endereco = txtendereco.Text;
            obj.Numero = txtnumero.Text;
            obj.Bairro = txtbairro.Text;
            obj.Cidade = txtcidade.Text;
            obj.Estado = cbuf.Text;
            obj.CEP = txtcep.Text;
            obj.Celular = txtcelular.Text;
            obj.Complemento = txtcomplemento.Text;

            obj.codigo = int.Parse(txtcodigo.Text);

            // Criar um objetov da classe ClienteDAO e chamar o método (alterar):
            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(obj);

            //Recarregar o gridview:
            tabelacliente.DataSource = dao.listarClientes();
        }

        private void tabelacliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar os dados da linha selecionada: De qual coluna? A coluna 0.
            txtcodigo.Text = tabelacliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelacliente.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text     = tabelacliente.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelacliente.CurrentRow.Cells[3].Value.ToString();   
            txtemail.Text = tabelacliente.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelacliente.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelacliente.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelacliente.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelacliente.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = tabelacliente.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelacliente.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelacliente.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelacliente.CurrentRow.Cells[13].Value.ToString();

            // Alterar guia de dados pessoais:
            // Clicou no dado, ele arrasta para a primeira página (frmclientes.cs):
            TabelaClientes.SelectedTab = tabPage1;


        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            // Botão excluir: (Criar o modelo de cliente pra eu receber os dados pro C# executar a tarefa no sql)
            Cliente obj = new Cliente();

            // Pegar o código:
            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(obj);
            

            tabelacliente.DataSource = dao.listarClientes();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Definir a imagem de cada empresa para cada tipo de sistema:
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Definir filtros para tipos de arquivo de imagem
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos (*.*)|*.*";

            // Permitir seleção de apenas um arquivo
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obter o caminho completo do arquivo selecionado
                string caminhoImagem = openFileDialog.FileName;

                // Exibir a imagem na PictureBox
                pictureBox1.Image = Image.FromFile(caminhoImagem);

                // Ajustar o tamanho da imagem de acordo com a PictureBox (opcional)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            //Botão pesquisar por nome:
            string nome = txtPesquisa.Text;
            ClienteDAO dao = new ClienteDAO();
            tabelacliente.DataSource = dao.BuscarClientePorNome(nome);

            // Se a contagem de linhas for igual à 1 ou 0, ele não encontra ngm ent:
            if(tabelacliente.Rows.Count == 0)
            {
                // Recarregar o nosso gridview (mantendo ele não branco):
                tabelacliente.DataSource = dao.listarClientes();
            }

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();
            tabelacliente.DataSource = dao.ListarClientePorNome(nome);

            // Se a contagem de linhas for igual à 1 ou 0, ele não encontra ngm ent:
            if (tabelacliente.Rows.Count == 1)
            {
                // Recarregar o nosso gridview (mantendo ele não branco):
                tabelacliente.DataSource = dao.listarClientes();
            }
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

        private void btnnovo_Click(object sender, EventArgs e, Form frmClientes)
        {
            txtnome.Clear();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            // Limpar os dados correspondentes ao form FRMCLIENTES.CS

            txtnome.Clear();
            txtcodigo.Clear();
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
