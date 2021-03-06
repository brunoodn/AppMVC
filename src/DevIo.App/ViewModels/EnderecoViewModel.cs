using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace DevIo.App.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(200, MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(20, MinimumLength = 2)]
        public string Numero { get; set; }

        [StringLength(500, MinimumLength = 2)]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(8, MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(200, MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(200, MinimumLength = 2)]
        public string Estado { get; set; }

        [HiddenInput]
        public Guid FornecedorId { get; set; }
    }
}
