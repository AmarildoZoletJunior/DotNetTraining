using FluentValidation;
using MinimalApiCatalogo.Models;

namespace MinimalApiCatalogo.Validators
{
    public class CategoriaValidation : AbstractValidator<Categoria>
    {
        public CategoriaValidation()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo1");
            RuleFor(x => x.Descricao).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo1");
            RuleFor(x => x.Id).NotNull().NotEmpty();

        }
    }
}
