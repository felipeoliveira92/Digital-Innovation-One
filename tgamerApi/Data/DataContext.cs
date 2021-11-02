using Microsoft.EntityFrameworkCore;
using tgamerApi.Models;

namespace tgamerApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Conquistas> Conquistas { get; set; }
        public DbSet<Contatos> Contatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}