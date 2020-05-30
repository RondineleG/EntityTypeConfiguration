using EntityTypeConfiguration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityTypeConfiguration.EntityConfig
{
    public class LivroDetalhesConfig : IEntityTypeConfiguration<LivroDetalhes>
    {
        public void Configure(EntityTypeBuilder<LivroDetalhes> livroDetalhe)
        {
            livroDetalhe.ToTable("LivroDetalhe");

            livroDetalhe.HasKey(x => x.LivroId);

            livroDetalhe.Property(x => x.Editora)
                .HasColumnType("varchar(100)");

            livroDetalhe.Property(x => x.NumeroDePaginas)
                .HasColumnType("smallint");

            livroDetalhe.HasOne(x => x.Livro)
                .WithOne(x => x.Detalhes);

        }
    }
}
