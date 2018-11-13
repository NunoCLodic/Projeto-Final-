using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Senhorio : Usuario
    {
        public int senhorioID { get; set; }
        public Residencia residenciaID { get; set; }

        public ICollection<Residencia> ListaResidenciaSenhorio { get; set; }
    }
}
