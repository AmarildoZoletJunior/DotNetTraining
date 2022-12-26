using MinimalApiCatalogo.DTO;
using System.Text.Json.Serialization;
using Flunt.Notifications;
using FluentValidation;

namespace MinimalApiCatalogo.Models
{
    public class Categoria : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        [JsonIgnore]
        public ICollection<Produto>? Produtos { get; set; }


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
}
