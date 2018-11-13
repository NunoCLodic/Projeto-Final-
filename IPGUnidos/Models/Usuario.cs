using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Usuario
    {
        public int usuarioID{ get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Pais { get; set; }
        public int Morada { get; set; }
        public int Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
