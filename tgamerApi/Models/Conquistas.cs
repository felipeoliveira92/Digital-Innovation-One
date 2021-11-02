using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tgamerApi.Models
{
    public class Conquistas
    {
        [Key]
        public int Id { get; set; }        
        public int? UsuarioId { get; set; }
        
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }        
        public int acertos { get; set; }
        public int erros { get; set; }
        public int nivel { get; set; }
    }
}