using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartSchool.API.Controllers
{
   [ApiController]
   [Route("api/[controller]")]

   public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Nelson",
                Sobrenome = "Cassemiro",
                Telefone = "4343242444"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Joao",
                Sobrenome = "Caio",
                Telefone = "4343242444"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Marcos",
                Sobrenome = "Oliveira",
                Telefone = "4343242444"
            },

        };

        public AlunoController() { }

        //api/aluno
        [HttpGet]

        public IActionResult Get()
        {

            return Ok (Alunos);
        }

        //api/aluno/id
        [HttpGet("ById/{id}")]
        // ex: localhost:5000/api/aluno/ById/2
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }

        [HttpGet("ByName")]
        // ex: localhost:5000/api/aluno/ByName?nome=Nelson&sobrenome=Cassemiro
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }

        [HttpPost]
        // ex: localhost:5000/api/aluno
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        // ex: localhost:5000/api/aluno
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        // ex: localhost:5000/api/aluno
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        // ex: localhost:5000/api/aluno
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
