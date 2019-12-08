using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeNotas.Models;

namespace SistemaDeNotas.Controllers
{
    public class NotaController : Controller
    {
        private Repositorio.NotaRepositorio _notaRepositorio;
        private Repositorio.AlunoRepositorio _alunoRepositorio;

        public NotaController(List<Nota> notas, List<Aluno> alunos)
        {
            _notaRepositorio = new Repositorio.NotaRepositorio(notas);
            _alunoRepositorio = new Repositorio.AlunoRepositorio(alunos);
        }
        public IActionResult Notas()
        {
            var notas = _notaRepositorio.todasNotas();
            var alunos = _alunoRepositorio.todosAlunos();
            ViewData["alunos"] = alunos;
            return View(notas);
        }
        [HttpPost]
        public IActionResult AddNotas(Nota nota)
        {
            _notaRepositorio.Add(nota);
            
            return RedirectToAction(nameof(Notas));
        }

        [HttpGet]
        public IActionResult AddNotas()
        {
            List<Aluno> alunos = _alunoRepositorio.todosAlunos();
            ViewData["alunos"] = alunos;
            return View();
        }

        [Route("Nota/Index/{id}")]
        public IActionResult Index(string id)
        {
            Aluno aluno = _alunoRepositorio.todosPorId(id);
            Nota nota = _notaRepositorio.notasIDAluno(id);
            nota.media = calculaMedia(nota, aluno);
            return View(nota);
        }
        public decimal calculaMedia(Nota nota, Aluno aluno)
        {
            decimal media = nota.Nota1 + nota.Nota2 + nota.Nota3 + nota.Nota4;
            media = media /4;

            if(media < 7)
            {
                aluno.Status = "Reprovado";
            }
            else
            {
                aluno.Status = "Aprovado";
            }
            return media;
        }
    }
}