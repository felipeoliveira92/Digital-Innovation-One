using System.Linq;
using Microsoft.AspNetCore.Mvc;
using src.Database;
using src.Dto;
using src.Entities;

namespace src.Controllers
{
    [ApiController]
    [Route("api/v1/heros")]
    public class HeroController
    {
        private DataContext _context;

        public HeroController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public Hero Create(CreateHero hero)
        {
            var newHero = new Hero(hero);

            _context.Heroes.Add(newHero);
            _context.SaveChanges();

            return newHero;
        }

        [HttpGet("{id:int}")]
        public Hero GetById(int id)
        {
            var result = _context.Heroes.FirstOrDefault(h => h.Id == id);
            return result;
        }
    }
}