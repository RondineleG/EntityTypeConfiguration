namespace EntityTypeConfiguration.Entities
{
    public class LivroDetalhes
    {
        public int LivroId { get; set; }

        public string Editora { get; set; }

        public int NumeroDePaginas { get; set; }

        public virtual Livro Livro { get; set; }
    }
}
