using SistemaDeNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeNotas.Repositorio
{
    public class NotaRepositorio
    {
        private List<Nota> _notas;

        public NotaRepositorio(List<Nota> listaNotas)
        {
            _notas = listaNotas;
        }
        public void Add(Nota nota)
        {
            _notas.Add(nota);
        }
        public List<Nota> todasNotas()
        {
            return _notas;
        }

        public Nota notasIDAluno(string id)
        {
            var nota = _notas.Where(x => x.IdAluno.ToString() == id).FirstOrDefault();
            return nota;
        }

       
    }
}
