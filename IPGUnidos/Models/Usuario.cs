using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Usuario
    {
        public int usuarioID{ get; set; }

        [Required(ErrorMessage = "Por Favor Insira seu Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por Favor Insira seu Telefone")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Por Favor Insira seu País")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Por Favor Insira a sua Morada")]
        public int Morada { get; set; }

        [Required(ErrorMessage = "Por Favor Insira seu Email")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Por Favor Insira um Email Valido")]
        public int Email { get; set; }

        [Required(ErrorMessage = "Por Favor Insira sua Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
