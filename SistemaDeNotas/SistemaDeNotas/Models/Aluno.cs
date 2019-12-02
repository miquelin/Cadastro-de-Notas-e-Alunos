using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeNotas.Models
{
    public class Aluno : Pessoa
    {
        public Guid id { get; set; }
        public int TurmaId { get; set; }
        public string Status { get; set; }
        public int Faltas { get; set; }
        public bool? Desistente { get; set; }
        public Aluno()
        {
            id = Guid.NewGuid();
        }
    }
}
