﻿// <auto-generated />
using System;
using EntityTypeConfiguration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityTypeConfiguration.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityTypeConfiguration.Entities.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoPublicacao")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("date");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(200)");

                    b.HasKey("LivroId");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("EntityTypeConfiguration.Entities.LivroDetalhes", b =>
                {
                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<string>("Editora")
                        .HasColumnType("varchar(100)");

                    b.Property<short>("NumeroDePaginas")
                        .HasColumnType("smallint");

                    b.HasKey("LivroId");

                    b.ToTable("LivroDetalhe");
                });

            modelBuilder.Entity("EntityTypeConfiguration.Entities.LivroDetalhes", b =>
                {
                    b.HasOne("EntityTypeConfiguration.Entities.Livro", "Livro")
                        .WithOne("Detalhes")
                        .HasForeignKey("EntityTypeConfiguration.Entities.LivroDetalhes", "LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
