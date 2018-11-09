using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Estudante : Pessoa
    {
        public int EstudanteID { get; set; }
        public int Nif { get; set; }
        public string Curso { get; set; }
        public string Escola { get; set; }
        public int Ano { get; set; }
        public Residencia IDResidencia { get; set; }
    }
}
