using Domain;
using Microsoft.EntityFrameworkCore;

namespace RepositoryPatternEntity.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Usuario> Usuarios { get; set; } 
    }
}
