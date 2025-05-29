using System.ComponentModel.DataAnnotations;

namespace FundamentosMVC.Models
{
    public class Pessoa
    {
        [Display(Name = "Código do CLiente")]

        public int ? PessoaId { get; set; }

        [Display(Name = "Nome do Cliente")]

        public string ? Nome { get; set; }

        [Display(Name = "Email do Cliente")]

        [EmailAddress(ErrorMessage = "Endereço de email invalido")]
        public string ? Email { get; set; }
    }
}
