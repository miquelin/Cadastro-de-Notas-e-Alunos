using SistemaDeNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeNotas.Repositorio
{
    public class AlunoRepositorio
    {
        private List<Aluno> _alunos;

        public AlunoRepositorio(List<Aluno>listaAlunos)
        {
            _alunos = listaAlunos;
        }
        public void Add(Aluno aluno)
        {
            _alunos.Add(aluno);
        }
        public List<Aluno> todosAlunos()
        {
            return _alunos;
        }
        public Aluno todosPorId(string id)
        {
            var aluno = _alunos.Where(x => x.id.ToString() == id).FirstOrDefault();
            return aluno;
        }
    }
}
