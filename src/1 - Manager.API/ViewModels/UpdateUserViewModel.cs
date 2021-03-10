using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.API.ViewModels
{
    public class UpdatedViewModel
    {
        [Required(ErrorMessage = "O ID não pode tar vazio.")]
        [Range(1, int.MaxValue, ErrorMessage = "O ID deve ter no minimo 1 caracteres.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome não pode estar nulo.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no minimo 3 caracteres.")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no maximo 80 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email nao pode estar vazio.")]
        [MinLength(10, ErrorMessage = "O email deve ter no minimo 10 caracteres.")]
        [MaxLength(180, ErrorMessage = "O email deve ter no maximo 180 caracteres")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                ErrorMessage = "Email Invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha não pode estar vazia.")]
        [MinLength(5, ErrorMessage = "A senha deve ter no minimo 5 caracteres")]
        [MaxLength(30, ErrorMessage = "A senha deve ter no maximo 30 caracteres.")]
        public string Senha { get; set; }
    }
}
