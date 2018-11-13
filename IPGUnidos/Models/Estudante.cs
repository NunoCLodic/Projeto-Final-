using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Estudante : Usuario
    {
        public int estudanteID { get; set; }
        public int nif { get; set; }
        public string curso { get; set; }
        public string escola { get; set; }
        public int ano { get; set; }
        public Residencia residenciaID { get; set; }
    }
}
