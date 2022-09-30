using System;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/nivel")]
    public class NivelController : ControllerBase
    {
        private readonly DataContext _context;
        public NivelController(DataContext context) =>
            _context = context;

        // GET: /api/nivel/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Nivel.ToList());

        // POST: /api/nivel/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Nivel nivel)
        {
            _context.Nivel.Add(nivel);
            _context.SaveChanges();
            return Created("", nivel);
        }

    }
}