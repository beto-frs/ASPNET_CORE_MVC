using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_View_Controller.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        
        public string Nome { get; set; }
        
        public string Sobrenome { get; set; }
        
        public string CPF { get; set; }

        public int idade { get; set; }

        public string Telefone { get; set; }
    }
}
