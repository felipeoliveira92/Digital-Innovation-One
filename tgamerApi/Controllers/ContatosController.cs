using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tgamerApi.Data;
using tgamerApi.Models;

namespace tgamerApi.Controllers
{
    [Route("api/v1/contatos")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private DataContext _context;

        public ContatosController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public Contatos Create(Contatos contatos)
        {
            var newContato = new Contatos(contatos);

            _context.Contatos.Add(newContato);
            _context.SaveChanges();

            return newContato;
        }
    }
}
