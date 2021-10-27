using Microsoft.EntityFrameworkCore;
using src.Entities;

namespace src.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}