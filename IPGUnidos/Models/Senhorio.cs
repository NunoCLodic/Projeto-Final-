using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Senhorio : Pessoa
    {
        public int SenhorioID { get; set; }
        public Residencia IDResidencia { get; set; }

        public ICollection<Residencia> ListaResidenciaSenhorio { get; set; }
    }
}
