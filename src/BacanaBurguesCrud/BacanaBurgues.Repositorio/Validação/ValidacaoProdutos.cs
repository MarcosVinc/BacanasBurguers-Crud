using BacanasBurgues.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanaBurgues.Repositorio
{
    public class ValidacaoProdutos : AbstractValidator<Produto>
    {
         public ValidacaoProdutos() 
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().MinimumLength(3).MaximumLength(160);
            RuleFor(x => x.Tipo).NotNull().NotEmpty();
            RuleFor(x => x.Quantidade).NotNull().NotEmpty();
            RuleFor(x => x.Preco).NotNull().NotEmpty();
            RuleFor(x => x.Lucro).NotNull().NotEmpty();
        }
    }
}
