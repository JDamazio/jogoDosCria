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

    }
}