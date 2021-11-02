using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tgamerApi.Dto
{
    public class CreateConquista
    {
        public int? UsuarioId { get; set; }
        public int acertos { get; set; }
        public int erros { get; set; }
        public int nivel { get; set; }
    }
}
