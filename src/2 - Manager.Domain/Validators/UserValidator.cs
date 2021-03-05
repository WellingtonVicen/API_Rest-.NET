using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
             .NotEmpty()
             .WithMessage("A entidade não pode estar vazia.")

             .NotNull()
             .WithMessage("A entidade não pode estar ser Nula");

            RuleFor(x => x.Nome)
                .NotNull()
                .WithMessage("O nome não pode estar nulo.")

                .NotEmpty()
                .WithMessage("O nome não pode estar Vazio.")

               .MinimumLength(3)
               .WithMessage("O nome deve ter no minimo 3 caracteres.")

               .MaximumLength(80)
               .WithMessage("O nome deve ter no maximo 80 caracteres");

            RuleFor(x => x.Email)
               .NotNull()
               .WithMessage("O email nao pode estar nulo.")

               .NotEmpty()
               .WithMessage("O email nao pode estar vazio.")

               .MinimumLength(10)
               .WithMessage("O email deve ter no minimo 10 caracteres")

               .MaximumLength(180)
               .WithMessage("O email deve ter no maximo 180 caracteres")

               .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
               .WithMessage("O email informado não é valido.");

            RuleFor(x => x.Senha)
               .NotNull()
               .WithMessage("A senha não pode estar nula.")

               .NotEmpty()
               .WithMessage("A senha não pode estar vazia.")

               .MinimumLength(5)
               .WithMessage("A senha deve ter no minimo 5 caracteres")

               .MaximumLength(30)
               .WithMessage("A senha deve ter no maximo 30 caracteres.");   
        }
    }
}