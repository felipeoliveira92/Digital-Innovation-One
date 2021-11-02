using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tgamerApi.Data;
using tgamerApi.Models;

namespace tgamerApi.Controllers
{
    [ApiController]
    [Route("api/v1/Home")]
    public class HomeController : Controller
    {
        private DataContext _context;

        public HomeController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public List<Usuario> GetUsuario()
        {
            return _context.Usuarios.ToList();
        }
    }
}
