using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tgamerApi.Data;
using tgamerApi.Dto;
using tgamerApi.Models;

namespace tgamerApi.Controllers
{
    [ApiController]
    [Route("api/v1/Conquistas")]
    public class ConquistasController : Controller
    {
        private DataContext _context;

        public ConquistasController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost("{id:int}")]
        public Conquistas Create(int id, Conquistas conquista)
        {
            conquista.UsuarioId = id;

            var newconquista = new Conquistas(conquista);

            _context.Conquistas.Add(newconquista);
            _context.SaveChanges();

            return newconquista;
        }

        //[HttpGet("{id:int}")]
        //public Usuario GetById(int id)
        //{
        //    var result = _context.Usuarios.FirstOrDefault(u => u.Id == id);
        //    return result;
        //}

        [HttpGet]
        public List<Conquistas> GetConquistas()
        {
            return _context.Conquistas.ToList();
        }

        //[HttpPut("{id:int}")]
        //public Usuario PutUsuario(int id, Usuario usuario)
        //{
        //    usuario.Id = id;
        //    _context.Update(usuario);
        //    _context.SaveChanges();
        //    return usuario;
        //}

        //[HttpDelete("{id:int}")]
        //public Usuario DeleteUsuario(int id)
        //{
        //    var result = _context.Usuarios.FirstOrDefault(u => u.Id == id);
        //    _context.Usuarios.Remove(result);
        //    _context.SaveChanges();

        //    return result;
        //}
    }
}
