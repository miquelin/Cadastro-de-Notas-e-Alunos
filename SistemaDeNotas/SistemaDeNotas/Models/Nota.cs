using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeNotas.Models
{
    public class Nota
    {
        public string IdAluno { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Nota4 { get; set; }
        public decimal media { get; set; }
        
    }
}
