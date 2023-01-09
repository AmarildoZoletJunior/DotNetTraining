using FluentValidation;
using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Services.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Nome).NotEmpty().WithMessage("Por favor, Coloque seu nome").NotNull().WithMessage("Por favor, preencha o campo nome");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Por favor, Coloque seu Email").NotNull().WithMessage("Este campo não pode ser nulo").EmailAddress().WithMessage("Este Email é invalido");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Por favor, Coloque sua senha").NotNull().WithMessage("Este campo não pode ser nulo");

        }
    }
}
