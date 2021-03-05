using Manager.Core.Exceptions;
using System.Collections.Generic;
using Manager.Domain.Validators;


namespace Manager.Domain.Entities
{
    public class User : Base
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
      

        //EF
        protected User() { }

        public User(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            _errors = new List<string>();

            Validate();
        }

        public void ChangeName(string nome)
        {
            Nome = nome;
            Validate();
        }

        public void ChangeSenha(string senha)
        {
            Senha = senha;
            Validate();
        }

        public void ChangeEmail(string email)
        {
            Email = email;
            Validate();
        }


        public override bool Validate()
        {
            var validator = new UserValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var error in  validation.Errors)
                _errors.Add(error.ErrorMessage);

                throw new DomainException("Alguns campos estão invalidos, por favor corrija-os!" , _errors);
            }

            return true;
        }



    }
}