using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using tgamerApi.Data;
using tgamerApi.Dto;
using tgamerApi.Models;

namespace tgamerApi.Controllers
{
    [ApiController]
    [Route("api/v1/Usuarios")]
    public class UsuarioController
    {
        private DataContext _context;

        public UsuarioController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public Usuario Create(CreateUsuario usuario)
        {
            var newUsuario = new Usuario(usuario);

            _context.Usuarios.Add(newUsuario);
            _context.SaveChanges();

            return newUsuario;
        }

        [HttpGet("{id:int}")]
        public Usuario GetById(int id)
        {
            var result = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            return result;
        }

        [HttpGet]
        public List<Usuario> GetUsuario()
        {
            return _context.Usuarios.ToList();
        }
                
        [HttpPut("{id:int}")]
        public Usuario PutUsuario(int id, Usuario usuario)
        {
            usuario.Id = id;
            _context.Update(usuario);
            _context.SaveChanges();
            return usuario;
        }

        [HttpDelete("{id:int}")]
        public Usuario DeleteUsuario(int id)
        {
            var result = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            _context.Usuarios.Remove(result);
            _context.SaveChanges();

            return result;
        }

        //[HttpPost]
        //[Route("api/v1/Conquistas")]
        //public Conquistas Create(Usuario usuario, Conquistas conquistas)
        //{
        //    var newconquista = new Conquistas(usuario, conquistas);

        //    _context.Conquistas.Add(newconquista);
        //    _context.SaveChanges();

        //    return newconquista;
        //}

    }
}