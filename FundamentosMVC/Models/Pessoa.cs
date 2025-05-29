using System.ComponentModel.DataAnnotations;

namespace FundamentosMVC.Models
{
    public class Pessoa
    {
        [Display(Name = "Código do CLiente")]

        public int ? PessoaId { get; set; }

        [Display(Name = "Nome do Cliente")]

        public string ? Nome { get; set; }
        public string ? Email { get; set; }
    }
}
