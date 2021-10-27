using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using src.Dto;

namespace src.Entities
{
    public class Hero
    {
        public Hero()
        {
            
        }
        public Hero(CreateHero hero)
        {
            this.Name = hero.Name;
            this.RealName = hero.RealName;
            this.GroupId = hero.GroupId;
            this.CreatedAt = DateTime.Now;
        }


        [Key]
        public int Id { get; set; }

        [MaxLength(80)]
        [MinLength(3)]
        public string Name { get; set; }

        [MaxLength(80)]
        [Required]
        public string RealName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Group group { get; set; }
    }
}