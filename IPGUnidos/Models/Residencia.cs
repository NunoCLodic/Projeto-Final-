using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGUnidos.Models
{
    public class Residencia
    {
        public int residenciaID { get; set; }
        public Senhorio senhorioID { get; set; }
        public Estudante estudanteID { get; set; }
        public string morada { get; set; }
        public int codPostal { get; set; }
        public int nQuartos { get; set; }
        public int nCama { get; set; }
        public int nsalas { get; set; }
        public int nvaranda { get; set; }
        public int ndespensa { get; set; }
        public int ncasaBanho { get; set; }
        public int nGaragem { get; set; }
        public int nSoton { get; set; }
        public int nCozinha { get; set; }
        public double preco { get; set; }
        public string cor { get; set; }
        public Boolean vaga { get; set; }
        public Boolean mobilhado { get; set; }

        public ICollection<Estudante> ListaEstudantesResidencia { get; set; }
    }
}
