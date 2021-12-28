using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIo.App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("Fornecedor")]
        public Guid FornecedorId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O campo {0} é obrigatório.", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required]
        [StringLength(100, ErrorMessage = "O campo {0} é obrigatório.", MinimumLength = 2)]
        public string Descricao { get; set; }

        public IFormFile ImagemUpload { get; set; }
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
        public FornecedorViewModel Fornecedor { get; set; }
    }
}
