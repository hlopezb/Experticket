using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>();
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
    }
}
