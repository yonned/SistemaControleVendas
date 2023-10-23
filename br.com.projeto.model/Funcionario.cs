using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Controle_Vendas.br.com.projeto.model
{

    // Utilizamos a herança da class Cliente:
    public class Funcionario : Cliente
    {
        // Criar os atributos, getter e setter:
        public string senha { get; set; }
        public string Cargo { get; set; }
        public string nivel_acesso { get; set; }
    }
}
