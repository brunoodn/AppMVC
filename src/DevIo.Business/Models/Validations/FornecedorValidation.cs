using DevIo.Business.Models.Validations.Documentos;
using DevIo.Business.Models.Validations.Documentos.DevIO.Business.Models.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {

        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecedido")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () => 
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("o campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");
                    
                RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("O Documento fornecidó é inválido");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () => 
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("o campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");

                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                    .WithMessage("O Documento fornecidó é inválido");
            });
        }
    }
}
