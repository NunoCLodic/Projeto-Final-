using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Administrador : Pessoa
    {
        public int AdministradorID { get; set; }
        public int Escola { get; set; }
    }
}
