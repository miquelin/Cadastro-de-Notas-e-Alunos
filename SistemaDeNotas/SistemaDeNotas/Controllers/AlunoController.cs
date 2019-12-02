using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeNotas.Models;

namespace SistemaDeNotas.Controllers
{
    public class AlunoController : Controller
    {
        private Repositorio.AlunoRepositorio _alunoRepositorio;
        public AlunoController(List<Aluno> alunos)
        {
            _alunoRepositorio = new Repositorio.AlunoRepositorio(alunos);
        }

        public IActionResult Alunos()
        {
            var alunos = _alunoRepositorio.todosAlunos();
            return View(alunos);
        }
        
        [HttpGet]
        public IActionResult AddAlunos()
        {
           
            return View();

        }
        [HttpPost]
        public IActionResult AddAlunos(Aluno aluno)
        {
            _alunoRepositorio.Add(aluno);
            
            return RedirectToAction(nameof(Alunos));
        }

        [Route("Aluno/Index/{id}")]
        public IActionResult Index(string id)
        {
              Aluno aluno = _alunoRepositorio.todosPorId(id);
              return View(aluno);
        }
        

        
    }
}