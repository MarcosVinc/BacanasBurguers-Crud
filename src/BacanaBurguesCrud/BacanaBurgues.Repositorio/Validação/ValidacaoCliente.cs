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
            RuleFor(x => x.Nome).NotNull().NotEmpty().MinimumLength(3).MaximumLength(160);
            RuleFor(x => x.Endereco).NotNull().NotEmpty().MinimumLength(3).MaximumLength(160);
            RuleFor(x => x.Telefone).NotNull().NotEmpty();
            RuleFor(x => x.Cep).NotNull().NotEmpty();

        }
    }
}
