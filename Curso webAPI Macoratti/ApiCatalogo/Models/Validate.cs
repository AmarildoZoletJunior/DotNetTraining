using FluentValidation;

namespace ApiCatalogo.Models
{
    public class Validate : AbstractValidator<Categoria>
    {
        public Validate()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("nome obg")
                    .Must(x => x.Length > 10 && x.Length < 15)
                    .WithMessage("nome menor que 10 ou maior que 15");
        }
    }
}
