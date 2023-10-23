using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Vendas.br.com.projeto.model
{
    public class Produto : Fornecedor
    {
        // Atributos, getters e setters:
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int qtdestoque { get; set; }

        public int for_id { get; set; }
        public Fornecedor fornecedor { get; set; }
    }
}
