using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O login não pode estar vazio.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A Senha não pode estar vazia.")]
        public string Senha { get; set; }




    }
}