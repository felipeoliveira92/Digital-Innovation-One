using System;
using System.ComponentModel.DataAnnotations;
using tgamerApi.Dto;

namespace tgamerApi.Models
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(CreateUsuario usuario)
        {
            this.nome = usuario.nome;
            this.email = usuario.email;
            this.senha = usuario.senha;
            this.idade = usuario.idade;
            this.celular = usuario.celular;
            this.dataCadastro = DateTime.Now;
        }
        public void Atualizar(Usuario usuario)
        {            
            this.nome = usuario.nome;
            this.email = usuario.email;
            this.senha = usuario.senha;
            this.idade = usuario.idade;
            this.celular = usuario.celular;

        }

        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string nome { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        public string email { get; set; }

        public string senha { get; set; }
        public int idade { get; set; }
        public string celular { get; set; }         
        public DateTime dataCadastro { get; set; }    
    }
}