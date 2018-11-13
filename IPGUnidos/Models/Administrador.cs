using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Administrador : Usuario
    {
        public int administradorID { get; set; }
        public string funcao { get; set; }
        public DateTime entrada { get; set; }
        public int escola { get; set; }
    }
}
