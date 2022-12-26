using FluentValidation;
using MinimalApiCatalogo.Models;

namespace MinimalApiCatalogo.Validators
{
    public class CategoriaValidation : AbstractValidator<Categoria>
    {
        public CategoriaValidation()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage("Nome obrigatorio").Must(x => x.Length > 5 && x.Length < 10).WithMessage("Este campo tem que conter mais de 5 caracteres");
            RuleFor(x => x.Descricao).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo1");
            RuleFor(x => x.Id).NotNull().NotEmpty();

        }
    }
}
