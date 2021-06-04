using BacanasBurgues.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanaBurgues.Repositorio.Validação
{
   public class ValidacaoUsuario : AbstractValidator<Usuario>
    {
        public ValidacaoUsuario()
        {
            RuleFor(x => x.Login).NotEmpty().NotNull().MinimumLength(3).MaximumLength(160);
            RuleFor(x => x.Senha).NotNull().NotEmpty();
        }
    }
}
