using System;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/personagem")]
    public class PersonagemController : ControllerBase
    {
        private readonly DataContext _context;
        public PersonagemController(DataContext context) =>
            _context = context;

        // GET: /api/personagem/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Personagens.ToList());

        // POST: /api/personagem/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Personagem personagem)
        {
            personagem.Nivel = _context.Nivel.Find(personagem.NivelId);
            personagem.User = _context.Usuario.Find(personagem.UserId);
            _context.Personagens.Add(personagem);
            _context.SaveChanges();
            return Created("", personagem);
        }

        // DELETE: /api/personagem/deletar/{id}
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Personagem personagem = _context.Personagens.Find(id);
            if (personagem != null)
            {
                _context.Personagens.Remove(personagem);
                _context.SaveChanges();
                return Ok(personagem);
            }
            return NotFound();
        }

         // PATCH: /api/personagem/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Personagem personagem)
        {
            try
            {
                _context.Personagens.Update(personagem);
                _context.SaveChanges();
                return Ok(personagem);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}