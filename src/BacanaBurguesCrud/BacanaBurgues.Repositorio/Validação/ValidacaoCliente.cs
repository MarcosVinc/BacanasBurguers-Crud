using BacanasBurgues.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanaBurgues.Repositorio.Validação
{
    public class ValidacaoCliente: AbstractValidator <Cliente>
    {
        public ValidacaoCliente()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().MinimumLength(3).MaximumLength(160).WithMessage("Formato do nome esta invalido");
            RuleFor(x => x.Endereco).NotNull().NotEmpty().MinimumLength(3).MaximumLength(160).WithMessage("Formato do endereço esta invalido");
            RuleFor(x => x.Telefone).NotNull().NotEmpty().Matches("[2-9][0-9]{11}").WithMessage("Formato do telefone esta invalido");
            RuleFor(x => x.Cep).NotNull().NotEmpty().WithMessage("Formato do cep esta invalido");

        }
    }
}
