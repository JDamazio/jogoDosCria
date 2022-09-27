using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context) =>
            _context = context;

        // GET: /api/user/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Usuario.ToList());

        // POST: /api/user/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] User usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
        }

        // GET: /api/user/buscar/{cpf}
        [HttpGet]
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            User usuario = _context.Usuario.
                FirstOrDefault(f => f.Cpf.Equals(cpf));
            return usuario != null ? Ok(usuario) : NotFound();
        }

        // PATCH: /api/user/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] User usuario)
        {
            try
            {
                _context.Usuario.Update(usuario);
                _context.SaveChanges();
                return Ok(usuario);
            }
            catch
            {
                return NotFound();
            }
        }

        // DELETE: /api/user/deletar/{id}
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            User usuario = _context.Usuario.Find(id);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
                _context.SaveChanges();
                return Ok(usuario);
            }
            return NotFound();
        }
    }
}