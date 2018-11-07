using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Estudante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public string Pais { get; set; }
        public int Escola { get; set; }
    }
}
