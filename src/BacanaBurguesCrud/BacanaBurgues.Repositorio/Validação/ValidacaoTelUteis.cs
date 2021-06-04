using BacanasBurgues.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanaBurgues.Repositorio.Validação
{
   public class ValidacaoTelUteis : AbstractValidator<TelefonesUteis>
    {
        public ValidacaoTelUteis() 
        {
            RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3).MaximumLength(160);
            RuleFor(x => x.Telefone).NotNull().NotEmpty();
        }
    }
}
