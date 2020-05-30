using EntityTypeConfiguration.Entities;
using EntityTypeConfiguration.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace EntityTypeConfiguration.Data
{
    public class AppDataContext : DbContext
    {

        public DbSet<Livro> Livro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCore;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LIvroConfig());
            modelBuilder.ApplyConfiguration(new LivroDetalhesConfig());
        }

    }
}
