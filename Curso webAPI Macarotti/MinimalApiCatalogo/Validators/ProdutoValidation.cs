using FluentValidation;
using MinimalApiCatalogo.Models;

namespace MinimalApiCatalogo.Validators
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo1");
            RuleFor(x => x.Descricao).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo2");
            RuleFor(x => x.Preco).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo3");
            RuleFor(x => x.ImagemI).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo4");
            RuleFor(x => x.Estoque).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo5");
            RuleFor(x => x.CategoriaId).NotNull().NotEmpty().WithMessage("Este campo não pode ser nulo6");
        }
    }
}
