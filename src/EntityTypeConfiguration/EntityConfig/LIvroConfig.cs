using EntityTypeConfiguration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityTypeConfiguration.EntityConfig
{
    public class LIvroConfig : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> livro)
        {
            livro.ToTable("Livro");

            livro.HasKey(x => x.LivroId);

            livro.Property(x => x.Titulo)
                .HasColumnType("varchar(200)");

            livro.Property(x => x.Autor)
                .HasColumnType("varchar(100)");

            livro.Property(x => x.DataCadastro)
                .HasColumnType("date");

        }
    }
}
