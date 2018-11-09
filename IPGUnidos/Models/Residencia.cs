using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Residencia
    {
        public int ResidenciaID { get; set; }
        public Senhorio SenhorioID { get; set; }
        public string Morada { get; set; }
        public int CodPostal { get; set; }
        public int NQuartos { get; set; }
        public int NCama { get; set; }
        public int Nsalas { get; set; }
        public int Nvaranda { get; set; }
        public int Ndespensa { get; set; }
        public int NcasaBanho { get; set; }
        public int NGaragem { get; set; }
        public int NSoton { get; set; }
        public int NCozinha { get; set; }
        public double Preco { get; set; }
        public string Cor { get; set; }
        public Boolean Vaga { get; set; }
        public Boolean Mobilhado { get; set; }

        public ICollection<Estudante> ListaEstudantesResidencia { get; set; }
    }
}
