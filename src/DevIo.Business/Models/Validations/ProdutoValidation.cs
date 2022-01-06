﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Business.Models.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} dever ser preenchido")
                .Length(2, 200).WithMessage("O campo {PropertyName} dever conter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.Descricao)
                .NotEmpty().WithMessage("O campo {PropertyName} dever ser preenchido.")
                .Length(2, 1000).WithMessage("O campo {PropertyName} dever conter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(p => p.Valor)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }

    }
}